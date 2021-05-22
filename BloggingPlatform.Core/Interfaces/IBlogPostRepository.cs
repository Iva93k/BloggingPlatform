﻿using BloggingPlatform.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BloggingPlatform.Core.Interfaces
{
    public interface IBlogPostRepository
    {
        IEnumerable<BlogPost> GetBlogPosts(string tag);
        BlogPost GetBlogPost(string slug);
        BlogPost CreateBlogPost(BlogPost blogPost);
        BlogPost UpdateBlogPost(BlogPost blogPost);
        void Delete(string slug);
    }
}
