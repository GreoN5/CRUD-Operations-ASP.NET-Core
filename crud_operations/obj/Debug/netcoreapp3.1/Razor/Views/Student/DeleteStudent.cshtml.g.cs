#pragma checksum "D:\Projects C#\CRUD_operations\crud_operations\Views\Student\DeleteStudent.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "97a28f7b040f491028bc00f27a2848154dc8e730"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Student_DeleteStudent), @"mvc.1.0.view", @"/Views/Student/DeleteStudent.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"97a28f7b040f491028bc00f27a2848154dc8e730", @"/Views/Student/DeleteStudent.cshtml")]
    public class Views_Student_DeleteStudent : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<crud_operations.Models.Student>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Projects C#\CRUD_operations\crud_operations\Views\Student\DeleteStudent.cshtml"
   
	ViewData["Title"] = "Delete student";
	Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Delete student</h2>\r\n\r\n<div>\r\n\t<table>\r\n\t\t<thead>\r\n\t\t\t<tr>\r\n\t\t\t\t<th>\r\n\t\t\t\t\t");
#nullable restore
#line 15 "D:\Projects C#\CRUD_operations\crud_operations\Views\Student\DeleteStudent.cshtml"
               Write(Html.DisplayNameFor(model => model.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t</th>\r\n\t\t\t\t<th>\r\n\t\t\t\t\t");
#nullable restore
#line 18 "D:\Projects C#\CRUD_operations\crud_operations\Views\Student\DeleteStudent.cshtml"
               Write(Html.DisplayNameFor(model => model.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t</th>\r\n\t\t\t\t<th>\r\n\t\t\t\t\t");
#nullable restore
#line 21 "D:\Projects C#\CRUD_operations\crud_operations\Views\Student\DeleteStudent.cshtml"
               Write(Html.DisplayNameFor(model => model.Gender));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t</th>\r\n\t\t\t\t<th>\r\n\t\t\t\t\t");
#nullable restore
#line 24 "D:\Projects C#\CRUD_operations\crud_operations\Views\Student\DeleteStudent.cshtml"
               Write(Html.DisplayNameFor(model => model.Year));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t</th>\r\n\t\t\t\t<th>\r\n\t\t\t\t\t");
#nullable restore
#line 27 "D:\Projects C#\CRUD_operations\crud_operations\Views\Student\DeleteStudent.cshtml"
               Write(Html.DisplayNameFor(model => model.Major));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t</th>\r\n\t\t\t</tr>\r\n\t\t</thead>\r\n\t\t<tbody>\r\n\t\t\t<tr>\r\n\t\t\t\t<td>\r\n\t\t\t\t\t");
#nullable restore
#line 34 "D:\Projects C#\CRUD_operations\crud_operations\Views\Student\DeleteStudent.cshtml"
               Write(Html.DisplayFor(model => model.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t</td>\r\n\t\t\t\t<td>\r\n\t\t\t\t\t");
#nullable restore
#line 37 "D:\Projects C#\CRUD_operations\crud_operations\Views\Student\DeleteStudent.cshtml"
               Write(Html.DisplayFor(model => model.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t</td>\r\n\t\t\t\t<td>\r\n\t\t\t\t\t");
#nullable restore
#line 40 "D:\Projects C#\CRUD_operations\crud_operations\Views\Student\DeleteStudent.cshtml"
               Write(Html.DisplayFor(model => model.Gender));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t</td>\r\n\t\t\t\t<td>\r\n\t\t\t\t\t");
#nullable restore
#line 43 "D:\Projects C#\CRUD_operations\crud_operations\Views\Student\DeleteStudent.cshtml"
               Write(Html.DisplayFor(model => model.Year));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t</td>\r\n\t\t\t\t<td>\r\n\t\t\t\t\t");
#nullable restore
#line 46 "D:\Projects C#\CRUD_operations\crud_operations\Views\Student\DeleteStudent.cshtml"
               Write(Html.DisplayFor(model => model.MajorID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t</td>\r\n\t\t\t</tr>\r\n\t\t</tbody>\r\n\t</table>\r\n</div>\r\n\r\n<div>\r\n\t<form action=\"/Student/DeleteStudent\">\r\n\t\t");
#nullable restore
#line 55 "D:\Projects C#\CRUD_operations\crud_operations\Views\Student\DeleteStudent.cshtml"
   Write(Html.HiddenFor(model => model.StudentID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t<input type=\"submit\" value=\"Delete\" />\r\n\t</form>\r\n</div>\r\n\r\n<div>\r\n\t<a href=\"/Students/Index\">Go back</a>\r\n</div>\r\n");
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
