using AutoMapper;
using WebApiCrawl.Entities;
using WebApiCrawl.Model;

namespace WebApiCrawler.Extensions.AutoMapper
{
    public class WebsiteProfile : Profile
    {
        public WebsiteProfile() {
            CreateMap<Website, WebsiteModel>();
        }
    }
}
