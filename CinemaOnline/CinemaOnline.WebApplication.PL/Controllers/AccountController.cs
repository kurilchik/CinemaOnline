using CinemaOnline.BLL.Services.Interfaces;
using CinemaOnline.BLL.ViewModels;
using CinemaOnline.WebApplication.PL.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace CinemaOnline.WebApplication.PL.Controllers
{
    public class AccountController : Controller
    {
        private IUserService _userService;

        public AccountController(IUserService userService)
        {
            _userService = userService;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login([FromForm] LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = _userService.GetByEmail(model.Email);
                if (user != null && model.Password == user.Password)
                {
                    await Authenticate(model.Email);

                    return RedirectToAction("Index", "Films");
                }
                ModelState.AddModelError("", "Incorrect login and (or) password");
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = _userService.GetByEmail(model.Email);
                if (user == null)
                {
                    _userService.Add(new UserViewModel { Name = model.Name, Email = model.Email, Password = model.Password});

                    await Authenticate(model.Email);

                    return RedirectToAction("Index", "Films");
                }
                else
                    ModelState.AddModelError("", "Incorrect login and (or) password");

            }
            return View(model);
        }

        [Authorize]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Index", "Films");
        }

        private async Task Authenticate(string email)
        {
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Email, email)
            };

            ClaimsIdentity id = new ClaimsIdentity(claims, "ApplicationCookie", ClaimsIdentity.DefaultNameClaimType, ClaimsIdentity.DefaultRoleClaimType);

            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(id));
        }
    }
}
