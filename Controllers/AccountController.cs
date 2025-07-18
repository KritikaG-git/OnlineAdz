﻿using OnlineAdz.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineAdz.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;
        public AccountController(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = new IdentityUser
                {
                    
                    UserName = model.Name,
                    Email = model.Email
                    

                };
                var result = await _userManager.CreateAsync(user, model.Password);
                if (result.Succeeded)
                {
                    //add role here
                    //await _userManager.AddToRoleAsync(user, "Admin");
                    return RedirectToAction("Login", "Account");
                }
            }
            ModelState.AddModelError("", "Invalid Register.");
            return View(model);
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(model.Email,model.Password, isPersistent: false, lockoutOnFailure: false);
                if (result.Succeeded)
                {
                    var user = await _userManager.FindByNameAsync(model.Email);
                    
                    //user role list here
                    
                    if(model.Role == "Admin")
                    {
                        return RedirectToAction("Index", "CategoryAd");
                    }
                    else if(model.Role =="User")
                    {
                        return RedirectToAction("Index", "UserAd");
                    }
                    else
                    {
                        ModelState.AddModelError("", "Invalid Role.");
                    }
                    //return RedirectToAction("Index", "Home");

                }
            }
            ModelState.AddModelError("", "Invalid Email or Password");
            return View(model);
        }

        
        public IActionResult Logout()
        {
            
            return RedirectToAction("Index", "Home");
        }

    }
}