#pragma checksum "C:\revature\Project1\PizzaBox.Client\Views\User\Read.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "36332b33f524abd45443dd263546e74907beb476"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_Read), @"mvc.1.0.view", @"/Views/User/Read.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/User/Read.cshtml", typeof(AspNetCore.Views_User_Read))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"36332b33f524abd45443dd263546e74907beb476", @"/Views/User/Read.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0869890531cd973fc94231944f02086ee7830497", @"/Views/_ViewImports.cshtml")]
    public class Views_User_Read : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<PizzaBox.Domain.Models.User>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(42, 8, true);
            WriteLiteral("\r\n<ul>\r\n");
            EndContext();
#line 4 "C:\revature\Project1\PizzaBox.Client\Views\User\Read.cshtml"
   foreach (var item in Model)
  {

#line default
#line hidden
            BeginContext(87, 8, true);
            WriteLiteral("    <li>");
            EndContext();
            BeginContext(96, 9, false);
#line 6 "C:\revature\Project1\PizzaBox.Client\Views\User\Read.cshtml"
   Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(105, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 7 "C:\revature\Project1\PizzaBox.Client\Views\User\Read.cshtml"
  }

#line default
#line hidden
            BeginContext(117, 5, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<PizzaBox.Domain.Models.User>> Html { get; private set; }
    }
}
#pragma warning restore 1591
