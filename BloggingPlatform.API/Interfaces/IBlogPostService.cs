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
        //IEnumerable<MultipleBlogPostsDTO> GetBlogPosts(string tag);
        MultipleBlogPostsDTO GetBlogPosts(string tag);
        SingleBlogPostDTO GetBlogPostBySlug(string slug);
        SingleBlogPostDTO CreateBlogPost(BlogPostBindingModel blogPostModel);
        SingleBlogPostDTO UpdateBlogPost(BlogPostBindingModel blogPostModel);
        void Delete(string slug);
    }
}
