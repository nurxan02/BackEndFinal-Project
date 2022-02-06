using EduHomeFinal.DAL;
using EduHomeFinal.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeFinal.Controllers
{
    public class BlogController : Controller
    {
        private readonly EduDb _eduDb;
        public BlogController(EduDb eduDb)
        {
            _eduDb = eduDb;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Search(string key)
        {
            IEnumerable<Blog> blog = _eduDb.Blogs.Where(b => b.Blogname.Contains(key.ToLower())).ToList();
            return PartialView("~/Views/Shared/_partialSearch.cshtml", blog);
        }
        public IActionResult Detail(int? id)
        {
            if (id == null)
                return NotFound();
            Blog blog =_eduDb.Blogs.Where(b => b.Id == id).FirstOrDefault();
            return View(blog);
        }
    }
}
