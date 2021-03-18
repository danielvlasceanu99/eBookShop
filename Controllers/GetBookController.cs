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
    public class GetBookController : Controller
    {
        private readonly ILogger<GetBookController> _logger;
        private readonly EBookShopAuthContext _context;

        public GetBookController(ILogger<GetBookController> logger, EBookShopAuthContext context)
        {
            _logger = logger;
            _context = context;
        }
        public async Task<IActionResult> Get(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var book = await _context.Book.Include(x => x.Author)
                .Include(x => x.GenreList).ThenInclude(x => x.Genre)
                .Include(x => x.ReviewList).ThenInclude(x => x.User)
                .FirstOrDefaultAsync(m => m.Id == id);

            if (book == null)
            {
                return NotFound();
            }
            return View(book);
        }
    }
}
