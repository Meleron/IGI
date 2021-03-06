﻿using Blogger.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Blogger.Mapped
{
    public class PostModel
    {
        [Required]
        public int ID { get; set; }
        [Required]
        [StringLength(30, MinimumLength = 5)]
        public string PostTitle { get; set; }
        [Required]
        [StringLength(500, MinimumLength = 5)]
        public string PostContent { get; set; }
        public int BlogId { get; set; }
        public Blog Blog { get; set; }
        public List<Comment> CommentList { get; set; }
    }
}
