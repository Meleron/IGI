#pragma checksum "C:\Users\dtrotsky\source\repos\Blogger\Blogger\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b84648733601cfd7b1a17aecd60d15e3e5c01a9f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\dtrotsky\source\repos\Blogger\Blogger\Views\_ViewImports.cshtml"
using Blogger;

#line default
#line hidden
#line 2 "C:\Users\dtrotsky\source\repos\Blogger\Blogger\Views\_ViewImports.cshtml"
using Blogger.Models;

#line default
#line hidden
#line 2 "C:\Users\dtrotsky\source\repos\Blogger\Blogger\Views\Home\Index.cshtml"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b84648733601cfd7b1a17aecd60d15e3e5c01a9f", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"358804778ee50facceaad3d8db461f20cb286ac4", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Post>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\dtrotsky\source\repos\Blogger\Blogger\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(102, 133, true);
            WriteLiteral("<div>\r\n    <div>\r\n        <div>\r\n            <h2>Последние посты</h2>\r\n        </div>\r\n        <div style=\"word-break: break-all;\">\r\n");
            EndContext();
#line 12 "C:\Users\dtrotsky\source\repos\Blogger\Blogger\Views\Home\Index.cshtml"
             foreach (var post in Model)
            {

#line default
#line hidden
            BeginContext(292, 159, true);
            WriteLiteral("                <div style=\"background-color:lightgray; text-align:center; border-radius:10px; padding:3px 0px 10px 0px; margin:5px\">\r\n                    <h3>");
            EndContext();
            BeginContext(452, 14, false);
#line 15 "C:\Users\dtrotsky\source\repos\Blogger\Blogger\Views\Home\Index.cshtml"
                   Write(post.PostTitle);

#line default
#line hidden
            EndContext();
            BeginContext(466, 4, true);
            WriteLiteral(" by ");
            EndContext();
            BeginContext(471, 19, false);
#line 15 "C:\Users\dtrotsky\source\repos\Blogger\Blogger\Views\Home\Index.cshtml"
                                      Write(post.Blog.User.Name);

#line default
#line hidden
            EndContext();
            BeginContext(490, 37, true);
            WriteLiteral("</h3><br />\r\n                    <h4>");
            EndContext();
            BeginContext(528, 16, false);
#line 16 "C:\Users\dtrotsky\source\repos\Blogger\Blogger\Views\Home\Index.cshtml"
                   Write(post.PostContent);

#line default
#line hidden
            EndContext();
            BeginContext(544, 31, true);
            WriteLiteral("</h4>\r\n                </div>\r\n");
            EndContext();
#line 18 "C:\Users\dtrotsky\source\repos\Blogger\Blogger\Views\Home\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(590, 34, true);
            WriteLiteral("        </div>\r\n    </div>\r\n</div>");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Post>> Html { get; private set; }
    }
}
#pragma warning restore 1591
