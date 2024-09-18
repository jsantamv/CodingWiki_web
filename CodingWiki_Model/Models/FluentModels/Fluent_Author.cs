using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodingWiki_Model.Models.FluentModels;

public class Fluent_Author
{
    [Key]
    public int AuthorId { get; set; }

    [Required]
    [StringLength(50)]
    public string? FirstName { get; set; }

    [Required]
    public string? LastName { get; set; }

    public DateTime? BirthDate { get; set; }

    public string? Location { get; set; }

    [NotMapped]
    public string? FullName => $"{LastName} {FirstName}".Trim();

    //public List<Fluent_BookAuthorMap> BookAuthorMap { get; set; }
}