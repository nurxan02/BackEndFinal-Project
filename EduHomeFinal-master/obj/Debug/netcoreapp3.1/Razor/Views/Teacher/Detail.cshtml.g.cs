#pragma checksum "C:\Users\nmasi\Desktop\Back-end-2021-main\EduHomeFinal-master\Views\Teacher\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "107e6b2f5fd6d373685a8d4122c548e980eef81f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(EduHomeFinal.Pages.Teacher.Views_Teacher_Detail), @"mvc.1.0.view", @"/Views/Teacher/Detail.cshtml")]
namespace EduHomeFinal.Pages.Teacher
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
#line 1 "C:\Users\nmasi\Desktop\Back-end-2021-main\EduHomeFinal-master\Views\_ViewImports.cshtml"
using EduHomeFinal.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"107e6b2f5fd6d373685a8d4122c548e980eef81f", @"/Views/Teacher/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0f1efb2ea291fd9568cc719994fe1984c6624b26", @"/Views/_ViewImports.cshtml")]
    public class Views_Teacher_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Teacher>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("teacher"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "C:\Users\nmasi\Desktop\Back-end-2021-main\EduHomeFinal-master\Views\Teacher\Detail.cshtml"
  
    Layout = "~/Views/Shared/_Layout2.cshtml";
    ViewData["Title"] = "Detail";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- Banner Area Start -->
<div class=""banner-area-wrapper"">
    <div class=""banner-area text-center"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-xs-12"">
                    <div class=""banner-content-wrapper"">
                        <div class=""banner-content"">
                            <h2>teachers / details</h2>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
<!-- Banner Area End -->
<!-- Teacher Start -->
<div class=""teacher-details-area pt-150 pb-60"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-5 col-sm-5 col-xs-12"">
                <div class=""teacher-details-img"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "107e6b2f5fd6d373685a8d4122c548e980eef81f4377", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 890, "~/Assets/img/teacher/", 890, 21, true);
#nullable restore
#line 30 "C:\Users\nmasi\Desktop\Back-end-2021-main\EduHomeFinal-master\Views\Teacher\Detail.cshtml"
AddHtmlAttributeValue("", 911, Model.Image, 911, 12, false);

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
            WriteLiteral("\n                </div>\n            </div>\n            <div class=\"col-md-7 col-sm-7 col-xs-12\">\n                <div class=\"teacher-details-content ml-50\">\n                    <h2>");
#nullable restore
#line 35 "C:\Users\nmasi\Desktop\Back-end-2021-main\EduHomeFinal-master\Views\Teacher\Detail.cshtml"
                   Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\n                    <h5>");
#nullable restore
#line 36 "C:\Users\nmasi\Desktop\Back-end-2021-main\EduHomeFinal-master\Views\Teacher\Detail.cshtml"
                   Write(Model.Profession);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\n                    <h4>about me</h4>\n                    <p>");
#nullable restore
#line 38 "C:\Users\nmasi\Desktop\Back-end-2021-main\EduHomeFinal-master\Views\Teacher\Detail.cshtml"
                  Write(Model.AboutMe);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                    <ul>\n                        <li><span>degree: </span>");
#nullable restore
#line 40 "C:\Users\nmasi\Desktop\Back-end-2021-main\EduHomeFinal-master\Views\Teacher\Detail.cshtml"
                                            Write(Model.Degree);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n                        <li><span>experience: </span>");
#nullable restore
#line 41 "C:\Users\nmasi\Desktop\Back-end-2021-main\EduHomeFinal-master\Views\Teacher\Detail.cshtml"
                                                Write(Model.Experience);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n                        <li><span>hobbies: </span>");
#nullable restore
#line 42 "C:\Users\nmasi\Desktop\Back-end-2021-main\EduHomeFinal-master\Views\Teacher\Detail.cshtml"
                                             Write(Model.Hobbies);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n                        <li><span>faculty: </span>");
#nullable restore
#line 43 "C:\Users\nmasi\Desktop\Back-end-2021-main\EduHomeFinal-master\Views\Teacher\Detail.cshtml"
                                             Write(Model.Faculty);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</li>
                    </ul>
                </div>
            </div>
        </div>
        <div class=""row"">
            <div class=""col-md-3 col-sm-4"">
                <div class=""teacher-contact"">
                    <h4>contact information</h4>
                    <p><span>mail me : </span>");
#nullable restore
#line 52 "C:\Users\nmasi\Desktop\Back-end-2021-main\EduHomeFinal-master\Views\Teacher\Detail.cshtml"
                                         Write(Model.Mail);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                    <p><span>make a call : </span>");
#nullable restore
#line 53 "C:\Users\nmasi\Desktop\Back-end-2021-main\EduHomeFinal-master\Views\Teacher\Detail.cshtml"
                                             Write(Model.ContactTel);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                    <p><span>skype : </span>");
#nullable restore
#line 54 "C:\Users\nmasi\Desktop\Back-end-2021-main\EduHomeFinal-master\Views\Teacher\Detail.cshtml"
                                       Write(Model.Skype);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                    <ul>\n                        <li><a");
            BeginWriteAttribute("href", " href=\"", 2071, "\"", 2093, 1);
#nullable restore
#line 56 "C:\Users\nmasi\Desktop\Back-end-2021-main\EduHomeFinal-master\Views\Teacher\Detail.cshtml"
WriteAttributeValue("", 2078, Model.Facebook, 2078, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"zmdi zmdi-facebook\"></i></a></li>\n                        <li><a");
            BeginWriteAttribute("href", " href=\"", 2169, "\"", 2192, 1);
#nullable restore
#line 57 "C:\Users\nmasi\Desktop\Back-end-2021-main\EduHomeFinal-master\Views\Teacher\Detail.cshtml"
WriteAttributeValue("", 2176, Model.Pinterest, 2176, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"zmdi zmdi-pinterest\"></i></a></li>\n                        <li><a href=\"#\"><i class=\"zmdi zmdi-vimeo\"></i></a></li>\n                        <li><a");
            BeginWriteAttribute("href", " href=\"", 2350, "\"", 2371, 1);
#nullable restore
#line 59 "C:\Users\nmasi\Desktop\Back-end-2021-main\EduHomeFinal-master\Views\Teacher\Detail.cshtml"
WriteAttributeValue("", 2357, Model.Twitter, 2357, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@"><i class=""zmdi zmdi-twitter""></i></a></li>
                    </ul>
                </div>
            </div>
            <div class=""col-md-9 col-sm-8"">
                <div class=""skill-area"">
                    <h4>skills</h4>
                </div>
                <div class=""skill-wrapper"">
                    <div class=""row"">
                        <div class=""col-sm-4"">
                            <div class=""skill-bar-item"">
                                <span>language</span>
                                <div class=""progress"">
                                    <div data-wow-delay=""1.2s"" data-wow-duration=""1.5s"" style=""width: 85%; visibility: visible; animation-duration: 1.5s; animation-delay: 1.2s; animation-name: fadeInLeft;"" data-progress=""50%"" class=""progress-bar wow fadeInLeft"">
                                        <span class=""text-top"">");
#nullable restore
#line 74 "C:\Users\nmasi\Desktop\Back-end-2021-main\EduHomeFinal-master\Views\Teacher\Detail.cshtml"
                                                          Write(Model.Skills.Language);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"%</span>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class=""col-sm-4"">
                            <div class=""skill-bar-item"">
                                <span>team leader</span>
                                <div class=""progress"">
                                    <div data-wow-delay=""1.2s"" data-wow-duration=""1.5s"" style=""width: 90%; visibility: visible; animation-duration: 1.5s; animation-delay: 1.2s; animation-name: fadeInLeft;"" data-progress=""50%"" class=""progress-bar wow fadeInLeft"">
                                        <span class=""text-top"">");
#nullable restore
#line 84 "C:\Users\nmasi\Desktop\Back-end-2021-main\EduHomeFinal-master\Views\Teacher\Detail.cshtml"
                                                          Write(Model.Skills.TeamLeader);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"%</span>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class=""col-sm-4"">
                            <div class=""skill-bar-item"">
                                <span>development</span>
                                <div class=""progress"">
                                    <div data-wow-delay=""1.2s"" data-wow-duration=""1.5s"" style=""width: 85%; visibility: visible; animation-duration: 1.5s; animation-delay: 1.2s; animation-name: fadeInLeft;"" data-progress=""50%"" class=""progress-bar wow fadeInLeft"">
                                        <span class=""text-top"">");
#nullable restore
#line 94 "C:\Users\nmasi\Desktop\Back-end-2021-main\EduHomeFinal-master\Views\Teacher\Detail.cshtml"
                                                          Write(Model.Skills.Development);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"%</span>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class=""col-sm-4"">
                            <div class=""skill-bar-item"">
                                <span>design</span>
                                <div class=""progress"">
                                    <div data-wow-delay=""1.2s"" data-wow-duration=""1.5s"" style=""width: 95%; visibility: visible; animation-duration: 1.5s; animation-delay: 1.2s; animation-name: fadeInLeft;"" data-progress=""50%"" class=""progress-bar wow fadeInLeft"">
                                        <span class=""text-top"">");
#nullable restore
#line 104 "C:\Users\nmasi\Desktop\Back-end-2021-main\EduHomeFinal-master\Views\Teacher\Detail.cshtml"
                                                          Write(Model.Skills.Design);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"%</span>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class=""col-sm-4"">
                            <div class=""skill-bar-item"">
                                <span>innovation</span>
                                <div class=""progress"">
                                    <div data-wow-delay=""1.2s"" data-wow-duration=""1.5s"" style=""width: 85%; visibility: visible; animation-duration: 1.5s; animation-delay: 1.2s; animation-name: fadeInLeft;"" data-progress=""50%"" class=""progress-bar wow fadeInLeft"">
                                        <span class=""text-top"">");
#nullable restore
#line 114 "C:\Users\nmasi\Desktop\Back-end-2021-main\EduHomeFinal-master\Views\Teacher\Detail.cshtml"
                                                          Write(Model.Skills.Innovation);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"%</span>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class=""col-sm-4"">
                            <div class=""skill-bar-item"">
                                <span>communication</span>
                                <div class=""progress"">
                                    <div data-wow-delay=""1.2s"" data-wow-duration=""1.5s"" style=""width: 95%; visibility: visible; animation-duration: 1.5s; animation-delay: 1.2s; animation-name: fadeInLeft;"" data-progress=""50%"" class=""progress-bar wow fadeInLeft"">
                                        <span class=""text-top"">");
#nullable restore
#line 124 "C:\Users\nmasi\Desktop\Back-end-2021-main\EduHomeFinal-master\Views\Teacher\Detail.cshtml"
                                                          Write(Model.Skills.Communication);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"%</span>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
<!-- Teacher End -->
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Teacher> Html { get; private set; }
    }
}
#pragma warning restore 1591