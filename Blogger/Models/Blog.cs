using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Blogger.Models
{
    public class Blog
    {
        [Required]
        public int ID { get; set; }
        [Required]
        [StringLength(30)]
        public string Title { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public List<Post> PostList { get; set; }
    }
}
