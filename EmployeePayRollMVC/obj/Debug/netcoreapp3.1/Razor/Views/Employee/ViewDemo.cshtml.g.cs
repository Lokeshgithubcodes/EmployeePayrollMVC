#pragma checksum "C:\Users\Ramisettylokesh\source\repos\EmployeePayRollMVC\EmployeePayRollMVC\Views\Employee\ViewDemo.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "f466ecb9673a30186742a807d66ae64508c23a9838046a17fe9a27c9361bc16a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employee_ViewDemo), @"mvc.1.0.view", @"/Views/Employee/ViewDemo.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Ramisettylokesh\source\repos\EmployeePayRollMVC\EmployeePayRollMVC\Views\_ViewImports.cshtml"
using EmployeePayRollMVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Ramisettylokesh\source\repos\EmployeePayRollMVC\EmployeePayRollMVC\Views\_ViewImports.cshtml"
using EmployeePayRollMVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"f466ecb9673a30186742a807d66ae64508c23a9838046a17fe9a27c9361bc16a", @"/Views/Employee/ViewDemo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"4e7012c3eda21ba1f07ef08dfcb5ffeeb00ab4e1f305129aa779cc9a37a65cc0", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Employee_ViewDemo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CommonLayer.Models.Employee>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Ramisettylokesh\source\repos\EmployeePayRollMVC\EmployeePayRollMVC\Views\Employee\ViewDemo.cshtml"
  
    ViewData["Title"] = "ViewDemo";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>ViewDemo</h1>\r\n\r\n<h4>Workers</h4>\r\n\r\n");
            WriteLiteral("<label>");
#nullable restore
#line 12 "C:\Users\Ramisettylokesh\source\repos\EmployeePayRollMVC\EmployeePayRollMVC\Views\Employee\ViewDemo.cshtml"
  Write(ViewBag.date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n\r\n");
            WriteLiteral("\r\n<table class=\"table table-responsive\">\r\n    <tr>\r\n        <th>Id</th>\r\n        <th>Name</th>\r\n    </tr>\r\n");
#nullable restore
#line 21 "C:\Users\Ramisettylokesh\source\repos\EmployeePayRollMVC\EmployeePayRollMVC\Views\Employee\ViewDemo.cshtml"
     foreach (EmployeePayRollMVC.Controllers.EmployeeController.Workers wok in (List<EmployeePayRollMVC.Controllers.EmployeeController.Workers>)ViewData["All"])
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <th>");
#nullable restore
#line 24 "C:\Users\Ramisettylokesh\source\repos\EmployeePayRollMVC\EmployeePayRollMVC\Views\Employee\ViewDemo.cshtml"
           Write(wok.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            <th>");
#nullable restore
#line 25 "C:\Users\Ramisettylokesh\source\repos\EmployeePayRollMVC\EmployeePayRollMVC\Views\Employee\ViewDemo.cshtml"
           Write(wok.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n        </tr>\r\n");
#nullable restore
#line 27 "C:\Users\Ramisettylokesh\source\repos\EmployeePayRollMVC\EmployeePayRollMVC\Views\Employee\ViewDemo.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n\r\n\r\n\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 34 "C:\Users\Ramisettylokesh\source\repos\EmployeePayRollMVC\EmployeePayRollMVC\Views\Employee\ViewDemo.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
            }
            );
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CommonLayer.Models.Employee> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591