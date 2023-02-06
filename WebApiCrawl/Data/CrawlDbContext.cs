using Microsoft.EntityFrameworkCore;
using WebApiCrawl.Entities;

namespace AspnetRunBasics.Data
{
    public class CrawlDbContext : DbContext
    {
        public CrawlDbContext(DbContextOptions<CrawlDbContext> options)
            : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Website> Websites { get; set; }
        public DbSet<Post> Posts { get; set; }
    }
}
