using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeFinal.Models
{
    public class Slider
    {
        public int Id { get; set; }
        [Required]
        public string Image { get; set; }
        [StringLength(150)]
        public string Title { get; set; }
        [StringLength(450)]
        public string Description { get; set; }
        [NotMapped]
        public IFormFile PhotoSlide { get; set; }
    }
}
