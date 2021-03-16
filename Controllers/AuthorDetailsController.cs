using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EBookShop.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace EBookShop.Controllers
{
    public class AuthorDetailsController : Controller
    {
        private readonly ILogger<AuthorDetailsController> _logger;
        private readonly EBookShopAuthContext _context;

        public AuthorDetailsController(ILogger<AuthorDetailsController> logger, EBookShopAuthContext context)
        {
            _logger = logger;
            _context = context;
        }
        [HttpGet]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var author = await _context.Author
                .Include(x=>x.BookList)
                .FirstOrDefaultAsync(x => x.Id == id);

            if (author == null)
            {
                return NotFound();
            }

            return View(author);
        }
    }
}
