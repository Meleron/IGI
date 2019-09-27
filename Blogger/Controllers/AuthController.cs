using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Blogger.Models;
using Blogger.ViewModels;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;

namespace Blogger.Controllers
{
    public class AuthController : Controller
    {

        readonly ApiDbContext dbContext;

        public AuthController(ApiDbContext _dbContext)
        {
            dbContext = _dbContext;
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
        public async Task<IActionResult> Login(LoginModel model)
        {
            if (ModelState.IsValid)
            {
                User user = dbContext.UsersList.FirstOrDefault(u => u.Email == model.Email && u.Password == model.Password);
                if (user == null)
                {
                    ModelState.AddModelError("", "Incorrect Email");
                    return View(model);
                }
                else
                {
                    await Authenticate(user);
                    return RedirectToAction("Index", "Home");
                }
            }
            return View(model);
        }

        public async Task<IActionResult> Registrate(RegisterModel model)
        {
            if (ModelState.IsValid)
            {
                User user = dbContext.UsersList.FirstOrDefault(u => u.Email == model.Email);
                if (user != null) ModelState.AddModelError("", "User already exists");
                else
                {
                    user = new User { Name = model.Email, Email = model.Email, Password = model.Password };
                    Blog blog = new Blog { Title = $"{user.Name}'s blog", User = user };
                    dbContext.BlogList.Add(blog);
                    dbContext.UsersList.Add(user);
                    await dbContext.SaveChangesAsync();
                    await Authenticate(user);
                    return RedirectToAction("Index", "Home");
                }
            }
            return View(model);
        }

        public async Task Authenticate(User user)
        {
            var claims = new List<Claim>
            {
                new Claim(ClaimsIdentity.DefaultNameClaimType, user.Email)
            };
            ClaimsIdentity id = new ClaimsIdentity(claims, "ApplicationCookie", ClaimsIdentity.DefaultNameClaimType, ClaimsIdentity.DefaultRoleClaimType);
            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(id));
        }

        public async Task<IActionResult> SignOut()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Login");
        }
    }
}