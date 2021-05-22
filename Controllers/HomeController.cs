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
            var genreQuery = await _context.Genre.ToListAsync();
            var books = await _context.Book.Include(x => x.Author)
                .Include(x => x.GenreList).ThenInclude(x => x.Genre).ToListAsync();

            if (!string.IsNullOrEmpty(searchString))
            {
                books = books.Where(b => b.Title.Contains(searchString)).ToList();
            }

            if (!string.IsNullOrEmpty(bookGenre))
            {
                books = books.Where(b => b.CheckGenre(bookGenre)).ToList();
            }

            var bookListVM = new BookListViewModel
            {
                Genres = genreQuery,
                Books = books
            };

            return View(bookListVM);
        }

        [HttpGet]
        public async Task<IActionResult> BestSellers()
        {
            var books = await _context.Book.Include(x => x.Author)
                .Include(x => x.GenreList).ThenInclude(x => x.Genre).ToListAsync();
            var purchase = await _context.BookToUser.ToListAsync();

            List<int> counts = new List<int>();
            foreach(Book book in books)
            {
                int count = purchase.Where(x => x.BookID == book.Id).ToList().Count();
            }

            for(int i = 0; i < counts.Count() - 1; i++)
            {
                for(int j = i+1; j<counts.Count(); j++)
                {
                    if(counts[i] < counts[j])
                    {
                        int x = counts[i];
                        counts[i] = counts[j];
                        counts[j] = x;

                        Book b = books[i];
                        books[i] = books[j];
                        books[j] = b;
                    }
                }
            }
            var bookListVM = new BookListViewModel
            {
                Books = books
            };
            return View(bookListVM);
        }
        public async Task<IActionResult> Promotions()
        {
            var books = await _context.Book.Include(x => x.Author)
                .Include(x => x.GenreList).ThenInclude(x => x.Genre).ToListAsync();
            books = books.Where(book => book.Discount != 0).ToList();

            var bookListVM = new BookListViewModel
            {
                Books = books
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
