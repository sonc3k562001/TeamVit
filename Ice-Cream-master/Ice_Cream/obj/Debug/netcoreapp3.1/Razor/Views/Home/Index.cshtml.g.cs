#pragma checksum "D:\Visual studio code\TeamVit\Ice-Cream-master\Ice_Cream\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "343eea163aa12e66b38a9bb043f7ca619bc07813"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "D:\Visual studio code\TeamVit\Ice-Cream-master\Ice_Cream\Views\_ViewImports.cshtml"
using Ice_Cream;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Visual studio code\TeamVit\Ice-Cream-master\Ice_Cream\Views\_ViewImports.cshtml"
using Ice_Cream.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Visual studio code\TeamVit\Ice-Cream-master\Ice_Cream\Views\_ViewImports.cshtml"
using Ice_Cream.Models.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Visual studio code\TeamVit\Ice-Cream-master\Ice_Cream\Views\_ViewImports.cshtml"
using Ice_Cream.Infrastructure;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"343eea163aa12e66b38a9bb043f7ca619bc07813", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"118ad47d25865380f63af3744309f5ae468eefba", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IQueryable<Product>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/site.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Recipe", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "About", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Contact", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.EnvironmentTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Visual studio code\TeamVit\Ice-Cream-master\Ice_Cream\Views\Home\Index.cshtml"
 foreach (var p in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"col-12 container\" style=\"margin-top:100px;\">\r\n    <div class=\"col-4\" style=\"float:left;\">\r\n        <div style=\"height:30px; margin-bottom:10px;\"><h4>");
