namespace FootballBlogApi.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Bio { get; set; } = string.Empty;
        public List<Post> Posts { get; set; } = new();
    }
}