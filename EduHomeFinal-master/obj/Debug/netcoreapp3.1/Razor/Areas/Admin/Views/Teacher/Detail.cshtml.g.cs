#pragma checksum "C:\Users\nmasi\Desktop\BackEndProject-NurkhanMasimzade\EduHomeFinal-master\Areas\Admin\Views\Teacher\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "39cbf9e028336f851feb171e09ec2fe78c67bb10"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(EduHomeFinal.Pages.Teacher.Areas_Admin_Views_Teacher_Detail), @"mvc.1.0.view", @"/Areas/Admin/Views/Teacher/Detail.cshtml")]
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
#line 1 "C:\Users\nmasi\Desktop\BackEndProject-NurkhanMasimzade\EduHomeFinal-master\Areas\Admin\Views\_ViewImports.cshtml"
using EduHomeFinal.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"39cbf9e028336f851feb171e09ec2fe78c67bb10", @"/Areas/Admin/Views/Teacher/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a94b6dc578955b86a7aec7612713f5e0a68a8249", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Teacher_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Teacher>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/et-line-icon.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/ionicons.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/material-design-iconic-font.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/font-awesome.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/style.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:300px;height:400px;object-fit:cover;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("teacher"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Teacher", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary  w-25"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("float:right!important;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\nmasi\Desktop\BackEndProject-NurkhanMasimzade\EduHomeFinal-master\Areas\Admin\Views\Teacher\Detail.cshtml"
  
    ViewData["Title"] = "Detail";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            DefineSection("style", async() => {
                WriteLiteral("\n\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "39cbf9e028336f851feb171e09ec2fe78c67bb108072", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "39cbf9e028336f851feb171e09ec2fe78c67bb109248", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "39cbf9e028336f851feb171e09ec2fe78c67bb1010425", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "39cbf9e028336f851feb171e09ec2fe78c67bb1011603", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "39cbf9e028336f851feb171e09ec2fe78c67bb1012781", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n\n\n");
            }
            );
            WriteLiteral("<!-- Teacher Start -->\n<div class=\"teacher-details-area pt-150 pb-60\">\n    <div class=\"container\">\n        <div class=\"row\">\n            <div class=\"col-md-4 col-sm-5 col-xs-12\">\n                <div class=\"teacher-details-img\">\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "39cbf9e028336f851feb171e09ec2fe78c67bb1014282", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 643, "~/Assets/img/teacher/", 643, 21, true);
#nullable restore
#line 22 "C:\Users\nmasi\Desktop\BackEndProject-NurkhanMasimzade\EduHomeFinal-master\Areas\Admin\Views\Teacher\Detail.cshtml"
AddHtmlAttributeValue("", 664, Model.Image, 664, 12, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                </div>\n            </div>\n            <div class=\"col-md-8 col-sm-7 col-xs-12\">\n                <div class=\"teacher-details-content ml-50 \">\n                    <h2 class=\"text-black\">");
#nullable restore
#line 27 "C:\Users\nmasi\Desktop\BackEndProject-NurkhanMasimzade\EduHomeFinal-master\Areas\Admin\Views\Teacher\Detail.cshtml"
                                      Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\n                    <h5>");
#nullable restore
#line 28 "C:\Users\nmasi\Desktop\BackEndProject-NurkhanMasimzade\EduHomeFinal-master\Areas\Admin\Views\Teacher\Detail.cshtml"
                   Write(Model.Profession);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\n                    <h4 class=\"text-black\">About me</h4>\n                    <p>");
#nullable restore
#line 30 "C:\Users\nmasi\Desktop\BackEndProject-NurkhanMasimzade\EduHomeFinal-master\Areas\Admin\Views\Teacher\Detail.cshtml"
                  Write(Model.AboutMe);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\n                    <ul>\n                        <li><span class=\"text-black\">Degree: </span>");
#nullable restore
#line 32 "C:\Users\nmasi\Desktop\BackEndProject-NurkhanMasimzade\EduHomeFinal-master\Areas\Admin\Views\Teacher\Detail.cshtml"
                                                               Write(Model.Degree);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n                        <li><span class=\"text-black\">Experience: </span>");
