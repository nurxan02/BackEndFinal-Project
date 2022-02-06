using EduHomeFinal.DAL;
using EduHomeFinal.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeFinal.Controllers
{
    public class HomeController : Controller
    {
        private readonly EduDb _eduDb;
        public HomeController(EduDb eduDb)
        {
            _eduDb = eduDb;
        }
        public IActionResult Index()
        {
            return View(new HomeVM
            {
                Sliders = _eduDb.Sliders.ToList(),
                NoticeProfessions = _eduDb.NoticeProfessions.ToList(),
                Events = _eduDb.Events.ToList()
            });
        }
    }
}
