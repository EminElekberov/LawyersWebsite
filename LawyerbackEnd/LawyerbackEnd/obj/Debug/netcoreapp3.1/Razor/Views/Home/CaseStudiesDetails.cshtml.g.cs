#pragma checksum "C:\Users\EMIN\Desktop\lawyersWebsite\LawyerbackEnd\LawyerbackEnd\Views\Home\CaseStudiesDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "25ea4db1b2e3ba9a48f3fa3ed2d2d154eb17754d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_CaseStudiesDetails), @"mvc.1.0.view", @"/Views/Home/CaseStudiesDetails.cshtml")]
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
#line 1 "C:\Users\EMIN\Desktop\lawyersWebsite\LawyerbackEnd\LawyerbackEnd\Views\_ViewImports.cshtml"
using LawyerbackEnd;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\EMIN\Desktop\lawyersWebsite\LawyerbackEnd\LawyerbackEnd\Views\_ViewImports.cshtml"
using LawyerbackEnd.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\EMIN\Desktop\lawyersWebsite\LawyerbackEnd\LawyerbackEnd\Views\_ViewImports.cshtml"
using LawyerbackEnd.ViewModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\EMIN\Desktop\lawyersWebsite\LawyerbackEnd\LawyerbackEnd\Views\_ViewImports.cshtml"
using LawyerbackEnd.Models.AdminAccount;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"25ea4db1b2e3ba9a48f3fa3ed2d2d154eb17754d", @"/Views/Home/CaseStudiesDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b775534a9fd6fa373aceda92e0937edb1015c4c5", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_CaseStudiesDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Case>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid margin-b32"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Case", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\EMIN\Desktop\lawyersWebsite\LawyerbackEnd\LawyerbackEnd\Views\Home\CaseStudiesDetails.cshtml"
   List<Case> cases = ViewBag.Cases; 

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<!-- TOP IMAGE -->
<div class=""page-head "" style=""background-image:url('../images/cases/casBg.jpg');background-size:cover;"">
    <div class=""inner-desc"">
        <div class=""container"">
            <h1 class=""page-title"">Case Single Page</h1>
        </div>
    </div>
</div>
<!-- /TOP IMAGE -->
<!-- PAGE CONTENT -->
<div class=""page-holder custom-page-template page-full fullscreen-page clearfix"">
    <!-- SECTION 1-->
    <section class=""section-holder"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-lg-9"">
                    <h3>");
#nullable restore
#line 19 "C:\Users\EMIN\Desktop\lawyersWebsite\LawyerbackEnd\LawyerbackEnd\Views\Home\CaseStudiesDetails.cshtml"
                   Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\n                    <p>");