#nullable restore
#line 33 "C:\Users\nmasi\Desktop\BackEndProject-NurkhanMasimzade\EduHomeFinal-master\Areas\Admin\Views\Teacher\Detail.cshtml"
                                                                   Write(Model.Experience);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n                        <li><span class=\"text-black\">Hobbies: </span>");
#nullable restore
#line 34 "C:\Users\nmasi\Desktop\BackEndProject-NurkhanMasimzade\EduHomeFinal-master\Areas\Admin\Views\Teacher\Detail.cshtml"
                                                                Write(Model.Hobbies);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n                        <li><span class=\"text-black\">Faculty: </span>");
#nullable restore
#line 35 "C:\Users\nmasi\Desktop\BackEndProject-NurkhanMasimzade\EduHomeFinal-master\Areas\Admin\Views\Teacher\Detail.cshtml"
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
                    <h4 class=""text-black"">Contact Information</h4>
                    <p><span class=""text-black"">Mail me : </span>");
#nullable restore
#line 44 "C:\Users\nmasi\Desktop\BackEndProject-NurkhanMasimzade\EduHomeFinal-master\Areas\Admin\Views\Teacher\Detail.cshtml"
                                                            Write(Model.Mail);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                    <p><span class=\"text-black\">Make a call : </span>");
#nullable restore
#line 45 "C:\Users\nmasi\Desktop\BackEndProject-NurkhanMasimzade\EduHomeFinal-master\Areas\Admin\Views\Teacher\Detail.cshtml"
                                                                Write(Model.ContactTel);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                    <p><span class=\"text-black\">Skype : </span>");
#nullable restore
#line 46 "C:\Users\nmasi\Desktop\BackEndProject-NurkhanMasimzade\EduHomeFinal-master\Areas\Admin\Views\Teacher\Detail.cshtml"
                                                          Write(Model.Skype);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                    <ul>\n                        <li><a");
            BeginWriteAttribute("href", " href=\"", 2067, "\"", 2089, 1);
#nullable restore
#line 48 "C:\Users\nmasi\Desktop\BackEndProject-NurkhanMasimzade\EduHomeFinal-master\Areas\Admin\Views\Teacher\Detail.cshtml"
WriteAttributeValue("", 2074, Model.Facebook, 2074, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"zmdi zmdi-facebook\"></i></a></li>\n                        <li><a");
            BeginWriteAttribute("href", " href=\"", 2165, "\"", 2188, 1);
#nullable restore
#line 49 "C:\Users\nmasi\Desktop\BackEndProject-NurkhanMasimzade\EduHomeFinal-master\Areas\Admin\Views\Teacher\Detail.cshtml"
WriteAttributeValue("", 2172, Model.Pinterest, 2172, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"zmdi zmdi-pinterest\"></i></a></li>\n                        <li><a href=\"#\"><i class=\"zmdi zmdi-vimeo\"></i></a></li>\n                        <li><a");
            BeginWriteAttribute("href", " href=\"", 2346, "\"", 2367, 1);
