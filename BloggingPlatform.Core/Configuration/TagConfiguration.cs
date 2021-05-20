using BloggingPlatform.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace BloggingPlatform.Core.Configuration
{
    public class TagConfiguration : IEntityTypeConfiguration<Tag>
    {
        public void Configure(EntityTypeBuilder<Tag> builder)
        {
            builder.HasData
            (
                new Tag
                {
                    Id = 1,
                    Title = "Tag1"
                },
                new Tag
                {
                    Id = 2,
                    Title = "Tag2"
                }, 
                new Tag
                {
                    Id = 3,
                    Title = "Tag3"
                }
            );
        }
    }
}
