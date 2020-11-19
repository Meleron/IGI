using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blogger.Components
{
    [ViewComponent]
    public class Date
    {
        public string Invoke()
        {
            return $"Дата:{DateTime.Now.ToString("dd/mm/yyyy")}";
        }
    }
}
