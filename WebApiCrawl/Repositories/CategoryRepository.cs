using AspnetRunBasics.Data;
using Microsoft.EntityFrameworkCore;
using WebApiCrawl.Entities;
using WebApiCrawl.Repositories.Interfaces;

namespace WebApiCrawl.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        protected readonly CrawlerDbContext _dbContext;
        public CategoryRepository(CrawlerDbContext dbContext)
        {
            _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
        }


        public async Task<List<Category>> GetAllByWebsiteId(int websiteId)
        {
            return await _dbContext.Categories.Where(x => x.WebsiteId == websiteId).ToListAsync();
        }
    }
}
