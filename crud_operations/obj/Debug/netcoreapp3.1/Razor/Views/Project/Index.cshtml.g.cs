#pragma checksum "D:\Projects C#\CRUD_operations\crud_operations\Views\Project\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a92d2032aa74661257a06815d7350b731b5745fc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Project_Index), @"mvc.1.0.view", @"/Views/Project/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a92d2032aa74661257a06815d7350b731b5745fc", @"/Views/Project/Index.cshtml")]
    public class Views_Project_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<crud_operations.Models.Project>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Projects C#\CRUD_operations\crud_operations\Views\Project\Index.cshtml"
   
	ViewData["Title"] = "Projects";
	Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Projects</h2>\r\n\r\n<table>\r\n\t<thead>\r\n\t\t<tr>\r\n\t\t\t<th>\r\n\t\t\t\t");
#nullable restore
#line 14 "D:\Projects C#\CRUD_operations\crud_operations\Views\Project\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ProjectID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t</th>\r\n\t\t\t<th>\r\n\t\t\t\t");
#nullable restore
#line 17 "D:\Projects C#\CRUD_operations\crud_operations\Views\Project\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ProjectName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t</th>\r\n\t\t</tr>\r\n\t</thead>\r\n\t<tbody>\r\n");
#nullable restore
#line 22 "D:\Projects C#\CRUD_operations\crud_operations\Views\Project\Index.cshtml"
         foreach (var item in Model)
		{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t<tr>\r\n\t\t\t\t<td>\r\n\t\t\t\t\t");
#nullable restore
#line 26 "D:\Projects C#\CRUD_operations\crud_operations\Views\Project\Index.cshtml"
               Write(Html.DisplayFor(model => item.ProjectID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t</td>\r\n\t\t\t\t<td>\r\n\t\t\t\t\t");
#nullable restore
#line 29 "D:\Projects C#\CRUD_operations\crud_operations\Views\Project\Index.cshtml"
               Write(Html.DisplayFor(model => item.ProjectName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t</td>\r\n\t\t\t</tr>\r\n");
#nullable restore
#line 32 "D:\Projects C#\CRUD_operations\crud_operations\Views\Project\Index.cshtml"
		}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t</tbody>\r\n</table>\r\n\r\n<div class=\"link-wrapper\">\r\n\t<a id=\"button\" href=\"/Project/ProjectsToStudents\">Projects to students</a>\r\n\t<a id=\"button\" href=\"/Project/CreateNewProject\">Create new project</a>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<crud_operations.Models.Project>> Html { get; private set; }
    }
}
#pragma warning restore 1591
