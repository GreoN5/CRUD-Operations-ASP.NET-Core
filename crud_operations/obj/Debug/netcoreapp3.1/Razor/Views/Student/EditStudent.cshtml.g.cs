#pragma checksum "D:\Projects C#\crud_operations\crud_operations\Views\Student\EditStudent.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3952f9ecf132ead248e9f05433c3e61d86d5cbf4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Student_EditStudent), @"mvc.1.0.view", @"/Views/Student/EditStudent.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3952f9ecf132ead248e9f05433c3e61d86d5cbf4", @"/Views/Student/EditStudent.cshtml")]
    public class Views_Student_EditStudent : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<crud_operations.ViewModels.EditStudentVM>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Projects C#\crud_operations\crud_operations\Views\Student\EditStudent.cshtml"
   
	ViewData["Title"] = "Edit student";
	Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Edit student</h2>\r\n\r\n<div>\r\n\t<form action=\"/Student/EditStudent\" method=\"post\">\r\n\r\n\t\t");
#nullable restore
#line 13 "D:\Projects C#\crud_operations\crud_operations\Views\Student\EditStudent.cshtml"
   Write(Html.ValidationSummary(true));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t");
#nullable restore
#line 14 "D:\Projects C#\crud_operations\crud_operations\Views\Student\EditStudent.cshtml"
   Write(Html.HiddenFor(model => model.StudentID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t");
#nullable restore
#line 15 "D:\Projects C#\crud_operations\crud_operations\Views\Student\EditStudent.cshtml"
   Write(Html.HiddenFor(model => model.MajorID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\t\t<div>\r\n\t\t\t");
#nullable restore
#line 18 "D:\Projects C#\crud_operations\crud_operations\Views\Student\EditStudent.cshtml"
       Write(Html.LabelFor(model => model.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t");
#nullable restore
#line 19 "D:\Projects C#\crud_operations\crud_operations\Views\Student\EditStudent.cshtml"
       Write(Html.EditorFor(model => model.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t");
#nullable restore
#line 20 "D:\Projects C#\crud_operations\crud_operations\Views\Student\EditStudent.cshtml"
       Write(Html.ValidationMessageFor(model => model.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t</div>\r\n\t\t<div>\r\n\t\t\t");
#nullable restore
#line 23 "D:\Projects C#\crud_operations\crud_operations\Views\Student\EditStudent.cshtml"
       Write(Html.LabelFor(model => model.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t");
#nullable restore
#line 24 "D:\Projects C#\crud_operations\crud_operations\Views\Student\EditStudent.cshtml"
       Write(Html.EditorFor(model => model.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t");
#nullable restore
#line 25 "D:\Projects C#\crud_operations\crud_operations\Views\Student\EditStudent.cshtml"
       Write(Html.ValidationMessageFor(model => model.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t</div>\r\n\t\t<div>\r\n\t\t\t");
#nullable restore
#line 28 "D:\Projects C#\crud_operations\crud_operations\Views\Student\EditStudent.cshtml"
       Write(Html.LabelFor(model => model.Gender));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t");
#nullable restore
#line 29 "D:\Projects C#\crud_operations\crud_operations\Views\Student\EditStudent.cshtml"
       Write(Html.EditorFor(model => model.Gender));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t");
#nullable restore
#line 30 "D:\Projects C#\crud_operations\crud_operations\Views\Student\EditStudent.cshtml"
       Write(Html.ValidationMessageFor(model => model.Gender));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t</div>\r\n\t\t<div>\r\n\t\t\t");
#nullable restore
#line 33 "D:\Projects C#\crud_operations\crud_operations\Views\Student\EditStudent.cshtml"
       Write(Html.LabelFor(model => model.Year));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t");
#nullable restore
#line 34 "D:\Projects C#\crud_operations\crud_operations\Views\Student\EditStudent.cshtml"
       Write(Html.EditorFor(model => model.Year));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t");
#nullable restore
#line 35 "D:\Projects C#\crud_operations\crud_operations\Views\Student\EditStudent.cshtml"
       Write(Html.ValidationMessageFor(model => model.Year));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t</div>\r\n\t\t<div>\r\n\t\t\t<input type=\"submit\" value=\"Save\" />\r\n\t\t\t<a href=\"/Student/Index\">Cancel</a>\r\n\t\t</div>\r\n\t</form>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<crud_operations.ViewModels.EditStudentVM> Html { get; private set; }
    }
}
#pragma warning restore 1591