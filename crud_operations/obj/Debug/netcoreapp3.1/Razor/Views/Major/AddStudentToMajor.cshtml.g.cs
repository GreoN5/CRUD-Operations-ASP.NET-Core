#pragma checksum "D:\Projects C#\CRUD_operations\crud_operations\Views\Major\AddStudentToMajor.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1db7a13e16f3d8ed7ad5d72e8a4ecd965827fb8f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Major_AddStudentToMajor), @"mvc.1.0.view", @"/Views/Major/AddStudentToMajor.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1db7a13e16f3d8ed7ad5d72e8a4ecd965827fb8f", @"/Views/Major/AddStudentToMajor.cshtml")]
    public class Views_Major_AddStudentToMajor : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<crud_operations.Models.Student>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Projects C#\CRUD_operations\crud_operations\Views\Major\AddStudentToMajor.cshtml"
   
	ViewData["Title"] = "Add new student";
	Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Add student to major</h1>\r\n\r\n<div>\r\n\t<form method=\"post\" action=\"/Major/AddStudentToMajor\">\r\n\t\t");
#nullable restore
#line 12 "D:\Projects C#\CRUD_operations\crud_operations\Views\Major\AddStudentToMajor.cshtml"
   Write(Html.ValidationSummary(true));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t<div>\r\n\t\t\t");
#nullable restore
#line 14 "D:\Projects C#\CRUD_operations\crud_operations\Views\Major\AddStudentToMajor.cshtml"
       Write(Html.LabelFor(model => model.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t");
#nullable restore
#line 15 "D:\Projects C#\CRUD_operations\crud_operations\Views\Major\AddStudentToMajor.cshtml"
       Write(Html.TextBoxFor(model => model.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t");
#nullable restore
#line 16 "D:\Projects C#\CRUD_operations\crud_operations\Views\Major\AddStudentToMajor.cshtml"
       Write(Html.ValidationMessageFor(model => model.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t</div>\r\n\t\t<div>\r\n\t\t\t");
#nullable restore
#line 19 "D:\Projects C#\CRUD_operations\crud_operations\Views\Major\AddStudentToMajor.cshtml"
       Write(Html.LabelFor(model => model.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t");
#nullable restore
#line 20 "D:\Projects C#\CRUD_operations\crud_operations\Views\Major\AddStudentToMajor.cshtml"
       Write(Html.TextBoxFor(model => model.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t");
#nullable restore
#line 21 "D:\Projects C#\CRUD_operations\crud_operations\Views\Major\AddStudentToMajor.cshtml"
       Write(Html.ValidationMessageFor(model => model.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t</div>\r\n\t\t<div>\r\n\t\t\t");
#nullable restore
#line 24 "D:\Projects C#\CRUD_operations\crud_operations\Views\Major\AddStudentToMajor.cshtml"
       Write(Html.LabelFor(model => model.Gender));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t");
#nullable restore
#line 25 "D:\Projects C#\CRUD_operations\crud_operations\Views\Major\AddStudentToMajor.cshtml"
       Write(Html.TextBoxFor(model => model.Gender));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t");
#nullable restore
#line 26 "D:\Projects C#\CRUD_operations\crud_operations\Views\Major\AddStudentToMajor.cshtml"
       Write(Html.ValidationMessageFor(model => model.Gender));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t</div>\r\n\t\t<div>\r\n\t\t\t");
#nullable restore
#line 29 "D:\Projects C#\CRUD_operations\crud_operations\Views\Major\AddStudentToMajor.cshtml"
       Write(Html.LabelFor(model => model.Year));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t");
#nullable restore
#line 30 "D:\Projects C#\CRUD_operations\crud_operations\Views\Major\AddStudentToMajor.cshtml"
       Write(Html.TextBoxFor(model => model.Year));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t");
#nullable restore
#line 31 "D:\Projects C#\CRUD_operations\crud_operations\Views\Major\AddStudentToMajor.cshtml"
       Write(Html.ValidationMessageFor(model => model.Year));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t</div>\r\n\t\t<div>\r\n\t\t\t<input type=\"submit\" value=\"Add\"/>\r\n\t\t</div>\r\n\t</form>\r\n</div>\r\n\r\n<div>\r\n\t<a href=\"/Major/Index\">Back to majors</a>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<crud_operations.Models.Student> Html { get; private set; }
    }
}
#pragma warning restore 1591
