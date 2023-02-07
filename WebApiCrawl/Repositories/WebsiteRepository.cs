using AspnetRunBasics.Data;
using Microsoft.EntityFrameworkCore;
using WebApiCrawl.Entities;
using WebApiCrawl.Repositories.Interfaces;

namespace WebApiCrawl.Repositories
{
    public class WebsiteRepository : IWebsiteRepository
    {
        protected readonly CrawlerDbContext _dbContext;
        public WebsiteRepository(CrawlerDbContext dbContext)
        {
            _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
        }


        public async Task<List<Website>> GetAll()
        {
            return await _dbContext.Websites.ToListAsync();
        }

        public async Task<Website> GetWebsiteById(int id)
        {
            return await _dbContext.Websites.Where(x => x.Id == id).FirstOrDefaultAsync();
        }

        public async Task<Website> AddAsync(Website website)
        {
            _dbContext.Websites.Add(website);
            await _dbContext.SaveChangesAsync();
            return website;
        }

        public async Task UpdateAsync(Website website)
        {
            _dbContext.Entry(website).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(Website website)
        {
            _dbContext.Websites.Remove(website);
            await _dbContext.SaveChangesAsync();
        }
    }
}
