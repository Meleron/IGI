using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blogger.Models
{
    public class Role
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public List<User> UserList { get; set; }
    }
}
