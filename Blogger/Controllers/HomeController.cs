using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Blogger.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using AutoMapper;
using Blogger.Mapped;

namespace Blogger.Controllers
{
    [Authorize(Roles = ("User"))]
    public class HomeController : Controller
    {
            
        readonly ApiDbContext dbContext;
        readonly IMapper mapper;


        public HomeController(ApiDbContext _dbContext, IMapper _mapper)
        {
            dbContext = _dbContext;
            mapper = _mapper;
        }

        [AllowAnonymous]
        public IActionResult Index(string searchString = null) 
        {
            var posts = dbContext.PostsList.Include(post => post.Blog).ThenInclude(blog => blog.User).Where(p=>true);
            if (searchString != null)
                posts = posts.Where(p=>p.PostContent.Contains(searchString));
            var toReturn = posts.ToList();
            toReturn.Reverse();
            //return View(toReturn);
            return View(mapper.Map<List<Post>, List<PostModel>>(toReturn));
        }

        [HttpPut]
        public void ChangeName(string newName) {
            try
            {
                dbContext.UsersList.Single(u => u.Email == User.Identity.Name).Name = newName;
                dbContext.SaveChanges();
            }
            catch (Exception)
            {
                
            }
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



