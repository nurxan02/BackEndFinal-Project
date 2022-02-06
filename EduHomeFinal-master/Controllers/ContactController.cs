using EduHomeFinal.DAL;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeFinal.Controllers
{
    public class ContactController : Controller
    {
        private readonly EduDb _eduDb;
        public ContactController(EduDb eduDb)
        {
            _eduDb = eduDb;
        }
        public IActionResult Index()
        {
            return View(_eduDb.Contacts.FirstOrDefault());
        }
    }
}
