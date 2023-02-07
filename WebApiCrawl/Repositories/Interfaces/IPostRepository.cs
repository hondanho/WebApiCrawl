using WebApiCrawl.Entities;

namespace WebApiCrawl.Repositories.Interfaces
{
    public interface IPostRepository
    {
        Task<List<Post>> GetAll();
        Task<List<Post>> GetPostByWebsiteId(int id);
        Task UpdateAsync(Post post);
        Task<Post> AddAsync(Post post);
        Task DeleteAsync(Post post);
    }
}
