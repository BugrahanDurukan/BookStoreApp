#pragma checksum "D:\CS projects\BugrahanDurukan-HW2\Views\Novel\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a38a28a9ac239d3a765fa6a162072857b230ac71"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Novel_Detail), @"mvc.1.0.view", @"/Views/Novel/Detail.cshtml")]
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
#line 1 "D:\CS projects\BugrahanDurukan-HW2\Views\_ViewImports.cshtml"
using BugrahanDurukan_HW2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\CS projects\BugrahanDurukan-HW2\Views\_ViewImports.cshtml"
using BugrahanDurukan_HW2.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\CS projects\BugrahanDurukan-HW2\Views\_ViewImports.cshtml"
using BugrahanDurukan_HW2.Models.View_Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a38a28a9ac239d3a765fa6a162072857b230ac71", @"/Views/Novel/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c712f6ab9db215b5440c9e51120abc6367bb6541", @"/Views/_ViewImports.cshtml")]
    public class Views_Novel_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Novel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\CS projects\BugrahanDurukan-HW2\Views\Novel\Detail.cshtml"
  
	ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n<div>\r\n    <h4>Novel</h4>\r\n\t<hr />\r\n\t<dl class=\"row\">\r\n\t\t<dt class = \"col-sm-2\">\r\n\t\t\t");
#nullable restore
#line 14 "D:\CS projects\BugrahanDurukan-HW2\Views\Novel\Detail.cshtml"
       Write(Html.DisplayNameFor(model => model.NovelId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t</dt>\r\n\t\t<dd class = \"col-sm-10\">\r\n\t\t\t");
#nullable restore
#line 17 "D:\CS projects\BugrahanDurukan-HW2\Views\Novel\Detail.cshtml"
       Write(Html.DisplayFor(model => model.NovelId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t</dd>\r\n\r\n\t\t<dt class = \"col-sm-2\">\r\n\t\t\t");
#nullable restore
#line 21 "D:\CS projects\BugrahanDurukan-HW2\Views\Novel\Detail.cshtml"
       Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t</dt>\r\n\t\t<dd class = \"col-sm-10\">\r\n\t\t\t");
#nullable restore
#line 24 "D:\CS projects\BugrahanDurukan-HW2\Views\Novel\Detail.cshtml"
       Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t</dd>\r\n\t\t<dt class = \"col-sm-2\">\r\n\t\t\t");
#nullable restore
#line 27 "D:\CS projects\BugrahanDurukan-HW2\Views\Novel\Detail.cshtml"
       Write(Html.DisplayNameFor(model => model.Category));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t</dt>\r\n\t\t<dd class = \"col-sm-10\">\r\n\t\t\t");
#nullable restore
#line 30 "D:\CS projects\BugrahanDurukan-HW2\Views\Novel\Detail.cshtml"
       Write(Html.DisplayFor(model => model.Category));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t</dd>\r\n\t\t<dt class = \"col-sm-2\">\r\n\t\t\t");
#nullable restore
#line 33 "D:\CS projects\BugrahanDurukan-HW2\Views\Novel\Detail.cshtml"
       Write(Html.DisplayNameFor(model => model.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t</dt>\r\n\t\t<dd class = \"col-sm-10\">\r\n\t\t\t");
#nullable restore
#line 36 "D:\CS projects\BugrahanDurukan-HW2\Views\Novel\Detail.cshtml"
       Write(Html.DisplayFor(model => model.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t</dd>\r\n\t\t<dt class = \"col-sm-2\">\r\n\t\t\t");
#nullable restore
#line 39 "D:\CS projects\BugrahanDurukan-HW2\Views\Novel\Detail.cshtml"
       Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t</dt>\r\n\t\t<dd class = \"col-sm-10\">\r\n\t\t\t");
#nullable restore
#line 42 "D:\CS projects\BugrahanDurukan-HW2\Views\Novel\Detail.cshtml"
       Write(Html.DisplayFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t</dd>\r\n\r\n\t</dl>\r\n</div>\r\n<div>\r\n\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a38a28a9ac239d3a765fa6a162072857b230ac717036", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 48 "D:\CS projects\BugrahanDurukan-HW2\Views\Novel\Detail.cshtml"
                           WriteLiteral(Model.NovelId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\r\n\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a38a28a9ac239d3a765fa6a162072857b230ac719162", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Novel> Html { get; private set; }
    }
}
#pragma warning restore 1591
