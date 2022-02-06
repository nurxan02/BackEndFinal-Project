using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeFinal.Models
{
    public class Event
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string Image { get; set; }
        public string Day { get; set; }
        public string Month { get; set; }
        public string EventAbout { get; set; }
        public bool IsDeleted { get; set; }
        public string EventPlace { get; set; }
        public string EventStart { get; set; }
        public string EventFinish { get; set; }
        [NotMapped]
        public IFormFile Photo { get; set; }
        public ICollection<Speakers> Speakers { get; set; }
    }
}
