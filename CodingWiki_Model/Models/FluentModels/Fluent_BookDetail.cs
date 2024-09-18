using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodingWiki_Model.Models.FluentModels;

public class Fluent_BookDetail
{
    public int BookDetailId { get; set; }

    public int NumberOfPages { get; set; }

    public int NumberOfChapters { get; set; }

    public string? Weight { get; set; }

    // [ForeignKey("Book")] 
    // public int BookId { get; set; }

    // public Fluent_Book Book { get; set; }
}