#pragma checksum "C:\Users\son10\Downloads\TeamVit-master\Ice-Cream-master\Ice_Cream\Views\Shared\ProductSummary.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "486b9b83f236769e32f17552ebe8073514c0eb46"
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
#line 1 "C:\Users\son10\Downloads\TeamVit-master\Ice-Cream-master\Ice_Cream\Views\_ViewImports.cshtml"
using Ice_Cream;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\son10\Downloads\TeamVit-master\Ice-Cream-master\Ice_Cream\Views\_ViewImports.cshtml"
using Ice_Cream.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\son10\Downloads\TeamVit-master\Ice-Cream-master\Ice_Cream\Views\_ViewImports.cshtml"
using Ice_Cream.Models.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\son10\Downloads\TeamVit-master\Ice-Cream-master\Ice_Cream\Views\_ViewImports.cshtml"
using Ice_Cream.Infrastructure;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"486b9b83f236769e32f17552ebe8073514c0eb46", @"/Views/Shared/ProductSummary.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"27a42a902c36709f076743b6cb10e6fdf8b07436", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_ProductSummary : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Product>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"

<div class=""one-third mcb-wrap"" style=""padding:0 1%"">
    <div class=""column one"">
        <div style=""background-color: #ffd4de; padding: 0 0 40px; border-radius: 20px;text-align: center;margin-top:100px"">
            <div class=""image_frame"" style=""margin-top:-80px;border-width: 0"">
                <div class=""image_wrapper"">
                    <img class=""scale-with-grid"" src=""https://themes.muffingroup.com/be/icecream2/wp-content/uploads/2019/09/icecream2-ourproducts-pic2.png"" width=""780"" height=""780"" />
                    <hr class=""no_line"" style=""margin:0 auto 10px"" />
                    <h6 style=""color: #ffb8c9; margin-bottom: 2px"">");
#nullable restore
#line 11 "C:\Users\son10\Downloads\TeamVit-master\Ice-Cream-master\Ice_Cream\Views\Shared\ProductSummary.cshtml"
                                                              Write(Model.Category);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                    <h4>\r\n                        ");
#nullable restore
#line 13 "C:\Users\son10\Downloads\TeamVit-master\Ice-Cream-master\Ice_Cream\Views\Shared\ProductSummary.cshtml"
                   Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </h4>\r\n                    <p style=\"margin: 0 10%;\">");
#nullable restore
#line 15 "C:\Users\son10\Downloads\TeamVit-master\Ice-Cream-master\Ice_Cream\Views\Shared\ProductSummary.cshtml"
                                         Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                    <hr class=""no_line"" style=""margin: 0 auto 20px"" />
                    <div class=""image_frame no_border"" style=""border-width: 0;border-color: #f8f8f8;"">
                        <div class=""i"" style="" border-color: #e2e2e2; position:relative; overflow:hidden; box-sizing:border-box"">
                            <div class=""wrapper"">
                                <a");
            BeginWriteAttribute("href", " href=\"", 1253, "\"", 1291, 2);
            WriteAttributeValue("", 1260, "/Recipe/Detail/", 1260, 15, true);
#nullable restore
#line 20 "C:\Users\son10\Downloads\TeamVit-master\Ice-Cream-master\Ice_Cream\Views\Shared\ProductSummary.cshtml"
WriteAttributeValue("", 1275, Model.ProductID, 1275, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                                    <div style=""box-shadow: inset 0 0 5px 2px rgba(0,0,0,.07);display: none!important;position:absolute;z-index:2;width:100%;height:100%""></div>
                                    <img src=""https://themes.muffingroup.com/be/icecream2/wp-content/uploads/2019/09/icecream2-arrow-right.png"" style="" max-width: 100%; height: auto"" width=""40"" height=""40"" />
                                </a>
                            </div>
                            <div style=""display: none;"">
                                <a> <i style=""font-style:italic""></i></a>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>");
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
