#pragma checksum "D:\Visual Studio 2019\EAP\IceTeam\TeamVit\Ice-Cream\Ice_Cream\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "916c1d122cf30f38c4f1eaf9f28b95c108a0bce1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
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
#line 1 "D:\Visual Studio 2019\EAP\IceTeam\TeamVit\Ice-Cream\Ice_Cream\Views\_ViewImports.cshtml"
using Ice_Cream;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Visual Studio 2019\EAP\IceTeam\TeamVit\Ice-Cream\Ice_Cream\Views\_ViewImports.cshtml"
using Ice_Cream.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Visual Studio 2019\EAP\IceTeam\TeamVit\Ice-Cream\Ice_Cream\Views\_ViewImports.cshtml"
using Ice_Cream.Models.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Visual Studio 2019\EAP\IceTeam\TeamVit\Ice-Cream\Ice_Cream\Views\_ViewImports.cshtml"
using Ice_Cream.Infrastructure;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"916c1d122cf30f38c4f1eaf9f28b95c108a0bce1", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"27a42a902c36709f076743b6cb10e6fdf8b07436", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap/dist/css/bootstrap.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/fontawesome-free-5.15.1-web/css/all.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/fontawesome-free-5.15.1-web/js/all.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\n<html lang=\"en\">\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "916c1d122cf30f38c4f1eaf9f28b95c108a0bce15341", async() => {
                WriteLiteral("\n    <meta charset=\"utf-8\" />\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\" />\n    <title>");
#nullable restore
#line 6 "D:\Visual Studio 2019\EAP\IceTeam\TeamVit\Ice-Cream\Ice_Cream\Views\Shared\_Layout.cshtml"
      Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("  Ice_Cream</title>\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "916c1d122cf30f38c4f1eaf9f28b95c108a0bce15985", async() => {
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
                WriteLiteral(@"

    <link rel=""stylesheet"" id=""mfn-fonts-css"" href=""https://fonts.googleapis.com/css?family=DM+Sans%3A1%2C300%2C400%2C400italic%2C500%2C700%2C700italic%7CTitan+One%3A1%2C300%2C400%2C400italic%2C500%2C700%2C700italic&amp;ver=5.3.6"" type=""text/css"" media=""all"">
    <link rel=""stylesheet"" id=""Montserrat-css"" href=""https://fonts.googleapis.com/css?family=Montserrat%3A400%2C500&amp;ver=5.3.6"" type=""text/css"" media=""all"">
    <link rel=""preconnect"" href=""https://fonts.gstatic.com"">
    <link href=""https://fonts.googleapis.com/css2?family=Titan+One&display=swap"" rel=""stylesheet"">
    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "916c1d122cf30f38c4f1eaf9f28b95c108a0bce17770", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "916c1d122cf30f38c4f1eaf9f28b95c108a0bce18947", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("defer", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
    <style>
        footer {
            width: 100%;
            height: 395px;
            float: left;
        }

            footer .widgets-wapper {
                padding-top: 80px;
                width: 100%;
                height: 305px;
            }

        .columns-footer-one {
            float: left;
        }

            .columns-footer-one h3 {
                color: #ffa5ba;
                font-family: ""Titan One"", Arial, Tahoma, sans-serif;
                font-size: 30px;
                line-height: 40px;
                font-weight: 400;
                letter-spacing: 0px;
            }

            .columns-footer-one h2 {
                color: #d41442;
                font-family: ""Titan One"", Arial, Tahoma, sans-serif;
                font-size: 60px;
                line-height: 60px;
                font-weight: 400;
                letter-spacing: 0px;
            }

        .columns-footer-two {
            float: left;
            position: relative;
        }

           ");
                WriteLiteral(@" .columns-footer-two p {
                display: inline-flex;
                padding-left: 400px;
                font-size: 35px;
                float: right;
                width: 100%;
            }

                .columns-footer-two p a {
                    color: #ffa5ba;
                    border-radius: 100%;
                    padding-right: 20px;
                }

                    .columns-footer-two p a:hover {
                        color: #d41442;
                        transition: 2s;
                    }

                    .columns-footer-two p a i {
                        background: #ffa5ba;
                        color: #fff5f7;
                    }

            .columns-footer-two h6 {
                float: right;
                width: 100%;
                font-family: ""DM Sans"", Arial, Tahoma, sans-serif;
            }

                .columns-footer-two h6 span {
                    color: #d41442
                }

        .text-contact-footer {
            margin");
                WriteLiteral(@"-top: 20px;
            font-weight: 500;
            float: right;
            font-family: ""DM Sans"", Arial, Tahoma, sans-serif;
        }

        .footer-copy {
            width: 100%;
            height: 90px;
            border-top: 1px solid #b3a0a4;
        }

        .copy-right {
            text-align: center;
            padding-top: 35px;
        }

            .copy-right span {
                color: #907e82
            }

            .copy-right a {
                color: #ffa5ba;
            }

                .copy-right a:hover {
                    color: #a8092f;
                    transition: 2s;
                }
    </style>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "916c1d122cf30f38c4f1eaf9f28b95c108a0bce113852", async() => {
                WriteLiteral("\n\n    <main role=\"main\" class=\"pb-3\">\n        ");
#nullable restore
#line 124 "D:\Visual Studio 2019\EAP\IceTeam\TeamVit\Ice-Cream\Ice_Cream\Views\Shared\_Layout.cshtml"
   Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
    </main>

    <footer>
        <div class=""widgets-wapper"">
            <div class=""container"">
                <div class=""columns-footer-one col-6"">
                    <h3>HOMEMADE ICE CREAM MADE</h3>
                    <h2>WITH PASSION</h2>
                </div>
                <div class=""columns-footer-two col-6"">
                    <p>
                        <a href=""twitter.com""><i class=""fab fa-twitter-square""></i></a>
                        <a href=""facebook.com""><i class=""fab fa-facebook-square""></i></a>
                        <a href=""skype.com""><i class=""fab fa-skype""></i></a>
                    </p>
                    <div class=""text-contact-footer"">
                        <h6>
                            Feel free to contact
                            <span>+84 1892938283</span>
                        </h6>
                    </div>
                </div>
            </div>
        </div>
        <div class=""footer-copy"">
            <div class=""copy-right"">
                <sp");
                WriteLiteral("an> © 2020 BeIceCream 2 - BeTheme. All Rights Reserved. </span>\n                <a target=\"_blank\" href=\"#\">About Us</a>\n            </div>\n        </div>\n    </footer>\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n</html>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
