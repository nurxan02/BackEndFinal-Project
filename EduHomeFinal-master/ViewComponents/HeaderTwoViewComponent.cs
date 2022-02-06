using EduHomeFinal.DAL;
using EduHomeFinal.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeFinal.ViewComponents
{
    public class HeaderTwoViewComponent : ViewComponent
    {
        private readonly EduDb _eduDb;
        private readonly UserManager<AppUser> _userManager;
        public HeaderTwoViewComponent(EduDb eduDb, UserManager<AppUser> userManager)
        {
            _eduDb = eduDb;
            _userManager = userManager;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            ViewBag.UserName = "";
            ViewBag.Email = "";
            ViewBag.UserRole = "";
            if (User.Identity.IsAuthenticated)
            {
                AppUser appUser = await _userManager.FindByNameAsync(User.Identity.Name);
                ViewBag.UserName = appUser.UserName;
                ViewBag.Email = appUser.Email;
                ViewBag.UserRole = appUser.UserThoughts;
            }
            Bio bio = _eduDb.Bios.FirstOrDefault();
            return View(await Task.FromResult(bio));
        }
    }
}
