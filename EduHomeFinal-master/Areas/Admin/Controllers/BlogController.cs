using EduHomeFinal.DAL;
using EduHomeFinal.Extencions;
using EduHomeFinal.Helpers;
using EduHomeFinal.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeFinal.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BlogController : Controller
    {
        private readonly EduDb _eduDb;
        private readonly IWebHostEnvironment _web;
        public BlogController(EduDb eduDb, IWebHostEnvironment web)
        {
            _eduDb = eduDb;
            _web = web;
        }
        public IActionResult Index()
        {
            return View(_eduDb.Blogs.ToList());
        }
        public IActionResult Detail(int? id)
        {
            if (id == null)
                return NotFound();
            Blog blog = _eduDb.Blogs.FirstOrDefault(b => b.Id == id);
            if (blog == null)
                return NotFound();
            return View(blog);
        }
        public IActionResult Update(int? id)
        {
            if (id == null)
                return NotFound();
            Blog blog = _eduDb.Blogs.FirstOrDefault(b => b.Id == id);
            if (blog == null)
                return NotFound();
            return View(blog);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int? id, Blog blog)
        {
            if (id == null)
                return NotFound();
            if (!ModelState.IsValid)
            {
                return View();
            }
            Blog dbblog = _eduDb.Blogs.FirstOrDefault(b => b.Id == id);
            if (ModelState["PhotoBlog"].ValidationState == Microsoft.AspNetCore.Mvc.ModelBinding.ModelValidationState.Invalid)
            {
                return View();
            }
            if (!blog.PhotoBlog.IsImage())
            {
                ModelState.AddModelError("PhotoBlog", "Use an image file");
                return View();
            }
            if (blog.PhotoBlog.CheckFileSize(800))
            {
                ModelState.AddModelError("PhotoBlog", "Size is bigger than 800kb");
                return View();
            }
            string folderpath = Path.Combine("Assets", "img", "blog");
            Helper.DeleteFile(_web.WebRootPath, folderpath, dbblog.Blogname);
            string FileName = await blog.PhotoBlog.SaveFileAsync(_web.WebRootPath, folderpath);

            dbblog.Image = FileName;
            dbblog.Blogname = blog.Blogname;
            dbblog.Author = blog.Author;
            dbblog.BlogWriteTime = blog.BlogWriteTime;
            dbblog.CommentCount = blog.CommentCount;
            dbblog.Description = blog.Description;

            await _eduDb.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Create()
        {
            return View(_eduDb.Blogs.FirstOrDefault());
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Blog blog)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            if (ModelState["PhotoBlog"].ValidationState == Microsoft.AspNetCore.Mvc.ModelBinding.ModelValidationState.Invalid)
            {
                return View();
            }
            bool isExist = _eduDb.Blogs.Any(c => c.Blogname.ToLower() == blog.Blogname.ToLower());
            if (isExist)
            {
                ModelState.AddModelError("Blogname", "The name is already exist");
            }
            if (!blog.PhotoBlog.IsImage())
            {
                ModelState.AddModelError("PhotoBlog", "Use an image file");
                return View();
            }
            if (blog.PhotoBlog.CheckFileSize(800))
            {
                ModelState.AddModelError("PhotoBlog", "Size is bigger than 800kb");
                return View();
            }
            string newfolder = Path.Combine("Assets", "img", "blog");
            string FileName = await blog.PhotoBlog.SaveFileAsync(_web.WebRootPath, "img");
            blog.Image = FileName;
            await _eduDb.Blogs.AddAsync(blog);
            await _eduDb.SaveChangesAsync();
            return View();
        }
    }
}
