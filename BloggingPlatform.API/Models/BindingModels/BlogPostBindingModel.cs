using BloggingPlatform.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BloggingPlatform.API.Models.BindingModels
{
    public class BlogPostBindingModel
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
    public class BlogPostBinding
    {
        public BlogPostBindingModel BlogPost { get; set; }
    }
}
