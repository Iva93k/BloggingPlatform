using BloggingPlatform.Core.Entities;
using BloggingPlatform.Core.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BloggingPlatform.Infrastructure.Repository
{
    public class BlogPostRepository : IBlogPostRepository
    {
        private readonly EFContext _efcontext;

        public BlogPostRepository(EFContext efcontext)
        {
            _efcontext = efcontext;
        }
        public BlogPost CreateBlogPost(BlogPost blogPost)
        {
            throw new NotImplementedException();
        }

        public void Delete(string slug)
        {
            throw new NotImplementedException();
        }

        public BlogPost GetBlogPostBySlug(string slug)
        {
            var blogPost = _efcontext.BlogPost.Include(p => p.Tags).Where(p => p.Slug == slug).FirstOrDefault();

            return blogPost;
        }

        public IEnumerable<BlogPost> GetBlogPosts(string tag)
        {
            var blogPosts = _efcontext.BlogPost.Include(t => t.Tags).AsQueryable();
            if (!string.IsNullOrEmpty(tag))
            {
                var filteredBlogPosts = blogPosts.Where(p => p.Tags.Any(t => t.Title == tag)).OrderByDescending(p => p.CreatedAt).ToList();
                return filteredBlogPosts;
            }
            else
            {
                return blogPosts.OrderByDescending(p => p.CreatedAt).ToList();
            }
        }

        public BlogPost UpdateBlogPost(BlogPost blogPost)
        {
            throw new NotImplementedException();
        }
    }
}
