using CodingWiki_Model.Models;
using CodingWiki_Model.Models.FluentModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace CodingWiki_DataAccess.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {
        }
        
        public DbSet<Book> Books {  get; set; }
        public DbSet<Category> Categories {  get; set; }
        public DbSet<SubCategory> SubCategory {  get; set; }
        public DbSet<Author> Author {  get; set; }
        public DbSet<Publisher> Publisher {  get; set; }
        public DbSet<BookDetail> BookDetail {  get; set; }

        // public DbSet<Fluent_Book> Books_fluent {  get; set; }
        // public DbSet<Fluent_Author> Author_fluent {  get; set; }
        // public DbSet<Fluent_Publisher> Publisher_fluent {  get; set; }
        public DbSet<Fluent_BookDetail> BookDetail_fluent {  get; set; }
        
        // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        // {
        //     //base.OnConfiguring(optionsBuilder);
        //     //optionsBuilder.UseSqlServer("Server=localhost;Database=CodingWiki;Trusted_Connection=True;TrustServerCertificate=True");            
        //     //optionsBuilder.UseSqlServer(connectionString);
        //     
        //     // optionsBuilder.UseSqlServer("Server=localhost;Database=CodingWiki;User ID=sa;Password=Chirripo3820;TrustServerCertificate=True")
        //     //     .LogTo(Console.WriteLine, new[] {DbLoggerCategory.Database.Command.Name}, LogLevel.Information);
        // }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Fluent_BookDetail>().ToTable("Fluent_BookDetail");
            modelBuilder.Entity<Fluent_BookDetail>().Property(u => u.NumberOfChapters).HasColumnName("NoOfChapters");
            modelBuilder.Entity<Fluent_BookDetail>().Property(u => u.NumberOfChapters).IsRequired();
            modelBuilder.Entity<Fluent_BookDetail>().HasKey(u => u.BookDetailId); 
            
            
            modelBuilder.Entity<Book>().Property(u => u.Price).HasPrecision(10, 5);

            modelBuilder.Entity<BookAuthorMap>().HasKey(u => new { u.AuthorId, u.BookId });
            
            modelBuilder.Entity<Book>().HasData(
                new Book { BookId = 2, Title = "Summarily", ISBN = "1S11U11", Price = 25.99m, PublisherId = 1}
            );

            var bookList = new Book[]
            {
                new Book { BookId = 3, Title = "The Wanderer's Tale", ISBN = "XK12345", Price = 12.99m , PublisherId = 1},
                new Book { BookId = 4, Title = "Mystery of the Night", ISBN = "YZ98765", Price = 15.49m , PublisherId = 2},
                new Book { BookId = 5, Title = "Journey to the Stars", ISBN = "LM45678", Price = 8.75m , PublisherId = 3},
                new Book { BookId = 6, Title = "The Lost Kingdom", ISBN = "HG54321", Price = 20.00m , PublisherId = 1},
                new Book { BookId = 7, Title = "Secrets of the Deep", ISBN = "TR65432", Price = 18.99m , PublisherId = 2}
            };
            modelBuilder.Entity<Book>().HasData(bookList);

            var publisherList = new Publisher[]
            {
                new Publisher { PublisherId = 1, Name = "The Hobbit", Location = "Chicago" },
                new Publisher { PublisherId = 2, Name = "The Hobbit2", Location = "Chicago2" },
                new Publisher { PublisherId = 3, Name = "The Hobbit3", Location = "Chicago3" }

            };
            modelBuilder.Entity<Publisher>().HasData(publisherList);
        }

    }
}
