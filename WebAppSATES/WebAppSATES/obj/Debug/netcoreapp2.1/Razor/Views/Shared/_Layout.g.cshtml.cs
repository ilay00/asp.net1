#pragma checksum "C:\Users\laic\source\repos\WebAppSATES\WebAppSATES\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1679ab85be2e8c9674e9dbbf088d56dbca8ebae5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_Layout.cshtml", typeof(AspNetCore.Views_Shared__Layout))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1679ab85be2e8c9674e9dbbf088d56dbca8ebae5", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"deb97a496ed8dd5fd544c79e5864c2f181d0593a", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\laic\source\repos\WebAppSATES\WebAppSATES\Views\Shared\_Layout.cshtml"
  
    Layout = "_LayoutBase";

#line default
#line hidden
            BeginContext(36, 29, true);
            WriteLiteral("<div class=\"container\">\r\n    ");
            EndContext();
            BeginContext(66, 12, false);
#line 5 "C:\Users\laic\source\repos\WebAppSATES\WebAppSATES\Views\Shared\_Layout.cshtml"
Write(RenderBody());

#line default
#line hidden
            EndContext();
            BeginContext(78, 13, true);
            WriteLiteral(";\r\n</div>\r\n\r\n");
            EndContext();
            DefineSection("Style", async() => {
                BeginContext(112, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(119, 29, false);
#line 10 "C:\Users\laic\source\repos\WebAppSATES\WebAppSATES\Views\Shared\_Layout.cshtml"
Write(RenderSection("Style", false));

#line default
#line hidden
                EndContext();
                BeginContext(148, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            DefineSection("Script", async() => {
                BeginContext(175, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(182, 30, false);
#line 14 "C:\Users\laic\source\repos\WebAppSATES\WebAppSATES\Views\Shared\_Layout.cshtml"
Write(RenderSection("Script", false));

#line default
#line hidden
                EndContext();
                BeginContext(212, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
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