#pragma checksum "D:\CS projects\BugrahanDurukan-HW2\Views\Shared\MagazineSummary.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d18d61774e2c795354def1c32473aa17dfd532c4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_MagazineSummary), @"mvc.1.0.view", @"/Views/Shared/MagazineSummary.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d18d61774e2c795354def1c32473aa17dfd532c4", @"/Views/Shared/MagazineSummary.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c712f6ab9db215b5440c9e51120abc6367bb6541", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_MagazineSummary : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Magazine>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!--Partial view-->\r\n<div class=\"card card-outline-primary m-1 p-1\">\r\n    <div class=\"bg-faded p-1\">\r\n        <h4>\r\n            ");
#nullable restore
#line 6 "D:\CS projects\BugrahanDurukan-HW2\Views\Shared\MagazineSummary.cshtml"
       Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <span class=\"badge badge-pill badge-primary\" style=\"float:right\">\r\n                <small>");
#nullable restore
#line 8 "D:\CS projects\BugrahanDurukan-HW2\Views\Shared\MagazineSummary.cshtml"
                  Write(Model.Price.ToString("c"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\r\n            </span>\r\n        </h4>\r\n    </div>\r\n    <div class=\"card-text p-1\">");
#nullable restore
#line 12 "D:\CS projects\BugrahanDurukan-HW2\Views\Shared\MagazineSummary.cshtml"
                          Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Magazine> Html { get; private set; }
    }
}
#pragma warning restore 1591
