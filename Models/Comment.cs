namespace FootballBlogApi.Models
{
    public class Comment
{
    public int Id { get; set; }
    public string Content { get; set; } = string.Empty;
    public int PostId { get; set; }
    public Post Post { get; set; } = new();
}
}