#pragma checksum "E:\Git\TopDevTeam56\FrontEnd\Pages\Empresas\Detalle.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8b64de0e28ccf6f5608aff24634acf5e07f61a36"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8b64de0e28ccf6f5608aff24634acf5e07f61a36", @"/Pages/Empresas/Detalle.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9f31024f321d31a654453198d9422fbb8d2a0cd", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Empresas_Detalle : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Listado", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
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
            WriteLiteral(@"</p>
        </div>
        </div>
    </div>
</div>

<h4>LISTADO Directivos</h4>
<table class=""table"">
    <thead class=""table-dark text-center"">
        <tr>
            <th scope=""col"">Id</th>
            <th scope=""col"">Nombre</th>
            <th scope=""col"">Sueldo Bruto</th>
            <th scope=""col"">Categoria</th>
        </tr>
    </thead>
    <tbody class=""text-center"">
");
#nullable restore
#line 37 "E:\Git\TopDevTeam56\FrontEnd\Pages\Empresas\Detalle.cshtml"
         foreach (var Directivo in Model.listadoDirectivos)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <th scope=\"row\">");
#nullable restore
#line 40 "E:\Git\TopDevTeam56\FrontEnd\Pages\Empresas\Detalle.cshtml"
                           Write(Directivo.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <td>");
#nullable restore
#line 41 "E:\Git\TopDevTeam56\FrontEnd\Pages\Empresas\Detalle.cshtml"
               Write(Directivo.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 42 "E:\Git\TopDevTeam56\FrontEnd\Pages\Empresas\Detalle.cshtml"
               Write(Directivo.Sueldo_Bruto.ToString("C"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 43 "E:\Git\TopDevTeam56\FrontEnd\Pages\Empresas\Detalle.cshtml"
               Write(Directivo.Categoria.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 45 "E:\Git\TopDevTeam56\FrontEnd\Pages\Empresas\Detalle.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </tbody>
</table>

<h4>LISTADO EMPLEADOS</h4>
<table class=""table"">
    <thead class=""table-dark text-center"">
        <tr>
            <th scope=""col"">Id</th>
            <th scope=""col"">Nombre</th>
            <th scope=""col"">Sueldo Bruto</th>
        </tr>
    </thead>
    <tbody class=""text-center"">
");
#nullable restore
#line 59 "E:\Git\TopDevTeam56\FrontEnd\Pages\Empresas\Detalle.cshtml"
         foreach (var empleado in Model.listadoEmpleados)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <th scope=\"row\">");
#nullable restore
#line 62 "E:\Git\TopDevTeam56\FrontEnd\Pages\Empresas\Detalle.cshtml"
                           Write(empleado.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <td>");
#nullable restore
#line 63 "E:\Git\TopDevTeam56\FrontEnd\Pages\Empresas\Detalle.cshtml"
               Write(empleado.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 64 "E:\Git\TopDevTeam56\FrontEnd\Pages\Empresas\Detalle.cshtml"
               Write(empleado.Sueldo_Bruto.ToString("C"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 66 "E:\Git\TopDevTeam56\FrontEnd\Pages\Empresas\Detalle.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </tbody>
</table>

<h4>LISTADO DE CLIENTES</h4>
<table class=""table"">
    <thead class=""table-dark text-center"">
        <tr>
            <th scope=""col"">Id</th>
            <th scope=""col"">Nombre</th>
            <th scope=""col"">Telefono</th>
        </tr>
    </thead>
    <tbody class=""text-center"">
");
#nullable restore
#line 80 "E:\Git\TopDevTeam56\FrontEnd\Pages\Empresas\Detalle.cshtml"
         foreach (var cliente in Model.listadoClientes)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <th scope=\"row\">");
#nullable restore
#line 83 "E:\Git\TopDevTeam56\FrontEnd\Pages\Empresas\Detalle.cshtml"
                           Write(cliente.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <td>");
#nullable restore
#line 84 "E:\Git\TopDevTeam56\FrontEnd\Pages\Empresas\Detalle.cshtml"
               Write(cliente.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 85 "E:\Git\TopDevTeam56\FrontEnd\Pages\Empresas\Detalle.cshtml"
               Write(cliente.Telefono);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 87 "E:\Git\TopDevTeam56\FrontEnd\Pages\Empresas\Detalle.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n<br>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8b64de0e28ccf6f5608aff24634acf5e07f61a369782", async() => {
                WriteLiteral("\r\n    <i class=\"fa fa-arrow-left\"></i>\r\n    Regresar\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
