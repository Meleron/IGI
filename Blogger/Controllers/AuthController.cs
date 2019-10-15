using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Blogger.Models;
using Blogger.ViewModels;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Blogger.Controllers
{
    public class AuthController : Controller
    {

        readonly ApiDbContext dbContext;

        public AuthController(ApiDbContext _dbContext)
        {
            dbContext = _dbContext;
        }

        [Authorize(Roles =("Banned"))]
        public async Task<IActionResult> Banned()
        {
            await SignOut();
            return View();
        }
        [HttpGet]
        public IActionResult Login()
        {
            if (User.Identity.IsAuthenticated)
                return RedirectToAction("Index", "Home");
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginModel model)
        {
            if (User.Identity.IsAuthenticated)
                return RedirectToAction("Index", "Home");
            if (ModelState.IsValid)
            {
                User user = dbContext.UsersList.Include(u=>u.Role).FirstOrDefault(u => u.Email == model.Email && u.Password == model.Password);
                if (user == null)
                {
                    ModelState.AddModelError("", "Incorrect Email");
                    return View(model);
                }
                else
                {
                    await Authenticate(user);
                    if(user.Role.Name == "Banned")
                    {
                        return RedirectToAction("Banned", "Auth");
                    }
                    return RedirectToAction("Index", "Home");
                }
            }
            return View(model);
        }

        public async Task<IActionResult> Registrate(RegisterModel model)
        {
            //dbContext.RolesList.AddRange(new Role { Name = "User" }, new Role { Name="Banned"});
            //dbContext.SaveChanges();
            if (User.Identity.IsAuthenticated)
                return RedirectToAction("Home", "Index");
            if (ModelState.IsValid)
            {
                User user = dbContext.UsersList.FirstOrDefault(u => u.Email == model.Email);
                if (user != null) ModelState.AddModelError("", "User already exists");
                else
                {
                    Role role = dbContext.RolesList.FirstOrDefault(r => r.Name == "User");
                    if (role == null)
                    {
                        ModelState.AddModelError("", "Role not found");
                        return View(model);
                    }
                    user = new User { Name = model.Email, Email = model.Email, Password = model.Password, RoleId = role.ID, Role = role };
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

        [NonAction]
        public async Task Authenticate(User user)
        {
            var claims = new List<Claim>
            {
                new Claim(ClaimsIdentity.DefaultNameClaimType, user.Email),
                new Claim(ClaimsIdentity.DefaultRoleClaimType, user.Role?.Name)
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