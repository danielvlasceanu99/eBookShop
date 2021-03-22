using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EBookShop.Areas.Identity.Data;
using EBookShop.Data;
using EBookShop.ViewModels;
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

        public GetBookController(ILogger<GetBookController> logger, EBookShopAuthContext context, UserManager<User> userManager)
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
                .Include(x => x.GenreList).ThenInclude(x => x.Genre)
                .Include(x => x.ReviewList).ThenInclude(x => x.User)
                .FirstOrDefaultAsync(m => m.Id == id);

            if (book == null)
            {
                return NotFound();
            }

            var getBookVM = new GetBookViewModel()
            {
                book = book
            };
            return View(getBookVM);
        }
    }
}
