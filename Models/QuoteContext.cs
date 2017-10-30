using Microsoft.EntityFrameworkCore;
 
namespace quotingDojo2.Models
{
    public class QuoteContext : DbContext
    {
        // base() calls the parent class' constructor passing the "options" parameter along
        public QuoteContext(DbContextOptions<QuoteContext> options) : base(options) { }

        public DbSet<Author> authors { get; set; }
        public DbSet<Category> categories { get; set; }
        public DbSet<Meta> metas { get; set; }
        public DbSet<Quote> quotes { get; set; }
        public DbSet<Categorized> quotes_has_categories { get; set; }


    }
}