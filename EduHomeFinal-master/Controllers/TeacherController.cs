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
    public class TeacherController : Controller
    {
        private readonly EduDb _eduDb;
        public TeacherController(EduDb eduDb)
        {
            _eduDb = eduDb;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Search(string search)
        {
            IEnumerable<Teacher> teachers = _eduDb.Teachers.Where(t => t.Name.ToLower().Contains(search.ToLower())).ToList();
            return PartialView("_partialSearchTeacher", teachers);
        }
        public async Task<IActionResult> Detail(int? id)
        {
            if (id == null)
                return NotFound();
            Teacher teacher = await _eduDb.Teachers.Include(t => t.Skills).FirstOrDefaultAsync(t => t.Id == id);
            return View(teacher);
        }
    }
}
