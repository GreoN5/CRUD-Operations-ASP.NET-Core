#pragma checksum "D:\Projects C#\CRUD_operations\crud_operations\Views\Major\Students.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "689387c389e4bcebe648f88f5b43e7f911876d7a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Major_Students), @"mvc.1.0.view", @"/Views/Major/Students.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"689387c389e4bcebe648f88f5b43e7f911876d7a", @"/Views/Major/Students.cshtml")]
    public class Views_Major_Students : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<crud_operations.Models.Student>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Projects C#\CRUD_operations\crud_operations\Views\Major\Students.cshtml"
  
	ViewData["Title"] = "Students";
	Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Students</h2>\r\n\r\n");
#nullable restore
#line 10 "D:\Projects C#\CRUD_operations\crud_operations\Views\Major\Students.cshtml"
 if (this.Model.Count() == 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t<p>\r\n\t\t<strong>There are no students in current major!</strong>\r\n\t</p>\r\n");
#nullable restore
#line 15 "D:\Projects C#\CRUD_operations\crud_operations\Views\Major\Students.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t<table>\r\n\t\t<thead>\r\n\t\t\t<tr>\r\n\t\t\t\t<th>\r\n\t\t\t\t\t");
#nullable restore
#line 21 "D:\Projects C#\CRUD_operations\crud_operations\Views\Major\Students.cshtml"
               Write(Html.DisplayNameFor(model => model.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t</th>\r\n\t\t\t\t<th>\r\n\t\t\t\t\t");
#nullable restore
#line 24 "D:\Projects C#\CRUD_operations\crud_operations\Views\Major\Students.cshtml"
               Write(Html.DisplayNameFor(model => model.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t</th>\r\n\t\t\t\t<th>\r\n\t\t\t\t\t");
#nullable restore
#line 27 "D:\Projects C#\CRUD_operations\crud_operations\Views\Major\Students.cshtml"
               Write(Html.DisplayNameFor(model => model.Gender));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t</th>\r\n\t\t\t\t<th>\r\n\t\t\t\t\t");
#nullable restore
#line 30 "D:\Projects C#\CRUD_operations\crud_operations\Views\Major\Students.cshtml"
               Write(Html.DisplayNameFor(model => model.Year));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t</th>\r\n\t\t\t\t<th>\r\n\t\t\t\t\t");
#nullable restore
#line 33 "D:\Projects C#\CRUD_operations\crud_operations\Views\Major\Students.cshtml"
               Write(Html.DisplayNameFor(model => model.MajorID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t</th>\r\n\t\t\t</tr>\r\n\t\t</thead>\r\n\t\t<tbody>\r\n");
#nullable restore
#line 38 "D:\Projects C#\CRUD_operations\crud_operations\Views\Major\Students.cshtml"
             foreach (var item in Model)
			{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t<tr>\r\n\t\t\t\t\t<td>\r\n\t\t\t\t\t\t");
#nullable restore
#line 42 "D:\Projects C#\CRUD_operations\crud_operations\Views\Major\Students.cshtml"
                   Write(Html.DisplayFor(model => item.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t</td>\r\n\t\t\t\t\t<td>\r\n\t\t\t\t\t\t");
#nullable restore
#line 45 "D:\Projects C#\CRUD_operations\crud_operations\Views\Major\Students.cshtml"
                   Write(Html.DisplayFor(model => item.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t</td>\r\n\t\t\t\t\t<td>\r\n\t\t\t\t\t\t");
#nullable restore
#line 48 "D:\Projects C#\CRUD_operations\crud_operations\Views\Major\Students.cshtml"
                   Write(Html.DisplayFor(model => item.Gender));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t</td>\r\n\t\t\t\t\t<td>\r\n\t\t\t\t\t\t");
#nullable restore
#line 51 "D:\Projects C#\CRUD_operations\crud_operations\Views\Major\Students.cshtml"
                   Write(Html.DisplayFor(model => item.Year));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t</td>\r\n\t\t\t\t\t<td>\r\n\t\t\t\t\t\t");
#nullable restore
#line 54 "D:\Projects C#\CRUD_operations\crud_operations\Views\Major\Students.cshtml"
                   Write(Html.DisplayFor(model => item.MajorID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t</td>\r\n\t\t\t\t\t<td>\r\n\t\t\t\t\t\t<a");
            BeginWriteAttribute("href", " href=\"", 1113, "\"", 1159, 2);
            WriteAttributeValue("", 1120, "/Student/EditStudent?Id=", 1120, 24, true);
#nullable restore
#line 57 "D:\Projects C#\CRUD_operations\crud_operations\Views\Major\Students.cshtml"
WriteAttributeValue("", 1144, item.StudentID, 1144, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit</a>\r\n\t\t\t\t\t\t<a");
            BeginWriteAttribute("href", " href=\"", 1179, "\"", 1227, 2);
            WriteAttributeValue("", 1186, "/Student/DeleteStudent?Id=", 1186, 26, true);
#nullable restore
#line 58 "D:\Projects C#\CRUD_operations\crud_operations\Views\Major\Students.cshtml"
WriteAttributeValue("", 1212, item.StudentID, 1212, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Delete</a>\r\n\t\t\t\t\t</td>\r\n\t\t\t\t</tr>\r\n");
#nullable restore
#line 61 "D:\Projects C#\CRUD_operations\crud_operations\Views\Major\Students.cshtml"
			}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t</tbody>\r\n\t</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<crud_operations.Models.Student>> Html { get; private set; }
    }
}
#pragma warning restore 1591
