using CodingWiki_Model.Models;
using Microsoft.EntityFrameworkCore;

namespace CodingWiki_DataAccess.Data
{
    public class ApplicationDbContext: DbContext
    {
        
        public DbSet<Book> Books {  get; set; }
        public DbSet<Genre> Genres {  get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //base.OnConfiguring(optionsBuilder);
            //optionsBuilder.UseSqlServer("Server=localhost;Database=CodingWiki;Trusted_Connection=True;TrustServerCertificate=True");            
            optionsBuilder.UseSqlServer("Server=localhost;Database=CodingWiki;User ID=sa;Password=Chirripo3820@;TrustServerCertificate=True");
            //optionsBuilder.UseSqlServer(connectionString);

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>().Property(u => u.Price).HasPrecision(10,5);
            modelBuilder.Entity<Book>().HasData(
                new Book { BookId = 1 , Title = "THe Hobbit", ISBN = "111U11", Price = 10.99m},
                new Book { BookId = 2 , Title = "Summarily", ISBN = "1S11U11", Price = 25.99m}
            );

            var bookList = new Book[]
            {
                new Book { BookId = 3, Title = "The Wanderer's Tale", ISBN = "XK12345", Price = 12.99m },
                new Book { BookId = 4, Title = "Mystery of the Night", ISBN = "YZ98765", Price = 15.49m },
                new Book { BookId = 5, Title = "Journey to the Stars", ISBN = "LM45678", Price = 8.75m },
                new Book { BookId = 6, Title = "The Lost Kingdom", ISBN = "HG54321", Price = 20.00m },
                new Book { BookId = 7, Title = "Secrets of the Deep", ISBN = "TR65432", Price = 18.99m }
            };
            modelBuilder.Entity<Book>().HasData(bookList);
        }

    }
}
