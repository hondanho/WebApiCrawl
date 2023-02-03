using Microsoft.AspNetCore.Mvc;
using WebApiCrawl.Model;

namespace WebApiCrawl.Controllers {

    [ApiController]
    [Route("[controller]")]
    public class WebsiteController : BaseController {
        private readonly ILogger<WebsiteController> _logger;

        public WebsiteController(ILogger<WebsiteController> logger) {
            _logger = logger;
        }

        [HttpGet(Name = "GetWebsites")]
        public IEnumerable<WebsiteModel> Get() {
            return new List<WebsiteModel>();
        }

        [HttpGet(Name = "GetWebsites")]
        public IEnumerable<WebsiteModel> Get() {
            return new List<WebsiteModel>();
        }
    }
}