#pragma checksum "C:\Users\son10\Downloads\TeamVit-master\Ice-Cream-master\Ice_Cream\Views\About\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a2a75fe69043a02b0e79e377ed2ec2d914391c02"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_About_Index), @"mvc.1.0.view", @"/Views/About/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a2a75fe69043a02b0e79e377ed2ec2d914391c02", @"/Views/About/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"27a42a902c36709f076743b6cb10e6fdf8b07436", @"/Views/_ViewImports.cshtml")]
    public class Views_About_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Ice_Cream.Models.Product>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Recipe", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "About", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Contact", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("environment", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a2a75fe69043a02b0e79e377ed2ec2d914391c025160", async() => {
                WriteLiteral("\n    <link rel=\"stylesheet\" href=\"/css/about.css\" />\n");
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
            WriteLiteral("\n\n\n");
            WriteLiteral("<div style=\"background:#f9b3cf;\">\n    <div class=\"top-bar-left\">\n        <div class=\"logo\">\n            <a href=\"/#\"><span>ICE CREAM</span></a>\n        </div>\n        <div class=\"menu-wrapper\">\n            <ul class=\"menu-ul\">\n                <li>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a2a75fe69043a02b0e79e377ed2ec2d914391c026490", async() => {
                WriteLiteral("<span>Home</span>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\n                <li>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a2a75fe69043a02b0e79e377ed2ec2d914391c027885", async() => {
                WriteLiteral("<span>Recipe</span>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\n                <li>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a2a75fe69043a02b0e79e377ed2ec2d914391c029282", async() => {
                WriteLiteral("<span style=\"color:#d41442;font-size:20px\">About</span>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\n                <li>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a2a75fe69043a02b0e79e377ed2ec2d914391c0210717", async() => {
                WriteLiteral("<span>Contact</span>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
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


<div style=""background-image: url(https://themes.muffingroup.com/be/icecream2/wp-content/uploads/2019/09/icecream2-subheader1.jpg);
        background-repeat: no-repeat;
        background-size: cover; height:580px"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-6"">
                <h1 class=""title""
                    style=""width: 100%; font-size: 70px; line-height: 70px; font-weight: 400; letter-spacing: 0px; font-family: 'Titan One', Arial, Tahoma, sans-serif;color:white;margin-top: 200px"">
                    A FEW WORDS ABOUT US
                </h1>
            </div>
        </div>
    </div>
</div>
<div style=""background-color:white"">
    <div class=""container"">
        <div class=""row"" style=""padding-top:120px;padding-bottom:80px"">
            <div class=""col-6"" style=""padding: 40px 6% 0 0"">
    ");
            WriteLiteral(@"            <h3 style=""color: #ffa5ba;font-family: 'Titan One', Arial, Tahoma, sans-serif"">ORCI VARIUS</h3>
                <h2 style=""color: #D41442;font-family: 'Titan One', Arial, Tahoma, sans-serif"">TORQUENT</h2>
                <h6 style=""font-family: 'DM Sans', Arial, Tahoma, sans-serif; "">
                    Vivamus in diam turpis. In condimentum maximus tristique.
                    Maecenas non laoreet odio. Fusce lobortis porttitor purus,
                    vel vestibulum libero pharetra vel. Pellentesque lorem augue,
                    fermentum nec nibh et, fringilla sollicitudin orci.
                </h6>
                <p style=""font-family: 'DM Sans', Arial, Tahoma, sans-serif;color: #907e82;"">
                    Integer pharetra magna non ante blandit lobortis. Sed mollis consequat eleifend.
                    Aliquam consectetur orci eget dictum tristique.
                    Aenean et sodales est, ut vestibulum lorem. Ut ultricies imperdiet sodales. Aliquam fringilla.
               ");
            WriteLiteral(@" </p>
                <p style=""font-family: 'DM Sans', Arial, Tahoma, sans-serif;color: #907e82;"">
                    Integer magna purus, commodo in diam nec, pretium auctor sapien.
                    In pulvinar, ipsum eu dignissim facilisis, massa justo varius purus,
                    non dictum elit nibh ut massa.
                </p>
                <button>READ MORE </button>
            </div>
            <div class=""col-6"">
                <img src=""https://themes.muffingroup.com/be/icecream2/wp-content/uploads/2019/09/icecream2-about-pic1.jpg"" width=""100%"" height=""650"" />
            </div>
        </div>
    </div>
</div>
<div style=""background-color: #FFF5F7;
        background-image: url(https://themes.muffingroup.com/be/icecream2/wp-content/uploads/2019/09/icecream2-sectionbg4.png);
        background-repeat: no-repeat;
        background-size: cover;
    "">
    <div class=""container"">
        <div style=""padding: 120px 0 80px"">
            <h3 style=""color:#FFA5BA;
                 margin:0");
            WriteLiteral(@"px 0px 15px;
                 font-family:'Titan One', Arial, Tahoma, sans-serif;
                 text-align:center;
                 font-size:30px;
                 line-height:40px;
                 font-weight:400;
                 letter-spacing:0px"">
                MEET
            </h3>
            <h2 style=""
                margin: 0px 0px 15px;
                font-size: 60px;
                line-height: 60px;
                font-weight: 400;
                letter-spacing: 0px;
                color: #d41422;
                text-align: center ;
                font-family: 'Titan One', Arial, Tahoma, sans-serif;"">
                OUR TEAM
            </h2>
            <div class=""container"" style=""width: 170px;padding: 10px 0"">
                <button style=""margin:auto"">CONTACT US </button>
            </div>
        </div>
        <div class=""row"" style=""padding-top: 80px; padding-bottom: 50px;width:100%"">
            <div class=""col-4"">
                <div class=""container form"">
         ");
            WriteLiteral(@"           <img src=""https://themes.muffingroup.com/be/icecream2/wp-content/uploads/2019/09/icecream2-about-pic2.png"" alt=""Alternate Text"" height=""400"" width=""92%"" style=""margin:-30px 13px 0"" />
                    <div style=""margin:20px 0"">
                        <h4>HANH</h4>
                        <p style=""color:#907282;font-family:'Rubik', sans-serif"">Hahahaha</p>
                    </div>
                </div>
            </div>
            <div class=""col-4"" style=""margin-top: -50px"">
                <div class=""container form"">
                    <img src=""https://themes.muffingroup.com/be/icecream2/wp-content/uploads/2019/09/icecream2-about-pic2.png"" alt=""alternate text"" height=""400"" width=""92%"" style=""margin:-30px 13px 0"" />
                    <div style=""margin:20px 0"">
                        <h4>MINH</h4>
                        <p style=""color:#907282;font-family:'Rubik', sans-serif"">Hahahaha</p>
                    </div>
                </div>
            </div>
            <div class=""");
            WriteLiteral(@"col-4"">
                <div class=""container form"">
                    <img src=""https://themes.muffingroup.com/be/icecream2/wp-content/uploads/2019/09/icecream2-about-pic2.png"" alt=""Alternate Text"" height=""400"" width=""92%"" style=""margin:-30px 13px 0"" />
                    <div style=""margin:20px 0"">
                        <h4>QUYNH</h4>
                        <p style=""color:#907282;font-family:'Rubik', sans-serif"">Hahahaha</p>
                    </div>
                </div>
            </div>
        </div>
        <div class=""row"" style=""padding-top: 10px; padding-bottom: 250px;width:100%"">
            <div class=""col-6"">
                <div class=""container form-user"" style=""float:right"">
                    <img src=""https://themes.muffingroup.com/be/icecream2/wp-content/uploads/2019/09/icecream2-about-pic2.png"" alt=""Alternate Text"" height=""400"" width=""92%"" style=""margin:-30px 13px 0"" />
                    <div style=""margin:20px 0"">
                        <h4>AN</h4>
                        <p");
            WriteLiteral(@">Hahahaha</p>
                    </div>
                </div>
            </div>
            <div class=""col-6"">
                <div class=""container form-user"" style=""float:left"">
                    <img src=""https://themes.muffingroup.com/be/icecream2/wp-content/uploads/2019/09/icecream2-about-pic2.png"" alt=""Alternate Text"" height=""400"" width=""92%"" style=""margin:-30px 13px 0"" />
                    <div style=""margin:20px 0"">
                        <h4>SON</h4>
                        <p>Hahahaha</p>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
<div style=""background-color:white;padding-bottom: 300px"">
    <div class=""container"">
        <img src=""https://themes.muffingroup.com/be/icecream2/wp-content/uploads/2019/09/icecream2-home-pic5.jpg"" width=""1900"" height=""650"" style=""margin: 0 -395px"" />
    </div>
</div>
<div style=""background-color: #FFF5F7;
        background-image: url(https://themes.muffingroup.com/be/icecream2/wp-content/uploads/2019");
            WriteLiteral(@"/09/icecream2-sectionbg4.png);
        background-repeat: no-repeat;
        background-size: cover;
"">
    <div class=""container"">
        <div class=""row"" style=""padding-bottom: 50px;width:100%"">
            <div class=""col-4 content"">
                <div class=""container form-content"" style=""width: 100%;background-color: white;border-radius:20px;box-shadow: 0px 0px 20px 0px #d5d3d3"">
                    <span>CAFE</span>
                    <h6>Chicago</h6>
                    <p style=""color:#907E82"">Fusce ut velit laoreet, tempus arcu molestie vulputate</p>
                    <hr style=""margin: 30px 0 30px; color:#907E82"" />
                    <h6>Monday-Friday</h6>
                    <p style=""color:#ffa5ba;"">06:00 AM - 10:00 PM</p>
                    <h6>Monday-Friday</h6>
                    <p style=""color:#ffa5ba;"">06:00 AM - 10:00 PM</p>
                    <hr style=""margin: 30px 0 30px; color:#907E82"" />
                    <p style=""color:#907E82;padding-bottom: 30px"">
                     ");
            WriteLiteral(@"   +61(0) 383 766 284<br />
                        noreply@envato.com
                    </p>
                </div>
            </div>
            <div class=""col-4 content"">
                <div class=""container form-content"" style=""width: 100%;background-color: white;border-radius:20px;box-shadow: 0px 0px 20px 0px #d5d3d3"">
                    <span>CAFE</span>
                    <h6>Chicago</h6>
                    <p style=""color:#907E82"">Fusce ut velit laoreet, tempus arcu molestie vulputate</p>
                    <hr style=""margin: 30px 0 30px; color:#907E82"" />
                    <h6>Monday-Friday</h6>
                    <p style=""color:#ffa5ba;"">06:00 AM - 10:00 PM</p>
                    <h6>Monday-Friday</h6>
                    <p style=""color:#ffa5ba;"">06:00 AM - 10:00 PM</p>
                    <hr style=""margin: 30px 0 30px; color:#907E82"" />
                    <p style=""color:#907E82;padding-bottom: 30px"">
                        +61(0) 383 766 284<br />
                        noreply@");
            WriteLiteral(@"envato.com
                    </p>
                </div>
            </div>
            <div class=""col-4 content"">
                <div class=""container form-content"" style=""width: 100%;background-color: white;border-radius:20px;box-shadow: 0px 0px 20px 0px #d5d3d3"">
                    <span>CAFE</span>
                    <h6>Chicago</h6>
                    <p style=""color:#907E82"">Fusce ut velit laoreet, tempus arcu molestie vulputate</p>
                    <hr style=""margin: 30px 0 30px; color:#907E82"" />
                    <h6>Monday-Friday</h6>
                    <p style=""color:#ffa5ba;"">06:00 AM - 10:00 PM</p>
                    <h6>Monday-Friday</h6>
                    <p style=""color:#ffa5ba;"">06:00 AM - 10:00 PM</p>
                    <hr style=""margin: 30px 0 30px; color:#907E82"" />
                    <p style=""color:#907E82;padding-bottom: 30px"">
                        +61(0) 383 766 284<br />
                        noreply@envato.com
                    </p>
                </div>
 ");
            WriteLiteral(@"           </div>
        </div>
        <div>
            <div class=""container"" style=""width: 170px;padding: 10px 0 150px"">
                <div class=""row"">
                    <div class=""col-6"">
                        <button style=""margin:auto;background-color: #d41442;width:170px; height:50px;outline:0;border:0;border-radius:25px;color:white;float:right""> Our locations -></button>
                    </div>
                    <div class=""col-6"">
                        <button style=""margin:auto;background-color: #fff;width:170px; height:50px;outline:0;border:0;border-radius:25px;color:#d41442;float:left""> Franchise -></button>
                    </div>
                </div>
            </div>
        </div>
    </div>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Ice_Cream.Models.Product> Html { get; private set; }
    }
}
#pragma warning restore 1591
