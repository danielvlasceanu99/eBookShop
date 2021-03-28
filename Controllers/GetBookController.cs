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
    public class GetBookController : Controller
    {
        private readonly ILogger<GetBookController> _logger;
        private readonly EBookShopAuthContext _context;
        private readonly UserManager<User> _userManager;

        public GetBookController(ILogger<GetBookController> logger, EBookShopAuthContext context, 
            UserManager<User> userManager)
        {
            _logger = logger;
            _context = context;
            _userManager = userManager;
        }

        public async Task<IActionResult> GetBook(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var book = await _context.Book.Include(x => x.Author)
                .FirstOrDefaultAsync(m => m.Id == id);

            if (book == null)
            {
                return NotFound();
            }

            string userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var bookToUser = await _context.BookToUser.FirstOrDefaultAsync(x => x.BookID == (int)id && x.UserID == userId);
            
            bool hasBook = true;
            if (bookToUser == null)
            {
                hasBook = false;
            }

            var getBookVM = new GetBookViewModel()
            {
                book = book,
                hasBook = hasBook
            };
            return View(getBookVM);
        }

        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> GetBook(int? id,
            [Bind("CardHolderName,CardNumber,ExpiryMonth,ExpiryYear,CVV")] PaymentInfo paymentInfo)
        {
            if (id == null)
            {
                return NotFound();
            }

            var book = await _context.Book.Include(x => x.Author)
                .FirstOrDefaultAsync(m => m.Id == id);

            if (book == null)
            {
                return NotFound();
            }

            if (TryValidateModel(paymentInfo, nameof(PaymentInfo)))
            {
                BookToUserAssociation bookToUser = new BookToUserAssociation();
                bookToUser.BookID = (int)id;
                bookToUser.UserID = User.FindFirstValue(ClaimTypes.NameIdentifier);
                _context.Add(bookToUser);
                await _context.SaveChangesAsync();
                return RedirectToAction("Details", "BookDetails", new { id = (int)id });
            }
            var getBookVM = new GetBookViewModel()
            {
                book = book
            };
            return View(getBookVM);
        }
    }
}
