﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using PcColletion.Cms.Models;
using PcColletion.InfraStructure;
using System.Text;
using System.Threading.Tasks;

namespace PcColletion.Cms.Controllers
{
    public class AccountController : Controller
    {

        private UserManager<ApplicationUser> userManager;
        private SignInManager<ApplicationUser> signInManager;

        public AccountController(UserManager<ApplicationUser> _userManager, SignInManager<ApplicationUser> _signInManager)
        {
            userManager = _userManager;
            signInManager = _signInManager;
        }

        [AllowAnonymous]
        public IActionResult Login()
        {
            return View();
        }
        [AllowAnonymous]
         [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {

            if (ModelState.IsValid)
            {
                var user = await userManager.FindByNameAsync(model.UserName);
                await signInManager.SignOutAsync();
                var result = await signInManager.PasswordSignInAsync(user, model.Password, false, false);

                if (result.Succeeded)
                {
                    var userId = "token-" + user.Id.ToString();

                    HttpContext.Session.Set("token", Encoding.UTF8.GetBytes(userId));

                    return RedirectToAction("Index", "Home");
                }

            }


            return View(model);
        }


    
        public IActionResult logout()
        {
            signInManager.SignOutAsync();
            return RedirectToAction("login");
        }

        [AllowAnonymous]
        public IActionResult NewUsers()
        {

            return View();
        }

        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> NewUsers(NewUserModel model)
        {
            if (ModelState.IsValid)
            {

                var _aplicationUser = new ApplicationUser
                {
                    Email = model.Emails,
                    Name = model.Name,
                    SurName = model.SurName,
                    PhoneNumber = model.Phone,
                    UserName = model.UserName

                };
                var result = await userManager.CreateAsync(_aplicationUser, model.Password);

                if (result.Succeeded)
                    return RedirectToAction("Index", "Home");
            }



            return View(model);
        }

    }
}