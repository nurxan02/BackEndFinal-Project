using EduHomeFinal.Models;
using EduHomeFinal.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeFinal.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        public AccountController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginVM login)
        {
            if (!ModelState.IsValid) 
                return View(login);
            AppUser loginUser = await _userManager.FindByEmailAsync(login.Email);
            if (loginUser == null)
            {
                ModelState.AddModelError("", "Email or password wrong!");
                return View(login);
            }
            if (!loginUser.IsActivated)
            {
                ModelState.AddModelError("", "Your Email has been blocked");
                return View(login);
            }
            Microsoft.AspNetCore.Identity.SignInResult signInResult = await _signInManager.PasswordSignInAsync(loginUser, login.Password, login.Rememberme, true);
            if (signInResult.IsLockedOut)
            {
                ModelState.AddModelError("", "You are locked out");
                return View(login);
            }
            if (!signInResult.Succeeded)
            {
                ModelState.AddModelError("", "Email or password wrong!");
                return View(login);
            }
            return RedirectToAction("Index", "Home");
        }
        public IActionResult SignUp()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> SignUp(RegisterVM register)
        {
            if (!ModelState.IsValid) 
                return NotFound();
            AppUser appUser = new AppUser
            {
                FullName = register.FullName,
                UserName = register.Username,
                Email = register.Email,
                UserThoughts = register.UserThoughts
            };
            IdentityResult identityresult = await _userManager.CreateAsync(appUser, register.Password);
            if (!identityresult.Succeeded)
            {
                foreach (var error in identityresult.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
                return View(register);
            }
            await _userManager.AddToRoleAsync(appUser, "Member");
            await _signInManager.SignInAsync(appUser, true);
            return RedirectToAction("Index", "Home");
        }
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
        //public async Task CreateRole()
        //{
        //    if (!await _roleManager.RoleExistsAsync("Admin"))
        //    {
        //        await _roleManager.CreateAsync(new IdentityRole { Name = "Admin" });
        //    }
        //    if (!await _roleManager.RoleExistsAsync("Member"))
        //    {
        //        await _roleManager.CreateAsync(new IdentityRole { Name = "Member" });
        //    }
        //}
    }
}
