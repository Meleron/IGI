using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Blogger.Models;
using Microsoft.AspNetCore.Authorization;

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
            return View(dbContext);
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
