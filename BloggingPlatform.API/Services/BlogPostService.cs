using BloggingPlatform.API.Interfaces;
using BloggingPlatform.API.Models.BindingModels;
using BloggingPlatform.API.Models.DTOModels;
using BloggingPlatform.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BloggingPlatform.API.Services
{
    public class BlogPostService : IBlogPostService
    {
        private readonly IBlogPostRepository _blogPostRepository;
        public BlogPostService(IBlogPostRepository blogPostRepository)
        {
            _blogPostRepository = blogPostRepository;
        }
        public SingleBlogPostDTO CreateBlogPost(BlogPostBindingModel blogPostModel)
        {
            //transform post u blogPost entity?
            //var blogPost = _blogPostRepository.Create(blogPostEntity);
            //transfrom entity u singlepostdto
            //return singlepostdto

            //ili sta 
            throw new NotImplementedException();
        }
        public void Delete(string slug)
        {
            throw new NotImplementedException();
        }

        public SingleBlogPostDTO GetBlogPost(string slug)
        {
            throw new NotImplementedException();
        }
        public MultipleBlogPostsDTO GetBlogPosts(string tag)
        {
            if (string.IsNullOrEmpty(tag))
            {
                tag = "";
            }
            var blogPosts = _blogPostRepository.GetBlogPosts(tag);
            int count = blogPosts.Count();

            MultipleBlogPostsDTO multipleBlogPostsDTO = new MultipleBlogPostsDTO();
            multipleBlogPostsDTO.BlogPosts = new List<BlogPostDTO>();

            foreach (var post in blogPosts)
            {
                BlogPostDTO blogPostDTO = new BlogPostDTO();
                List<string> list = new List<string>();

                blogPostDTO.Title = post.Title;
                blogPostDTO.Body = post.Body;
                blogPostDTO.Description = post.Description;
                blogPostDTO.Slug = post.Slug;
                blogPostDTO.CreatedAt = post.CreatedAt;
                blogPostDTO.UpdatedAt = post.UpdatedAt;

                foreach (var singleTag in post.Tags)
                {
                    list.Add(singleTag.Title);
                }

                string[] tags = list.ToArray();
                blogPostDTO.TagList = tags;

                multipleBlogPostsDTO.BlogPosts.Add(blogPostDTO);
            }
            multipleBlogPostsDTO.PostsCount = count;

            return multipleBlogPostsDTO;
        }

        public SingleBlogPostDTO UpdateBlogPost(BlogPostBindingModel blogPostModel)
        {
            throw new NotImplementedException();
        }
    }
}
