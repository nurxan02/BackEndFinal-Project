#pragma checksum "C:\Users\nmasi\Desktop\BackEndProject-NurkhanMasimzade\EduHomeFinal-master\Views\Shared\Components\Course\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5c9f57e3fb94da08a1344947947b18e478413215"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(EduHomeFinal.Pages.Shared.Components.Course.Views_Shared_Components_Course_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Course/Default.cshtml")]
namespace EduHomeFinal.Pages.Shared.Components.Course
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
#line 1 "C:\Users\nmasi\Desktop\BackEndProject-NurkhanMasimzade\EduHomeFinal-master\Views\_ViewImports.cshtml"
using EduHomeFinal.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5c9f57e3fb94da08a1344947947b18e478413215", @"/Views/Shared/Components/Course/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0f1efb2ea291fd9568cc719994fe1984c6624b26", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Course_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Courses>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("course"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("<div class=\"row\">\n");
#nullable restore
#line 3 "C:\Users\nmasi\Desktop\BackEndProject-NurkhanMasimzade\EduHomeFinal-master\Views\Shared\Components\Course\Default.cshtml"
     foreach (Courses courses in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"col-md-4 col-sm-6 col-xs-12\">\n            <div class=\"single-course mb-70\">\n                <div class=\"course-img\">\n                    <a>\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "5c9f57e3fb94da08a1344947947b18e4784132153975", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 287, "~/Assets/img/course/", 287, 20, true);
#nullable restore
#line 9 "C:\Users\nmasi\Desktop\BackEndProject-NurkhanMasimzade\EduHomeFinal-master\Views\Shared\Components\Course\Default.cshtml"
AddHtmlAttributeValue("", 307, courses.Image, 307, 14, false);

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
            WriteLiteral(@"
                        <div class=""course-hover"">
                            <i class=""fa fa-link""></i>
                        </div>
                    </a>
                </div>
                <div class=""course-content"">
                    
                    <h3><a");
            BeginWriteAttribute("href", " href=\"", 614, "\"", 647, 2);
            WriteAttributeValue("", 621, "/Course/Detail/", 621, 15, true);
#nullable restore
#line 17 "C:\Users\nmasi\Desktop\BackEndProject-NurkhanMasimzade\EduHomeFinal-master\Views\Shared\Components\Course\Default.cshtml"
WriteAttributeValue("", 636, courses.Id, 636, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 17 "C:\Users\nmasi\Desktop\BackEndProject-NurkhanMasimzade\EduHomeFinal-master\Views\Shared\Components\Course\Default.cshtml"
                                                        Write(courses.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h3>\n                    <p>");
#nullable restore
#line 18 "C:\Users\nmasi\Desktop\BackEndProject-NurkhanMasimzade\EduHomeFinal-master\Views\Shared\Components\Course\Default.cshtml"
                  Write(courses.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                    <a class=\"default-btn\"");
            BeginWriteAttribute("href", " href=\"", 762, "\"", 795, 2);
            WriteAttributeValue("", 769, "/Course/Detail/", 769, 15, true);
#nullable restore
#line 19 "C:\Users\nmasi\Desktop\BackEndProject-NurkhanMasimzade\EduHomeFinal-master\Views\Shared\Components\Course\Default.cshtml"
WriteAttributeValue("", 784, courses.Id, 784, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">read more</a>\n                </div>\n            </div>\n        </div>\n");
#nullable restore
#line 23 "C:\Users\nmasi\Desktop\BackEndProject-NurkhanMasimzade\EduHomeFinal-master\Views\Shared\Components\Course\Default.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Courses>> Html { get; private set; }
    }
}
#pragma warning restore 1591
