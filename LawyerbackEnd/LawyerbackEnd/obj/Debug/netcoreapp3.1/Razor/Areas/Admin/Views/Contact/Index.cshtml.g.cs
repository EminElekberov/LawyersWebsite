#pragma checksum "C:\Users\EMIN\Desktop\lawyersWebsite\LawyerbackEnd\LawyerbackEnd\Areas\Admin\Views\Contact\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c6416ce366f6dbc1db40b8f473fb7142d985494a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Contact_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Contact/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c6416ce366f6dbc1db40b8f473fb7142d985494a", @"/Areas/Admin/Views/Contact/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f440177ce4d3111613b76bc5fb6bc2e76c1f0760", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Contact_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IList<Contact>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "radio", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("html"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "fav_language", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "true", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "false", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\EMIN\Desktop\lawyersWebsite\LawyerbackEnd\LawyerbackEnd\Areas\Admin\Views\Contact\Index.cshtml"
 if (TempData["Success"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-primary\" role=\"alert\">\r\n        ");
#nullable restore
#line 7 "C:\Users\EMIN\Desktop\lawyersWebsite\LawyerbackEnd\LawyerbackEnd\Areas\Admin\Views\Contact\Index.cshtml"
   Write(TempData["Success"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
#nullable restore
#line 9 "C:\Users\EMIN\Desktop\lawyersWebsite\LawyerbackEnd\LawyerbackEnd\Areas\Admin\Views\Contact\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<table class=""table table-bordered table-striped"">
    <thead class=""bg-login-image"">
        <tr>
            <th scope=""col"">ID</th>
            <th scope=""col"">Name</th>
            <th scope=""col"">Email</th>
            <th scope=""col"">Subject</th>
            <th scope=""col"">Messsage</th>
            <th scope=""col"">Did you read?</th>
            <th scope=""col"">My Opinion</th>
            <th>Edit/Delete</th>
        </tr>
    </thead>

    <tbody>

");
#nullable restore
#line 26 "C:\Users\EMIN\Desktop\lawyersWebsite\LawyerbackEnd\LawyerbackEnd\Areas\Admin\Views\Contact\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <th scope=\"row\">");
#nullable restore
#line 29 "C:\Users\EMIN\Desktop\lawyersWebsite\LawyerbackEnd\LawyerbackEnd\Areas\Admin\Views\Contact\Index.cshtml"
                           Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <td>");
#nullable restore
#line 30 "C:\Users\EMIN\Desktop\lawyersWebsite\LawyerbackEnd\LawyerbackEnd\Areas\Admin\Views\Contact\Index.cshtml"
               Write(Html.Raw(item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 31 "C:\Users\EMIN\Desktop\lawyersWebsite\LawyerbackEnd\LawyerbackEnd\Areas\Admin\Views\Contact\Index.cshtml"
               Write(Html.Raw(item.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 32 "C:\Users\EMIN\Desktop\lawyersWebsite\LawyerbackEnd\LawyerbackEnd\Areas\Admin\Views\Contact\Index.cshtml"
               Write(Html.Raw(item.Subject));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 33 "C:\Users\EMIN\Desktop\lawyersWebsite\LawyerbackEnd\LawyerbackEnd\Areas\Admin\Views\Contact\Index.cshtml"
               Write(Html.Raw(item.Message));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "c6416ce366f6dbc1db40b8f473fb7142d985494a8648", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Name = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
#nullable restore
#line 35 "C:\Users\EMIN\Desktop\lawyersWebsite\LawyerbackEnd\LawyerbackEnd\Areas\Admin\Views\Contact\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => item.ReadyForm);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    <label for=\"html\">Yes</label>\r\n                    <br>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "c6416ce366f6dbc1db40b8f473fb7142d985494a10895", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Name = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
#nullable restore
#line 38 "C:\Users\EMIN\Desktop\lawyersWebsite\LawyerbackEnd\LawyerbackEnd\Areas\Admin\Views\Contact\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => item.ReadyForm);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    <label for=\"css\">No</label>\r\n                    <br>\r\n                </td>\r\n                <td>");
#nullable restore
#line 42 "C:\Users\EMIN\Desktop\lawyersWebsite\LawyerbackEnd\LawyerbackEnd\Areas\Admin\Views\Contact\Index.cshtml"
               Write(Html.Raw(item.MyOpinion));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                <td>\r\n                    <a class=\"btn btn-success\"");
            BeginWriteAttribute("href", " href=\"", 1488, "\"", 1532, 2);
            WriteAttributeValue("", 1495, "/Admin/Contact/CreateOpinion/", 1495, 29, true);
#nullable restore
#line 45 "C:\Users\EMIN\Desktop\lawyersWebsite\LawyerbackEnd\LawyerbackEnd\Areas\Admin\Views\Contact\Index.cshtml"
WriteAttributeValue("", 1524, item.Id, 1524, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Write opinion</a>\r\n                    <a class=\"btn btn-danger\"");
            BeginWriteAttribute("href", " href=\"", 1598, "\"", 1635, 2);
            WriteAttributeValue("", 1605, "/Admin/Contact/Delete/", 1605, 22, true);
#nullable restore
#line 46 "C:\Users\EMIN\Desktop\lawyersWebsite\LawyerbackEnd\LawyerbackEnd\Areas\Admin\Views\Contact\Index.cshtml"
WriteAttributeValue("", 1627, item.Id, 1627, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"fas fa-trash-alt\"></i></a>\r\n                    <a class=\"btn btn-primary\"");
            BeginWriteAttribute("href", " href=\"", 1721, "\"", 1759, 2);
            WriteAttributeValue("", 1728, "/Admin/Contact/Details/", 1728, 23, true);
#nullable restore
#line 47 "C:\Users\EMIN\Desktop\lawyersWebsite\LawyerbackEnd\LawyerbackEnd\Areas\Admin\Views\Contact\Index.cshtml"
WriteAttributeValue("", 1751, item.Id, 1751, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"color:red\">Etrafli</a>\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 50 "C:\Users\EMIN\Desktop\lawyersWebsite\LawyerbackEnd\LawyerbackEnd\Areas\Admin\Views\Contact\Index.cshtml"

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IList<Contact>> Html { get; private set; }
    }
}
#pragma warning restore 1591
