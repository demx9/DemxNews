#pragma checksum "C:\Users\Demian\source\repos\RNN\RNN\Views\Shared\Components\Row\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "95fc5dc8969a1c75dfa527a00d54726af819b512"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Row_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Row/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/Row/Default.cshtml", typeof(AspNetCore.Views_Shared_Components_Row_Default))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"95fc5dc8969a1c75dfa527a00d54726af819b512", @"/Views/Shared/Components/Row/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5cad1950e36dde1494660bdef181ebc4747f8bf0", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Row_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<RNN.Models.ViewModels.ViewComponents.RowViewComponent>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(75, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Demian\source\repos\RNN\RNN\Views\Shared\Components\Row\Default.cshtml"
 foreach (var row in Model) {

#line default
#line hidden
            BeginContext(108, 8, true);
            WriteLiteral("    <div");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 116, "\"", 141, 2);
            WriteAttributeValue("", 124, "row", 124, 3, true);
#line 4 "C:\Users\Demian\source\repos\RNN\RNN\Views\Shared\Components\Row\Default.cshtml"
WriteAttributeValue(" ", 127, row.CssClass, 128, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(142, 3, true);
            WriteLiteral(">\r\n");
            EndContext();
#line 5 "C:\Users\Demian\source\repos\RNN\RNN\Views\Shared\Components\Row\Default.cshtml"
        foreach(var column in row.Columns) {

#line default
#line hidden
            BeginContext(191, 16, true);
            WriteLiteral("            <div");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 207, "\"", 235, 2);
            WriteAttributeValue("", 215, "col-sm-", 215, 7, true);
#line 6 "C:\Users\Demian\source\repos\RNN\RNN\Views\Shared\Components\Row\Default.cshtml"
WriteAttributeValue("", 222, column.Width, 222, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(236, 3, true);
            WriteLiteral(">\r\n");
            EndContext();
#line 7 "C:\Users\Demian\source\repos\RNN\RNN\Views\Shared\Components\Row\Default.cshtml"
                 if (column.Rows != null) {
                    

#line default
#line hidden
            BeginContext(305, 62, false);
#line 8 "C:\Users\Demian\source\repos\RNN\RNN\Views\Shared\Components\Row\Default.cshtml"
               Write(await Component.InvokeAsync("Row", new { rows = column.Rows }));

#line default
#line hidden
            EndContext();
#line 8 "C:\Users\Demian\source\repos\RNN\RNN\Views\Shared\Components\Row\Default.cshtml"
                                                                                   
                }
                else {
                    foreach (var component in column.Components) {
                        

#line default
#line hidden
            BeginContext(505, 79, false);
#line 12 "C:\Users\Demian\source\repos\RNN\RNN\Views\Shared\Components\Row\Default.cshtml"
                   Write(await Component.InvokeAsync(component.GetType(), new { component = component }));

#line default
#line hidden
            EndContext();
#line 12 "C:\Users\Demian\source\repos\RNN\RNN\Views\Shared\Components\Row\Default.cshtml"
                                                                                                        
                    }
                }

#line default
#line hidden
            BeginContext(628, 20, true);
            WriteLiteral("            </div>\r\n");
            EndContext();
#line 16 "C:\Users\Demian\source\repos\RNN\RNN\Views\Shared\Components\Row\Default.cshtml"
        }

#line default
#line hidden
            BeginContext(659, 12, true);
            WriteLiteral("    </div>\r\n");
            EndContext();
#line 18 "C:\Users\Demian\source\repos\RNN\RNN\Views\Shared\Components\Row\Default.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<RNN.Models.ViewModels.ViewComponents.RowViewComponent>> Html { get; private set; }
    }
}
#pragma warning restore 1591
