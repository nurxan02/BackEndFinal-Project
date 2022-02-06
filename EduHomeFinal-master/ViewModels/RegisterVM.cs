using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeFinal.ViewModels
{
    public class RegisterVM
    {
        [Required, MaxLength(200)]
        public string FullName { get; set; }
        [Required, MaxLength(200)]
        public string Username { get; set; }
        [Required, DataType(DataType.Password)]
        public string Password { get; set; }
        [Required, DataType(DataType.Password), Compare(nameof(Password))]
        public string CheckPassword { get; set; }
        [Required, EmailAddress, DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        public string UserThoughts { get; set; }
    }
}
