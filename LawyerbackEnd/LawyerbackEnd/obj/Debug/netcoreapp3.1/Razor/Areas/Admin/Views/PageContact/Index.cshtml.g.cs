#pragma checksum "C:\Users\EMIN\Desktop\lawyersWebsite\LawyerbackEnd\LawyerbackEnd\Areas\Admin\Views\PageContact\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "317add1022cd023301be1d102eec9fd142891fda"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_PageContact_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/PageContact/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"317add1022cd023301be1d102eec9fd142891fda", @"/Areas/Admin/Views/PageContact/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2a9e96e9356355bc0a07a4f74e7984a416c6d14e", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_PageContact_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IList<PageContact>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\EMIN\Desktop\lawyersWebsite\LawyerbackEnd\LawyerbackEnd\Areas\Admin\Views\PageContact\Index.cshtml"
 if (TempData["Success"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-primary\" role=\"alert\">\r\n        ");
#nullable restore
#line 7 "C:\Users\EMIN\Desktop\lawyersWebsite\LawyerbackEnd\LawyerbackEnd\Areas\Admin\Views\PageContact\Index.cshtml"
   Write(TempData["Success"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
#nullable restore
#line 9 "C:\Users\EMIN\Desktop\lawyersWebsite\LawyerbackEnd\LawyerbackEnd\Areas\Admin\Views\PageContact\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div>
    <a href=""/Admin/PageContact/Create"" class=""btn btn-success"" style=""width:100%"">Add new practise Areas</a>
</div>

<table class=""table table-bordered"">
    <thead>
        <tr>
            <th scope=""col"">ID</th>
            <th scope=""col"">Header</th>
            <th scope=""col"">Title</th>
            <th scope=""col"">Link</th>
            <th scope=""col"">Link Description</th>
            <th scope=""col"">Description</th>
            <th>Edit/Delete</th>
        </tr>
    </thead>

    <tbody>

");
#nullable restore
#line 30 "C:\Users\EMIN\Desktop\lawyersWebsite\LawyerbackEnd\LawyerbackEnd\Areas\Admin\Views\PageContact\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <th scope=\"row\">");
#nullable restore
#line 33 "C:\Users\EMIN\Desktop\lawyersWebsite\LawyerbackEnd\LawyerbackEnd\Areas\Admin\Views\PageContact\Index.cshtml"
                           Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th scope=\"row\">");
#nullable restore
#line 34 "C:\Users\EMIN\Desktop\lawyersWebsite\LawyerbackEnd\LawyerbackEnd\Areas\Admin\Views\PageContact\Index.cshtml"
                           Write(Html.Raw(item.Header));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th scope=\"row\">");
#nullable restore
#line 35 "C:\Users\EMIN\Desktop\lawyersWebsite\LawyerbackEnd\LawyerbackEnd\Areas\Admin\Views\PageContact\Index.cshtml"
                           Write(Html.Raw(item.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <td>");
#nullable restore
#line 36 "C:\Users\EMIN\Desktop\lawyersWebsite\LawyerbackEnd\LawyerbackEnd\Areas\Admin\Views\PageContact\Index.cshtml"
               Write(Html.Raw(item.Link));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 37 "C:\Users\EMIN\Desktop\lawyersWebsite\LawyerbackEnd\LawyerbackEnd\Areas\Admin\Views\PageContact\Index.cshtml"
               Write(Html.Raw(item.LinkDescription));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 38 "C:\Users\EMIN\Desktop\lawyersWebsite\LawyerbackEnd\LawyerbackEnd\Areas\Admin\Views\PageContact\Index.cshtml"
               Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 1123, "\"", 1162, 2);
            WriteAttributeValue("", 1130, "/Admin/PageContact/Edit/", 1130, 24, true);
#nullable restore
#line 40 "C:\Users\EMIN\Desktop\lawyersWebsite\LawyerbackEnd\LawyerbackEnd\Areas\Admin\Views\PageContact\Index.cshtml"
WriteAttributeValue("", 1154, item.Id, 1154, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"color:red\"><i class=\"fas fa-edit\"></i></a>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 1237, "\"", 1278, 2);
            WriteAttributeValue("", 1244, "/Admin/PageContact/Delete/", 1244, 26, true);
#nullable restore
#line 41 "C:\Users\EMIN\Desktop\lawyersWebsite\LawyerbackEnd\LawyerbackEnd\Areas\Admin\Views\PageContact\Index.cshtml"
WriteAttributeValue("", 1270, item.Id, 1270, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" onclick=\"return confirm(\'Silmek isdediyinizden eminsinizmi?\')\" style=\"color:red\"><i class=\"fas fa-trash-alt\"></i></a>\r\n                    <br />\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 45 "C:\Users\EMIN\Desktop\lawyersWebsite\LawyerbackEnd\LawyerbackEnd\Areas\Admin\Views\PageContact\Index.cshtml"

        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IList<PageContact>> Html { get; private set; }
    }
}
#pragma warning restore 1591
