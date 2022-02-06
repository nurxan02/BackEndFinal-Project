using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeFinal.Models
{
    public class Courses
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public string Starts { get; set; }
        public string Duration { get; set; }
        public string ClassDuration { get; set; }
        public string SkillLevel { get; set; }
        public string Language { get; set; }
        public int StudentCapacity { get; set; }
        public string Assetsments { get; set; }
        public double Fee { get; set; }
        public int CategoriesId { get; set; }
        public Categories Categories { get; set; }
        [NotMapped]
        public IFormFile PhotoCourse { get; set; }
    }
}
