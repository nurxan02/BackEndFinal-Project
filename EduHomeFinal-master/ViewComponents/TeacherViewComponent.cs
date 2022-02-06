using EduHomeFinal.DAL;
using EduHomeFinal.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeFinal.ViewComponents
{
    public class TeacherViewComponent : ViewComponent
    {
        private readonly EduDb _eduDb;
        public TeacherViewComponent(EduDb eduDb)
        {
            _eduDb = eduDb;
        }
        public async Task<IViewComponentResult> InvokeAsync(int count = 12)
        {
            IEnumerable<Teacher> teachers = _eduDb.Teachers.Take(count);
            return View(await Task.FromResult(teachers));
        }
    }
}
