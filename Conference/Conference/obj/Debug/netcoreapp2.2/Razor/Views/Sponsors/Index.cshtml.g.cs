#pragma checksum "F:\Conference\finalproject-doctav\Conference\Conference\Views\Sponsors\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b58701421356bc647a6fabda7fb0091e783dd539"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Sponsors_Index), @"mvc.1.0.view", @"/Views/Sponsors/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Sponsors/Index.cshtml", typeof(AspNetCore.Views_Sponsors_Index))]
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
#line 1 "F:\Conference\finalproject-doctav\Conference\Conference\Views\_ViewImports.cshtml"
using Conference;

#line default
#line hidden
#line 2 "F:\Conference\finalproject-doctav\Conference\Conference\Views\_ViewImports.cshtml"
using Conference.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b58701421356bc647a6fabda7fb0091e783dd539", @"/Views/Sponsors/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8cbfddc5984994e8dad86012996c8394c90c1314", @"/Views/_ViewImports.cshtml")]
    public class Views_Sponsors_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Conference.Domain.Entities.Sponsors>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/sponsors.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(57, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "F:\Conference\finalproject-doctav\Conference\Conference\Views\Sponsors\Index.cshtml"
  
    ViewData["Title"] = "Index of sponsors - by Tavy";

#line default
#line hidden
            BeginContext(122, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(124, 67, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b58701421356bc647a6fabda7fb0091e783dd5394609", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(191, 78, true);
            WriteLiteral("\r\n\r\n\r\n<p></p>\r\n\r\n<h2>Our active sponsors</h2>\r\n<div class=\"sponsorCategory\">\r\n");
            EndContext();
#line 14 "F:\Conference\finalproject-doctav\Conference\Conference\Views\Sponsors\Index.cshtml"
     foreach (var item in Model)
    {
        if (item.Active == true)
        {

#line default
#line hidden
            BeginContext(355, 75, true);
            WriteLiteral("            <div class=\"sponsor\">\r\n                <p class=\"sponsorName\"> ");
            EndContext();
            BeginContext(431, 9, false);
#line 19 "F:\Conference\finalproject-doctav\Conference\Conference\Views\Sponsors\Index.cshtml"
                                   Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(440, 52, true);
            WriteLiteral("</p>\r\n                <p class=\"sponsorDescription\">");
            EndContext();
            BeginContext(493, 16, false);
#line 20 "F:\Conference\finalproject-doctav\Conference\Conference\Views\Sponsors\Index.cshtml"
                                         Write(item.Description);

#line default
#line hidden
            EndContext();
            BeginContext(509, 26, true);
            WriteLiteral("</p>\r\n            </div>\r\n");
            EndContext();
#line 22 "F:\Conference\finalproject-doctav\Conference\Conference\Views\Sponsors\Index.cshtml"
        }
    }

#line default
#line hidden
            BeginContext(553, 91, true);
            WriteLiteral("</div>\r\n\r\n<br />\r\n<br />\r\n\r\n<h2>Our inactive sponsors</h2>\r\n<div class=\"sponsorCategory\">\r\n");
            EndContext();
#line 31 "F:\Conference\finalproject-doctav\Conference\Conference\Views\Sponsors\Index.cshtml"
     foreach (var item in Model)
    {
        if (item.Active == false)
        {

#line default
#line hidden
            BeginContext(731, 75, true);
            WriteLiteral("            <div class=\"sponsor\">\r\n                <p class=\"sponsorName\"> ");
            EndContext();
            BeginContext(807, 9, false);
#line 36 "F:\Conference\finalproject-doctav\Conference\Conference\Views\Sponsors\Index.cshtml"
                                   Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(816, 52, true);
            WriteLiteral("</p>\r\n                <p class=\"sponsorDescription\">");
            EndContext();
            BeginContext(869, 16, false);
#line 37 "F:\Conference\finalproject-doctav\Conference\Conference\Views\Sponsors\Index.cshtml"
                                         Write(item.Description);

#line default
#line hidden
            EndContext();
            BeginContext(885, 57, true);
            WriteLiteral("</p>\r\n                <p class=\"sponsorEdition\">Edition: ");
            EndContext();
            BeginContext(943, 12, false);
#line 38 "F:\Conference\finalproject-doctav\Conference\Conference\Views\Sponsors\Index.cshtml"
                                              Write(item.Edition);

#line default
#line hidden
            EndContext();
            BeginContext(955, 82, true);
            WriteLiteral("</p>\r\n                <p>-----------</p>\r\n            </div>\r\n            <br />\r\n");
            EndContext();
#line 42 "F:\Conference\finalproject-doctav\Conference\Conference\Views\Sponsors\Index.cshtml"
        }
    }

#line default
#line hidden
            BeginContext(1055, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Conference.Domain.Entities.Sponsors>> Html { get; private set; }
    }
}
#pragma warning restore 1591
