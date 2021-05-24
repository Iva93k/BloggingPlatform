using BloggingPlatform.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BloggingPlatform.API.Models.BindingModels
{
    public class BlogPostCreateBindingModel
    {
        [Required(ErrorMessage = "You should provide a title value.")]
        [MaxLength(255, ErrorMessage = "Title can't be longer than 255  characters.")]
        public string Title { get; set; }
        [Required(ErrorMessage = "You should provide a description value.")]
        public string Description { get; set; }
        [Required(ErrorMessage = "You should provide a body value.")]
        public string Body { get; set; }
        public string[]  TagList { get; set; }
    }
    public class BlogPostCreateBinding
    {
        public BlogPostCreateBindingModel BlogPost { get; set; }
    }
    public class BlogPostUpdateBindingModel
    {
        [MaxLength(255, ErrorMessage = "Title can't be longer than 255  characters.")]
        public string Title { get; set; }
        public string Description { get; set; }
        public string Body { get; set; }
    }
    public class BlogPostUpdateBinding
    {
        public BlogPostUpdateBindingModel BlogPost { get; set; }
    }

}
