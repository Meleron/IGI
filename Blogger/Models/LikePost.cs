using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blogger.Models
{
    public class LikePost
    {
        public Guid ID { get; set; }
        public int UserID { get; set; }
        public int PostID { get; set; }
        public User User { get; set; }
        public Post Post { get; set; }
    }
}
