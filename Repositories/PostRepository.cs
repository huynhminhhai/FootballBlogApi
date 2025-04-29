using FootballBlogApi.Data;
using FootballBlogApi.Interfaces;
using FootballBlogApi.Models;
using Microsoft.EntityFrameworkCore;

namespace FootballBlogApi.Repositories
{
    public class PostRepository : IPostRepository
    {
        private readonly ApplicationDbContext _context;
        public PostRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Post>> GetAllPostAsync()
        {
            return await _context.Posts.Include(p => p.Category).ToListAsync();
        }

        public async Task<Post?> GetPostByIdAsync(int id)
        {

            var post = await _context.Posts.Include(p => p.Category).FirstOrDefaultAsync(p => p.Id == id);

            if (post == null)
            {
                return null;
            }

            return post;
        }
    }
}
