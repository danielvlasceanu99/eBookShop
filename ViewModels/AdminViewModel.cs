using EBookShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EBookShop.ViewModels
{
    public class AdminViewModel
    {
        public List<string> Titles { get; set; }
        public List<int> OwnedNo { get; set; }
        public List<int> WishlistNo { get; set; }
        public List<int> CartNo { get; set; }
        public List<float> Prices { get; set; }
        
    }
}
