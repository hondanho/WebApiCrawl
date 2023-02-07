using AspnetRunBasics.Data;
using Microsoft.EntityFrameworkCore;
using WebApiCrawl.Entities;
using WebApiCrawl.Repositories.Interfaces;

namespace WebApiCrawl.Repositories
{
    public class PostRepository : IPostRepository
    {
        protected readonly CrawlerDbContext _dbContext;
        public PostRepository(CrawlerDbContext dbContext)
        {
            _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
        }


        public async Task<List<Post>> GetAll()
        {
            return await _dbContext.Posts.ToListAsync();
        }

        public async Task<List<Post>> GetPostByWebsiteId(int id)
        {
            return await _dbContext.Posts.Where(x => x.Id == id).ToListAsync();
        }

        public async Task<Post> AddAsync(Post post)
        {
            _dbContext.Posts.Add(post);
            await _dbContext.SaveChangesAsync();
            return post;
        }

        public async Task UpdateAsync(Post post)
        {
            _dbContext.Entry(post).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(Post post)
        {
            _dbContext.Posts.Remove(post);
            await _dbContext.SaveChangesAsync();
        }
    }
}
