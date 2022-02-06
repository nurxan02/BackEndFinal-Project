using EduHomeFinal.DAL;
using EduHomeFinal.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeFinal.Controllers
{
    public class AboutController : Controller
    {
        private readonly EduDb _eduDb;
        public AboutController(EduDb eduDb)
        {
            _eduDb = eduDb;
        }
        public IActionResult Index()
        {
            return View(new AboutVM
            {
                EduHome = _eduDb.EduHomes.FirstOrDefault(),
                Video = _eduDb.Videos.FirstOrDefault()
            });
        }
    }
}
