using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeFinal.Models
{
    public class Blog
    {
        public int Id { get; set; }
        [Required]
        public string Image { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
        public string BlogWriteTime { get; set; }
        public string CommentCount { get; set; }
        public string Blogname { get; set; }
        public string Text { get; set; }
        [NotMapped]
        public IFormFile PhotoBlog { get; set; }
    }
}
