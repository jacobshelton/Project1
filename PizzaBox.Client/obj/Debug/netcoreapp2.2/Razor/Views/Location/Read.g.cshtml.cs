#pragma checksum "C:\revature\Project1\PizzaBox.Client\Views\Location\Read.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "20889cd9ba0578886ae2ee9067284ddd5d1b670c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Location_Read), @"mvc.1.0.view", @"/Views/Location/Read.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Location/Read.cshtml", typeof(AspNetCore.Views_Location_Read))]
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
#line 1 "C:\revature\Project1\PizzaBox.Client\Views\_ViewImports.cshtml"
using PizzaBox.Client;

#line default
#line hidden
#line 2 "C:\revature\Project1\PizzaBox.Client\Views\_ViewImports.cshtml"
using PizzaBox.Client.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"20889cd9ba0578886ae2ee9067284ddd5d1b670c", @"/Views/Location/Read.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0869890531cd973fc94231944f02086ee7830497", @"/Views/_ViewImports.cshtml")]
    public class Views_Location_Read : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<PizzaBox.Domain.Models.Location>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(46, 8, true);
            WriteLiteral("\r\n<ul>\r\n");
            EndContext();
#line 4 "C:\revature\Project1\PizzaBox.Client\Views\Location\Read.cshtml"
   foreach (var item in Model)
  {

#line default
#line hidden
            BeginContext(91, 8, true);
            WriteLiteral("    <li>");
            EndContext();
            BeginContext(100, 12, false);
#line 6 "C:\revature\Project1\PizzaBox.Client\Views\Location\Read.cshtml"
   Write(item.Address);

#line default
#line hidden
            EndContext();
            BeginContext(112, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 7 "C:\revature\Project1\PizzaBox.Client\Views\Location\Read.cshtml"
  }

#line default
#line hidden
            BeginContext(124, 5, true);
            WriteLiteral("</ul>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<PizzaBox.Domain.Models.Location>> Html { get; private set; }
    }
}
#pragma warning restore 1591
