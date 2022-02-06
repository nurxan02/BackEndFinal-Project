using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeFinal.Models
{
    public class AppUser : IdentityUser
    {
        [Required, StringLength(200)]
        public string FullName { get; set; }
        public bool IsActivated { get; set; }
        public string UserThoughts { get; set; }
    }
}
