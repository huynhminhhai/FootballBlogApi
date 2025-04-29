using FootballBlogApi.Models;

namespace FootballBlogApi.Interfaces
{
    public interface IPostRepository
    {
        Task<List<Post>> GetAllPostAsync();
        Task<Post?> GetPostByIdAsync(int id);
    }
}