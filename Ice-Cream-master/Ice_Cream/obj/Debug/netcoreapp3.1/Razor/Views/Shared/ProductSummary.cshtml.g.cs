#pragma checksum "D:\Visual studio code\TeamVit\TeamVit\Ice-Cream-master\Ice_Cream\Views\Shared\ProductSummary.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ca14835b79d68c6b35304c365f473694ebace3a6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_ProductSummary), @"mvc.1.0.view", @"/Views/Shared/ProductSummary.cshtml")]
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
#nullable restore
#line 1 "D:\Visual studio code\TeamVit\TeamVit\Ice-Cream-master\Ice_Cream\Views\_ViewImports.cshtml"
using Ice_Cream;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Visual studio code\TeamVit\TeamVit\Ice-Cream-master\Ice_Cream\Views\_ViewImports.cshtml"
using Ice_Cream.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Visual studio code\TeamVit\TeamVit\Ice-Cream-master\Ice_Cream\Views\_ViewImports.cshtml"
using Ice_Cream.Models.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Visual studio code\TeamVit\TeamVit\Ice-Cream-master\Ice_Cream\Views\_ViewImports.cshtml"
using Ice_Cream.Infrastructure;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ca14835b79d68c6b35304c365f473694ebace3a6", @"/Views/Shared/ProductSummary.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"118ad47d25865380f63af3744309f5ae468eefba", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_ProductSummary : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Product>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n<div class=\"col-4\" style=\"float:left\">\r\n    <img");
            BeginWriteAttribute("src", " src=\"", 68, "\"", 86, 1);
#nullable restore
#line 5 "D:\Visual studio code\TeamVit\TeamVit\Ice-Cream-master\Ice_Cream\Views\Shared\ProductSummary.cshtml"
WriteAttributeValue("", 74, Model.Image, 74, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 87, "\"", 93, 0);
            EndWriteAttribute();
            WriteLiteral(" style=\"width:25vw;height:25vw;\" />\r\n    <h3 style=\"color:red;text-align:center\">");
#nullable restore
#line 6 "D:\Visual studio code\TeamVit\TeamVit\Ice-Cream-master\Ice_Cream\Views\Shared\ProductSummary.cshtml"
                                       Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n    <b>Decription:</b> ");
#nullable restore
#line 7 "D:\Visual studio code\TeamVit\TeamVit\Ice-Cream-master\Ice_Cream\Views\Shared\ProductSummary.cshtml"
                  Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <br />\r\n    <b>Category:</b> ");
#nullable restore
#line 9 "D:\Visual studio code\TeamVit\TeamVit\Ice-Cream-master\Ice_Cream\Views\Shared\ProductSummary.cshtml"
                Write(Model.Category);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    \r\n    <hr />\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Product> Html { get; private set; }
    }
}
#pragma warning restore 1591
