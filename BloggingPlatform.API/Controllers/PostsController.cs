﻿using System;
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
            var blogPosts = _blogPostService.GetBlogPosts(tag);
            return Ok(blogPosts);
        }

        //POST api/posts
        [HttpPost]
        public  ActionResult<BlogPostDTO> Create([FromBody] BlogPostBindingModel post)
        {
            if(post == null)
            {
                return BadRequest();
            }

            var blogPost = _blogPostService.CreateBlogPost(post);
            return Ok(blogPost);
        }
    }
}