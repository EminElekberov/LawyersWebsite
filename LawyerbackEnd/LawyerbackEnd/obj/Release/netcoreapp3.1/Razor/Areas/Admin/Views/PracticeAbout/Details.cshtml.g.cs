#pragma checksum "C:\Users\EMIN\Desktop\lawyersWebsite\LawyerbackEnd\LawyerbackEnd\Areas\Admin\Views\PracticeAbout\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e0c4f3dbd21e4e98f6e0a50e48871e20e850fc8c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_PracticeAbout_Details), @"mvc.1.0.view", @"/Areas/Admin/Views/PracticeAbout/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e0c4f3dbd21e4e98f6e0a50e48871e20e850fc8c", @"/Areas/Admin/Views/PracticeAbout/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f440177ce4d3111613b76bc5fb6bc2e76c1f0760", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_PracticeAbout_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PracticeAbout>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral(@"

<table class=""table table-bordered"">
    <thead>
        <tr>
            <th scope=""col"">ID</th>
            <th scope=""col"">Icon</th>
            <th scope=""col"">Header</th>
            <th scope=""col"">Description</th>
            <th scope=""col"">Learn Text</th>
            <th scope=""col"">Learn Text Link</th>
        </tr>
    </thead>

    <tbody>

            <tr>
                <th scope=""row"">");
#nullable restore
#line 20 "C:\Users\EMIN\Desktop\lawyersWebsite\LawyerbackEnd\LawyerbackEnd\Areas\Admin\Views\PracticeAbout\Details.cshtml"
                           Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <td>");
#nullable restore
#line 21 "C:\Users\EMIN\Desktop\lawyersWebsite\LawyerbackEnd\LawyerbackEnd\Areas\Admin\Views\PracticeAbout\Details.cshtml"
               Write(Html.Raw(Model.IconLink));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 22 "C:\Users\EMIN\Desktop\lawyersWebsite\LawyerbackEnd\LawyerbackEnd\Areas\Admin\Views\PracticeAbout\Details.cshtml"
               Write(Html.Raw(Model.Header));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 23 "C:\Users\EMIN\Desktop\lawyersWebsite\LawyerbackEnd\LawyerbackEnd\Areas\Admin\Views\PracticeAbout\Details.cshtml"
               Write(Html.Raw(Model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 24 "C:\Users\EMIN\Desktop\lawyersWebsite\LawyerbackEnd\LawyerbackEnd\Areas\Admin\Views\PracticeAbout\Details.cshtml"
               Write(Html.Raw(Model.Learntext));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 25 "C:\Users\EMIN\Desktop\lawyersWebsite\LawyerbackEnd\LawyerbackEnd\Areas\Admin\Views\PracticeAbout\Details.cshtml"
               Write(Html.Raw(Model.LearnLink));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n               \r\n            </tr>\r\n\r\n        \r\n    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PracticeAbout> Html { get; private set; }
    }
}
#pragma warning restore 1591