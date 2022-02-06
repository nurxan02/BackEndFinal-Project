using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeFinal.Models
{
    public class EduHome
    {
        public int Id { get; set; }
        [Required]
        public string Image { get; set; }
        [MaxLength(100)]
        public string Title { get; set; }
        public string Description { get; set; }
        [NotMapped]
        public IFormFile PhotoEdu { get; set; }
    }
}