#nullable restore
#line 51 "C:\Users\nmasi\Desktop\BackEndProject-NurkhanMasimzade\EduHomeFinal-master\Areas\Admin\Views\Teacher\Detail.cshtml"
WriteAttributeValue("", 2353, Model.Twitter, 2353, 14, false);

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
                    <h4 class=""text-black"">Skills</h4>
                </div>
                <div class=""skill-wrapper"">
                    <div class=""row"">
                        <div class=""col-sm-4"">
                            <div class=""skill-bar-item"">
                                <span class=""text-black"">Language</span>
                                <div class=""progress"">
                                    <div data-wow-delay=""1.2s"" data-wow-duration=""1.5s""");
            BeginWriteAttribute("style", " style=\"", 3044, "\"", 3183, 11);
            WriteAttributeValue("", 3052, "width:", 3052, 6, true);
#nullable restore
#line 65 "C:\Users\nmasi\Desktop\BackEndProject-NurkhanMasimzade\EduHomeFinal-master\Areas\Admin\Views\Teacher\Detail.cshtml"
WriteAttributeValue(" ", 3058, Model.Skills.Language, 3059, 24, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3083, "%;", 3083, 2, true);
            WriteAttributeValue(" ", 3085, "visibility:", 3086, 12, true);
            WriteAttributeValue(" ", 3097, "visible;", 3098, 9, true);
            WriteAttributeValue(" ", 3106, "animation-duration:", 3107, 20, true);
            WriteAttributeValue(" ", 3126, "1.5s;", 3127, 6, true);
            WriteAttributeValue(" ", 3132, "animation-delay:", 3133, 17, true);
            WriteAttributeValue(" ", 3149, "1.2s;", 3150, 6, true);
            WriteAttributeValue(" ", 3155, "animation-name:", 3156, 16, true);
            WriteAttributeValue(" ", 3171, "fadeInLeft;", 3172, 12, true);
            EndWriteAttribute();
            WriteLiteral(" data-progress=\"50%\" class=\"progress-bar wow fadeInLeft\">\n                                        <span class=\"text-top\">");
#nullable restore
#line 66 "C:\Users\nmasi\Desktop\BackEndProject-NurkhanMasimzade\EduHomeFinal-master\Areas\Admin\Views\Teacher\Detail.cshtml"
                                                          Write(Model.Skills.Language);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class=""col-sm-4"">
                            <div class=""skill-bar-item"">
                                <span class=""text-black"">Team Leader</span>
                                <div class=""progress"">
                                    <div data-wow-delay=""1.2s"" data-wow-duration=""1.5s""");
            BeginWriteAttribute("style", " style=\"", 3805, "\"", 3946, 11);
            WriteAttributeValue("", 3813, "width:", 3813, 6, true);
#nullable restore
#line 75 "C:\Users\nmasi\Desktop\BackEndProject-NurkhanMasimzade\EduHomeFinal-master\Areas\Admin\Views\Teacher\Detail.cshtml"
WriteAttributeValue(" ", 3819, Model.Skills.TeamLeader, 3820, 26, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3846, "%;", 3846, 2, true);
            WriteAttributeValue(" ", 3848, "visibility:", 3849, 12, true);
            WriteAttributeValue(" ", 3860, "visible;", 3861, 9, true);
            WriteAttributeValue(" ", 3869, "animation-duration:", 3870, 20, true);
            WriteAttributeValue(" ", 3889, "1.5s;", 3890, 6, true);
            WriteAttributeValue(" ", 3895, "animation-delay:", 3896, 17, true);
            WriteAttributeValue(" ", 3912, "1.2s;", 3913, 6, true);
            WriteAttributeValue(" ", 3918, "animation-name:", 3919, 16, true);
            WriteAttributeValue(" ", 3934, "fadeInLeft;", 3935, 12, true);
            EndWriteAttribute();
            WriteLiteral(" data-progress=\"50%\" class=\"progress-bar wow fadeInLeft\">\n                                        <span class=\"text-top\">");
