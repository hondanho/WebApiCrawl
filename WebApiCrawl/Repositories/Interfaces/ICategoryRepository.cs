using WebApiCrawl.Entities;

namespace WebApiCrawl.Repositories.Interfaces
{
    public interface ICategoryRepository
    {
        Task<List<Category>> GetAllByWebsiteId(int websiteId);
    }
}
