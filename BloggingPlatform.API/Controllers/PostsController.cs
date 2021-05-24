using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BloggingPlatform.API.Interfaces;
using BloggingPlatform.API.Models.BindingModels;
using BloggingPlatform.API.Models.DTOModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BloggingPlatform.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostsController : ControllerBase
    {
        private readonly IBlogPostService _blogPostService;

        public PostsController(IBlogPostService blogPostService)
        {
            _blogPostService = blogPostService;
        }

        //GET api/posts
        [HttpGet]
        public ActionResult<MultipleBlogPostsDTO> GetAllBlogPosts([FromQuery] string tag)
        {
            try
            {
                var blogPosts = _blogPostService.GetBlogPosts(tag);
                if (blogPosts == null)
                {
                    return NotFound();
                }
                else
                {
                    return Ok(blogPosts);
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }
        //GET api/posts/slug
        [HttpGet("{slug}")]
        public ActionResult<SingleBlogPostDTO> GetBlogPost([FromRoute] string slug)
        {
            try
            {
                var blogPost = _blogPostService.GetBlogPostBySlug(slug);
                if (blogPost == null)
                {
                    return NotFound();
                }
                else
                {
                    return Ok(blogPost);
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        //POST api/posts
        [HttpPost]
        public  ActionResult<BlogPostDTO> Create([FromBody] BlogPostCreateBinding post)
        {
            try
            {
                if (post.BlogPost == null)
                {
                    return BadRequest("Post object is null!");
                }

                if(!ModelState.IsValid)
                {
                    return BadRequest("Invalid model object!");
                }

                var blogPostDTO = _blogPostService.CreateBlogPost(post.BlogPost);
                return Ok(blogPostDTO);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }
        //PUT api/posts/slug
        [HttpPut("{slug}")]
        public ActionResult<BlogPostDTO> Update([FromRoute] string slug, [FromBody] BlogPostUpdateBinding post)
        {
            try
            {
                if (post.BlogPost == null)
                {
                    return BadRequest("Post object is null!");
                }

                if (!ModelState.IsValid)
                {
                    return BadRequest("Invalid model object!");
                }

                var blogPostEntity = _blogPostService.GetBlogPostBySlug(slug);
                if(blogPostEntity.BlogPost == null)
                {
                    return NotFound($"Blog post with a slug: {slug}  hasn't been found!");
                }
                var blogPostDTO = _blogPostService.UpdateBlogPost(slug, post.BlogPost);
                return Ok(blogPostDTO);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

    }
}
