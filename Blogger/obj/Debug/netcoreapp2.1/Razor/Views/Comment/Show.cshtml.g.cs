#pragma checksum "C:\Users\dtrotsky\source\repos\Blogger\Blogger\Views\Comment\Show.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e150e2f59d8c1f4cd370c940478cca67dcd287fd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Comment_Show), @"mvc.1.0.view", @"/Views/Comment/Show.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Comment/Show.cshtml", typeof(AspNetCore.Views_Comment_Show))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e150e2f59d8c1f4cd370c940478cca67dcd287fd", @"/Views/Comment/Show.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"358804778ee50facceaad3d8db461f20cb286ac4", @"/Views/_ViewImports.cshtml")]
    public class Views_Comment_Show : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Blogger.ViewModels.CommentPageModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddComment", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Comment", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\dtrotsky\source\repos\Blogger\Blogger\Views\Comment\Show.cshtml"
  
    ViewData["Title"] = "Show";

#line default
#line hidden
            BeginContext(84, 30, true);
            WriteLiteral("<div>\r\n    <div>\r\n        <h2>");
            EndContext();
            BeginContext(115, 20, false);
#line 7 "C:\Users\dtrotsky\source\repos\Blogger\Blogger\Views\Comment\Show.cshtml"
       Write(Model.Post.PostTitle);

#line default
#line hidden
            EndContext();
            BeginContext(135, 19, true);
            WriteLiteral("</h2>\r\n        <h3>");
            EndContext();
            BeginContext(155, 22, false);
#line 8 "C:\Users\dtrotsky\source\repos\Blogger\Blogger\Views\Comment\Show.cshtml"
       Write(Model.Post.PostContent);

#line default
#line hidden
            EndContext();
            BeginContext(177, 30, true);
            WriteLiteral("</h3>\r\n    </div>\r\n    <div>\r\n");
            EndContext();
#line 11 "C:\Users\dtrotsky\source\repos\Blogger\Blogger\Views\Comment\Show.cshtml"
         if (Model.CommentList.Count == 0)
        {

#line default
#line hidden
            BeginContext(262, 45, true);
            WriteLiteral("            <h4>Комментарии отсуствуют</h4>\r\n");
            EndContext();
#line 14 "C:\Users\dtrotsky\source\repos\Blogger\Blogger\Views\Comment\Show.cshtml"
        }
        else
        {

#line default
#line hidden
            BeginContext(343, 53, true);
            WriteLiteral("            <h2>Комментарии:</h2>\r\n            <ul>\r\n");
            EndContext();
#line 19 "C:\Users\dtrotsky\source\repos\Blogger\Blogger\Views\Comment\Show.cshtml"
                 foreach (var comment in Model.CommentList)
                {

#line default
#line hidden
            BeginContext(476, 54, true);
            WriteLiteral("                    <li>\r\n                        <h4>");
            EndContext();
            BeginContext(531, 46, false);
#line 22 "C:\Users\dtrotsky\source\repos\Blogger\Blogger\Views\Comment\Show.cshtml"
                       Write(string.Format($"{comment.User.Name} сказал: "));

#line default
#line hidden
            EndContext();
            BeginContext(577, 35, true);
            WriteLiteral("</h4>\r\n                        <h4>");
            EndContext();
            BeginContext(613, 15, false);
#line 23 "C:\Users\dtrotsky\source\repos\Blogger\Blogger\Views\Comment\Show.cshtml"
                       Write(comment.Content);

#line default
#line hidden
            EndContext();
            BeginContext(628, 34, true);
            WriteLiteral("</h4>\r\n                    </li>\r\n");
            EndContext();
#line 25 "C:\Users\dtrotsky\source\repos\Blogger\Blogger\Views\Comment\Show.cshtml"
                }

#line default
#line hidden
            BeginContext(681, 19, true);
            WriteLiteral("            </ul>\r\n");
            EndContext();
#line 27 "C:\Users\dtrotsky\source\repos\Blogger\Blogger\Views\Comment\Show.cshtml"
        }

#line default
#line hidden
            BeginContext(711, 12, true);
            WriteLiteral("    </div>\r\n");
            EndContext();
#line 29 "C:\Users\dtrotsky\source\repos\Blogger\Blogger\Views\Comment\Show.cshtml"
     if (User.Identity.IsAuthenticated)
    {

#line default
#line hidden
            BeginContext(771, 93, true);
            WriteLiteral("        <div>\r\n            <h2>Добавить комментарий</h2>\r\n            <div>\r\n                ");
            EndContext();
            BeginContext(864, 302, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5f47630027544815bb70fe7647dfbb8b", async() => {
                BeginContext(884, 56, true);
                WriteLiteral("\r\n                    <input type=\"hidden\" name=\"postid\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 940, "\"", 962, 1);
#line 35 "C:\Users\dtrotsky\source\repos\Blogger\Blogger\Views\Comment\Show.cshtml"
WriteAttributeValue("", 948, Model.Post.ID, 948, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(963, 83, true);
                WriteLiteral(" />\r\n                    <textarea name=\"content\"></textarea>\r\n                    ");
                EndContext();
                BeginContext(1046, 95, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e11c2bbb173b496ab0914199a886e608", async() => {
                    BeginContext(1124, 8, true);
                    WriteLiteral("Добавить");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1141, 18, true);
                WriteLiteral("\r\n                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1166, 38, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n");
            EndContext();
#line 41 "C:\Users\dtrotsky\source\repos\Blogger\Blogger\Views\Comment\Show.cshtml"
    }

#line default
#line hidden
            BeginContext(1211, 10, true);
            WriteLiteral("</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Blogger.ViewModels.CommentPageModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
