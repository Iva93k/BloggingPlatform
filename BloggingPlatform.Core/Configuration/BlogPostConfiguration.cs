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
                    Title = "Augmented Reality iOS Application",
                    Slug = "augmented-reality-ios-application",
                    Description = "Rubicon Software Development and Gazzda furniture are proud to launch an augmented reality app.",
                    Body = "The app is simple to use, and will help you decide on your best furniture fit.",
                    CreatedAt = new DateTime(2018, 05, 18, 03, 22, 56),
                },
                new BlogPost
                {
                    Id = 2,
                    Title = "Augmented Reality iOS Application 2",
                    Slug = "augmented-reality-ios-application-2",
                    Description = "Rubicon Software Development and Gazzda furniture are proud to launch an augmented reality app.",
                    Body = "The app is simple to use, and will help you decide on your best furniture fit.",
                    CreatedAt = DateTime.Now,
                },
                new BlogPost
                {
                    Id = 3,
                    Title = "Augmented Reality iOS Application 3",
                    Slug = "augmented-reality-ios-application-3",
                    Description = "Rubicon Software Development and Gazzda furniture are proud to launch an augmented reality app.",
                    Body = "The app is simple to use, and will help you decide on your best furniture fit.",
                    CreatedAt = new DateTime(2020, 05, 18, 06, 22, 56),
                },
                new BlogPost
                {
                    Id = 4,
                    Title = "Augmented Reality iOS Application 4",
                    Slug = "augmented-reality-ios-application-4",
                    Description = "Rubicon Software Development and Gazzda furniture are proud to launch an augmented reality app.",
                    Body = "The app is simple to use, and will help you decide on your best furniture fit.",
                    CreatedAt = new DateTime(2021, 05, 18, 04, 15, 00)
                }
            );
        }
    }
}
