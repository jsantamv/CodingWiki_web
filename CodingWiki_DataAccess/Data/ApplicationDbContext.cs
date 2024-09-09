using CodingWiki_Model.Models;
using Microsoft.EntityFrameworkCore;

namespace CodingWiki_DataAccess.Data
{
    public class ApplicationDbContext: DbContext
    {
        
        public DbSet<Book> Books {  get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //base.OnConfiguring(optionsBuilder);
            //optionsBuilder.UseSqlServer("Server=localhost;Database=CodingWiki;Trusted_Connection=True;TrustServerCertificate=True");            
            optionsBuilder.UseSqlServer("Server=localhost;Database=CodingWiki;User ID=sa;Password=Chirripo3820@;TrustServerCertificate=True");
            //optionsBuilder.UseSqlServer(connectionString);

        }

    }
}
