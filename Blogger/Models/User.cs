using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Blogger.Models
{
    public class User
    {
        [Required]
        public int ID { get; set; }
        [Required]
        [StringLength(30, MinimumLength = 5)]
        public string Name { get; set; }
        [Required]
        [StringLength(30, MinimumLength = 5)]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required]
        [StringLength(30, MinimumLength = 5)]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public int? RoleId { get; set; }
        public Role Role { get; set; }
        public Blog Blog { get; set; }
        public List<Comment> CommentList { get; set; }
    }
}
