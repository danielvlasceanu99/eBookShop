using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EBookShop.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EBookShop.Controllers
{
    public class BookDetailsController : Controller
    {
        private readonly EBookShopAuthContext _context;

        BookDetailsController(EBookShopAuthContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var book = await _context.Book
                .FirstOrDefaultAsync(m => m.Id == id);
            if (book == null)
            {
                return NotFound();
            }

            return View(book);
        }
    }
}
