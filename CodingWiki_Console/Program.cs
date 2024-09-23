using System.Runtime.CompilerServices;
using CodingWiki_DataAccess.Data;
using CodingWiki_Model.Models;
using Microsoft.EntityFrameworkCore;

Console.WriteLine("Hello, World!");

// using ApplicationDbContext context = new();
//
// context.Database.EnsureCreated();
//     
// if (context.Database.GetPendingMigrations().Any())
// {
//     context.Database.Migrate();
// }

GetAllBooks();
//AddBooks();
return;

void GetAllBooks()
{
    using var context = new ApplicationDbContext();
    var books = context.Books.ToList();

    foreach (var book in books)
    {
        Console.WriteLine($"{book.Title} {book.ISBN}");
    }
}

void AddBooks()
{
    Book book = new() { Title = "Professional C# 6", Price = 10.93m, ISBN = "12345678", PublisherId = 1 };
    using var context = new ApplicationDbContext();
    context.Books.Add(book);
    context.SaveChanges();
}