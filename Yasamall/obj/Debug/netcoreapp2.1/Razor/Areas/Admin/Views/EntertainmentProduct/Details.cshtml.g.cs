#pragma checksum "C:\Users\Lenovo\OneDrive\Desktop\Projects\Yasamall\Yasamall\Areas\Admin\Views\EntertainmentProduct\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a9c0b6c364c8095f60afd65c3ac2b6fff02e146f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_EntertainmentProduct_Details), @"mvc.1.0.view", @"/Areas/Admin/Views/EntertainmentProduct/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/EntertainmentProduct/Details.cshtml", typeof(AspNetCore.Areas_Admin_Views_EntertainmentProduct_Details))]
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
#line 2 "C:\Users\Lenovo\OneDrive\Desktop\Projects\Yasamall\Yasamall\Areas\Admin\Views\_ViewImports.cshtml"
using Yasamall.Models;

#line default
#line hidden
#line 3 "C:\Users\Lenovo\OneDrive\Desktop\Projects\Yasamall\Yasamall\Areas\Admin\Views\_ViewImports.cshtml"
using Yasamall.ViewModel;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9c0b6c364c8095f60afd65c3ac2b6fff02e146f", @"/Areas/Admin/Views/EntertainmentProduct/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4032012f45eb513df75691a0ecfc0ed3978695ef", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_EntertainmentProduct_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Products>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\Lenovo\OneDrive\Desktop\Projects\Yasamall\Yasamall\Areas\Admin\Views\EntertainmentProduct\Details.cshtml"
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(66, 221, true);
            WriteLiteral("\r\n<div class=\"page-container\">\r\n    <div class=\"main-content\">\r\n        <div class=\"section__content section__content--p30\">\r\n            <div class=\"container-fluid\">\r\n                <!-- Start One Product Section -->\r\n");
            EndContext();
