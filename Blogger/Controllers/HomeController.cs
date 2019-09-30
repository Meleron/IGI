using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Blogger.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;

namespace Blogger.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {

        ApiDbContext dbContext;

        public HomeController(ApiDbContext _dbContext)
        {
            dbContext = _dbContext;
        }
        [AllowAnonymous]
        public IActionResult Index()
        {
            List<Post> posts = dbContext.PostsList.Include(post => post.Blog).ThenInclude(blog => blog.User).ToList();
            posts.Reverse();
            return View(posts);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}



