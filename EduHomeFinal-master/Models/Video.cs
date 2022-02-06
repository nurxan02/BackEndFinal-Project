using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeFinal.Models
{
    public class Video
    {
        public int Id { get; set; }
        [Required]
        public string VideoType { get; set; }
        public string Title { get; set; }
    }
}
