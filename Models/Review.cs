using EBookShop.Areas.Identity.Data;
using System;
using System.Collections.Generic;

namespace  EBookShop.Models
{
    public class Review
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public int Rating { get; set; }
        
        // Relatioships
        // Book relationship - one to many
        public int BookID { get; set; }
        public Book Book {get; set; }
       
        // User relationship - one to many
        public string UserID { get; set; }
        public User User {get; set; }
    }
}