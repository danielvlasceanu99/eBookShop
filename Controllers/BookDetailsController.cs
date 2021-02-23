﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EBookShop.Data;
using EBookShop.Models;
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
        [HttpGet]
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

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateReview([Bind("Id,Text,Rating,BookID,GenreID")] Review review)
        {
            if (ModelState.IsValid)
            {
                _context.Add(review);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Details));
            }
            return View(review);
        }
    }
}