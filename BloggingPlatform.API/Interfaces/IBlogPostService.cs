using BloggingPlatform.API.Models.BindingModels;
using BloggingPlatform.API.Models.DTOModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BloggingPlatform.API.Interfaces
{
    public interface IBlogPostService
    {
        MultipleBlogPostsDTO GetBlogPosts(string tag);
        SingleBlogPostDTO GetBlogPostBySlug(string slug);
        SingleBlogPostDTO CreateBlogPost(BlogPostCreateBindingModel blogPostModel);
        SingleBlogPostDTO UpdateBlogPost(string slug, BlogPostUpdateBindingModel blogPostModel);
        void Delete(string slug);
    }
}
