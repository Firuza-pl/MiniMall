#pragma checksum "C:\Users\user\source\repos\Yasamall\Yasamall\Views\Shop\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "157f02589af91b6a35947f535c69ccfef87be542"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shop_Index), @"mvc.1.0.view", @"/Views/Shop/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shop/Index.cshtml", typeof(AspNetCore.Views_Shop_Index))]
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
#line 1 "C:\Users\user\source\repos\Yasamall\Yasamall\Views\_ViewImports.cshtml"
using Yasamall;

#line default
#line hidden
#line 2 "C:\Users\user\source\repos\Yasamall\Yasamall\Views\_ViewImports.cshtml"
using Yasamall.Models;

#line default
#line hidden
#line 4 "C:\Users\user\source\repos\Yasamall\Yasamall\Views\_ViewImports.cshtml"
using Yasamall.ViewModel;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"157f02589af91b6a35947f535c69ccfef87be542", @"/Views/Shop/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"309021642bd299ddbc47725980987baeac659b11", @"/Views/_ViewImports.cshtml")]
    public class Views_Shop_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BrandViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "0", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_ShopPartialView", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(34, 78, true);
            WriteLiteral("\r\n\r\n<!-- Start Main-İmage Section -->\r\n\r\n<input type=\"hidden\" id=\"shopDetails\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 112, "\"", 139, 1);
#line 8 "C:\Users\user\source\repos\Yasamall\Yasamall\Views\Shop\Index.cshtml"
WriteAttributeValue("", 120, ViewBag.TotalCount, 120, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(140, 41, true);
            WriteLiteral(" />\r\n<input type=\"hidden\" id=\"categoryId\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 181, "\"", 208, 1);
#line 9 "C:\Users\user\source\repos\Yasamall\Yasamall\Views\Shop\Index.cshtml"
WriteAttributeValue("", 189, ViewBag.CategoryId, 189, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(209, 547, true);
            WriteLiteral(@" />

<section id=""main-image"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-12 text-center"">
                <div class=""heading-main-image"">
                    <h4>Mağazalar</h4>
                </div>
            </div>
            <div class=""col-12 col-md-2""></div>
            <div class=""col-12 col-md-8"">
                <div class=""form-group"">
                    <label for=""category"">Kateqoriya üzrə axtarış</label>
                    <select id=""category"">
                        ");
            EndContext();
            BeginContext(756, 33, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "497f8147f9ca4c15bdf438a974ef84cd", async() => {
                BeginContext(774, 6, true);
                WriteLiteral("Hamısı");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(789, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 25 "C:\Users\user\source\repos\Yasamall\Yasamall\Views\Shop\Index.cshtml"
                         foreach (var t in Model.Tags)
                        {

#line default
#line hidden
            BeginContext(874, 28, true);
            WriteLiteral("                            ");
            EndContext();
            BeginContext(902, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7c108dadf20245f79d58eea071e35c06", async() => {
                BeginContext(925, 6, false);
#line 27 "C:\Users\user\source\repos\Yasamall\Yasamall\Views\Shop\Index.cshtml"
                                             Write(t.Name);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#line 27 "C:\Users\user\source\repos\Yasamall\Yasamall\Views\Shop\Index.cshtml"
                               WriteLiteral(t.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(940, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 28 "C:\Users\user\source\repos\Yasamall\Yasamall\Views\Shop\Index.cshtml"
                        }

#line default
#line hidden
            BeginContext(969, 392, true);
            WriteLiteral(@"                    </select>
                    <i class=""fad fa-angle-double-down""></i>
                </div>
            </div>
            <div class=""col-12 col-md-2""></div>
        </div>
    </div>
</section>

<!-- End Main İmage Section -->
<!-- Start Store Section -->

<section id=""stores"">
    <div class=""container"">
        <div class=""row shopRow"">
            ");
            EndContext();
            BeginContext(1361, 56, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "85f187b25b0244aaaeedc38ec239f2a2", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#line 44 "C:\Users\user\source\repos\Yasamall\Yasamall\Views\Shop\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = Model.Brands;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1417, 18, true);
            WriteLiteral("\r\n        </div>\r\n");
            EndContext();
#line 46 "C:\Users\user\source\repos\Yasamall\Yasamall\Views\Shop\Index.cshtml"
         if (ViewBag.TotalCount > 8)
        {

#line default
#line hidden
            BeginContext(1484, 276, true);
            WriteLiteral(@"            <div class=""row mt-5"">
                <div class=""col-12 text-center"">
                    <div class=""btn-more btn-shop"">
                        <a href=""#"" id=""load_more"">Daha Çox</a>
                    </div>
                </div>
            </div>
");
            EndContext();
#line 55 "C:\Users\user\source\repos\Yasamall\Yasamall\Views\Shop\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(1771, 54, true);
            WriteLiteral("    </div>\r\n</section>\r\n\r\n<!-- End Store Section -->\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BrandViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
