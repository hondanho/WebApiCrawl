namespace WebApiCrawl.Model {
    public class PostModel : BaseModel {
        public int Id { get; set; }
        public string Title { get; set; }
        public int CategoryId { get; set; }
        public string Content { get; set; }
        public string Thumbnail { get; set; }

    }
}