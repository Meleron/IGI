using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Blogger.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Blogger.Controllers
{
    [Authorize]
    public class PostController : Controller
    {

        ApiDbContext dbContext;

        public PostController(ApiDbContext _dbContext)
        {
            dbContext = _dbContext;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult AddPost()
        {
            return View();
        }

        [HttpPost]
        public string AddPost(Post postToAdd)
        {
            try
            {
                dbContext.PostsList.Add(postToAdd);
                dbContext.SaveChanges();
            } catch(Exception ex)
            {
                return $"Error while adding user: {ex}";
            }
            return "New post successfully added";
        }
    }
}