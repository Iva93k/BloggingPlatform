using BloggingPlatform.API.Interfaces;
using BloggingPlatform.API.Models.BindingModels;
using BloggingPlatform.API.Models.DTOModels;
using BloggingPlatform.Core.Entities;
using BloggingPlatform.Core.Interfaces;
using BloggingPlatform.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BloggingPlatform.API.Services
{
    public class BlogPostService : IBlogPostService
    {
        private readonly IBlogPostRepository _blogPostRepository;
        private readonly ITagRepository _tagRepository;
        public BlogPostService(IBlogPostRepository blogPostRepository, ITagRepository tagRepository)
        {
            _blogPostRepository = blogPostRepository;
            _tagRepository = tagRepository;
        }
        public SingleBlogPostDTO CreateBlogPost(BlogPostBindingModel blogPostModel)
        {
            BlogPost blogPost = new BlogPost();
            //List<string> tags = new List<string>();
            List<Tag> tags = new List<Tag>();

            blogPost.Title = blogPostModel.Title;
            blogPost.Description = blogPostModel.Description;
            blogPost.Body = blogPostModel.Body;
            blogPost.CreatedAt = DateTime.Now;
            blogPost.Slug = SlugifyManager.Slugify(blogPostModel.Title);

            blogPost.Tags = tags;

            if (blogPostModel.TagList != null)
            {
                foreach (var singleTag in blogPostModel.TagList)
                {
                    Tag tag = new Tag();
                    tag = _tagRepository.GetTagByTitle(singleTag);
                    //tags.Add(tag);
                    //blogPost.Tags = tags;
                    blogPost.Tags.Add(tag);
                }
            }
            var createdBlogPost = _blogPostRepository.CreateBlogPost(blogPost);
            SingleBlogPostDTO singleBlogPostDTO = new SingleBlogPostDTO();
            singleBlogPostDTO = GetBlogPostBySlug(createdBlogPost.Slug);

            return singleBlogPostDTO;
        }
        public void Delete(string slug)
        {
            throw new NotImplementedException();
        }

        public SingleBlogPostDTO GetBlogPostBySlug(string slug)
        {
            SingleBlogPostDTO singleBlogPostDTO = new SingleBlogPostDTO();
            List<string> list = new List<string>();

            var blogPost = _blogPostRepository.GetBlogPostBySlug(slug);

            if (blogPost != null)
            {
                BlogPostDTO blogPostDTO = new BlogPostDTO();

                blogPostDTO.Title = blogPost.Title;
                blogPostDTO.Description = blogPost.Description;
                blogPostDTO.Body = blogPost.Body;
                blogPostDTO.Slug = blogPost.Slug;
                blogPostDTO.CreatedAt = blogPost.CreatedAt;
                blogPostDTO.UpdatedAt = blogPost.UpdatedAt;

                foreach (var singleTag in blogPost.Tags)
                {
                    list.Add(singleTag.Title);
                }

                string[] tags = list.ToArray();
                blogPostDTO.TagList = tags;

                singleBlogPostDTO.BlogPost = blogPostDTO;
            }

            return singleBlogPostDTO;
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
