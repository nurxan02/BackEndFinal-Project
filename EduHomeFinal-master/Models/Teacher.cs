using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeFinal.Models
{
    public class Teacher
    {
        public int Id { get; set; }
        public string AboutMe { get; set; }
        [MaxLength(80)]
        public string Name { get; set; }
        [Required]
        public string Image { get; set; }
        public string Profession { get; set; }
        public string Degree { get; set; }
        public int Experience { get; set; }
        public string Hobbies { get; set; }
        public string Faculty { get; set; }
        public string ContactTel { get; set; }
        public string Mail { get; set; }
        public string Skype { get; set; }
        public string Facebook { get; set; }
        public string Pinterest { get; set; }
        public string Twitter { get; set; }
        public string Instagram { get; set; }
        public Skills Skills { get; set; }
        [NotMapped]
        public IFormFile PhotoTeacher { get; set; }
    }
}
