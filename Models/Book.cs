using System;
using System.Collections.Generic;

namespace  EBookShop.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string ISBN { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public float Rating { get; set; }
        public string OriginalLanguage { get; set; }
        public float Price { get; set; }
        public string ImageId { get; set; }
        public string PreviewId { get; set; }

        // Relatioships
        // Genre relationship - many to many
        public virtual ICollection<GenreToBookAssociation> GenreList { get; set; }

        // Book relationship - many to many
        public virtual ICollection<BookToUserAssociation> UserList { get; set; }
        public virtual ICollection<Wishlist> WishlistList { get; set; }
        public virtual ICollection<Cart> CartList { get; set; }

        // Review relationship - one to many
        public virtual ICollection<Review> ReviewList { get; set; }

        // File relationship - one to many
        public virtual ICollection<File> FileList { get; set; }

        // Author relationship - one to many
        public int AuthorID { get; set; }
        public Author Author { get; set; }

        public int DiscountID { get; set; }
        public Discount Discount {get; set;}

        public bool CheckGenre(string bookgenre)
        {
            foreach(GenreToBookAssociation gtb in this.GenreList)
            {
                if(string.Equals(gtb.Genre.GenreName, bookgenre))
                {
                    return true;
                }
            }
            return false;
        }
    }
}