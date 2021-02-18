using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using EBookShop.Models;
using Microsoft.AspNetCore.Authorization;
using EBookShop.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using EBookShop.ViewModels;

namespace EBookShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly EBookShopAuthContext _context;

        public HomeController(ILogger<HomeController> logger, EBookShopAuthContext context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> Index(string bookGenre, string searchString)
        {
            IQueryable<string> genreQuery = from genres in _context.Genre select genres.GenreName;
            var books = from book in _context.Book select book;

            if (!string.IsNullOrEmpty(searchString))
            {
                books = books.Where(b => b.Title.Contains(searchString));
            }

            if (!string.IsNullOrEmpty(bookGenre))
            {
                GenreToBookAssociation gtb = new GenreToBookAssociation();
                gtb.Genre = new Genre(bookGenre);
                books = books.Where(b => b.GenreList.Contains(gtb));
            }

            var bookListVM = new BookListViewModel
            {
                Genres = new SelectList(await genreQuery.Distinct().ToListAsync()),
                Books = await books.ToListAsync()
            };

            return View(bookListVM);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
