#pragma checksum "C:\Users\Humberto\Documents\GitHub\AtendimentoWebAsp\AtendimentoWeb\AtendimentoWeb_App\Views\Admin\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "99b28ff594aa05f423ee2c6832a70eadf7a3b4f1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Index), @"mvc.1.0.view", @"/Views/Admin/Index.cshtml")]
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
#line 1 "C:\Users\Humberto\Documents\GitHub\AtendimentoWebAsp\AtendimentoWeb\AtendimentoWeb_App\Views\_ViewImports.cshtml"
using AtendimentoWeb_App;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Humberto\Documents\GitHub\AtendimentoWebAsp\AtendimentoWeb\AtendimentoWeb_App\Views\_ViewImports.cshtml"
using AtendimentoWeb_App.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Humberto\Documents\GitHub\AtendimentoWebAsp\AtendimentoWeb\AtendimentoWeb_App\Views\_ViewImports.cshtml"
using AtendimentoWeb_Model.Relatorios;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Humberto\Documents\GitHub\AtendimentoWebAsp\AtendimentoWeb\AtendimentoWeb_App\Views\_ViewImports.cshtml"
using AtendimentoWeb_Model.Classes;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"99b28ff594aa05f423ee2c6832a70eadf7a3b4f1", @"/Views/Admin/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f22be2dbb509a9ceec1fb873665cbb7c6372274c", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Admin_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DashAtendimentos>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Humberto\Documents\GitHub\AtendimentoWebAsp\AtendimentoWeb\AtendimentoWeb_App\Views\Admin\Index.cshtml"
  
    ViewData["Title"] = "Dashboard Atendimentos";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Index</h1>

<div class=""container"">
    <h1>Dashboard Atendimentos</h1>
    <div class=""row"">
        <div class=""col-md-4"">
            <div class=""card text-white bg-success mb-3"" style=""max-width: 18rem;"">
                <div class=""card-header"">Total</div>
                <div class=""card-body"">
                    <h5 class=""card-title"">");
#nullable restore
#line 15 "C:\Users\Humberto\Documents\GitHub\AtendimentoWebAsp\AtendimentoWeb\AtendimentoWeb_App\Views\Admin\Index.cshtml"
                                      Write(Model.Total);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h5>
                    <p class=""card-text"">Some quick example text to build on the card title and make up the bulk of the card's content.</p>
                </div>
            </div>
        </div>
        <div class=""col-md-4"">
            <div class=""card text-white bg-danger  mb-3"" style=""max-width: 18rem;"">
                <div class=""card-header"">Abertos</div>
                <div class=""card-body"">
                    <h5 class=""card-title"">");
#nullable restore
#line 24 "C:\Users\Humberto\Documents\GitHub\AtendimentoWebAsp\AtendimentoWeb\AtendimentoWeb_App\Views\Admin\Index.cshtml"
                                      Write(Model.EmbAberto);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h5>
                    <p class=""card-text"">Some quick example text to build on the card title and make up the bulk of the card's content.</p>
                </div>
            </div>
        </div>
        <div class=""col-md-4"">
            <div class=""card text-white bg-warning  mb-3"" style=""max-width: 18rem;"">
                <div class=""card-header"">Finalizados</div>
                <div class=""card-body"">
                    <h5 class=""card-title"">");
#nullable restore
#line 33 "C:\Users\Humberto\Documents\GitHub\AtendimentoWebAsp\AtendimentoWeb\AtendimentoWeb_App\Views\Admin\Index.cshtml"
                                      Write(Model.Finalizados);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                    <p class=\"card-text\">Some quick example text to build on the card title and make up the bulk of the card\'s content.</p>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DashAtendimentos> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