#line 12 "C:\Users\Lenovo\OneDrive\Desktop\Projects\Yasamall\Yasamall\Areas\Admin\Views\EntertainmentProduct\Details.cshtml"
                 if (Model.Brands.IsFilm)
                {

#line default
#line hidden
            BeginContext(349, 304, true);
            WriteLiteral(@"                    <section id=""oneFilm"">
                        <div class=""container"">
                            <div class=""row"">
                                <div class=""col-12 col-lg-6"">
                                    <div class=""one-image"">
                                        ");
            EndContext();
            BeginContext(653, 85, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "a9c0b6c364c8095f60afd65c3ac2b6fff02e146f5045", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 663, "~/img/", 663, 6, true);
#line 19 "C:\Users\Lenovo\OneDrive\Desktop\Projects\Yasamall\Yasamall\Areas\Admin\Views\EntertainmentProduct\Details.cshtml"
AddHtmlAttributeValue("", 669, Model.Photos.FirstOrDefault(p => p.IsMain == true).PhotoURL, 669, 60, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(738, 262, true);
            WriteLiteral(@"
                                    </div>
                                </div>
                                <div class=""col-12 col-lg-6"">
                                    <div class=""main-product-info"">
                                        <h4>");
            EndContext();
            BeginContext(1001, 10, false);
#line 24 "C:\Users\Lenovo\OneDrive\Desktop\Projects\Yasamall\Yasamall\Areas\Admin\Views\EntertainmentProduct\Details.cshtml"
                                       Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1011, 96, true);
            WriteLiteral("</h4>\r\n                                        <p>\r\n                                            ");
            EndContext();
            BeginContext(1108, 10, false);
#line 26 "C:\Users\Lenovo\OneDrive\Desktop\Projects\Yasamall\Yasamall\Areas\Admin\Views\EntertainmentProduct\Details.cshtml"
                                       Write(Model.Info);

#line default
#line hidden
            EndContext();
            BeginContext(1118, 261, true);
            WriteLiteral(@"
                                        </p>
                                    </div>
                                    <div class=""main-product-hall"">
                                        <p>Zal :</p>
                                        <span>");
            EndContext();
            BeginContext(1380, 15, false);
#line 31 "C:\Users\Lenovo\OneDrive\Desktop\Projects\Yasamall\Yasamall\Areas\Admin\Views\EntertainmentProduct\Details.cshtml"
                                         Write(Model.Hall.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1395, 169, true);
            WriteLiteral("</span>\r\n                                    </div>\r\n                                    <div class=\"main-product-price\">\r\n                                        <span>");
            EndContext();
            BeginContext(1565, 11, false);
#line 34 "C:\Users\Lenovo\OneDrive\Desktop\Projects\Yasamall\Yasamall\Areas\Admin\Views\EntertainmentProduct\Details.cshtml"
                                         Write(Model.Price);

#line default
#line hidden
            EndContext();
            BeginContext(1576, 193, true);
            WriteLiteral("</span>\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                    </section>\r\n");
            EndContext();
#line 40 "C:\Users\Lenovo\OneDrive\Desktop\Projects\Yasamall\Yasamall\Areas\Admin\Views\EntertainmentProduct\Details.cshtml"

                }
                else
                {

#line default
#line hidden
            BeginContext(1831, 304, true);
            WriteLiteral(@"                    <section id=""oneFilm"">
                        <div class=""container"">
                            <div class=""row"">
                                <div class=""col-12 col-lg-6"">
                                    <div class=""one-image"">
                                        ");
            EndContext();
            BeginContext(2135, 85, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "a9c0b6c364c8095f60afd65c3ac2b6fff02e146f9997", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2145, "~/img/", 2145, 6, true);
#line 49 "C:\Users\Lenovo\OneDrive\Desktop\Projects\Yasamall\Yasamall\Areas\Admin\Views\EntertainmentProduct\Details.cshtml"
AddHtmlAttributeValue("", 2151, Model.Photos.FirstOrDefault(p => p.IsMain == true).PhotoURL, 2151, 60, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2220, 262, true);
            WriteLiteral(@"
                                    </div>
                                </div>
                                <div class=""col-12 col-lg-6"">
                                    <div class=""main-product-info"">
                                        <h4>");
            EndContext();
            BeginContext(2483, 10, false);
#line 54 "C:\Users\Lenovo\OneDrive\Desktop\Projects\Yasamall\Yasamall\Areas\Admin\Views\EntertainmentProduct\Details.cshtml"
                                       Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(2493, 96, true);
            WriteLiteral("</h4>\r\n                                        <p>\r\n                                            ");
            EndContext();
            BeginContext(2590, 10, false);
#line 56 "C:\Users\Lenovo\OneDrive\Desktop\Projects\Yasamall\Yasamall\Areas\Admin\Views\EntertainmentProduct\Details.cshtml"
                                       Write(Model.Info);

#line default
#line hidden
            EndContext();
            BeginContext(2600, 208, true);
            WriteLiteral("\r\n                                        </p>\r\n                                    </div>\r\n                                    <div class=\"main-product-price\">\r\n                                        <span>");
            EndContext();
            BeginContext(2809, 11, false);
#line 60 "C:\Users\Lenovo\OneDrive\Desktop\Projects\Yasamall\Yasamall\Areas\Admin\Views\EntertainmentProduct\Details.cshtml"
                                         Write(Model.Price);

#line default
#line hidden
            EndContext();
            BeginContext(2820, 193, true);
            WriteLiteral("</span>\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                    </section>\r\n");
            EndContext();
#line 66 "C:\Users\Lenovo\OneDrive\Desktop\Projects\Yasamall\Yasamall\Areas\Admin\Views\EntertainmentProduct\Details.cshtml"
                }

#line default
#line hidden
            BeginContext(3032, 110, true);
            WriteLiteral("\r\n                <!-- End One Product Section -->\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Products> Html { get; private set; }
    }
}
#pragma warning restore 1591
