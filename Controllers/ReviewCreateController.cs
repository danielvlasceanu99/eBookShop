using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EBookShop.Data;
using EBookShop.Models;
using EBookShop.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace EBookShop.Controllers
{
    public class ReviewCreateController : Controller
    {
        private readonly EBookShopAuthContext _context;

        public ReviewCreateController(EBookShopAuthContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> CreateReview(BookDetailesViewModel model)
        {
            model.Review.Rating = 3;
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
