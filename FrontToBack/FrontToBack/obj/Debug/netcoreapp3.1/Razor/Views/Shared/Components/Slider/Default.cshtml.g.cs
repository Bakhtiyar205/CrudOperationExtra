#pragma checksum "C:\Users\Baxtiyar\Documents\Code Academy Back Asp\Lesson10CrudExtraSlider\FrontToBack\FrontToBack\Views\Shared\Components\Slider\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f759e68ae53e112e7316a1d03f4bc05d2e7d096a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Slider_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Slider/Default.cshtml")]
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
#line 1 "C:\Users\Baxtiyar\Documents\Code Academy Back Asp\Lesson10CrudExtraSlider\FrontToBack\FrontToBack\Views\_ViewImports.cshtml"
using FrontToBack;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Baxtiyar\Documents\Code Academy Back Asp\Lesson10CrudExtraSlider\FrontToBack\FrontToBack\Views\_ViewImports.cshtml"
using FrontToBack.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Baxtiyar\Documents\Code Academy Back Asp\Lesson10CrudExtraSlider\FrontToBack\FrontToBack\Views\_ViewImports.cshtml"
using FrontToBack.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f759e68ae53e112e7316a1d03f4bc05d2e7d096a", @"/Views/Shared/Components/Slider/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"81052c4d0d671e0e46db3449fbc1cb187fb05a64", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Slider_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Slider>>
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
            WriteLiteral("\r\n\r\n\r\n");
#nullable restore
#line 5 "C:\Users\Baxtiyar\Documents\Code Academy Back Asp\Lesson10CrudExtraSlider\FrontToBack\FrontToBack\Views\Shared\Components\Slider\Default.cshtml"
 foreach (var slider in Model)
{


#line default
#line hidden
#nullable disable
            WriteLiteral("            <div");
            BeginWriteAttribute("class", " class=\"", 80, "\"", 116, 1);
#nullable restore
#line 8 "C:\Users\Baxtiyar\Documents\Code Academy Back Asp\Lesson10CrudExtraSlider\FrontToBack\FrontToBack\Views\Shared\Components\Slider\Default.cshtml"
WriteAttributeValue("", 88, slider.ClassName?.ToLower(), 88, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "f759e68ae53e112e7316a1d03f4bc05d2e7d096a4683", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 146, "~/assets/img/", 146, 13, true);
#nullable restore
#line 9 "C:\Users\Baxtiyar\Documents\Code Academy Back Asp\Lesson10CrudExtraSlider\FrontToBack\FrontToBack\Views\Shared\Components\Slider\Default.cshtml"
AddHtmlAttributeValue("", 159, slider.Image, 159, 13, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                <div class=\"text-1\">\r\n                    <p>Exclusive offer <span class=\"btn-success discount-text\">&nbsp; ");
#nullable restore
#line 11 "C:\Users\Baxtiyar\Documents\Code Academy Back Asp\Lesson10CrudExtraSlider\FrontToBack\FrontToBack\Views\Shared\Components\Slider\Default.cshtml"
                                                                                 Write(slider.Discount);

#line default
#line hidden
#nullable disable
            WriteLiteral("% off &nbsp; </span></p>\r\n                    ");
#nullable restore
#line 12 "C:\Users\Baxtiyar\Documents\Code Academy Back Asp\Lesson10CrudExtraSlider\FrontToBack\FrontToBack\Views\Shared\Components\Slider\Default.cshtml"
               Write(Html.Raw(slider.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    <p>");
#nullable restore
#line 13 "C:\Users\Baxtiyar\Documents\Code Academy Back Asp\Lesson10CrudExtraSlider\FrontToBack\FrontToBack\Views\Shared\Components\Slider\Default.cshtml"
                  Write(slider.SubTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <span>from</span>\r\n                    <span class=\"text-danger price\">$");
#nullable restore
#line 15 "C:\Users\Baxtiyar\Documents\Code Academy Back Asp\Lesson10CrudExtraSlider\FrontToBack\FrontToBack\Views\Shared\Components\Slider\Default.cshtml"
                                                Write(slider.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                    <button class=\"btn btn-primary\">Shop Now <i class=\"fa-solid fa-right-long\"></i></button>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 19 "C:\Users\Baxtiyar\Documents\Code Academy Back Asp\Lesson10CrudExtraSlider\FrontToBack\FrontToBack\Views\Shared\Components\Slider\Default.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Slider>> Html { get; private set; }
    }
}
#pragma warning restore 1591
