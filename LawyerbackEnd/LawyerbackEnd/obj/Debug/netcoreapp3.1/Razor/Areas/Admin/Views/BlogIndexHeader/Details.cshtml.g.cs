#pragma checksum "C:\Users\EMIN\Desktop\lawyersWebsite\LawyerbackEnd\LawyerbackEnd\Areas\Admin\Views\BlogIndexHeader\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d2f7637cfc519858396987da4cded1ab76f63d3b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_BlogIndexHeader_Details), @"mvc.1.0.view", @"/Areas/Admin/Views/BlogIndexHeader/Details.cshtml")]
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
#nullable restore
#line 1 "C:\Users\EMIN\Desktop\lawyersWebsite\LawyerbackEnd\LawyerbackEnd\Areas\Admin\Views\_ViewImports.cshtml"
using LawyerbackEnd;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\EMIN\Desktop\lawyersWebsite\LawyerbackEnd\LawyerbackEnd\Areas\Admin\Views\_ViewImports.cshtml"
using LawyerbackEnd.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\EMIN\Desktop\lawyersWebsite\LawyerbackEnd\LawyerbackEnd\Areas\Admin\Views\_ViewImports.cshtml"
using LawyerbackEnd.Models.AdminAccount;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d2f7637cfc519858396987da4cded1ab76f63d3b", @"/Areas/Admin/Views/BlogIndexHeader/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2a9e96e9356355bc0a07a4f74e7984a416c6d14e", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_BlogIndexHeader_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BlogIndexAbout>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral(@"
<div style=""overflow-x:auto"">

    <table class=""table table-bordered"">
        <thead>
            <tr>
                <th scope=""col"">ID</th>
                <th scope=""col"">About Header</th>
                <th scope=""col"">About Description</th>
                <th scope=""col"">Recent titles</th>
                <th scope=""col"">Recent Description</th>
                <th scope=""col"">Categorise title</th>
                <th scope=""col"">Categories Description</th>
            </tr>
        </thead>

        <tbody>
                <tr>
                    <th scope=""row"">");
#nullable restore
#line 21 "C:\Users\EMIN\Desktop\lawyersWebsite\LawyerbackEnd\LawyerbackEnd\Areas\Admin\Views\BlogIndexHeader\Details.cshtml"
                               Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n\r\n                    <td>");
#nullable restore
#line 23 "C:\Users\EMIN\Desktop\lawyersWebsite\LawyerbackEnd\LawyerbackEnd\Areas\Admin\Views\BlogIndexHeader\Details.cshtml"
                   Write(Html.Raw(Model.AboutHeadder));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 24 "C:\Users\EMIN\Desktop\lawyersWebsite\LawyerbackEnd\LawyerbackEnd\Areas\Admin\Views\BlogIndexHeader\Details.cshtml"
                   Write(Html.Raw(Model.ABoutDescription));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 25 "C:\Users\EMIN\Desktop\lawyersWebsite\LawyerbackEnd\LawyerbackEnd\Areas\Admin\Views\BlogIndexHeader\Details.cshtml"
                   Write(Model.RecetHeader);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 26 "C:\Users\EMIN\Desktop\lawyersWebsite\LawyerbackEnd\LawyerbackEnd\Areas\Admin\Views\BlogIndexHeader\Details.cshtml"
                   Write(Model.RecentDesc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 27 "C:\Users\EMIN\Desktop\lawyersWebsite\LawyerbackEnd\LawyerbackEnd\Areas\Admin\Views\BlogIndexHeader\Details.cshtml"
                   Write(Model.CategoryHEader);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 28 "C:\Users\EMIN\Desktop\lawyersWebsite\LawyerbackEnd\LawyerbackEnd\Areas\Admin\Views\BlogIndexHeader\Details.cshtml"
                   Write(Model.catgoryDesc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    \r\n                </tr>\r\n        </tbody>\r\n    </table>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BlogIndexAbout> Html { get; private set; }
    }
}
#pragma warning restore 1591
