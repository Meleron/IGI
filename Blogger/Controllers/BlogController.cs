using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blogger.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Blogger.Controllers
{
    [Authorize]
    public class BlogController : Controller
    {
        readonly ApiDbContext dbContext;

        public BlogController(ApiDbContext _dbContext)
        {
            dbContext = _dbContext;
        }
        public IActionResult Index()
        {
            User user = dbContext.UsersList.Include(u => u.Blog).ThenInclude(b => b.PostList).FirstOrDefault(u=>u.Email == User.Identity.Name);
            return View(user.Blog);
        }
    }
}