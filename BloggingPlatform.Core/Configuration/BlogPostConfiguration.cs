using BloggingPlatform.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace BloggingPlatform.Core.Configuration
{
    public class BlogPostConfiguration : IEntityTypeConfiguration<BlogPost>
    {
        public void Configure(EntityTypeBuilder<BlogPost> builder)
        {
            builder.HasData
            (
                new BlogPost
                {
                    Id = 1,
                    Title = "Blogging platform post",
                    Slug = "blogging-platform-post",
                    Description = "This is a test post.",
                    Body = "Every post must have title, body and description, and can have multiple tags.",
                    CreatedAt = new DateTime(2018, 05, 18, 03, 22, 56)                
                },
                new BlogPost
                {
                    Id = 2,
                    Title = "Blogging platform post 2",
                    Slug = "blogging-platform-post-2",
                    Description = "This is a test post.",
                    Body = "Every post must have title, body and description, and can have multiple tags.",
                    CreatedAt = new DateTime(2018, 05, 18, 03, 22, 56)                
                },
                new BlogPost
                {
                    Id = 3,
                    Title = "Blogging platform post 3",
                    Slug = "blogging-platform-post-3",
                    Description = "This is a test post.",
                    Body = "Every post must have title, body and description, and can have multiple tags.",
                    CreatedAt = new DateTime(2018, 05, 18, 03, 22, 56)                
                },
                new BlogPost
                {
                    Id = 4,
                    Title = "Blogging platform post 4",
                    Slug = "blogging-platform-post-4",
                    Description = "This is a test post.",
                    Body = "Every post must have title, body and description, and can have multiple tags.",
                    CreatedAt = new DateTime(2018, 05, 18, 03, 22, 56)                
                }
            );
        }
    }
}
