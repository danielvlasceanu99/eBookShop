using System;
using System.Collections.Generic;

namespace  EBookShop.Models
{
    public class Genre
    {
        public int Id { get; set; }
        public string GenreName { get; set; }
        
        // Relatioships
        // Book relationship - many to many
        public virtual ICollection<GenreToBookAssociation> BookLsit { get; set; }
     
        public bool Equals(Genre other)
        {
            if (other == null)
            {
                return false;
            }
            return (string.Equals(this.GenreName, other.GenreName));
        }

    }
}