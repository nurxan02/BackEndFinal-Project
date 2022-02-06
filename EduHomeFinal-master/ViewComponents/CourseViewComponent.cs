using EduHomeFinal.DAL;
using EduHomeFinal.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeFinal.ViewComponents
{
    public class CourseViewComponent : ViewComponent
    {
        private readonly EduDb _eduDb;
        public CourseViewComponent(EduDb eduDb)
        {
            _eduDb = eduDb;
        }
        public async Task<IViewComponentResult> InvokeAsync(int count = 9)
        {
            IEnumerable<Courses> courses = _eduDb.Courses.Take(count);
            return View(await Task.FromResult(courses));
        }
    }
}
