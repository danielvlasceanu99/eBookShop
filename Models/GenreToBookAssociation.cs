using System;

namespace  EBookShop.Models
{
    public class GenreToBookAssociation
    {
        public int BookID { get; set; }
        public Book Book { get; set; } 

        public int GenreID{ get; set; }
        public Genre Genre { get; set;}

        public GenreToBookAssociation(Genre genre)
        {
            this.Genre = genre;
        }

        public bool Equals(GenreToBookAssociation other)
        {
            if (other == null)
            {
                return false;
            }
            return (this.Genre.Equals(other.Genre));
        }
    }
}