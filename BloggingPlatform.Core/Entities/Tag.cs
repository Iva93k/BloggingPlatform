using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BloggingPlatform.Core.Entities
{
    public class Tag
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Title is required.")]
        [MaxLength(50, ErrorMessage = "Title can't be longer than 50 characters.")]
        public string Title { get; set; }
        public ICollection<BlogPost> BlogPosts { get; set; }
    }
}
