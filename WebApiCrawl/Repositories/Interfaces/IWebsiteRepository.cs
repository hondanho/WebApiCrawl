using WebApiCrawl.Entities;

namespace WebApiCrawl.Repositories.Interfaces
{
    public interface IWebsiteRepository
    {
        Task<List<Website>> GetAll();
        Task<Website> GetWebsiteById(int id);
        Task UpdateAsync(Website website);
        Task<Website> AddAsync(Website website);
        Task DeleteAsync(Website website);
    }
}
