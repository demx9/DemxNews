#pragma checksum "C:\Users\Demian\source\repos\RNN\RNN\Views\Shared\Components\Post\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e3df5c17d8ba4eba8adb4f79c47c0518a0cdff61"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Post_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Post/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/Post/Default.cshtml", typeof(AspNetCore.Views_Shared_Components_Post_Default))]
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
#line 1 "C:\Users\Demian\source\repos\RNN\RNN\Views\_ViewImports.cshtml"
using RNN;

#line default
#line hidden
#line 2 "C:\Users\Demian\source\repos\RNN\RNN\Views\_ViewImports.cshtml"
using RNN.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e3df5c17d8ba4eba8adb4f79c47c0518a0cdff61", @"/Views/Shared/Components/Post/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5cad1950e36dde1494660bdef181ebc4747f8bf0", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Post_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RNN.Models.ViewModels.ViewComponents.PostViewComponent>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 26, true);
            WriteLiteral("<!--\r\n    post view\r\n-->\r\n");
            EndContext();
            BeginContext(89, 22, true);
            WriteLiteral("\r\n<div class=\"post\">\r\n");
            EndContext();
#line 7 "C:\Users\Demian\source\repos\RNN\RNN\Views\Shared\Components\Post\Default.cshtml"
     foreach (var topic in Model.Topics) {

#line default
#line hidden
            BeginContext(155, 31, true);
            WriteLiteral("        <span class=\"post-tag\">");
            EndContext();
            BeginContext(187, 5, false);
#line 8 "C:\Users\Demian\source\repos\RNN\RNN\Views\Shared\Components\Post\Default.cshtml"
                          Write(topic);

#line default
#line hidden
            EndContext();
            BeginContext(192, 9, true);
            WriteLiteral("</span>\r\n");
            EndContext();
#line 9 "C:\Users\Demian\source\repos\RNN\RNN\Views\Shared\Components\Post\Default.cshtml"
    }

#line default
#line hidden
            BeginContext(208, 46, true);
            WriteLiteral("    <span class=\"post-span-divider\">/</span><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 254, "\"", 271, 1);
#line 10 "C:\Users\Demian\source\repos\RNN\RNN\Views\Shared\Components\Post\Default.cshtml"
WriteAttributeValue("", 261, Model.Url, 261, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(272, 26, true);
            WriteLiteral("><span class=\"post-title\">");
            EndContext();
            BeginContext(299, 11, false);
#line 10 "C:\Users\Demian\source\repos\RNN\RNN\Views\Shared\Components\Post\Default.cshtml"
                                                                                     Write(Model.Title);

#line default
#line hidden
            EndContext();
            BeginContext(310, 19, true);
            WriteLiteral("</span></a>\r\n</div>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RNN.Models.ViewModels.ViewComponents.PostViewComponent> Html { get; private set; }
    }
}
#pragma warning restore 1591