#nullable restore
#line 76 "C:\Users\nmasi\Desktop\BackEndProject-NurkhanMasimzade\EduHomeFinal-master\Areas\Admin\Views\Teacher\Detail.cshtml"
                                                          Write(Model.Skills.TeamLeader);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class=""col-sm-4"">
                            <div class=""skill-bar-item"">
                                <span class=""text-black"">Development</span>
                                <div class=""progress"">
                                    <div data-wow-delay=""1.2s"" data-wow-duration=""1.5s""");
            BeginWriteAttribute("style", " style=\"", 4570, "\"", 4712, 11);
            WriteAttributeValue("", 4578, "width:", 4578, 6, true);
#nullable restore
#line 85 "C:\Users\nmasi\Desktop\BackEndProject-NurkhanMasimzade\EduHomeFinal-master\Areas\Admin\Views\Teacher\Detail.cshtml"
WriteAttributeValue(" ", 4584, Model.Skills.Development, 4585, 27, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4612, "%;", 4612, 2, true);
            WriteAttributeValue(" ", 4614, "visibility:", 4615, 12, true);
            WriteAttributeValue(" ", 4626, "visible;", 4627, 9, true);
            WriteAttributeValue(" ", 4635, "animation-duration:", 4636, 20, true);
            WriteAttributeValue(" ", 4655, "1.5s;", 4656, 6, true);
            WriteAttributeValue(" ", 4661, "animation-delay:", 4662, 17, true);
            WriteAttributeValue(" ", 4678, "1.2s;", 4679, 6, true);
            WriteAttributeValue(" ", 4684, "animation-name:", 4685, 16, true);
            WriteAttributeValue(" ", 4700, "fadeInLeft;", 4701, 12, true);
            EndWriteAttribute();
            WriteLiteral(" data-progress=\"50%\" class=\"progress-bar wow fadeInLeft\">\n                                        <span class=\"text-top\">");
#nullable restore
#line 86 "C:\Users\nmasi\Desktop\BackEndProject-NurkhanMasimzade\EduHomeFinal-master\Areas\Admin\Views\Teacher\Detail.cshtml"
                                                          Write(Model.Skills.Development);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class=""col-sm-4"">
                            <div class=""skill-bar-item"">
                                <span class=""text-black"">Design</span>
                                <div class=""progress"">
                                    <div data-wow-delay=""1.2s"" data-wow-duration=""1.5s""");
            BeginWriteAttribute("style", " style=\"", 5332, "\"", 5468, 11);
            WriteAttributeValue("", 5340, "width:", 5340, 6, true);
#nullable restore
#line 95 "C:\Users\nmasi\Desktop\BackEndProject-NurkhanMasimzade\EduHomeFinal-master\Areas\Admin\Views\Teacher\Detail.cshtml"
WriteAttributeValue("", 5346, Model.Skills.Design, 5346, 22, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5368, "%;", 5368, 2, true);
            WriteAttributeValue(" ", 5370, "visibility:", 5371, 12, true);
            WriteAttributeValue(" ", 5382, "visible;", 5383, 9, true);
            WriteAttributeValue(" ", 5391, "animation-duration:", 5392, 20, true);
            WriteAttributeValue(" ", 5411, "1.5s;", 5412, 6, true);
            WriteAttributeValue(" ", 5417, "animation-delay:", 5418, 17, true);
            WriteAttributeValue(" ", 5434, "1.2s;", 5435, 6, true);
            WriteAttributeValue(" ", 5440, "animation-name:", 5441, 16, true);
            WriteAttributeValue(" ", 5456, "fadeInLeft;", 5457, 12, true);
            EndWriteAttribute();
            WriteLiteral(" data-progress=\"50%\" class=\"progress-bar wow fadeInLeft\">\n                                        <span class=\"text-top\">");
