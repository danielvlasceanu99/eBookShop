using EBookShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EBookShop.ViewModels
{
    public class BookDetailesViewModel
    {
        public Book Book { get; set; }
        public Review Review { get; set; }
        public bool HasBook { get; set; }
        public bool InWishlist { get; set; }
        public bool InCart { get; set; }
    }
}
