using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using WebApiCrawl.Entities;
using WebApiCrawl.Model;
using WebApiCrawl.Repositories.Interfaces;

namespace WebApiCrawl.Controllers {

    [ApiController]
    [Route("[controller]")]
    public class WebsiteController : BaseController {
        private readonly ILogger<WebsiteController> _logger;
        private readonly IWebsiteRepository _websiteRepository;
        private readonly IMapper _mapper;

        public WebsiteController(ILogger<WebsiteController> logger, 
            IWebsiteRepository websiteRepository,
            IMapper mapper
            ) {
            _logger = logger;
            _websiteRepository = websiteRepository;
            _mapper = mapper;
        }

        [HttpGet(Name = "GetAll")]
        public async Task<List<Website>> GetAll() {
            return await _websiteRepository.GetAll();
        }

        [HttpPost(Name = "Create")]
        public async Task<Website> Create(WebsiteModel websiteModel)
        {
            Website website = _mapper.Map<Website>(websiteModel);
            return await _websiteRepository.AddAsync(website);
        }

        [HttpPost(Name = "Update")]
        public async Task Update(WebsiteModel websiteModel)
        {
            Website website = _mapper.Map<Website>(websiteModel);
            await _websiteRepository.UpdateAsync(website);
        }
    }
}