#pragma checksum "G:\Keshav\Projects\EF\CookieLogin\Views\Security\InsertDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3ea0d53d79c25e906a38755bd3a45425ac548425"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Security_InsertDetails), @"mvc.1.0.view", @"/Views/Security/InsertDetails.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Security/InsertDetails.cshtml", typeof(AspNetCore.Views_Security_InsertDetails))]
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
#line 1 "G:\Keshav\Projects\EF\CookieLogin\Views\_ViewImports.cshtml"
using AutomobileCMS;

#line default
#line hidden
#line 2 "G:\Keshav\Projects\EF\CookieLogin\Views\_ViewImports.cshtml"
using AutomobileCMS.Models;

#line default
#line hidden
#line 4 "G:\Keshav\Projects\EF\CookieLogin\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3ea0d53d79c25e906a38755bd3a45425ac548425", @"/Views/Security/InsertDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"88bcd3f4a9534e619ee3d2d5e78d4b494a7c5a53", @"/Views/_ViewImports.cshtml")]
    public class Views_Security_InsertDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AutomobileCMS.ViewModels.SecurityDetails>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(49, 6, true);
            WriteLiteral("\r\n<h1>");
            EndContext();
            BeginContext(56, 10, false);
#line 3 "G:\Keshav\Projects\EF\CookieLogin\Views\Security\InsertDetails.cshtml"
Write(Model.Text);

#line default
#line hidden
            EndContext();
            BeginContext(66, 7, true);
            WriteLiteral("</h1>\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IAuthorizationService AuthorizationService { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AutomobileCMS.ViewModels.SecurityDetails> Html { get; private set; }
    }
}
#pragma warning restore 1591