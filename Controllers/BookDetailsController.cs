using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using EBookShop.Areas.Identity.Data;
using EBookShop.Data;
using EBookShop.Models;
using EBookShop.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace EBookShop.Controllers
{
    public class BookDetailsController : Controller
    {
        private readonly ILogger<BookDetailsController> _logger;
        private readonly EBookShopAuthContext _context;
        private readonly UserManager<User> _userManager;

        public BookDetailsController(ILogger<BookDetailsController> logger, EBookShopAuthContext context,
            UserManager<User> userManager)
        {
            _logger = logger;
            _context = context;
            _userManager = userManager;
        }
        [HttpGet]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var book = await _context.Book.Include(x => x.Author)
                .Include(x => x.GenreList).ThenInclude(x => x.Genre)
                .Include(x=>x.ReviewList).ThenInclude(x=>x.User)
                .FirstOrDefaultAsync(m => m.Id == id);

            if (book == null)
            {
                return NotFound();
            }

            string userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var bookToUser = await _context.BookToUser.FirstOrDefaultAsync(x => x.BookID == (int)id && x.UserID == userId);

            bool hasBook = true;

            if(bookToUser == null)
            {
                hasBook = false;
            }

            var BookDetailsVM = new BookDetailesViewModel
            {
                Book = book,
                HasBook = hasBook
            };

            return View(BookDetailsVM);
        }
        [Authorize, HttpPost]
        public async Task<IActionResult> Details(BookDetailesViewModel model)
        {
            model.Review.Rating = 3;
            model.Review.UserID = User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (ModelState.IsValid)
            {
                _context.Add(model.Review);
                await _context.SaveChangesAsync();
                return RedirectToAction("Details", "BookDetails", new { id = model.Review.BookID });
            }
            return RedirectToAction("Details", "BookDetails", new { id = model.Review.BookID });
        }
    }
}
