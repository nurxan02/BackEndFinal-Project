using EduHomeFinal.DAL;
using EduHomeFinal.Models;
using EduHomeFinal.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeFinal.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class UserController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly EduDb _eduDb;
        public UserController(UserManager<AppUser> userManager, EduDb eduDb)
        {
            _userManager = userManager;
            _eduDb = eduDb;
        }
        public async Task<IActionResult> Index()
        {
            IEnumerable<AppUser> appUsers = _userManager.Users.ToList();
            List<UserVM> userVMs = new List<UserVM>();
            foreach (AppUser user in appUsers)
            {
                UserVM userVM = new UserVM
                {
                    Id = user.Id,
                    Email = user.Email,
                    IsActivited = user.IsActivated,
                    Fullname = user.FullName,
                    Username = user.UserName,
                    UserPosition = user.UserThoughts,
                    Role = (await _userManager.GetRolesAsync(user))[0]
                };
                userVMs.Add(userVM);
            }
            return View(userVMs);
        }
    }
}
