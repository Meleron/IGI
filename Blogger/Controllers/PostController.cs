using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Blogger.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Blogger.Controllers
{
    [Authorize(Roles = ("User"))]
    public class PostController : Controller
    {

        readonly ApiDbContext dbContext;

        public PostController(ApiDbContext _dbContext, IMapper _mapper)
        {
            dbContext = _dbContext;
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
            }
            catch (Exception ex)
            {
                return $"Error while adding user: {ex}";
            }
            return "New post successfully added";
        }

        [HttpPost]
        public IActionResult RedactPost(int postId)
        {
            Post pst = dbContext.PostsList.Single(p => p.ID == postId);
            return View(dbContext.PostsList.Single(p => p.ID == postId));
        }
        [HttpPost]
        public IActionResult RedactPos(Post post)
        {
            Post postToUpdate = dbContext.PostsList.FirstOrDefault(p => p.ID == post.ID);
            if (postToUpdate == null) return BadRequest();
            postToUpdate.PostTitle = post.PostTitle;
            postToUpdate.PostContent = post.PostContent;
            dbContext.SaveChanges();
            return Content("Post successfully updated");
        }
    }
}