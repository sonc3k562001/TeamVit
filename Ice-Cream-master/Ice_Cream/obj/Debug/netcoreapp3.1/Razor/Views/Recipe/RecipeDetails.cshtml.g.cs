#pragma checksum "D:\Visual Studio 2019\EAP\IceCream\Ice-Cream-master\Ice_Cream\Views\Recipe\RecipeDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "850d23702bc65a23a9c84be81ec5b634d70e1fa0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Recipe_RecipeDetails), @"mvc.1.0.view", @"/Views/Recipe/RecipeDetails.cshtml")]
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
#line 1 "D:\Visual Studio 2019\EAP\IceCream\Ice-Cream-master\Ice_Cream\Views\_ViewImports.cshtml"
using Ice_Cream;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Visual Studio 2019\EAP\IceCream\Ice-Cream-master\Ice_Cream\Views\_ViewImports.cshtml"
using Ice_Cream.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"850d23702bc65a23a9c84be81ec5b634d70e1fa0", @"/Views/Recipe/RecipeDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7c768e2ea11e9cafee4c2d1f157ee8fbd8ccd27e", @"/Views/_ViewImports.cshtml")]
    public class Views_Recipe_RecipeDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IQueryable<Recipe>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Visual Studio 2019\EAP\IceCream\Ice-Cream-master\Ice_Cream\Views\Recipe\RecipeDetails.cshtml"
 foreach (var p in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"col-12 container\">\r\n        <div class=\"col-12\">\r\n            <div style=\"height:30px\"><h4>");
#nullable restore
#line 7 "D:\Visual Studio 2019\EAP\IceCream\Ice-Cream-master\Ice_Cream\Views\Recipe\RecipeDetails.cshtml"
                                    Write(p.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4></div>\r\n            <img");
            BeginWriteAttribute("src", " src=", 202, "", 213, 1);
#nullable restore
#line 8 "D:\Visual Studio 2019\EAP\IceCream\Ice-Cream-master\Ice_Cream\Views\Recipe\RecipeDetails.cshtml"
WriteAttributeValue("", 207, p.Img, 207, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" height=\"450\" width=\"500\" />\r\n            <br />\r\n            <div>\r\n                <b>Ingredient:</b>\r\n                <span>");
#nullable restore
#line 12 "D:\Visual Studio 2019\EAP\IceCream\Ice-Cream-master\Ice_Cream\Views\Recipe\RecipeDetails.cshtml"
                 Write(p.Ingredients);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                <br />\r\n                <b>Price:</b>\r\n                <span>");
#nullable restore
#line 15 "D:\Visual Studio 2019\EAP\IceCream\Ice-Cream-master\Ice_Cream\Views\Recipe\RecipeDetails.cshtml"
                 Write(p.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                <br />\r\n                <b>Price:</b>\r\n                <span>");
#nullable restore
#line 18 "D:\Visual Studio 2019\EAP\IceCream\Ice-Cream-master\Ice_Cream\Views\Recipe\RecipeDetails.cshtml"
                 Write(p.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                <br />\r\n                <b>Category:</b>\r\n                <span>");
#nullable restore
#line 21 "D:\Visual Studio 2019\EAP\IceCream\Ice-Cream-master\Ice_Cream\Views\Recipe\RecipeDetails.cshtml"
                 Write(p.Category);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n            </div>\r\n            <div>\r\n                <p>");
#nullable restore
#line 24 "D:\Visual Studio 2019\EAP\IceCream\Ice-Cream-master\Ice_Cream\Views\Recipe\RecipeDetails.cshtml"
              Write(p.RecipeIce);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 28 "D:\Visual Studio 2019\EAP\IceCream\Ice-Cream-master\Ice_Cream\Views\Recipe\RecipeDetails.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IQueryable<Recipe>> Html { get; private set; }
    }
}
#pragma warning restore 1591
