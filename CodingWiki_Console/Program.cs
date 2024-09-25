using System.Numerics;
using System.Runtime.CompilerServices;
using CodingWiki_DataAccess.Data;
using CodingWiki_Model.Models;
using Microsoft.EntityFrameworkCore;

Console.WriteLine("Hello, World!");
//
// // using ApplicationDbContext context = new();
// //
// // context.Database.EnsureCreated();
// //     
// // if (context.Database.GetPendingMigrations().Any())
// // {
// //     context.Database.Migrate();
// // }
//
//
// GetAllBooks();
// //AddBooks();
// //UpdateBooks();
// DeleteBooks();
//
//
// return;
//
// void GetAllBooks()
// {
//     using var context = new ApplicationDbContext();
//     // ReSharper disable once EntityFramework.UnsupportedServerSideFunctionCall
//     //var books = context.Books.Where(book => book.Title.Contains("Y"));
//     //Console.WriteLine(books.);
//
//     var books = context.Books
//                             .AsNoTracking()
//                             .OrderBy(b => b.Title).ToList();
//     
//     foreach (var book in books)
//     {
//         Console.WriteLine($"{book.Title} {book.ISBN}");
//     }
// }
//
// void AddBooks()
// {
//     Book book = new() { Title = "Professional C# 6", Price = 10.93m, ISBN = "12345678", PublisherId = 1 };
//     using var context = new ApplicationDbContext();
//     context.Books.Add(book);
//     context.SaveChanges();
// }
//
//
// void UpdateBooks()
// {
//     using var context = new ApplicationDbContext();
//     var bookExists = context.Books.Find(2);
//
//     if (bookExists != null) bookExists.Title = "Professional C# 8";
//
//     context.SaveChanges();
//     
//
// }
//
//
// async void DeleteBooks()
// {
//     await using var context = new ApplicationDbContext();
//     var bookExists = await context.Books.FindAsync(2);
//     if (bookExists != null) context.Books.Remove(bookExists);
//     await context.SaveChangesAsync();
// }