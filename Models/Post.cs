namespace FootballBlogApi.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Content { get; set; } = string.Empty;
        public string Thumbnail { get; set; } = string.Empty;
        public DateTime PublishedDate { get; set; }
        public int? AuthorId { get; set; }
        public Author? Author { get; set; }
        public int? CategoryId { get; set; }
        public Category? Category { get; set; }
        public List<Comment> Comments { get; set; } = new();
    }
}