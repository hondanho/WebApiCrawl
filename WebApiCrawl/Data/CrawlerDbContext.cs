using Microsoft.EntityFrameworkCore;
using WebApiCrawl.Entities;

namespace AspnetRunBasics.Data
{
    public class CrawlerDbContext : DbContext
    {
        public CrawlerDbContext(DbContextOptions<CrawlerDbContext> options)
            : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Website> Websites { get; set; }
        public DbSet<Post> Posts { get; set; }
    }
}
