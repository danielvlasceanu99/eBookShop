using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace  EBookShop.Models
{
    public class Author
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }
        [DataType(DataType.Date)]
        public DateTime DateOfDeath { get; set; }
        public string PlaceAOfBirth { get; set; }
        public string ShortDesctiption { get; set; }
        
        // Relatioships
        // Book relationship - one to many
        public virtual ICollection<Book> BookList { get; set; } 
    }
}