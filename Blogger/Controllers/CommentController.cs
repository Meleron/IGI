﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Blogger.Models;
using Blogger.Paging;
using Blogger.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Microsoft.EntityFrameworkCore.Query.Internal;
using Microsoft.EntityFrameworkCore.Storage;

namespace Blogger.Controllers
{
    [Authorize(Roles = ("User"))]
    public class CommentController : Controller
    {
        readonly ApiDbContext dbContext;

        public CommentController(ApiDbContext _dbContext)
        {
            dbContext = _dbContext;
        }

        [HttpPost]
        public IActionResult Show(int ID)
        {
            return View(new CommentPageModel { Post = dbContext.PostsList.Single(p => p.ID == ID), CommentList = dbContext.CommentList.Include(c => c.User).Where(c => c.PostId == ID).ToList() });
        }

        [HttpPost]
        public IActionResult AddComment(string content, int postId)
        {
            if (content == null)
                return Content("Неверный формат");
            dbContext.CommentList.Add(new Comment { Content = content, Post = dbContext.PostsList.Single(p => p.ID == postId), User = dbContext.UsersList.Single(u => u.Email == User.Identity.Name) });
            dbContext.SaveChanges();
            return Content("Комментарий успешно добавлен");
            //return RedirectToAction("Show", new RouteValueDictionary { { "id", 12 } });
        }


        [HttpGet]
        public ActionResult GetCommentsPaged(int ID, int pageNumber = 1, int pageSize = 20)
        {
            List<Comment> comments = dbContext.CommentList.Include(c => c.User).Where(c => c.PostId == ID).ToList();
            PagedData<Comment> a = comments.PagedResult(pageNumber, pageSize);
            return Json(a, new Newtonsoft.Json.JsonSerializerSettings { ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore });
        }
    }
}