using EduHomeFinal.DAL;
using EduHomeFinal.Extencions;
using EduHomeFinal.Helpers;
using EduHomeFinal.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeFinal.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CourseController : Controller
    {
        private readonly EduDb _eduDb;
        private readonly IWebHostEnvironment _web;
        public CourseController(EduDb eduDb, IWebHostEnvironment web)
        {
            _eduDb = eduDb;
            _web = web;
        }
        public IActionResult Index()
        {
            return View(_eduDb.Courses.ToList());
        }
        public IActionResult Detail(int? id)
        {
            if (id == null)
                return NotFound();
            Courses courses = _eduDb.Courses.FirstOrDefault(c => c.Id == id);
            if (courses == null)
                return NotFound();
            return View(courses);
        }
        public IActionResult Update(int? id)
        {
            if (id == null)
                return NotFound();
            Courses courses = _eduDb.Courses.FirstOrDefault(c => c.Id == id);
            if (courses == null)
                return NotFound();
            return View(courses);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int? id, Courses courses)
        {
            if (id == null)
                return NotFound();
            if (!ModelState.IsValid)
            {
                return View();
            }
            Courses dbcourse = _eduDb.Courses.Include(c => c.Categories).FirstOrDefault(c => c.Id == id);
            if (ModelState["PhotoCourse"].ValidationState == Microsoft.AspNetCore.Mvc.ModelBinding.ModelValidationState.Invalid)
            {
                return View();
            }
            if (!courses.PhotoCourse.IsImage())
            {
                ModelState.AddModelError("PhotoCourse", "Use an image file");
                return View();
            }
            if (courses.PhotoCourse.CheckFileSize(800))
            {
                ModelState.AddModelError("PhotoCourse", "Size is bigger than 800kb");
                return View();
            }
            string folderpath = Path.Combine("Assets", "img", "course");
            Helper.DeleteFile(_web.WebRootPath, folderpath, dbcourse.Name);
            string FileName = await courses.PhotoCourse.SaveFileAsync(_web.WebRootPath, folderpath);

            dbcourse.Image = FileName;
            dbcourse.Name = courses.Name;
            dbcourse.Description = courses.Description;
            dbcourse.Starts = courses.Starts;
            dbcourse.Duration = courses.Duration;
            dbcourse.ClassDuration = courses.ClassDuration;
            dbcourse.SkillLevel = courses.SkillLevel;
            dbcourse.Language = courses.Language;
            dbcourse.StudentCapacity = courses.StudentCapacity;
            dbcourse.Assetsments = courses.Assetsments;
            dbcourse.Fee = courses.Fee;
            dbcourse.CategoriesId = 1;

            await _eduDb.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Create()
        {
            return View(_eduDb.Courses.FirstOrDefault());
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Courses courses)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            if (ModelState["PhotoCourse"].ValidationState == Microsoft.AspNetCore.Mvc.ModelBinding.ModelValidationState.Invalid)
            {
                return View();
            }
            bool isExist = _eduDb.Courses.Any(c => c.Name.ToLower() == courses.Name.ToLower());
            if (isExist)
            {
                ModelState.AddModelError("Name", "The name is already exist");
            }
            if (!courses.PhotoCourse.IsImage())
            {
                ModelState.AddModelError("PhotoCourse", "Use an image file");
                return View();
            }
            if (courses.PhotoCourse.CheckFileSize(800))
            {
                ModelState.AddModelError("PhotoCourse", "Size is bigger than 800kb");
                return View();
            }

            return View();
        }
    }
}
