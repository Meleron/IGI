using Blogger.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blogger.ViewModels
{
    public class CommentPageModel
    {
        public Post Post { get; set; }
        public List<Comment> CommentList { get; set; }
        public string CommentContent { get; set; }
    }
}
