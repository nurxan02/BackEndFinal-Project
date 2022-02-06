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
    public class TeacherController : Controller
    {
        private readonly EduDb _eduDb;
        private readonly IWebHostEnvironment _web;
        public TeacherController(EduDb eduDb, IWebHostEnvironment web)
        {
            _eduDb = eduDb;
            _web = web;
        }
        public IActionResult Index()
        {
            return View(_eduDb.Teachers.ToList());
        }
        public IActionResult Detail(int? id)
        {
            if (id == null)
                return NotFound();
            Teacher teacher = _eduDb.Teachers.Include(s => s.Skills).FirstOrDefault(b => b.Id == id);
            if (teacher == null)
                return NotFound();
            return View(teacher);
        }
        public IActionResult Update(int? id)
        {
            if (id == null)
                return NotFound();
            Teacher teacher = _eduDb.Teachers.Include(s => s.Skills).FirstOrDefault(b => b.Id == id);
            if (teacher == null)
                return NotFound();
            return View(teacher);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int? id, Teacher teacher)
        {
            if (id == null)
                return NotFound();
            //if (!ModelState.IsValid)
            //{
            //    return View();
            //}
            if (ModelState["PhotoTeacher"].ValidationState == Microsoft.AspNetCore.Mvc.ModelBinding.ModelValidationState.Invalid)
            {
                return View();
            }
            if (!teacher.PhotoTeacher.IsImage())
            {
                ModelState.AddModelError("PhotoTeacher", "Use an image file");
                return View();
            }
            if (teacher.PhotoTeacher.CheckFileSize(800))
            {
                ModelState.AddModelError("PhotoTeacher", "Size is bigger than 800kb");
                return View();
            }
            Teacher dbteacher = _eduDb.Teachers.Include(s => s.Skills).FirstOrDefault(b => b.Id == id);
            if (dbteacher == null) return NotFound();
            string folderpath = Path.Combine("Assets", "img", "teacher");
            Helper.DeleteFile(_web.WebRootPath, folderpath, dbteacher.Name);
            string FileName = await teacher.PhotoTeacher.SaveFileAsync(_web.WebRootPath, folderpath);

            dbteacher.Image = FileName;
            dbteacher.Name = teacher.Name;
            dbteacher.Profession = teacher.Profession;
            dbteacher.Faculty = teacher.Faculty;
            dbteacher.Hobbies = teacher.Hobbies;
            dbteacher.Degree = teacher.Degree;
            dbteacher.AboutMe = teacher.AboutMe;
            dbteacher.ContactTel = teacher.ContactTel;
            dbteacher.Experience = teacher.Experience;
            dbteacher.Instagram = teacher.Instagram;
            dbteacher.Mail = teacher.Mail;
            dbteacher.Facebook = teacher.Facebook;
            dbteacher.Pinterest = teacher.Pinterest;
            dbteacher.Skype = teacher.Skype;
            dbteacher.Twitter = teacher.Twitter;

            dbteacher.Skills.Language = teacher.Skills.Language;
            dbteacher.Skills.Innovation = teacher.Skills.Innovation;
            dbteacher.Skills.Communication = teacher.Skills.Communication;
            dbteacher.Skills.Development = teacher.Skills.Development;
            dbteacher.Skills.Design = teacher.Skills.Design;
            dbteacher.Skills.TeamLeader = teacher.Skills.TeamLeader;
            await _eduDb.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
                return NotFound();
            Teacher teacher = _eduDb.Teachers.Include(s => s.Skills).FirstOrDefault(b => b.Id == id);
            if (teacher == null)
                return NotFound();
            return View(teacher);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public async Task<IActionResult> DeleteTeacher(int? id)
        {
            if (id == null) 
                return NotFound();
            Teacher teacher = _eduDb.Teachers.Include(s => s.Skills).FirstOrDefault(b => b.Id == id);
            _eduDb.Teachers.Remove(teacher);
            await _eduDb.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Teacher teacher)
        {
            if (ModelState.IsValid)
            {
                return View();
            }
            if (ModelState["PhotoTeacher"].ValidationState == Microsoft.AspNetCore.Mvc.ModelBinding.ModelValidationState.Invalid)
            {
                return View();
            }
            if (!teacher.PhotoTeacher.IsImage())
            {
                ModelState.AddModelError("Photo", "Use an image file");
                return View();
            }
            if (teacher.PhotoTeacher.CheckFileSize(2000))
            {
                ModelState.AddModelError("Photo", "Size is bigger than 2 mb");
                return View();
            }
            string newfolder = Path.Combine("Assets", "img", "teacher");
            string FileName = await teacher.PhotoTeacher.SaveFileAsync(_web.WebRootPath, newfolder);
            teacher.Image = FileName;
            Skills skills = new Skills();
            skills.TeacherId = teacher.Id;
            await _eduDb.Teachers.AddAsync(teacher);
            await _eduDb.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
