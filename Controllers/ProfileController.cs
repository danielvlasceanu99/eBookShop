using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EBookShop.Areas.Identity.Data;
using EBookShop.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EBookShop.Controllers
{
    [Authorize]
    public class ProfileController : Controller
    {
        private readonly EBookShopAuthContext _context;
        private readonly UserManager<User> _userManager;

        public ProfileController(EBookShopAuthContext context, UserManager<User> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            var user = await _userManager.GetUserAsync(HttpContext.User);
            user.BookList = await _context.BookToUser
                .Include(x => x.Book).ThenInclude(g => g.GenreList)
                .ThenInclude(x=>x.Genre).ToListAsync();
            user.BookList = user.BookList.Where(book => book.UserID == user.Id).ToList();
            return View(user);
        }

        public async Task<IActionResult> Wishlist()
        {
            var user = await _userManager.GetUserAsync(HttpContext.User);
            user.WishlistList = await _context.Wishlist
                .Include(x => x.Book).ThenInclude(g => g.GenreList)
                .ThenInclude(x => x.Genre).ToListAsync();
            user.WishlistList = user.WishlistList.Where(book => book.UserID == user.Id).ToList();
            return View(user);
        }

        public async Task<IActionResult> Cart()
        {
            var user = await _userManager.GetUserAsync(HttpContext.User);
            user.CartList = await _context.Cart
                .Include(x => x.Book).ThenInclude(g => g.GenreList)
                .ThenInclude(x => x.Genre).ToListAsync();
            user.CartList = user.CartList.Where(book => book.UserID == user.Id).ToList();
            return View(user);
        }
    }
}
