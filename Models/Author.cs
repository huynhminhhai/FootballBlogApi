namespace FootballBlogApi.Models
{
    public class Author
    {
        public int Id { get; set; }
        public string FullName { get; set; } = string.Empty;
        public string Bio { get; set; } = string.Empty;
        public List<Post> Posts { get; set; } = new();
    }
}