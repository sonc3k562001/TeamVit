#pragma checksum "C:\Users\son10\Downloads\TeamVit-master\Ice-Cream-master\Ice_Cream\Views\Product\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f722a42ce1236993a12410768f78b744810d9117"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Index), @"mvc.1.0.view", @"/Views/Product/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f722a42ce1236993a12410768f78b744810d9117", @"/Views/Product/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"27a42a902c36709f076743b6cb10e6fdf8b07436", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductsListViewModel>
    {
        private global::AspNetCore.Views_Product_Index.__Generated__NavigationMenuViewComponentTagHelper __NavigationMenuViewComponentTagHelper;
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "ProductSummary", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("page-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("page-class", "btn", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("page-class-normal", "btn-outline-dark", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("page-class-selected", "btn-primary", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn-group pull-right m-1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        private global::Ice_Cream.Infrastructure.PageLinkTagHelper __Ice_Cream_Infrastructure_PageLinkTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("vc:navigation-menu", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f722a42ce1236993a12410768f78b744810d91175701", async() => {
            }
            );
            __NavigationMenuViewComponentTagHelper = CreateTagHelper<global::AspNetCore.Views_Product_Index.__Generated__NavigationMenuViewComponentTagHelper>();
            __tagHelperExecutionContext.Add(__NavigationMenuViewComponentTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

<style>
    body {
    }

    h1 {
        font-size: 65px;
        line-height: 65px;
        padding-left: 300px;
        padding-top: 270px;
        color: white;
        font-weight: 600;
    }

    .section {
        position: relative;
    }

    .one-third {
        width: 33.333%;
    }

    .mcb-wrap {
        float: left;
        position: relative;
        z-index: 1;
        box-sizing: border-box;
    }

    .one.column {
        width: 98%;
    }

    .column, .columns {
        float: left;
        margin: 0 1% 40px;
    }

    .image_frame {
        border-color: #f8f8f8;
    }

    .image_wrapper {
        border-color: #e2e2e2;
        position: relative;
        overflow: hidden;
        box-sizing: border-box;
    }

    .scale-with-grid {
        max-width: 100%;
        height: auto;
    }

    hr {
        display: block;
        border: none;
        outline: none;
        height: 1px;
        width: 100%;
        margin: 0 a");
            WriteLiteral(@"uto 15px;
        clear: both;
    }

        hr .no_line {
            background: none;
            color: transparent;
        }

    h6 {
        font-size: 17px;
        line-height: 28px;
        font-weight: 500;
        letter-spacing: 0px;
        font-family: ""DM Sans"", Arial, Tahoma, sans-serif;
    }

    h4 {
        font-size: 25px;
        line-height: 35px;
        font-weight: 400;
        letter-spacing: 0px;
        font-family: ""Titan One"", Arial, Tahoma, sans-serif;
    }

        h4 a {
            font-weight: inherit;
            text-decoration: none;
        }

    .image_frame {
        border-color: #f8f8f8;
    }

        .image_frame.no_border {
            border-width: 0;
        }

</style>

<div");
            BeginWriteAttribute("class", " class=\"", 1852, "\"", 1860, 0);
            EndWriteAttribute();
            WriteLiteral(@" style=""background-image: url(https://themes.muffingroup.com/be/icecream2/wp-content/uploads/2019/09/icecream2-subheader3.jpg);
        background-repeat: no-repeat;
        background-size: cover;
        height: 550px;
        background-color: #fff5f7;
    "">
    <div>
        <h1 style=""font-size: 65px;
    line-height: 65px;
    padding-left: 300px;
    padding-top: 270px;
    color: white;
    font-weight: 600;"">
            ICE CREAM<br style=""color:red"" /> RECIPES
        </h1>
    </div>
</div>




<div style=""background-color:#fff5f7; padding-top:100px; height:1600px"">
    <div class=""container"">
        <div class=""text-center"" style=""max-width:1060px"">
");
#nullable restore
#line 128 "C:\Users\son10\Downloads\TeamVit-master\Ice-Cream-master\Ice_Cream\Views\Product\Index.cshtml"
                 foreach (var p in Model.Products)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f722a42ce1236993a12410768f78b744810d91179581", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 130 "C:\Users\son10\Downloads\TeamVit-master\Ice-Cream-master\Ice_Cream\Views\Product\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = p;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
#nullable restore
#line 131 "C:\Users\son10\Downloads\TeamVit-master\Ice-Cream-master\Ice_Cream\Views\Product\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\n        </div>\n    </div>\n\n\n\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f722a42ce1236993a12410768f78b744810d911711452", async() => {
                WriteLiteral("\n            ");
            }
            );
            __Ice_Cream_Infrastructure_PageLinkTagHelper = CreateTagHelper<global::Ice_Cream.Infrastructure.PageLinkTagHelper>();
            __tagHelperExecutionContext.Add(__Ice_Cream_Infrastructure_PageLinkTagHelper);
#nullable restore
#line 138 "C:\Users\son10\Downloads\TeamVit-master\Ice-Cream-master\Ice_Cream\Views\Product\Index.cshtml"
__Ice_Cream_Infrastructure_PageLinkTagHelper.PageModel = Model.PagingInfo;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("page-model", __Ice_Cream_Infrastructure_PageLinkTagHelper.PageModel, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Ice_Cream_Infrastructure_PageLinkTagHelper.PageAction = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#nullable restore
#line 138 "C:\Users\son10\Downloads\TeamVit-master\Ice-Cream-master\Ice_Cream\Views\Product\Index.cshtml"
__Ice_Cream_Infrastructure_PageLinkTagHelper.PageClassesEnabled = true;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("page-classes-enabled", __Ice_Cream_Infrastructure_PageLinkTagHelper.PageClassesEnabled, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Ice_Cream_Infrastructure_PageLinkTagHelper.PageClass = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Ice_Cream_Infrastructure_PageLinkTagHelper.PageClassNormal = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Ice_Cream_Infrastructure_PageLinkTagHelper.PageClassSelected = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Ice_Cream_Infrastructure_PageLinkTagHelper.PageUrlValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("page-url-category", "Ice_Cream.Infrastructure.PageLinkTagHelper", "PageUrlValues"));
            }
#nullable restore
#line 141 "C:\Users\son10\Downloads\TeamVit-master\Ice-Cream-master\Ice_Cream\Views\Product\Index.cshtml"
__Ice_Cream_Infrastructure_PageLinkTagHelper.PageUrlValues["category"] = Model.CurrentCategory;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("page-url-category", __Ice_Cream_Infrastructure_PageLinkTagHelper.PageUrlValues["category"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductsListViewModel> Html { get; private set; }
        [Microsoft.AspNetCore.Razor.TagHelpers.HtmlTargetElementAttribute("vc:navigation-menu")]
        public class __Generated__NavigationMenuViewComponentTagHelper : Microsoft.AspNetCore.Razor.TagHelpers.TagHelper
        {
            private readonly global::Microsoft.AspNetCore.Mvc.IViewComponentHelper __helper = null;
            public __Generated__NavigationMenuViewComponentTagHelper(global::Microsoft.AspNetCore.Mvc.IViewComponentHelper helper)
            {
                __helper = helper;
            }
            [Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeNotBoundAttribute, global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewContextAttribute]
            public global::Microsoft.AspNetCore.Mvc.Rendering.ViewContext ViewContext { get; set; }
            public override async global::System.Threading.Tasks.Task ProcessAsync(Microsoft.AspNetCore.Razor.TagHelpers.TagHelperContext __context, Microsoft.AspNetCore.Razor.TagHelpers.TagHelperOutput __output)
            {
                (__helper as global::Microsoft.AspNetCore.Mvc.ViewFeatures.IViewContextAware)?.Contextualize(ViewContext);
                var __helperContent = await __helper.InvokeAsync("NavigationMenu", new {  });
                __output.TagName = null;
                __output.Content.SetHtmlContent(__helperContent);
            }
        }
    }
}
#pragma warning restore 1591
