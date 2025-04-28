using FootballBlogApi.Models;
using Microsoft.EntityFrameworkCore;

namespace FootballBlogApi.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Post> Posts { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Comment> Comments { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        { }
    }
}