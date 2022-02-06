using EduHomeFinal.DAL;
using EduHomeFinal.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeFinal.Controllers
{
    public class EventController : Controller
    {
        private readonly EduDb _eduDb;
        public EventController(EduDb eduDb)
        {
            _eduDb = eduDb;
        }
        public IActionResult Index()
        {
            return View(_eduDb.Events.ToList());
        }
        public IActionResult Search(string key)
        {
            IEnumerable<Event> events = _eduDb.Events.Where(e => e.Name.Contains(key.ToLower())).ToList();
            return PartialView("~/Views/Shared/_partialSearchEvent.cshtml", events);
        }
        public async Task<IActionResult> Detail(int? id)
        {
            Event events = await _eduDb.Events.Include(e => e.Speakers).FirstOrDefaultAsync(e => e.Id == id);
            return View(events);
        }
    }
}
