#pragma checksum "D:\CS projects\BugrahanDurukan-HW2\Views\Shared\Components\Footer\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4cc93dc9a96dcd6d86e8bc22691f9e594b538e8a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Footer_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Footer/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4cc93dc9a96dcd6d86e8bc22691f9e594b538e8a", @"/Views/Shared/Components/Footer/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c712f6ab9db215b5440c9e51120abc6367bb6541", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Footer_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<string>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<footer class=\"footer myFooter border-top\">\r\n    <div class=\"container\">\r\n");
#nullable restore
#line 5 "D:\CS projects\BugrahanDurukan-HW2\Views\Shared\Components\Footer\Default.cshtml"
         foreach (string ftrText in Model)
        {
           

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\CS projects\BugrahanDurukan-HW2\Views\Shared\Components\Footer\Default.cshtml"
      Write(ftrText);

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\CS projects\BugrahanDurukan-HW2\Views\Shared\Components\Footer\Default.cshtml"
                   
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</footer>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<string>> Html { get; private set; }
    }
}
#pragma warning restore 1591
