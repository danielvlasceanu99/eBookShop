using EBookShop.Areas.Identity.Data;
using System;

namespace  EBookShop.Models
{
    public class BookToUserAssociation
    {
        public string UserID { get; set; }
        public User User {get; set;}
        
        public int BookID { get; set; }
        public Book Book { get; set; } 
    }
}