#pragma checksum "C:\Users\Sheth Multitech\Downloads\Student Management\Student Management\StudentManagement\Views\Student\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f0cd551eccb4152c3207494e0774b42a64d1c427"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Student_Index), @"mvc.1.0.view", @"/Views/Student/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Student/Index.cshtml", typeof(AspNetCore.Views_Student_Index))]
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
#line 1 "C:\Users\Sheth Multitech\Downloads\Student Management\Student Management\StudentManagement\Views\_ViewImports.cshtml"
using StudentRecordManagementSystem;

#line default
#line hidden
#line 2 "C:\Users\Sheth Multitech\Downloads\Student Management\Student Management\StudentManagement\Views\_ViewImports.cshtml"
using StudentRecordManagementSystem.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f0cd551eccb4152c3207494e0774b42a64d1c427", @"/Views/Student/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7890f67099b30a42c3625f195ac8aea3a1259201", @"/Views/_ViewImports.cshtml")]
    public class Views_Student_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<StudentRecordManagementSystem.Models.ToDo>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(63, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Sheth Multitech\Downloads\Student Management\Student Management\StudentManagement\Views\Student\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(106, 36, true);
            WriteLiteral("\r\n<h2>ToDO Details</h2>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(142, 61, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "18f7bcf4879c4851b094f35280cadd2c", async() => {
                BeginContext(189, 10, true);
                WriteLiteral("Create New");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(203, 92, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(296, 38, false);
#line 16 "C:\Users\Sheth Multitech\Downloads\Student Management\Student Management\StudentManagement\Views\Student\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(334, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(390, 41, false);
#line 19 "C:\Users\Sheth Multitech\Downloads\Student Management\Student Management\StudentManagement\Views\Student\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Notes));

#line default
#line hidden
            EndContext();
            BeginContext(431, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(487, 42, false);
#line 22 "C:\Users\Sheth Multitech\Downloads\Student Management\Student Management\StudentManagement\Views\Student\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Status));

#line default
#line hidden
            EndContext();
            BeginContext(529, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(585, 50, false);
#line 25 "C:\Users\Sheth Multitech\Downloads\Student Management\Student Management\StudentManagement\Views\Student\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ComplitionDate));

#line default
#line hidden
            EndContext();
            BeginContext(635, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 31 "C:\Users\Sheth Multitech\Downloads\Student Management\Student Management\StudentManagement\Views\Student\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(753, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(802, 37, false);
#line 34 "C:\Users\Sheth Multitech\Downloads\Student Management\Student Management\StudentManagement\Views\Student\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
            EndContext();
            BeginContext(839, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(895, 40, false);
#line 37 "C:\Users\Sheth Multitech\Downloads\Student Management\Student Management\StudentManagement\Views\Student\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Notes));

#line default
#line hidden
            EndContext();
            BeginContext(935, 39, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n");
            EndContext();
#line 40 "C:\Users\Sheth Multitech\Downloads\Student Management\Student Management\StudentManagement\Views\Student\Index.cshtml"
                 if (item.Status == "1")
                {

#line default
#line hidden
            BeginContext(1035, 44, true);
            WriteLiteral("                    <span>Completed</span>\r\n");
            EndContext();
#line 43 "C:\Users\Sheth Multitech\Downloads\Student Management\Student Management\StudentManagement\Views\Student\Index.cshtml"

                }
                else
                {

#line default
#line hidden
            BeginContext(1141, 46, true);
            WriteLiteral("                    <span>In Progress</span>\r\n");
            EndContext();
            BeginContext(1208, 148, false);
#line 48 "C:\Users\Sheth Multitech\Downloads\Student Management\Student Management\StudentManagement\Views\Student\Index.cshtml"
               Write(Html.ActionLink("Click to Complete..", "Edit", new { id = item.Id }, new { @class = "btn btn-success", style = "font-size: 12px;margin-left: 9px" }));

#line default
#line hidden
            EndContext();
#line 48 "C:\Users\Sheth Multitech\Downloads\Student Management\Student Management\StudentManagement\Views\Student\Index.cshtml"
                                                                                                                                                                         
                }

#line default
#line hidden
            BeginContext(1377, 37, true);
            WriteLiteral("            </td>\r\n            <td>\r\n");
            EndContext();
#line 52 "C:\Users\Sheth Multitech\Downloads\Student Management\Student Management\StudentManagement\Views\Student\Index.cshtml"
                 if (item.ComplitionDate == null)
                {

#line default
#line hidden
            BeginContext(1484, 35, true);
            WriteLiteral("                    <span></span>\r\n");
            EndContext();
#line 55 "C:\Users\Sheth Multitech\Downloads\Student Management\Student Management\StudentManagement\Views\Student\Index.cshtml"
                }
                else
                {
                    

#line default
#line hidden
            BeginContext(1600, 49, false);
#line 58 "C:\Users\Sheth Multitech\Downloads\Student Management\Student Management\StudentManagement\Views\Student\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.ComplitionDate));

#line default
#line hidden
            EndContext();
#line 58 "C:\Users\Sheth Multitech\Downloads\Student Management\Student Management\StudentManagement\Views\Student\Index.cshtml"
                                                                      
                }

#line default
#line hidden
            BeginContext(1670, 39, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n");
            EndContext();
            BeginContext(1828, 16, true);
            WriteLiteral("                ");
            EndContext();
            BeginContext(1845, 92, false);
#line 64 "C:\Users\Sheth Multitech\Downloads\Student Management\Student Management\StudentManagement\Views\Student\Index.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new { id = item.Id }, new { @class = "btn btn-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(1937, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 67 "C:\Users\Sheth Multitech\Downloads\Student Management\Student Management\StudentManagement\Views\Student\Index.cshtml"
}

#line default
#line hidden
            BeginContext(1976, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<StudentRecordManagementSystem.Models.ToDo>> Html { get; private set; }
    }
}
#pragma warning restore 1591