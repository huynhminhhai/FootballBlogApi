using FootballBlogApi.Dtos.Post;
using FootballBlogApi.Models;

namespace FootballBlogApi.Mappers
{
    public static class PostMapper
    {
        public static PostDto ToPostDto(this Post post)
        {
            return new PostDto
            {
                Id = post.Id,
                Title = post.Title,
                Content = post.Content,
                CategoryName = post.Category.Name,
                PublishedDate = post.PublishedDate
            };
        }

        public static PostDto ToPostDetailDto(this Post post)
        {
            return new PostDto
            {
                Id = post.Id,
                Title = post.Title,
                Content = post.Content,
                PublishedDate = post.PublishedDate
            };
        }
    }
}