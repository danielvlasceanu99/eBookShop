using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using EBookShop.Data;
using EBookShop.Models;
using EBookShop.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace EBookShop.Controllers
{
    public class AdminController : Controller
    {
        private readonly ILogger<AdminController> _logger;
        private readonly EBookShopAuthContext _context;

        public AdminController(ILogger<AdminController> logger, EBookShopAuthContext context)
        {
            _logger = logger;
            _context = context;
        }
        [Authorize]
        public async Task<IActionResult> Index()
        {
            var books = await _context.Book.ToListAsync();
            var titles = books.Select(book => book.Title).ToList();
            var prices = books.Select(book => book.Price).ToList();

            var purchase = await _context.BookToUser.ToListAsync();
            List<int> OwnedNo = new List<int>();
            foreach (Book book in books)
            {
                int count = purchase.Where(x => x.BookID == book.Id).ToList().Count();
                OwnedNo.Add(count);
            }

            var wishlist = await _context.Wishlist.ToListAsync();
            List<int> WishlistNo = new List<int>();
            foreach (Book book in books)
            {
                int count = wishlist.Where(x => x.BookID == book.Id).ToList().Count();
                WishlistNo.Add(count);
            }

            var cart = await _context.Cart.ToListAsync();
            List<int> CartNo = new List<int>();
            foreach (Book book in books)
            {
                int count = cart.Where(x => x.BookID == book.Id).ToList().Count();
                CartNo.Add(count);
            }

            //OwnedNo[0] = 47;
            //OwnedNo[1] = 96;
            //OwnedNo[2] = 14;
            //OwnedNo[3] = 29;
            //OwnedNo[4] = 14;
            //OwnedNo[54] = 43;
            //OwnedNo[53] = 91;
            //OwnedNo[52] = 70;
            //OwnedNo[51] = 20;
            //OwnedNo[50] = 73;
            //WishlistNo[0] = 87;
            //CartNo[2] = 92;
            //WishlistNo[51] = 59;
            //CartNo[50] = 11;

            var adminVM = new AdminViewModel
            {
                Titles = titles,
                OwnedNo = OwnedNo,
                WishlistNo = WishlistNo,
                CartNo = CartNo,
                Prices = prices
            };

            string userID = User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (string.Equals(userID, "dc862d71-0265-4532-9873-865d8b371511"))
            {
                return View(adminVM);
            }
            else
            {
                return NotFound();
            }

            
        }
    }
}
