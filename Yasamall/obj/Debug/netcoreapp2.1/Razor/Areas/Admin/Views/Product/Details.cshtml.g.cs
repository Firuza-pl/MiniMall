#pragma checksum "C:\Users\Lenovo\OneDrive\Desktop\Projects\Yasamall\Yasamall\Areas\Admin\Views\Product\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "922e3661b2da3f822f3adae0b3a8fe5ab389c3e6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Product_Details), @"mvc.1.0.view", @"/Areas/Admin/Views/Product/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Product/Details.cshtml", typeof(AspNetCore.Areas_Admin_Views_Product_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"922e3661b2da3f822f3adae0b3a8fe5ab389c3e6", @"/Areas/Admin/Views/Product/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4032012f45eb513df75691a0ecfc0ed3978695ef", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Product_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductsViewModel>
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
#line 4 "C:\Users\Lenovo\OneDrive\Desktop\Projects\Yasamall\Yasamall\Areas\Admin\Views\Product\Details.cshtml"
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(75, 496, true);
            WriteLiteral(@"
<div class=""page-container"">
    <div class=""main-content"">
        <div class=""section__content section__content--p30"">
            <div class=""container-fluid"">
                <section id=""oneProduct"">
                    <div class=""container"">
                        <div class=""row"">
                            <div class=""col-12 col-lg-1"">
                                <div class=""product-slider-images"">
                                    <ul class=""d-flex d-lg-block"">
");
            EndContext();
#line 17 "C:\Users\Lenovo\OneDrive\Desktop\Projects\Yasamall\Yasamall\Areas\Admin\Views\Product\Details.cshtml"
                                         foreach (var p in Model.Product.Photos)
                                        {
                                            if (p.Id == 1)
                                            {

#line default
#line hidden
            BeginContext(803, 80, true);
            WriteLiteral("                                                <li class=\"hover-slider-active\">");
            EndContext();
            BeginContext(883, 36, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "922e3661b2da3f822f3adae0b3a8fe5ab389c3e65149", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 893, "~/img/", 893, 6, true);
#line 21 "C:\Users\Lenovo\OneDrive\Desktop\Projects\Yasamall\Yasamall\Areas\Admin\Views\Product\Details.cshtml"
AddHtmlAttributeValue("", 899, p.PhotoURL, 899, 11, false);

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
            BeginContext(919, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 22 "C:\Users\Lenovo\OneDrive\Desktop\Projects\Yasamall\Yasamall\Areas\Admin\Views\Product\Details.cshtml"

                                            }
                                            else
                                            {

#line default
#line hidden
            BeginContext(1072, 52, true);
            WriteLiteral("                                                <li>");
            EndContext();
            BeginContext(1124, 36, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "922e3661b2da3f822f3adae0b3a8fe5ab389c3e67275", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1134, "~/img/", 1134, 6, true);
#line 26 "C:\Users\Lenovo\OneDrive\Desktop\Projects\Yasamall\Yasamall\Areas\Admin\Views\Product\Details.cshtml"
AddHtmlAttributeValue("", 1140, p.PhotoURL, 1140, 11, false);

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
            BeginContext(1160, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 27 "C:\Users\Lenovo\OneDrive\Desktop\Projects\Yasamall\Yasamall\Areas\Admin\Views\Product\Details.cshtml"
                                            }
                                        }

#line default
#line hidden
            BeginContext(1257, 271, true);
            WriteLiteral(@"                                    </ul>
                                </div>
                            </div>
                            <div class=""col-12 col-lg-6"">
                                <div class=""one-image"">
                                    ");
            EndContext();
            BeginContext(1528, 93, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "922e3661b2da3f822f3adae0b3a8fe5ab389c3e69575", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1538, "~/img/", 1538, 6, true);
#line 34 "C:\Users\Lenovo\OneDrive\Desktop\Projects\Yasamall\Yasamall\Areas\Admin\Views\Product\Details.cshtml"
AddHtmlAttributeValue("", 1544, Model.Product.Photos.FirstOrDefault(p => p.IsMain == true).PhotoURL, 1544, 68, false);

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
            BeginContext(1621, 242, true);
            WriteLiteral("\r\n                                </div>\r\n                            </div>\r\n                            <div class=\"col-12 col-lg-5\">\r\n                                <div class=\"main-product-info\">\r\n                                    <h4>");
            EndContext();
            BeginContext(1864, 25, false);
#line 39 "C:\Users\Lenovo\OneDrive\Desktop\Projects\Yasamall\Yasamall\Areas\Admin\Views\Product\Details.cshtml"
                                   Write(Model.Product.Brands.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1889, 3, true);
            WriteLiteral(" - ");
            EndContext();
            BeginContext(1893, 18, false);
#line 39 "C:\Users\Lenovo\OneDrive\Desktop\Projects\Yasamall\Yasamall\Areas\Admin\Views\Product\Details.cshtml"
                                                                Write(Model.Product.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1911, 88, true);
            WriteLiteral("</h4>\r\n                                    <p>\r\n                                        ");
            EndContext();
            BeginContext(2000, 18, false);
#line 41 "C:\Users\Lenovo\OneDrive\Desktop\Projects\Yasamall\Yasamall\Areas\Admin\Views\Product\Details.cshtml"
                                   Write(Model.Product.Info);

#line default
#line hidden
            EndContext();
            BeginContext(2018, 84, true);
            WriteLiteral("\r\n                                    </p>\r\n                                </div>\r\n");
            EndContext();
#line 44 "C:\Users\Lenovo\OneDrive\Desktop\Projects\Yasamall\Yasamall\Areas\Admin\Views\Product\Details.cshtml"
                                 if (ViewBag.ColorCount > 0)
                                {

#line default
#line hidden
            BeginContext(2199, 207, true);
            WriteLiteral("                                    <div class=\"main-product-color\">\r\n                                        <p>Rənglər :</p>\r\n                                        <div class=\"colors d-flex flex-wrap\">\r\n");
            EndContext();
#line 49 "C:\Users\Lenovo\OneDrive\Desktop\Projects\Yasamall\Yasamall\Areas\Admin\Views\Product\Details.cshtml"
                                             foreach (var c in Model.ProColors)
                                            {

#line default
#line hidden
            BeginContext(2534, 52, true);
            WriteLiteral("                                                <div");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 2586, "\"", 2622, 2);
#line 51 "C:\Users\Lenovo\OneDrive\Desktop\Projects\Yasamall\Yasamall\Areas\Admin\Views\Product\Details.cshtml"
WriteAttributeValue("", 2594, c.Color.ColorCode, 2594, 18, false);

#line default
#line hidden
            WriteAttributeValue(" ", 2612, "color-all", 2613, 10, true);
            EndWriteAttribute();
            BeginContext(2623, 9, true);
            WriteLiteral("></div>\r\n");
            EndContext();
#line 52 "C:\Users\Lenovo\OneDrive\Desktop\Projects\Yasamall\Yasamall\Areas\Admin\Views\Product\Details.cshtml"
                                            }

#line default
#line hidden
            BeginContext(2679, 92, true);
            WriteLiteral("                                        </div>\r\n                                    </div>\r\n");
            EndContext();
#line 55 "C:\Users\Lenovo\OneDrive\Desktop\Projects\Yasamall\Yasamall\Areas\Admin\Views\Product\Details.cshtml"
                                }

#line default
#line hidden
#line 56 "C:\Users\Lenovo\OneDrive\Desktop\Projects\Yasamall\Yasamall\Areas\Admin\Views\Product\Details.cshtml"
                                 if (ViewBag.SizeCount > 0)
                                {

#line default
#line hidden
            BeginContext(2902, 202, true);
            WriteLiteral("                                    <div class=\"main-product-size\">\r\n                                        <p>Ölçü :</p>\r\n                                        <div class=\"sizes d-flex flex-wrap\">\r\n");
            EndContext();
#line 61 "C:\Users\Lenovo\OneDrive\Desktop\Projects\Yasamall\Yasamall\Areas\Admin\Views\Product\Details.cshtml"
                                             foreach (var s in Model.ProSizes)
                                            {

#line default
#line hidden
            BeginContext(3231, 70, true);
            WriteLiteral("                                                <div class=\"size-all\">");
            EndContext();
            BeginContext(3302, 11, false);
#line 63 "C:\Users\Lenovo\OneDrive\Desktop\Projects\Yasamall\Yasamall\Areas\Admin\Views\Product\Details.cshtml"
                                                                 Write(s.Size.Size);

#line default
#line hidden
            EndContext();
            BeginContext(3313, 8, true);
            WriteLiteral("</div>\r\n");
            EndContext();
#line 64 "C:\Users\Lenovo\OneDrive\Desktop\Projects\Yasamall\Yasamall\Areas\Admin\Views\Product\Details.cshtml"
                                            }

#line default
#line hidden
            BeginContext(3368, 92, true);
            WriteLiteral("                                        </div>\r\n                                    </div>\r\n");
            EndContext();
#line 67 "C:\Users\Lenovo\OneDrive\Desktop\Projects\Yasamall\Yasamall\Areas\Admin\Views\Product\Details.cshtml"
                                }

#line default
#line hidden
            BeginContext(3495, 110, true);
            WriteLiteral("\r\n                                <div class=\"main-product-price\">\r\n                                    <span>");
            EndContext();
            BeginContext(3606, 19, false);
#line 70 "C:\Users\Lenovo\OneDrive\Desktop\Projects\Yasamall\Yasamall\Areas\Admin\Views\Product\Details.cshtml"
                                     Write(Model.Product.Price);

#line default
#line hidden
            EndContext();
            BeginContext(3625, 235, true);
            WriteLiteral(" AZN</span>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </section>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
