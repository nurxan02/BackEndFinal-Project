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
    public class EventController : Controller
    {
        private readonly EduDb _eduDb;
        private readonly IWebHostEnvironment _web;
        public EventController(EduDb eduDb, IWebHostEnvironment web)
        {
            _eduDb = eduDb;
            _web = web;
        }
        public IActionResult Index()
        {
            return View(_eduDb.Events.ToList());
        }
        public async Task<IActionResult> Detail(int? id)
        {
            if (id == null)
                return NotFound();
            Event events = await _eduDb.Events.Where(w => w.IsDeleted == false).Include(s => s.Speakers).FirstOrDefaultAsync(e => e.Id == id);
            if (events == null)
                return NotFound();
            return View(events);
        }
        //public async Task<IActionResult> Update(int? id)
        //{
        //    if (id == null)
        //        return NotFound();
        //    Event events = await _eduDb.Events.Where(w => w.IsDeleted == false).Include(s => s.Speakers).FirstOrDefaultAsync(e => e.Id == id);
        //    if (events == null)
        //        return NotFound();
        //    return View(events);
        //}
        //public async Task<IActionResult> Update(int? id, Event events)
        //{
        //    if (id == null)
        //        return NotFound();
        //    Event dbevents = await _eduDb.Events.Include(s => s.Speakers).Where(w => w.IsDeleted == false).FirstOrDefaultAsync(e => e.Id == id);
        //    if (events == null)
        //        return NotFound();
        //    if (ModelState["Photo"].ValidationState == Microsoft.AspNetCore.Mvc.ModelBinding.ModelValidationState.Invalid)
        //    {
        //        return View();
        //    }
        //    if (!events.Photo.IsImage())
        //    {
        //        ModelState.AddModelError("Photo", "Use an image file");
        //        return View();
        //    }
        //    if (events.Photo.CheckFileSize(2000))
        //    {
        //        ModelState.AddModelError("Photo", "Seklin olcusu 300kb-dan boyuk olmamalidir");
        //        return View();
        //    }
        //    string folderpath = Path.Combine("Assets", "img", "event");
        //    Helper.DeleteFile(_web.WebRootPath, folderpath, dbevents.Image);
        //    string FileName = await events.Photo.SaveFileAsync(_web.WebRootPath, folderpath);

        //    dbevents.Image = FileName;
        //    dbevents.Name = events.Name;
        //    dbevents.Description = events.Description;
        //    dbevents.EventAbout = events.EventAbout;
        //    dbevents.EventPlace = events.EventPlace;
        //    dbevents.Day = events.Day;
        //    dbevents.Month = events.Month;
        //    dbevents.EventStart = events.EventStart;
        //    dbevents.EventFinish = events.EventFinish;
             
        //    dbevents.Speakers.Pos

        //    await _eduDb.SaveChangesAsync();
        //    return RedirectToAction(nameof(Index));
        //}

    }
}
