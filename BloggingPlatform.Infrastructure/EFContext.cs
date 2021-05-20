using BloggingPlatform.Core.Configuration;
using BloggingPlatform.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace BloggingPlatform.Infrastructure
{
    public class EFContext : DbContext
    {
        public EFContext(DbContextOptions options)
            : base(options)
        {
        }
        public DbSet<BlogPost> BlogPost { get; set; }
        public DbSet<Tag> Tag { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.ApplyConfiguration(new BlogPostConfiguration());
        //    modelBuilder.ApplyConfiguration(new TagConfiguration());
        //    //modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        //}
    }
}
