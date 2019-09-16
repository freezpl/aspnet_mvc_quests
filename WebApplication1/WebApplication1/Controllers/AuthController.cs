using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EntityModels.Model;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using QuestWebApp.Models;

namespace QuestWebApp.Controllers
{
    public class AuthController : Controller
    {

        UserManager<UserEntity> _userManager;
        SignInManager<UserEntity> _signInManager;

        public AuthController(UserManager<UserEntity> userManager, SignInManager<UserEntity> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            var result = await _userManager.CreateAsync(new UserEntity { Email = model.Email, Name = model.Name, Years = model.Year, UserName = model.Email }, model.Password);

            if (result.Succeeded)
            {
                var user = await _userManager.FindByEmailAsync(model.Email);
                if (user != null)
                    await _signInManager.SignInAsync(user, false);
                return RedirectToAction("Quests", "Quest");
            }

            foreach (var error in result.Errors)
            {
                ModelState.AddModelError("", error.Description);
            }

            return View();
        }

        [HttpGet]
        public IActionResult Login(string url)
        {
            ViewBag.ReturnUrl = url;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model, string ReturnUrl)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            await _signInManager.SignOutAsync();
            var result = await _signInManager.PasswordSignInAsync(model.Login, model.Password, model.RememberMe, false);

            if (result.Succeeded)
            {
                if (String.IsNullOrEmpty(ReturnUrl))
                    return RedirectToAction("Index", "Games");
                return Redirect(ReturnUrl);
            }

            ModelState.AddModelError("", "Wrong login or password");
            return View();
        }


        [HttpGet]
        public async Task<IActionResult> Logout(string ReturnUrl)
        {
            await _signInManager.SignOutAsync();
            if (String.IsNullOrEmpty(ReturnUrl))
                return RedirectToAction("Quests", "Quest");
            return Redirect(ReturnUrl);
        }

    }
}