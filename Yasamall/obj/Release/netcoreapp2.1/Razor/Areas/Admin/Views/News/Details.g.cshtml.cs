#pragma checksum "C:\Users\user\source\repos\Yasamall\Yasamall\Areas\Admin\Views\News\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0c4821ecc4f23441dfb5d52bc8380809db2aca30"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_News_Details), @"mvc.1.0.view", @"/Areas/Admin/Views/News/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/News/Details.cshtml", typeof(AspNetCore.Areas_Admin_Views_News_Details))]
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
#line 2 "C:\Users\user\source\repos\Yasamall\Yasamall\Areas\Admin\Views\_ViewImports.cshtml"
using Yasamall.Models;

#line default
#line hidden
#line 3 "C:\Users\user\source\repos\Yasamall\Yasamall\Areas\Admin\Views\_ViewImports.cshtml"
using Yasamall.ViewModel;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0c4821ecc4f23441dfb5d52bc8380809db2aca30", @"/Areas/Admin/Views/News/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4032012f45eb513df75691a0ecfc0ed3978695ef", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_News_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<News>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger mt-5"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\user\source\repos\Yasamall\Yasamall\Areas\Admin\Views\News\Details.cshtml"
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(62, 675, true);
            WriteLiteral(@"
<div class=""page-container"">
    <div class=""main-content"">
        <div class=""section__content section__content--p30"">
            <div class=""container-fluid"">
                <section class=""wrapper"" style=""padding-bottom:50px;"">
                    <div class=""row"">
                        <div class=""col-3""></div>
                        <div class=""col-6 news-wrapper-slider"">
                            <div class=""news-details-img"">
                                <i class=""fas fa-angle-left arrow-left position-absolute""></i>
                                <div class=""window"">
                                    <ul class=""d-flex slider-lent"">
");
            EndContext();
#line 19 "C:\Users\user\source\repos\Yasamall\Yasamall\Areas\Admin\Views\News\Details.cshtml"
                                         foreach (var p in Model.Photos)
                                        {

#line default
#line hidden
            BeginContext(854, 98, true);
            WriteLiteral("                                            <li>\r\n                                                ");
            EndContext();
            BeginContext(952, 29, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "cf344e074a7d4521a16f7419225453f3", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 962, "~/img/", 962, 6, true);
#line 22 "C:\Users\user\source\repos\Yasamall\Yasamall\Areas\Admin\Views\News\Details.cshtml"
AddHtmlAttributeValue("", 968, p.PhotoURL, 968, 11, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(981, 53, true);
            WriteLiteral("\r\n                                            </li>\r\n");
            EndContext();
#line 24 "C:\Users\user\source\repos\Yasamall\Yasamall\Areas\Admin\Views\News\Details.cshtml"
                                        }

#line default
#line hidden
            BeginContext(1077, 409, true);
            WriteLiteral(@"                                    </ul>
                                </div>
                                <i class=""fas fa-angle-right arrow-right position-absolute""></i>
                            </div>
                        </div>
                        <div class=""col-3""></div>
                        
                        <div class=""col-12 mt-4"">
                            <h3>");
            EndContext();
            BeginContext(1487, 11, false);
#line 33 "C:\Users\user\source\repos\Yasamall\Yasamall\Areas\Admin\Views\News\Details.cshtml"
                           Write(Model.Title);

#line default
#line hidden
            EndContext();
            BeginContext(1498, 51, true);
            WriteLiteral("</h3>\r\n                            <p class=\"mt-5\">");
            EndContext();
            BeginContext(1550, 15, false);
#line 34 "C:\Users\user\source\repos\Yasamall\Yasamall\Areas\Admin\Views\News\Details.cshtml"
                                       Write(Model.ShortInfo);

#line default
#line hidden
            EndContext();
            BeginContext(1565, 37, true);
            WriteLiteral("</p>\r\n                            <p>");
            EndContext();
            BeginContext(1603, 14, false);
#line 35 "C:\Users\user\source\repos\Yasamall\Yasamall\Areas\Admin\Views\News\Details.cshtml"
                          Write(Model.MainInfo);

#line default
#line hidden
            EndContext();
            BeginContext(1617, 37, true);
            WriteLiteral("</p>\r\n                            <p>");
            EndContext();
            BeginContext(1655, 10, false);
#line 36 "C:\Users\user\source\repos\Yasamall\Yasamall\Areas\Admin\Views\News\Details.cshtml"
                          Write(Model.Time);

#line default
#line hidden
            EndContext();
            BeginContext(1665, 293, true);
            WriteLiteral(@"</p>
                        </div>
                    </div>
                    <div class=""nd-content"">
                        
                    </div>

                    <div class=""row"">
                        <div class=""col-12 text-center"">
                            ");
            EndContext();
            BeginContext(1958, 73, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4a94dbd1ffbe4b4e9ca171c2c51934c7", async() => {
                BeginContext(2008, 19, true);
                WriteLiteral("Əsas Səhifəyə qayıt");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2031, 148, true);
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                </section>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<News> Html { get; private set; }
    }
}
#pragma warning restore 1591
