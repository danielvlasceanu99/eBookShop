using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EBookShop.Areas.Identity.Data;
using EBookShop.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace EBookShop.Data
{
    public class EBookShopAuthContext : IdentityDbContext<User>
    {
        public EBookShopAuthContext(DbContextOptions<EBookShopAuthContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);

            modelBuilder.Entity<GenreToBookAssociation>().HasKey(key => new { key.BookID, key.GenreID });
            modelBuilder.Entity<BookToUserAssociation>().HasKey(key => new { key.BookID, key.UserID });

            modelBuilder.Entity<Book>().HasOne<Author>(book => book.Author)
                .WithMany(author => author.BookList)
                .HasForeignKey(book => book.AuthorID);

            modelBuilder.Entity<GenreToBookAssociation>().HasOne<Book>(association => association.Book)
                .WithMany(book => book.GenreList)
                .HasForeignKey(association => association.BookID);

            modelBuilder.Entity<GenreToBookAssociation>().HasOne<Genre>(association => association.Genre)
                .WithMany(genre => genre.BookLsit)
                .HasForeignKey(association => association.GenreID);

            modelBuilder.Entity<BookToUserAssociation>().HasOne<Book>(association => association.Book)
               .WithMany(book => book.UserList)
               .HasForeignKey(association => association.BookID);

            modelBuilder.Entity<BookToUserAssociation>().HasOne<User>(association => association.User)
                .WithMany(user => user.BookList)
                .HasForeignKey(association => association.UserID);

            modelBuilder.Entity<Review>().HasOne<Book>(association => association.Book)
               .WithMany(book => book.ReviewList)
               .HasForeignKey(association => association.BookID);

            modelBuilder.Entity<Review>().HasOne<User>(association => association.User)
                .WithMany(user => user.ReviewList)
                .HasForeignKey(association => association.UserID);

            modelBuilder.Entity<File>().HasOne<Book>(book => book.Book)
                .WithMany(file => file.FileList)
                .HasForeignKey(file => file.BookID);
        }

        public DbSet<Author> Author { get; set; }
        public DbSet<Book> Book { get; set; }
        public DbSet<BookToUserAssociation> BookToUser { get; set; }
        public DbSet<Genre> Genre { get; set; }
        public DbSet<GenreToBookAssociation> GenreToBook { get; set; }
        public DbSet<Review> Review { get; set; }
        public DbSet<User> User { get; set; }
    }
}
