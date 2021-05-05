using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EBookShop.Models
{
    public class Discount
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public float Percentage { get; set; }
        public int IsValid { get; set; }

        public virtual ICollection<Book> BookList { get; set; }
    }
}
