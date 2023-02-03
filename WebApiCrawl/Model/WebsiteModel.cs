using System.Collections.Generic;

namespace WebApiCrawl.Model {
    public class WebsiteModel : BaseModel {
        public int Id { get; set; }
        public string Domain { get; set; }
        public string LinkSiteMap { get; set; }
        public int SuccessSpyAmount { get; set; }
        public int FailSpyAmount { get; set; }
        public int PostPerDay { get; set; }
        public string RegexSiteMapPost { get; set; }
        public string RegexPost { get; set; }
        public int TotalSiteMapAmount { get; set; }
        public int PostsAmount { get; set; }
    }
}