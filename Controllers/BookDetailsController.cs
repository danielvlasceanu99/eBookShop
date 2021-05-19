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
            var bookInWishlist = await _context.Wishlist.FirstOrDefaultAsync(x => x.BookID == (int)id && x.UserID == userId);
            var bookInCart = await _context.Cart.FirstOrDefaultAsync(x => x.BookID == (int)id && x.UserID == userId);

            var BookDetailsVM = new BookDetailesViewModel
            {
                Book = book,
                HasBook = bookToUser == null ? false : true,
                InWishlist = bookInWishlist == null ? false : true,
                InCart = bookInCart == null ? false : true
        };

            return View(BookDetailsVM);
        }

        [Authorize, HttpPost]
        public async Task<IActionResult> Details(BookDetailesViewModel model)
        {
            model.Review.UserID = User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (ModelState.IsValid)
            {
                _context.Add(model.Review);

                model.Book = await _context.Book.Include(book => book.ReviewList)
                    .FirstOrDefaultAsync(book => book.Id == model.Review.BookID);

                model.Book.Rating = model.Book.Rating * model.Book.ReviewList.Count() + model.Review.Rating;
                _context.Update(model.Book);

                await _context.SaveChangesAsync();
                return RedirectToAction("Details", "BookDetails", new { id = model.Review.BookID });
            }
            return RedirectToAction("Details", "BookDetails", new { id = model.Review.BookID });
        }

        public ActionResult DownloadDocument(int id, string type)
        {
            var file = _context.File.FirstOrDefaultAsync(m => m.BookID == id && string.Equals(m.Type, type.ToUpper()) == true);
            
            string fileName = file.Result.FileName + "." + type;
            string filePath = "C:/Users/danie/OneDrive/Books/" + type + "/" + fileName;
            
            byte[] fileBytes = System.IO.File.ReadAllBytes(filePath);

            return File(fileBytes, "application/force-download", fileName);
        }
    }
}
