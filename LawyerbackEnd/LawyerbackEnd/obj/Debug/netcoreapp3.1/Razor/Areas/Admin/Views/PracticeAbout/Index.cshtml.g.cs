#pragma checksum "C:\Users\EMIN\Desktop\lawyersWebsite\LawyerbackEnd\LawyerbackEnd\Areas\Admin\Views\PracticeAbout\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "461d9e8ebcb0625deb7b944c9d1ad57f7ed02358"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_PracticeAbout_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/PracticeAbout/Index.cshtml")]
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
#nullable restore
#line 4 "C:\Users\EMIN\Desktop\lawyersWebsite\LawyerbackEnd\LawyerbackEnd\Areas\Admin\Views\_ViewImports.cshtml"
using LawyerbackEnd.ViewModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\EMIN\Desktop\lawyersWebsite\LawyerbackEnd\LawyerbackEnd\Areas\Admin\Views\_ViewImports.cshtml"
using LawyerbackEnd;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"461d9e8ebcb0625deb7b944c9d1ad57f7ed02358", @"/Areas/Admin/Views/PracticeAbout/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f440177ce4d3111613b76bc5fb6bc2e76c1f0760", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_PracticeAbout_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IList<PracticeAbout>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\EMIN\Desktop\lawyersWebsite\LawyerbackEnd\LawyerbackEnd\Areas\Admin\Views\PracticeAbout\Index.cshtml"
 if (TempData["Success"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-primary\" role=\"alert\">\r\n        ");
#nullable restore
#line 7 "C:\Users\EMIN\Desktop\lawyersWebsite\LawyerbackEnd\LawyerbackEnd\Areas\Admin\Views\PracticeAbout\Index.cshtml"
   Write(TempData["Success"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
#nullable restore
#line 9 "C:\Users\EMIN\Desktop\lawyersWebsite\LawyerbackEnd\LawyerbackEnd\Areas\Admin\Views\PracticeAbout\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div>
    <a href=""/Admin/PracticeAbout/Create"" class=""btn btn-success"" style=""width:100%"">Add new slider</a>
</div>

<table class=""table table-bordered"">
    <thead>
        <tr>
            <th scope=""col"">ID</th>
            <th scope=""col"">Icon</th>
            <th scope=""col"">Header</th>
            <th scope=""col"">Description</th>
            <th scope=""col"">Learn Text</th>
            <th scope=""col"">Learn Text Link</th>
            <th>Edit/Delete</th>
        </tr>
    </thead>

    <tbody>

");
#nullable restore
#line 30 "C:\Users\EMIN\Desktop\lawyersWebsite\LawyerbackEnd\LawyerbackEnd\Areas\Admin\Views\PracticeAbout\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <th scope=\"row\">");
#nullable restore
#line 33 "C:\Users\EMIN\Desktop\lawyersWebsite\LawyerbackEnd\LawyerbackEnd\Areas\Admin\Views\PracticeAbout\Index.cshtml"
                           Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <td>");
#nullable restore
#line 34 "C:\Users\EMIN\Desktop\lawyersWebsite\LawyerbackEnd\LawyerbackEnd\Areas\Admin\Views\PracticeAbout\Index.cshtml"
               Write(Html.Raw(item.IconLink));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 35 "C:\Users\EMIN\Desktop\lawyersWebsite\LawyerbackEnd\LawyerbackEnd\Areas\Admin\Views\PracticeAbout\Index.cshtml"
               Write(Html.Raw(item.Header));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 36 "C:\Users\EMIN\Desktop\lawyersWebsite\LawyerbackEnd\LawyerbackEnd\Areas\Admin\Views\PracticeAbout\Index.cshtml"
               Write(Html.Raw(item.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 37 "C:\Users\EMIN\Desktop\lawyersWebsite\LawyerbackEnd\LawyerbackEnd\Areas\Admin\Views\PracticeAbout\Index.cshtml"
               Write(Html.Raw(item.Learntext));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 38 "C:\Users\EMIN\Desktop\lawyersWebsite\LawyerbackEnd\LawyerbackEnd\Areas\Admin\Views\PracticeAbout\Index.cshtml"
               Write(item.LearnLink);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                <td>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 1103, "\"", 1144, 2);
            WriteAttributeValue("", 1110, "/Admin/PracticeAbout/Edit/", 1110, 26, true);
#nullable restore
#line 41 "C:\Users\EMIN\Desktop\lawyersWebsite\LawyerbackEnd\LawyerbackEnd\Areas\Admin\Views\PracticeAbout\Index.cshtml"
WriteAttributeValue("", 1136, item.Id, 1136, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"color:red\"><i class=\"fas fa-edit\"></i></a>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 1219, "\"", 1262, 2);
            WriteAttributeValue("", 1226, "/Admin/PracticeAbout/Delete/", 1226, 28, true);
#nullable restore
#line 42 "C:\Users\EMIN\Desktop\lawyersWebsite\LawyerbackEnd\LawyerbackEnd\Areas\Admin\Views\PracticeAbout\Index.cshtml"
WriteAttributeValue("", 1254, item.Id, 1254, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" onclick=\"return confirm(\'Silmek isdediyinizden eminsinizmi?\')\" style=\"color:red\"><i class=\"fas fa-trash-alt\"></i></a>\r\n                    <br />\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 1433, "\"", 1477, 2);
            WriteAttributeValue("", 1440, "/Admin/PracticeAbout/Details/", 1440, 29, true);
#nullable restore
#line 44 "C:\Users\EMIN\Desktop\lawyersWebsite\LawyerbackEnd\LawyerbackEnd\Areas\Admin\Views\PracticeAbout\Index.cshtml"
WriteAttributeValue("", 1469, item.Id, 1469, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"color:red\">Etrafli</a>\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 47 "C:\Users\EMIN\Desktop\lawyersWebsite\LawyerbackEnd\LawyerbackEnd\Areas\Admin\Views\PracticeAbout\Index.cshtml"

        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IList<PracticeAbout>> Html { get; private set; }
    }
}
#pragma warning restore 1591
