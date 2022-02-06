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
    public class SliderController : Controller
    {
        private readonly EduDb _eduDb;
        private readonly IWebHostEnvironment _web;
        public SliderController(EduDb eduDb, IWebHostEnvironment web)
        {
            _eduDb = eduDb;
            _web = web;
        }
        public IActionResult Index()
        {
            return View(_eduDb.Sliders.ToList());
        }
        public async Task<IActionResult> Update(int? id)
        {
            if (id == null)
                return NotFound();
            Slider slide = await _eduDb.Sliders.FindAsync(id);
            if (slide == null)
                return NotFound();
            return View(slide);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int? id, Slider slide)
        {
            if (id == null)
                return NotFound(); ;
            if (ModelState["PhotoSlide"].ValidationState == Microsoft.AspNetCore.Mvc.ModelBinding.ModelValidationState.Invalid)
            {
                return View();
            }
            if (!slide.PhotoSlide.IsImage())
            {
                ModelState.AddModelError("PhotoSlide", "Use an image file");
                return View();
            }
            if (!slide.PhotoSlide.CheckFileSize(2000))
            {
                ModelState.AddModelError("PhotoSlide", "Size is bigger than 800kb");
                return View();
            }
            Slider dbslide = await _eduDb.Sliders.FindAsync(id);
            if (dbslide == null) return NotFound();
            string folderpath = Path.Combine("Assets", "img", "slider");
            Helper.DeleteFile(_web.WebRootPath, folderpath, dbslide.Image);

            string FileName = await slide.PhotoSlide.SaveFileAsync(_web.WebRootPath, folderpath);
            dbslide.Image = FileName;
            dbslide.Title = slide.Title;
            dbslide.Description = slide.Description;
            await _eduDb.SaveChangesAsync();
            return View();
        }
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();
            Slider slider = await _eduDb.Sliders.FindAsync(id);
            if (slider == null) return NotFound();
            return View(slider);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public async Task<IActionResult> DeletePost(int? id)
        {
            if (id == null) 
                return NotFound();
            Slider slide = await _eduDb.Sliders.FindAsync(id);
            if (slide == null) 
                return NotFound();
            string folderpath = Path.Combine("img", "slider");
            Helper.DeleteFile(_web.WebRootPath, folderpath, slide.Image);
            _eduDb.Sliders.Remove(slide);
            await _eduDb.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Create()
        {
            if (_eduDb.Sliders.Count() >= 6)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Slider slide)
        {
            if (ModelState["PhotoSlide"].ValidationState == Microsoft.AspNetCore.Mvc.ModelBinding.ModelValidationState.Invalid)
            {
                return View();
            }
            if (!slide.PhotoSlide.IsImage())
            {
                ModelState.AddModelError("PhotoSlide", "Use an image file");
                return View();
            }
            if (slide.PhotoSlide.CheckFileSize(2000))
            {
                ModelState.AddModelError("Photo", "Size is bigger than 2 mb");
                return View();
            }
            string newfolder = Path.Combine("Assets", "img", "slider");
            string FileName = await slide.PhotoSlide.SaveFileAsync(_web.WebRootPath, newfolder);
            slide.Image = FileName;
            await _eduDb.Sliders.AddAsync(slide);
            await _eduDb.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
