using EduHomeFinal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeFinal.ViewModels
{
    public class CourseVM
    {
        public Courses Course { get; set; }
        public IEnumerable<Courses> Courses { get; set; }
        public IEnumerable<Blog> Blogs { get; set; }
    }
}
