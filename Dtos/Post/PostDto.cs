namespace FootballBlogApi.Dtos.Post
{
    public class PostDto
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Content { get; set; } = string.Empty;
        public string Thumbnail { get; set; } = string.Empty;
        public string CategoryName { get; set; } = string.Empty;
        public DateTime PublishedDate { get; set; }
    }
}