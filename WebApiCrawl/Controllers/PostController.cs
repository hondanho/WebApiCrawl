using Microsoft.AspNetCore.Mvc;
using WebApiCrawl.Entities;
using WebApiCrawl.Repositories.Interfaces;

namespace WebApiCrawl.Controllers {

    [ApiController]
    [Route("[controller]")]
    public class PostController : BaseController {
        private readonly ILogger<WebsiteController> _logger;
        private readonly IPostRepository _postRepository;

        public PostController(ILogger<WebsiteController> logger, IPostRepository postRepository) {
            _logger = logger;
            _postRepository = postRepository;
        }

        [HttpGet(Name = "GetPosts")]
        public async Task<List<Post>> GetPostByWebsiteId(int websiteId) {
            return await _postRepository.GetPostByWebsiteId(websiteId);
        }
    }
}