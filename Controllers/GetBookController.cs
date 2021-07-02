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

        [Authorize]
        public async Task<IActionResult> GetBook()
        {
            string userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var items = await _context.Cart.Include(x => x.Book)
                .ThenInclude(x => x.Author)
                .ToListAsync();
            items = items.Where(m => m.UserID == userId).ToList();
            if(items.Count == 0)
            {
                return RedirectToAction("Cart", "Profile");
            }

            var getBookVM = new GetBookViewModel()
            {
                books = items
            };
            return View(getBookVM);
        }

        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> GetBook(
            [Bind("CardHolderName,CardNumber,ExpiryDate,CVV")] PaymentInfo paymentInfo)
        {
            string userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var items = await _context.Cart.Include(x => x.Book).ThenInclude(auth => auth.Author).ToListAsync();
            items = items.Where(m => m.UserID == userId).ToList();
            if (TryValidateModel(paymentInfo, nameof(PaymentInfo)))
            {
                foreach (Cart item in items)
                {
                    BookToUserAssociation bookToUser = new BookToUserAssociation();
                    bookToUser.BookID = item.BookID;
                    bookToUser.UserID = User.FindFirstValue(ClaimTypes.NameIdentifier);
                    _context.Add(bookToUser);

                    _context.Remove(item);

                    var wishlist = await _context.Wishlist.ToListAsync();
                    wishlist = wishlist.Where(wish => wish.BookID == item.BookID
                        && wish.UserID == item.UserID).ToList();
                    if (wishlist.Count != 0)
                    {
                        _context.RemoveRange(wishlist);
                    }
                }
                await _context.SaveChangesAsync();
                return RedirectToAction("ConfirmPurchase", "GetBook");
            }

            var getBookVM = new GetBookViewModel()
            {
                books = items
            };
            return View(getBookVM);
        }

        [Authorize]
        public async Task<IActionResult> ConfirmPurchase()
        {
            return View();
        }

        [Authorize]
        public async Task<IActionResult> AddBookToWishlist(int ? id)
        {
            if(id == null)
            {
                return NotFound();
            }

            var book = await _context.Book.Include(x => x.Author).FirstOrDefaultAsync(m => m.Id == id);
            if (book == null)
            {
                return NotFound();
            }

            Wishlist wish = new Wishlist();
            wish.BookID = (int)id;
            wish.UserID = User.FindFirstValue(ClaimTypes.NameIdentifier);

            var wishlistItem = await _context.Wishlist
                .FirstOrDefaultAsync(m => m.BookID == wish.BookID && m.UserID == wish.UserID);
            var ownedItem = await _context.BookToUser
                .FirstOrDefaultAsync(m => m.BookID == wish.BookID && m.UserID == wish.UserID);
            if (wishlistItem == null && ownedItem == null)
            {
                _context.Add(wish);
                await _context.SaveChangesAsync();
            }
            return RedirectToAction("Details", "BookDetails", new { id = (int)id });
        }

        [Authorize]
        public async Task<IActionResult> AddBookToCart(int? id)
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

            Cart item = new Cart();
            item.BookID = (int)id;
            item.UserID = User.FindFirstValue(ClaimTypes.NameIdentifier);

            var cartItem = await _context.Cart
                .FirstOrDefaultAsync(m => m.BookID == item.BookID && m.UserID == item.UserID);
            var ownedItem = await _context.BookToUser
                .FirstOrDefaultAsync(m => m.BookID == item.BookID && m.UserID == item.UserID);
            if (cartItem == null && ownedItem == null)
            {
                _context.Add(item);
                await _context.SaveChangesAsync();
            }
            return RedirectToAction("Details", "BookDetails", new { id = (int)id });
        }

        [Authorize]
        public async Task<IActionResult> MoveToCart(int? id)
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

            Cart item = new Cart();
            item.BookID = (int)id;
            item.UserID = User.FindFirstValue(ClaimTypes.NameIdentifier);

            var wishlistItem = await _context.Wishlist
               .FirstOrDefaultAsync(m => m.BookID == item.BookID && m.UserID == item.UserID);

            if (wishlistItem == null)
            {
                return NotFound();
            }

            var itemInCart = await _context.Cart
                .FirstOrDefaultAsync(m => m.BookID == item.BookID && m.UserID == item.UserID);

            if(itemInCart == null)
            {
                _context.Add(item);
                _context.Wishlist.Remove(wishlistItem);
                await _context.SaveChangesAsync();
            }
            return RedirectToAction("Wishlist", "Profile");
        }

        [Authorize]
        public async Task<IActionResult> RemoveFromWishlist(int? id)
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

            var wishlistItem = await _context.Wishlist.FirstOrDefaultAsync(m => m.BookID == (int)id && 
                    m.UserID == User.FindFirstValue(ClaimTypes.NameIdentifier));
            if(wishlistItem != null)
            {
                _context.Wishlist.Remove(wishlistItem);
                await _context.SaveChangesAsync();
            }
            return RedirectToAction("Wishlist", "Profile");
        }

        [Authorize]
        public async Task<IActionResult> RemoveFromCart(int? id)
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
            var cartItem = await _context.Cart.FirstOrDefaultAsync(m => m.BookID == (int)id &&
                    m.UserID == User.FindFirstValue(ClaimTypes.NameIdentifier));
            if (cartItem != null)
            {
                _context.Cart.Remove(cartItem);
                await _context.SaveChangesAsync();
            }
            return RedirectToAction("Cart", "Profile");
        }

        [Authorize]
        public async Task<IActionResult> AddAllToCart()
        {
            var bookList = await _context.Wishlist.ToListAsync();
            bookList = bookList.Where(book => book.UserID == User.FindFirstValue(ClaimTypes.NameIdentifier)).ToList();

            if(bookList.Count != 0)
            {
                foreach (Wishlist wish in bookList)
                {
                    Cart item = new Cart();
                    item.BookID = wish.BookID;
                    item.UserID = wish.UserID;

                    var cartItem = await _context.Cart.FirstOrDefaultAsync(m => m.BookID == item.BookID
                        && m.UserID == item.UserID);
                    if (cartItem == null)
                    {
                        _context.Add(item);
                    }
                }
                await _context.SaveChangesAsync();
            }

            return RedirectToAction("Cart", "Profile");
        }
    }
}
