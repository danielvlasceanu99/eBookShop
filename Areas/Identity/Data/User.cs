using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using EBookShop.Models;
using Microsoft.AspNetCore.Identity;

namespace EBookShop.Areas.Identity.Data
{
    // Add profile data for application users by adding properties to the User class
    public class User : IdentityUser
    {
        [PersonalData]
        [Column(TypeName ="nvarchar(100)")]
        public string FirstName { get; set; }

        [PersonalData]
        [Column(TypeName = "nvarchar(100)")]
        public string LastName { get; set; }

        [PersonalData]
        [Column(TypeName = "nvarchar(15)")]
        public string Phone { get; set; }

        [PersonalData]
        [Column(TypeName = "nvarchar(100)")]
        public string RecoveryEmail { get; set; }

        // Relatioships
        // Book relationship - many to many
        public virtual ICollection<BookToUserAssociation> BookList { get; set; }
        public virtual ICollection<Wishlist> WishlistList { get; set; }
        public virtual ICollection<Cart> CartList { get; set; }

        // Review relationship - one to many
        public virtual ICollection<Review> ReviewList { get; set; }
    }
}
