#pragma checksum "C:\Users\umid_\source\repos\TemplatesetupTask\TemplatesetupTask\Views\Service\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "71c1558dbd4bb6ffbbd0500f0296687897aae239"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Service_Detail), @"mvc.1.0.view", @"/Views/Service/Detail.cshtml")]
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
#line 1 "C:\Users\umid_\source\repos\TemplatesetupTask\TemplatesetupTask\Views\_ViewImports.cshtml"
using TemplatesetupTask.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\umid_\source\repos\TemplatesetupTask\TemplatesetupTask\Views\_ViewImports.cshtml"
using TemplatesetupTask.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"71c1558dbd4bb6ffbbd0500f0296687897aae239", @"/Views/Service/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e96cbaa57829eb36e92ca6d213480d0b0b4f450a", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Service_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Service>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\umid_\source\repos\TemplatesetupTask\TemplatesetupTask\Views\Service\Detail.cshtml"
  
    ViewData["Title"] = "Detail";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Detail Sevice</h1>\r\n\r\n<ul>\r\n    <li>ID:");
#nullable restore
#line 9 "C:\Users\umid_\source\repos\TemplatesetupTask\TemplatesetupTask\Views\Service\Detail.cshtml"
      Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n    <li>Icon:");
#nullable restore
#line 10 "C:\Users\umid_\source\repos\TemplatesetupTask\TemplatesetupTask\Views\Service\Detail.cshtml"
        Write(Model.Icon);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n    <li>Header:");
#nullable restore
#line 11 "C:\Users\umid_\source\repos\TemplatesetupTask\TemplatesetupTask\Views\Service\Detail.cshtml"
          Write(Model.Header);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n    <li>Description:");
#nullable restore
#line 12 "C:\Users\umid_\source\repos\TemplatesetupTask\TemplatesetupTask\Views\Service\Detail.cshtml"
               Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n\r\n</ul>\r\n\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Service> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