#nullable restore
#line 7 "D:\Visual studio code\TeamVit\Ice-Cream-master\Ice_Cream\Views\Home\Index.cshtml"
                                                     Write(p.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4></div>\r\n        <img");
            BeginWriteAttribute("src", " src=", 253, "", 266, 1);
#nullable restore
#line 8 "D:\Visual studio code\TeamVit\Ice-Cream-master\Ice_Cream\Views\Home\Index.cshtml"
WriteAttributeValue("", 258, p.Image, 258, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" height=\"250\" width=\"300\" style=\"margin-bottom:20px;\" />\r\n        <br />\r\n        <b>Description:</b>\r\n        <div style=\"width:300px;height:50px; overflow:auto\">");
#nullable restore
#line 11 "D:\Visual studio code\TeamVit\Ice-Cream-master\Ice_Cream\Views\Home\Index.cshtml"
                                                       Write(p.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n        <div style=\"height:100px\">\r\n            <span style=\"width:300px;\"><b>Ingredient:</b>");
#nullable restore
#line 13 "D:\Visual studio code\TeamVit\Ice-Cream-master\Ice_Cream\Views\Home\Index.cshtml"
                                                    Write(p.Recipe);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n            <br />\r\n            <span><b>Price:</b>");
#nullable restore
#line 15 "D:\Visual studio code\TeamVit\Ice-Cream-master\Ice_Cream\Views\Home\Index.cshtml"
                          Write(p.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n            <br />\r\n            <span><b>Category:</b>");
#nullable restore
#line 17 "D:\Visual studio code\TeamVit\Ice-Cream-master\Ice_Cream\Views\Home\Index.cshtml"
                             Write(p.Category);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n        </div>\r\n        <button class=\"btn btn-info\" style=\"margin-bottom:50px;\">Add Bill</button>\r\n    </div>\r\n</div>\r\n");
#nullable restore
#line 22 "D:\Visual studio code\TeamVit\Ice-Cream-master\Ice_Cream\Views\Home\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n﻿\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("environment", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "343eea163aa12e66b38a9bb043f7ca619bc078138804", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "343eea163aa12e66b38a9bb043f7ca619bc078139073", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.EnvironmentTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<div>
    <header>
        <div class=""container"">
            <div class=""top-bar-left"">

                <div class=""logo"">
                    <a href=""/#""><span>ICE CREAM</span></a>
                </div>
                <div class=""menu-wrapper"">
                    <ul class=""menu-ul"">
                        <li>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "343eea163aa12e66b38a9bb043f7ca619bc0781311300", async() => {
                WriteLiteral("<span style=\"color:#d41442;font-size:20px\">Home</span>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\r\n                        <li>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "343eea163aa12e66b38a9bb043f7ca619bc0781312745", async() => {
                WriteLiteral("<span>Recipe</span>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\r\n                        <li>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "343eea163aa12e66b38a9bb043f7ca619bc0781314153", async() => {
                WriteLiteral("<span>About</span>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\r\n                        <li>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "343eea163aa12e66b38a9bb043f7ca619bc0781315560", async() => {
                WriteLiteral("<span>Contact</span>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"</li>
                    </ul>
                </div>
            </div>
            <div class=""top-bar-right"">
                <div class=""login"">
                    <span></span>
                </div>
            </div>
        </div>
        <div class=""header-slider-text"">
            <p>ICE CREAM</p>
            <p>MADE WITH</p>
            <span style=""color:#d41442;font-size:59px"">PASSION</span>
        </div>
        <div class=""header-slider-glass-milk"">
            <img src=""https://themes.muffingroup.com/be/icecream2/wp-content/uploads/2019/09/icecream2-slider-pic5.png"" width=""171"" height=""174"" />
            <div class=""slide-text-milk"">
                <span>Lorem ipsum dolor sit amet</span><br />
                <span>enim. Etiam  malesuada elit</span><br />
                <span>lectus felis, malesuada dolor </span><br />
                <span>ultricies. Curabitur ligula.  </span><br />
            </div>
        </div>
        <div class=""header-slider-circle"">
   ");
            WriteLiteral(@"         <img src=""https://themes.muffingroup.com/be/icecream2/wp-content/uploads/2019/09/icecream2-slider-pic1.png"" width=""533"" height=""533"" />
        </div>
        <div class=""header-slider-cream"">
            <img src=""https://themes.muffingroup.com/be/icecream2/wp-content/uploads/2019/09/icecream2-slider-pic7.png"" width=""235"" height=""557"" />
        </div>
        <div class=""header-silder-moderm"">
            <img src=""https://themes.muffingroup.com/be/icecream2/wp-content/uploads/2019/09/icecream2-slider-pic4.png"" width=""281"" height=""222"" />
        </div>

        <div class=""header-slider-circle-mini-one"">
            <img src=""https://themes.muffingroup.com/be/icecream2/wp-content/uploads/2019/09/icecream2-slider-pic6.png"" width=""26"" height=""26"" />
        </div>
        <span class=""slider-16"">16</span><br />
        <span class=""slider-cafes"">cafes</span>

        <div class=""header-slider-circle-mini-two"">
            <img src=""https://themes.muffingroup.com/be/icecream2/wp-conte");
            WriteLiteral(@"nt/uploads/2019/09/icecream2-slider-pic6.png"" width=""26"" height=""26"" />
        </div>
        <span class=""slider-23"">23</span><br />
        <span class=""slider-trucks"">food trucks</span>


    </header>

    <section class=""contentTop"">
        <div class=""container"">

            <div class=""title-content-1"">
                <h3>TRADITION AND LOVE</h3>
                <h2>HOW IT’S MADE?</h2>
            </div>

            <div class=""col-12 content-1"">

                <div class=""col-6 img-cow"">
                    <img src=""https://themes.muffingroup.com/be/icecream2/wp-content/uploads/2019/09/icecream2-home-pic4.png"" width=""100%"" height=""100%""");
            BeginWriteAttribute("alt", " alt=\"", 4387, "\"", 4393, 0);
            EndWriteAttribute();
            WriteLiteral(@" />
                </div>

                <div class=""col-6 text-cow"">
                    <h6>Fusce ut velit laoreet, tempus arcu eu, molestie tortor. Nam vel justo cursus, faucibus lorem eget, egestas eros. Maecenas eleifend erat at justo fringilla.</h6>
                    <p style=""margin:50px 0;color:#907e82"">Curabitur lacinia enim at ex blandit, vel pellentesque odio elementum. Mauris rhoncus orci in imperdiet placerat. Vestibulum euismod nisl suscipit ligula volutpat, a feugiat urna maximus. Cras massa nibh, tincidunt.</p>
                    <p style=""color:#907e82"">Aliquam erat volutpat. Aenean accumsan.</p>
                </div>
            </div>

        </div>
    </section>

    <section class=""contentShowUp col-12"">
        <div class=""container"">
            <div class=""col-4 contentChild"">
                <img src=""https://themes.muffingroup.com/be/icecream2/wp-content/uploads/2019/09/icecream2-home-icon1.png"" />
                <h2>72l</h2>
                <h6>Aliquam ac");
            WriteLiteral(@" dui vel dui vulputate consectetur. Mauris massa.</h6>
            </div>
            <div class=""col-4 contentChild"">
                <img src=""https://themes.muffingroup.com/be/icecream2/wp-content/uploads/2019/09/icecream2-home-icon2.png"" />
                <h2>16kg</h2>
                <h6>Aliquam ac dui vel dui vulputate consectetur. Mauris massa.</h6>
            </div>
            <div class=""col-4 contentChild"">
                <img src=""https://themes.muffingroup.com/be/icecream2/wp-content/uploads/2019/09/icecream2-home-icon3.png"" />
                <h2>84</h2>
                <h6>Aliquam ac dui vel dui vulputate consectetur. Mauris massa.</h6>
            </div>
        </div>
    </section>
</div>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IQueryable<Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
