using System.ComponentModel.DataAnnotations;

namespace WebApiCrawl.Entities
{
    public class Website
    {
        public int Id { get; set; }
        [Required]
        public string Domain { get; set; }
        public string LinkSiteMap { get; set; }
        public int SuccessSpyAmount { get; set; }
        public int FailSpyAmount { get; set; }
        public int PostPerDay { get; set; }
        public string RegexSiteMapPost { get; set; }
        public string RegexPost { get; set; }
        public int TotalSiteMapAmount { get; set; }
        public int PostsAmount { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public bool IsDeleted { get; set; }
    }
}
