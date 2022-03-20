#pragma checksum "C:\Users\EMIN\Desktop\lawyersWebsite\LawyerbackEnd\LawyerbackEnd\Areas\Admin\Views\Packet\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "63c9732311c48e75795e2b56af54c8174614c2ca"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Packet_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Packet/Index.cshtml")]
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
#nullable restore
#line 4 "C:\Users\EMIN\Desktop\lawyersWebsite\LawyerbackEnd\LawyerbackEnd\Areas\Admin\Views\_ViewImports.cshtml"
using LawyerbackEnd.ViewModel;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"63c9732311c48e75795e2b56af54c8174614c2ca", @"/Areas/Admin/Views/Packet/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6cf4c724a89af8a05ecc33744d67300178a688fb", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Packet_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IList<Packet>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\EMIN\Desktop\lawyersWebsite\LawyerbackEnd\LawyerbackEnd\Areas\Admin\Views\Packet\Index.cshtml"
  
    List<PacketToComponents> packetToComponents = ViewBag.PacketToComponents;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div>
    <a href=""/Admin/Packet/Create"" style=""width:100%"" class=""btn btn-success"">Add</a>
</div>
<table class=""table table-bordered"">
    <thead>
        <tr>
            <th>Packet Name</th>
            <th>components</th>
            <th>CRUD</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 17 "C:\Users\EMIN\Desktop\lawyersWebsite\LawyerbackEnd\LawyerbackEnd\Areas\Admin\Views\Packet\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("<tr>\n    <th scope=\"row\">");
#nullable restore
#line 20 "C:\Users\EMIN\Desktop\lawyersWebsite\LawyerbackEnd\LawyerbackEnd\Areas\Admin\Views\Packet\Index.cshtml"
               Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n\n    <th scope=\"row\">");
#nullable restore
#line 22 "C:\Users\EMIN\Desktop\lawyersWebsite\LawyerbackEnd\LawyerbackEnd\Areas\Admin\Views\Packet\Index.cshtml"
                     foreach (var item2 in packetToComponents)
    {
        if (item.Id==item2.PacketId)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "C:\Users\EMIN\Desktop\lawyersWebsite\LawyerbackEnd\LawyerbackEnd\Areas\Admin\Views\Packet\Index.cshtml"
        Write(item2.components.Name+ " ");

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "C:\Users\EMIN\Desktop\lawyersWebsite\LawyerbackEnd\LawyerbackEnd\Areas\Admin\Views\Packet\Index.cshtml"
                                         
        }
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n    <td>\n        <a");
            BeginWriteAttribute("href", " href=\"", 688, "\"", 722, 2);
            WriteAttributeValue("", 695, "/Admin/Packet/Edit/", 695, 19, true);
#nullable restore
#line 30 "C:\Users\EMIN\Desktop\lawyersWebsite\LawyerbackEnd\LawyerbackEnd\Areas\Admin\Views\Packet\Index.cshtml"
WriteAttributeValue("", 714, item.Id, 714, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"color:green\"><i class=\"fas fa-edit\"></i></a>\n        <a");
            BeginWriteAttribute("href", " href=\"", 786, "\"", 822, 2);
            WriteAttributeValue("", 793, "/Admin/Packet/Delete/", 793, 21, true);
#nullable restore
#line 31 "C:\Users\EMIN\Desktop\lawyersWebsite\LawyerbackEnd\LawyerbackEnd\Areas\Admin\Views\Packet\Index.cshtml"
WriteAttributeValue("", 814, item.Id, 814, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" onclick=\"return confirm(\'Are you delete?\')\" style=\"color:red\"><i class=\"fas fa-trash-alt\"></i></a>\n    </td>\n</tr>\n");
#nullable restore
#line 34 "C:\Users\EMIN\Desktop\lawyersWebsite\LawyerbackEnd\LawyerbackEnd\Areas\Admin\Views\Packet\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IList<Packet>> Html { get; private set; }
    }
}
#pragma warning restore 1591