#pragma checksum "D:\Projects C#\crud_operations\crud_operations\Views\Project\CreateNewInstance.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3ee13b21506bf933e6b5a15a9a6151d8d81b3f28"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Project_CreateNewInstance), @"mvc.1.0.view", @"/Views/Project/CreateNewInstance.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3ee13b21506bf933e6b5a15a9a6151d8d81b3f28", @"/Views/Project/CreateNewInstance.cshtml")]
    public class Views_Project_CreateNewInstance : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<crud_operations.Models.ProjectToStudent>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Projects C#\crud_operations\crud_operations\Views\Project\CreateNewInstance.cshtml"
   
	ViewData["Title"] = "Create new instance";
	Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Create new instance</h2>\r\n\r\n<div class=\"form-wrapper\">\r\n\t<form action=\"/Project/CreateNewInstance\" method=\"post\">\r\n\t\t");
#nullable restore
#line 12 "D:\Projects C#\crud_operations\crud_operations\Views\Project\CreateNewInstance.cshtml"
   Write(Html.ValidationSummary(true));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\t\t<div>\r\n\t\t\t");
#nullable restore
#line 15 "D:\Projects C#\crud_operations\crud_operations\Views\Project\CreateNewInstance.cshtml"
       Write(Html.DropDownList("ProjectID", (SelectList)ViewBag.ProjectID, "Select project", new { @id = "dropdown"} ));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t</div>\r\n\t\t<div>\r\n\t\t\t");
#nullable restore
#line 18 "D:\Projects C#\crud_operations\crud_operations\Views\Project\CreateNewInstance.cshtml"
       Write(Html.DropDownList("StudentID", (SelectList)ViewBag.StudentID, "Select student", new { @id = "dropdown" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t</div>\r\n\t\t<div>\r\n\t\t\t<input type=\"submit\" value=\"Create\" />\r\n\t\t</div>\r\n\t</form>\r\n</div>\r\n\r\n<div class=\"link-wrapper\">\r\n\t<a id=\"button\" href=\"/Project/ProjectsToStudents\">Go back</a>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<crud_operations.Models.ProjectToStudent> Html { get; private set; }
    }
}
#pragma warning restore 1591
