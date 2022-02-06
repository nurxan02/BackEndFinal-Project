using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeFinal.Models
{
    public class Categories
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Courses> Courses { get; set; }
    }
}
