using BloggingPlatform.Core.Entities;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BloggingPlatform.Infrastructure
{
    public static class SeedManager
    {
        public static IHost SeedData(this IHost host)
        {
            using (var scope = host.Services.CreateScope())
            {
                using (var efcontext = scope.ServiceProvider.GetRequiredService<EFContext>())
                {
                    var numberOfTags = efcontext.Tag.Count();
                    var numberofBlogPosts = efcontext.BlogPost.Count();

                    var tag1 = new Tag
                    {
                        Title = "Tag1"
                    };

                    var tag2 = new Tag
                    {
                        Title = "Tag2"
                    };

                    var tag3 = new Tag
                    {
                        Title = "Tag3"
                    };

                    if (!(numberOfTags > 0) && !(numberofBlogPosts > 0))
                    {
                        efcontext.AddRange(
                            new BlogPost
                            {
                                Title = "Blogging platform post",
                                Slug = "blogging-platform-post",
                                Description = "This is a test post.",
                                Body = "Every post must have title, body and description, and can have multiple tags.",
                                CreatedAt = new DateTime(2018, 05, 18, 03, 22, 56),
                                Tags = new List<Tag> { tag1, tag2 }
                            },
                            new BlogPost
                            {
                                Title = "Blogging platform post 2",
                                Slug = "blogging-platform-post-2",
                                Description = "This is a test post.",
                                Body = "Every post must have title, body and description, and can have multiple tags.",
                                CreatedAt = new DateTime(2018, 05, 18, 03, 22, 56),
                                Tags = new List<Tag> { tag1, tag2, tag3 }
                            },
                            new BlogPost
                            {
                                Title = "Blogging platform post 3",
                                Slug = "blogging-platform-post-3",
                                Description = "This is a test post.",
                                Body = "Every post must have title, body and description, and can have multiple tags.",
                                CreatedAt = new DateTime(2018, 05, 18, 03, 22, 56),
                                Tags = new List<Tag> { tag1 }
                            },
                            new BlogPost
                            {
                                Title = "Blogging platform post 4",
                                Slug = "blogging-platform-post-4",
                                Description = "This is a test post.",
                                Body = "Every post must have title, body and description, and can have multiple tags.",
                                CreatedAt = DateTime.Now,
                                Tags = new List<Tag> { tag3 }
                            }
                            );

                        efcontext.SaveChanges();
                    }
                }
            }

            return host;
        }
    }
}
