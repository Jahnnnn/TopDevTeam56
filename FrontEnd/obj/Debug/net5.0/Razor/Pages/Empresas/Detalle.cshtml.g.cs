#pragma checksum "E:\Git\TopDevTeam56\FrontEnd\Pages\Empresas\Detalle.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4ab56af39d8920d7b7db54793044aedecd677f87"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(FrontEnd.Pages.Empresas.Pages_Empresas_Detalle), @"mvc.1.0.razor-page", @"/Pages/Empresas/Detalle.cshtml")]
namespace FrontEnd.Pages.Empresas
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
#line 1 "E:\Git\TopDevTeam56\FrontEnd\Pages\_ViewImports.cshtml"
using FrontEnd;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4ab56af39d8920d7b7db54793044aedecd677f87", @"/Pages/Empresas/Detalle.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9f31024f321d31a654453198d9422fbb8d2a0cd", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Empresas_Detalle : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h4 class=\"text-center\">Detalle Empresa</h4>\r\n\r\n<div class=\"card\">\r\n    <div class=\"card-body\">\r\n        \r\n        <div class=\"col-med-12\">\r\n        <div class=\"col-med-12\">\r\n            <p><strong>Nombre Empresa: </strong>");
#nullable restore
#line 13 "E:\Git\TopDevTeam56\FrontEnd\Pages\Empresas\Detalle.cshtml"
                                           Write(Model.Empresa.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        </div>\r\n        <div class=\"col-med-4\">\r\n            <p><strong>Nit de la Empresa: </strong>");
#nullable restore
#line 16 "E:\Git\TopDevTeam56\FrontEnd\Pages\Empresas\Detalle.cshtml"
                                              Write(Model.Empresa.NIT);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        </div>\r\n\r\n        <div class=\"col-med-4\">\r\n            <p><strong>Nit de la Empresa: </strong>");
#nullable restore
#line 20 "E:\Git\TopDevTeam56\FrontEnd\Pages\Empresas\Detalle.cshtml"
                                              Write(Model.Empresa.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        </div>\r\n        </div>\r\n        \r\n\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FrontEnd.Pages.Empresas.DetalleModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<FrontEnd.Pages.Empresas.DetalleModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<FrontEnd.Pages.Empresas.DetalleModel>)PageContext?.ViewData;
        public FrontEnd.Pages.Empresas.DetalleModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
