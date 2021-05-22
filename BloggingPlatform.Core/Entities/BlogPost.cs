using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BloggingPlatform.Core.Entities
{
    public class BlogPost
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "You should provide a title value.")]
        [MaxLength(255, ErrorMessage ="Title can't be longer than 255  characters.")]
        public string Title { get; set; }
        [Required(ErrorMessage = "You should provide a description value.")]
        public string Description { get; set; }
        [Required(ErrorMessage = "You should provide a body value.")]
        public string Body { get; set; }
        [Required]
        public string Slug { get; set; }
        [Required]
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public virtual ICollection<Tag> Tags { get; set; }
    }
}
