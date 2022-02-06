using EduHomeFinal.DAL;
using EduHomeFinal.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeFinal.ViewComponents
{
    public class BlogViewComponent : ViewComponent
    {
        private readonly EduDb _eduDb;
        public BlogViewComponent(EduDb eduDb)
        {
            _eduDb = eduDb;
        }
        public async Task<IViewComponentResult> InvokeAsync(int count = 14)
        {
            IEnumerable<Blog> blogs = _eduDb.Blogs.Take(count);
            return View(await Task.FromResult(blogs));
        }
    }
}