#nullable restore
#line 20 "C:\Users\EMIN\Desktop\lawyersWebsite\LawyerbackEnd\LawyerbackEnd\Views\Home\CaseStudiesDetails.cshtml"
                  Write(Html.Raw(Model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "25ea4db1b2e3ba9a48f3fa3ed2d2d154eb17754d6440", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 739, "~/images/aboutCase/", 739, 19, true);
#nullable restore
#line 21 "C:\Users\EMIN\Desktop\lawyersWebsite\LawyerbackEnd\LawyerbackEnd\Views\Home\CaseStudiesDetails.cshtml"
AddHtmlAttributeValue("", 758, Model.Image, 758, 12, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                    <h3>The Challenge</h3>\n                    <p>");
#nullable restore
#line 23 "C:\Users\EMIN\Desktop\lawyersWebsite\LawyerbackEnd\LawyerbackEnd\Views\Home\CaseStudiesDetails.cshtml"
                  Write(Model.Challenge);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                    <h3>The Solution</h3>\n                    <p>");
#nullable restore
#line 25 "C:\Users\EMIN\Desktop\lawyersWebsite\LawyerbackEnd\LawyerbackEnd\Views\Home\CaseStudiesDetails.cshtml"
                  Write(Model.Solution);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                    <h3>The Result</h3>\n                    <p>");
#nullable restore
#line 27 "C:\Users\EMIN\Desktop\lawyersWebsite\LawyerbackEnd\LawyerbackEnd\Views\Home\CaseStudiesDetails.cshtml"
                  Write(Model.Result);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                </div>
                <div class=""col-lg-3"">
                    <aside>
                        <ul>
                            <li class=""widget"">
                                <div class=""case-info"">
                                    <h5 class=""white margin-b16"">Case Info</h5>
                                    <ul class=""case-info-list"">
                                        <li><b>Category:</b> ");
#nullable restore
#line 36 "C:\Users\EMIN\Desktop\lawyersWebsite\LawyerbackEnd\LawyerbackEnd\Views\Home\CaseStudiesDetails.cshtml"
                                                        Write(Model.categorys.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n                                        <li><b>Time:</b> ");
#nullable restore
#line 37 "C:\Users\EMIN\Desktop\lawyersWebsite\LawyerbackEnd\LawyerbackEnd\Views\Home\CaseStudiesDetails.cshtml"
                                                    Write(Model.Time);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Year</li>\n                                        <li><b>Lawyer:</b> ");
#nullable restore
#line 38 "C:\Users\EMIN\Desktop\lawyersWebsite\LawyerbackEnd\LawyerbackEnd\Views\Home\CaseStudiesDetails.cshtml"
                                                      Write(Model.LawherFullname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n                                        <li><b>Result:</b> $");
#nullable restore
#line 39 "C:\Users\EMIN\Desktop\lawyersWebsite\LawyerbackEnd\LawyerbackEnd\Views\Home\CaseStudiesDetails.cshtml"
                                                       Write(Model.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</li>
                                    </ul>
                                </div>
                            </li>
                            <li class=""widget"">
                                <h5 class=""widgettitle"">Case Studies</h5>
                                <div class=""sidebar widget_recent_entries"">
                                    <ul>
");
#nullable restore
#line 47 "C:\Users\EMIN\Desktop\lawyersWebsite\LawyerbackEnd\LawyerbackEnd\Views\Home\CaseStudiesDetails.cshtml"
                                         foreach (var item in cases)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <li>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "25ea4db1b2e3ba9a48f3fa3ed2d2d154eb17754d11634", async() => {
#nullable restore
#line 49 "C:\Users\EMIN\Desktop\lawyersWebsite\LawyerbackEnd\LawyerbackEnd\Views\Home\CaseStudiesDetails.cshtml"
                                                                                                 Write(item.Title);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 49 "C:\Users\EMIN\Desktop\lawyersWebsite\LawyerbackEnd\LawyerbackEnd\Views\Home\CaseStudiesDetails.cshtml"
                                                                                WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>");
#nullable restore
#line 49 "C:\Users\EMIN\Desktop\lawyersWebsite\LawyerbackEnd\LawyerbackEnd\Views\Home\CaseStudiesDetails.cshtml"
                                                                                                                          }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                    </ul>
                                </div>
                            </li>
                            <li class=""widget"">
                                <div class=""practice-contact"" style=""background-image: url('../assets/images/practice/practice-banner.jpg');""><h5 class=""white"">Need help?</h5><p>Contact us today for a free consultation and our experts will help you.</p><p><strong>Phone:</strong> 1-800-000-111<br><strong>Email:</strong> contact@example.com</p><p><strong>Mon – Fri:</strong> 09:00 -17:00</p></div>
                            </li>
                        </ul>
                    </aside>
                </div>
            </div>
            <!-- /row -->

        </div>
        <!-- /container -->
    </section>
    <!-- /SECTION 1-->
    <!-- SECTION 2-->
    <section class=""section-holder"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-lg-8 offset-lg-2 alignc"">
                    <span class=""heading");
            WriteLiteral(@"-subtitle"">Contact Us</span>
                    <h2 class=""section-heading-title"">Get in Touch</h2>
                </div>
            </div>
            <!-- /row -->
            <div class=""row"">
                <div class=""col-lg-4 alignc"">
                    <div class=""icon-box-icon margin-none""><i class=""fas fa-map-marker-alt""></i></div>
                    <div class=""icon-box-title"">OFFICE</div>
                    <p class=""icon-box-description"">40 Park Ave, Brooklyn, New York</p>
                </div>
                <div class=""col-lg-4 alignc"">
                    <div class=""icon-box-icon margin-none""><i class=""fas fa-phone-alt""></i></div>
                    <div class=""icon-box-title"">PHONE</div>
                    <p class=""icon-box-description"">1-800-000-111</p>
                </div>
                <div class=""col-lg-4 alignc"">
                    <div class=""icon-box-icon margin-none""><i class=""far fa-envelope""></i></div>
                    <div class=""icon-box-title"">EMAIL</div>
    ");
            WriteLiteral("                <p class=\"icon-box-description\">contact@example.com</p>\n                </div>\n\n            </div>\n            <!-- /row -->\n        </div>\n        <!-- /container -->\n    </section>\n    <!-- /SECTION 2-->\n\n</div><!-- /PAGE CONTENT -->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Case> Html { get; private set; }
    }
}
#pragma warning restore 1591
