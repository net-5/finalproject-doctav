#pragma checksum "F:\Conference\finalproject-doctav\Conference\Conference\Areas\Admin\Views\Speakers\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9ed5b4ee0372ca5efd07c14e94209dd3e580e61b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Speakers_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Speakers/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Speakers/Index.cshtml", typeof(AspNetCore.Areas_Admin_Views_Speakers_Index))]
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
#line 1 "F:\Conference\finalproject-doctav\Conference\Conference\Areas\Admin\Views\_ViewImports.cshtml"
using Conference;

#line default
#line hidden
#line 2 "F:\Conference\finalproject-doctav\Conference\Conference\Areas\Admin\Views\_ViewImports.cshtml"
using Conference.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9ed5b4ee0372ca5efd07c14e94209dd3e580e61b", @"/Areas/Admin/Views/Speakers/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"730217b378615efac836ac18994c698ac7ffdc81", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Speakers_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Conference.Domain.Entities.Speakers>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(57, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "F:\Conference\finalproject-doctav\Conference\Conference\Areas\Admin\Views\Speakers\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(100, 51, true);
            WriteLiteral("\r\n<h1>Index of Speakers - by Tavy</h1>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(151, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9ed5b4ee0372ca5efd07c14e94209dd3e580e61b3998", async() => {
                BeginContext(174, 10, true);
                WriteLiteral("Create New");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(188, 92, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(281, 38, false);
#line 16 "F:\Conference\finalproject-doctav\Conference\Conference\Areas\Admin\Views\Speakers\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(319, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(375, 45, false);
#line 19 "F:\Conference\finalproject-doctav\Conference\Conference\Areas\Admin\Views\Speakers\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(420, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(476, 44, false);
#line 22 "F:\Conference\finalproject-doctav\Conference\Conference\Areas\Admin\Views\Speakers\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(520, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(576, 44, false);
#line 25 "F:\Conference\finalproject-doctav\Conference\Conference\Areas\Admin\Views\Speakers\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Position));

#line default
#line hidden
            EndContext();
            BeginContext(620, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(676, 43, false);
#line 28 "F:\Conference\finalproject-doctav\Conference\Conference\Areas\Admin\Views\Speakers\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Website));

#line default
#line hidden
            EndContext();
            BeginContext(719, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(775, 44, false);
#line 31 "F:\Conference\finalproject-doctav\Conference\Conference\Areas\Admin\Views\Speakers\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Facebook));

#line default
#line hidden
            EndContext();
            BeginContext(819, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(875, 41, false);
#line 34 "F:\Conference\finalproject-doctav\Conference\Conference\Areas\Admin\Views\Speakers\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(916, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(972, 44, false);
#line 37 "F:\Conference\finalproject-doctav\Conference\Conference\Areas\Admin\Views\Speakers\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.LinkedIn));

#line default
#line hidden
            EndContext();
            BeginContext(1016, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1072, 41, false);
#line 40 "F:\Conference\finalproject-doctav\Conference\Conference\Areas\Admin\Views\Speakers\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Skype));

#line default
#line hidden
            EndContext();
            BeginContext(1113, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1169, 42, false);
#line 43 "F:\Conference\finalproject-doctav\Conference\Conference\Areas\Admin\Views\Speakers\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.GitHub));

#line default
#line hidden
            EndContext();
            BeginContext(1211, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1267, 43, false);
#line 46 "F:\Conference\finalproject-doctav\Conference\Conference\Areas\Admin\Views\Speakers\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Twitter));

#line default
#line hidden
            EndContext();
            BeginContext(1310, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1366, 47, false);
#line 49 "F:\Conference\finalproject-doctav\Conference\Conference\Areas\Admin\Views\Speakers\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.CompanyName));

#line default
#line hidden
            EndContext();
            BeginContext(1413, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1469, 50, false);
#line 52 "F:\Conference\finalproject-doctav\Conference\Conference\Areas\Admin\Views\Speakers\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.CompanyWebsite));

#line default
#line hidden
            EndContext();
            BeginContext(1519, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1575, 47, false);
#line 55 "F:\Conference\finalproject-doctav\Conference\Conference\Areas\Admin\Views\Speakers\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(1622, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1678, 44, false);
#line 58 "F:\Conference\finalproject-doctav\Conference\Conference\Areas\Admin\Views\Speakers\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.PageSlug));

#line default
#line hidden
            EndContext();
            BeginContext(1722, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1778, 43, false);
#line 61 "F:\Conference\finalproject-doctav\Conference\Conference\Areas\Admin\Views\Speakers\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Edition));

#line default
#line hidden
            EndContext();
            BeginContext(1821, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 67 "F:\Conference\finalproject-doctav\Conference\Conference\Areas\Admin\Views\Speakers\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(1939, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1988, 37, false);
#line 70 "F:\Conference\finalproject-doctav\Conference\Conference\Areas\Admin\Views\Speakers\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
            EndContext();
            BeginContext(2025, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2081, 44, false);
#line 73 "F:\Conference\finalproject-doctav\Conference\Conference\Areas\Admin\Views\Speakers\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(2125, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2181, 43, false);
#line 76 "F:\Conference\finalproject-doctav\Conference\Conference\Areas\Admin\Views\Speakers\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(2224, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2280, 43, false);
#line 79 "F:\Conference\finalproject-doctav\Conference\Conference\Areas\Admin\Views\Speakers\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Position));

#line default
#line hidden
            EndContext();
            BeginContext(2323, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2379, 42, false);
#line 82 "F:\Conference\finalproject-doctav\Conference\Conference\Areas\Admin\Views\Speakers\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Website));

#line default
#line hidden
            EndContext();
            BeginContext(2421, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2477, 43, false);
#line 85 "F:\Conference\finalproject-doctav\Conference\Conference\Areas\Admin\Views\Speakers\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Facebook));

#line default
#line hidden
            EndContext();
            BeginContext(2520, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2576, 40, false);
#line 88 "F:\Conference\finalproject-doctav\Conference\Conference\Areas\Admin\Views\Speakers\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
            EndContext();
            BeginContext(2616, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2672, 43, false);
#line 91 "F:\Conference\finalproject-doctav\Conference\Conference\Areas\Admin\Views\Speakers\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.LinkedIn));

#line default
#line hidden
            EndContext();
            BeginContext(2715, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2771, 40, false);
#line 94 "F:\Conference\finalproject-doctav\Conference\Conference\Areas\Admin\Views\Speakers\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Skype));

#line default
#line hidden
            EndContext();
            BeginContext(2811, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2867, 41, false);
#line 97 "F:\Conference\finalproject-doctav\Conference\Conference\Areas\Admin\Views\Speakers\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.GitHub));

#line default
#line hidden
            EndContext();
            BeginContext(2908, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2964, 42, false);
#line 100 "F:\Conference\finalproject-doctav\Conference\Conference\Areas\Admin\Views\Speakers\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Twitter));

#line default
#line hidden
            EndContext();
            BeginContext(3006, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3062, 46, false);
#line 103 "F:\Conference\finalproject-doctav\Conference\Conference\Areas\Admin\Views\Speakers\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.CompanyName));

#line default
#line hidden
            EndContext();
            BeginContext(3108, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3164, 49, false);
#line 106 "F:\Conference\finalproject-doctav\Conference\Conference\Areas\Admin\Views\Speakers\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.CompanyWebsite));

#line default
#line hidden
            EndContext();
            BeginContext(3213, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3269, 46, false);
#line 109 "F:\Conference\finalproject-doctav\Conference\Conference\Areas\Admin\Views\Speakers\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Description));

#line default
#line hidden
            EndContext();
            BeginContext(3315, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3371, 43, false);
#line 112 "F:\Conference\finalproject-doctav\Conference\Conference\Areas\Admin\Views\Speakers\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.PageSlug));

#line default
#line hidden
            EndContext();
            BeginContext(3414, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3470, 42, false);
#line 115 "F:\Conference\finalproject-doctav\Conference\Conference\Areas\Admin\Views\Speakers\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Edition));

#line default
#line hidden
            EndContext();
            BeginContext(3512, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(3568, 65, false);
#line 118 "F:\Conference\finalproject-doctav\Conference\Conference\Areas\Admin\Views\Speakers\Index.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(3633, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(3654, 71, false);
#line 119 "F:\Conference\finalproject-doctav\Conference\Conference\Areas\Admin\Views\Speakers\Index.cshtml"
           Write(Html.ActionLink("Details", "Details", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(3725, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(3746, 69, false);
#line 120 "F:\Conference\finalproject-doctav\Conference\Conference\Areas\Admin\Views\Speakers\Index.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(3815, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 123 "F:\Conference\finalproject-doctav\Conference\Conference\Areas\Admin\Views\Speakers\Index.cshtml"
}

#line default
#line hidden
            BeginContext(3854, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Conference.Domain.Entities.Speakers>> Html { get; private set; }
    }
}
#pragma warning restore 1591