#nullable restore
#line 96 "C:\Users\nmasi\Desktop\BackEndProject-NurkhanMasimzade\EduHomeFinal-master\Areas\Admin\Views\Teacher\Detail.cshtml"
                                                          Write(Model.Skills.Design);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class=""col-sm-4"">
                            <div class=""skill-bar-item"">
                                <span class=""text-black"">Innovation</span>
                                <div class=""progress"">
                                    <div data-wow-delay=""1.2s"" data-wow-duration=""1.5s""");
            BeginWriteAttribute("style", " style=\"", 6087, "\"", 6228, 11);
            WriteAttributeValue("", 6095, "width:", 6095, 6, true);
#nullable restore
#line 105 "C:\Users\nmasi\Desktop\BackEndProject-NurkhanMasimzade\EduHomeFinal-master\Areas\Admin\Views\Teacher\Detail.cshtml"
WriteAttributeValue(" ", 6101, Model.Skills.Innovation, 6102, 26, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 6128, "%;", 6128, 2, true);
            WriteAttributeValue(" ", 6130, "visibility:", 6131, 12, true);
            WriteAttributeValue(" ", 6142, "visible;", 6143, 9, true);
            WriteAttributeValue(" ", 6151, "animation-duration:", 6152, 20, true);
            WriteAttributeValue(" ", 6171, "1.5s;", 6172, 6, true);
            WriteAttributeValue(" ", 6177, "animation-delay:", 6178, 17, true);
            WriteAttributeValue(" ", 6194, "1.2s;", 6195, 6, true);
            WriteAttributeValue(" ", 6200, "animation-name:", 6201, 16, true);
            WriteAttributeValue(" ", 6216, "fadeInLeft;", 6217, 12, true);
            EndWriteAttribute();
            WriteLiteral(" data-progress=\"50%\" class=\"progress-bar wow fadeInLeft\">\n                                        <span class=\"text-top\">");
#nullable restore
#line 106 "C:\Users\nmasi\Desktop\BackEndProject-NurkhanMasimzade\EduHomeFinal-master\Areas\Admin\Views\Teacher\Detail.cshtml"
                                                          Write(Model.Skills.Innovation);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class=""col-sm-4"">
                            <div class=""skill-bar-item"">
                                <span class=""text-black"">Communication</span>
                                <div class=""progress"">
                                    <div data-wow-delay=""1.2s"" data-wow-duration=""1.5s""");
            BeginWriteAttribute("style", " style=\"", 6854, "\"", 6998, 11);
            WriteAttributeValue("", 6862, "width:", 6862, 6, true);
#nullable restore
#line 115 "C:\Users\nmasi\Desktop\BackEndProject-NurkhanMasimzade\EduHomeFinal-master\Areas\Admin\Views\Teacher\Detail.cshtml"
WriteAttributeValue(" ", 6868, Model.Skills.Communication, 6869, 29, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 6898, "%;", 6898, 2, true);
            WriteAttributeValue(" ", 6900, "visibility:", 6901, 12, true);
            WriteAttributeValue(" ", 6912, "visible;", 6913, 9, true);
            WriteAttributeValue(" ", 6921, "animation-duration:", 6922, 20, true);
            WriteAttributeValue(" ", 6941, "1.5s;", 6942, 6, true);
            WriteAttributeValue(" ", 6947, "animation-delay:", 6948, 17, true);
            WriteAttributeValue(" ", 6964, "1.2s;", 6965, 6, true);
            WriteAttributeValue(" ", 6970, "animation-name:", 6971, 16, true);
            WriteAttributeValue(" ", 6986, "fadeInLeft;", 6987, 12, true);
            EndWriteAttribute();
            WriteLiteral(" data-progress=\"50%\" class=\"progress-bar wow fadeInLeft\">\n                                        <span class=\"text-top\">");
#nullable restore
#line 116 "C:\Users\nmasi\Desktop\BackEndProject-NurkhanMasimzade\EduHomeFinal-master\Areas\Admin\Views\Teacher\Detail.cshtml"
                                                          Write(Model.Skills.Communication);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n                                    </div>\n                                </div>\n                            </div>\n                        </div>\n                    </div>\n                </div>\n            </div>\n        </div>\n    </div>\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "39cbf9e028336f851feb171e09ec2fe78c67bb1034685", async() => {
                WriteLiteral("Teachers");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_10.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_11);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_12);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n</div>\n\n<!-- Teacher End -->\n");
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
