#pragma checksum "C:\Users\EMIN\Desktop\lawyersWebsite\LawyerbackEnd\LawyerbackEnd\Areas\Admin\Views\AttorneysSlider\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5f48740cfdcbd4da39d7506c9673023e7da506a2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_AttorneysSlider_Details), @"mvc.1.0.view", @"/Areas/Admin/Views/AttorneysSlider/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5f48740cfdcbd4da39d7506c9673023e7da506a2", @"/Areas/Admin/Views/AttorneysSlider/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f440177ce4d3111613b76bc5fb6bc2e76c1f0760", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_AttorneysSlider_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AttorneysSlider>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral(@"


<table class=""table table-bordered"">
    <thead class=""bg-register-image"">
        <tr>
            <th scope=""col"">ID</th>
            <th scope=""col"">Name</th>
        </tr>
    </thead>

    <tbody>

            <tr>
                <th scope=""row"">");
#nullable restore
#line 17 "C:\Users\EMIN\Desktop\lawyersWebsite\LawyerbackEnd\LawyerbackEnd\Areas\Admin\Views\AttorneysSlider\Details.cshtml"
                           Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <td>");
#nullable restore
#line 18 "C:\Users\EMIN\Desktop\lawyersWebsite\LawyerbackEnd\LawyerbackEnd\Areas\Admin\Views\AttorneysSlider\Details.cshtml"
               Write(Html.Raw(Model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n\r\n        \r\n    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AttorneysSlider> Html { get; private set; }
    }
}
#pragma warning restore 1591