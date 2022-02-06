using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeFinal.Models
{
    public class Bio
    {
        public int Id { get; set; }
        [Required]
        public string Image { get; set; }
        public string Facebook { get; set; }
        public string Pinterset { get; set; }
        public string Twitter { get; set; }
        public string Instagram { get; set; }
        public string EudoHomeAdress { get; set; }
        public string Contact { get; set; }
        public string EudoHomePlaceCountry { get; set; }
        public string Email { get; set; }
        public string WebAdress { get; set; }
    }
}
