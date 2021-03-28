using EBookShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EBookShop.ViewModels
{
    public class GetBookViewModel
    {
        public PaymentInfo paymentInfo { get; set; }
        public Book book { get; set; }
        public bool hasBook { get; set; }
    }
}
