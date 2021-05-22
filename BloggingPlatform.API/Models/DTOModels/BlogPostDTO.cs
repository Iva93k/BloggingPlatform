using BloggingPlatform.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BloggingPlatform.API.Models.DTOModels
{
    public class BlogPostDTO
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Body { get; set; }
        public string Slug { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string[] TagList { get; set; }
    }

    public class SingleBlogPostDTO
    {
        public BlogPostDTO BlogPost { get; set; }
    }

    public class MultipleBlogPostsDTO
    {
        public List<BlogPostDTO> BlogPosts { get; set; }
        public int PostsCount { get; set; }
    }
}
