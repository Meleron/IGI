using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blogger.TagHelpers
{
    public class VkTagHelper : TagHelper
    {
        private const string Address = "https://vk.com/meeele";
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "a";
            output.Attributes.SetAttribute("href", Address);
            output.Content.SetContent("VK");
        }
    }
}
