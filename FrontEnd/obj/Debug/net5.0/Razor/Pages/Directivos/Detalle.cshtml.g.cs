#pragma checksum "C:\Users\DIEGO\Documents\Proyectos .Net Core\Empresa\FrontEnd\Pages\Directivos\Detalle.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "433812e20e076b1575447915db276c525bff5007"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(FrontEnd.Pages.Directivos.Pages_Directivos_Detalle), @"mvc.1.0.razor-page", @"/Pages/Directivos/Detalle.cshtml")]
namespace FrontEnd.Pages.Directivos
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
#line 1 "C:\Users\DIEGO\Documents\Proyectos .Net Core\Empresa\FrontEnd\Pages\_ViewImports.cshtml"
using FrontEnd;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"433812e20e076b1575447915db276c525bff5007", @"/Pages/Directivos/Detalle.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9f31024f321d31a654453198d9422fbb8d2a0cd", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Directivos_Detalle : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
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
            WriteLiteral("<h4 class=\"text-center\">DETALLE DEL DIRECTIVO</h4>\r\n<div class=\"card\">\r\n    <div class=\"card-body\">\r\n        <p><strong>Nombre completo: </strong>");
#nullable restore
#line 8 "C:\Users\DIEGO\Documents\Proyectos .Net Core\Empresa\FrontEnd\Pages\Directivos\Detalle.cshtml"
                                        Write(Model.Directivo.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <p><strong>Fecha de nacimiento: </strong>");
#nullable restore
#line 9 "C:\Users\DIEGO\Documents\Proyectos .Net Core\Empresa\FrontEnd\Pages\Directivos\Detalle.cshtml"
                                            Write(Model.Directivo.Fecha_Nacimiento.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <p><strong>Sueldo bruto: </strong>");
#nullable restore
#line 10 "C:\Users\DIEGO\Documents\Proyectos .Net Core\Empresa\FrontEnd\Pages\Directivos\Detalle.cshtml"
                                     Write(Model.Directivo.Sueldo_Bruto.ToString("C"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <p><strong>Categoría: </strong>");
#nullable restore
#line 11 "C:\Users\DIEGO\Documents\Proyectos .Net Core\Empresa\FrontEnd\Pages\Directivos\Detalle.cshtml"
                                  Write(Model.Directivo.Categoria);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <p><strong>Empresa a la que pertenece: </strong>");
#nullable restore
#line 12 "C:\Users\DIEGO\Documents\Proyectos .Net Core\Empresa\FrontEnd\Pages\Directivos\Detalle.cshtml"
                                                   Write(Model.Empresa.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
    </div>
</div>
<br>
<h4>LISTADO DE EMPLEADOS A CARGO</h4>
<table class=""table"">
    <thead class=""table-dark text-center"">
        <tr>
            <th scope=""col"">Id</th>
            <th scope=""col"">Nombre</th>
            <th scope=""col"">Fecha de Nacimiento</th>
            <th scope=""col"">Sueldo Bruto</th>
        </tr>
    </thead>
    <tbody class=""text-center"">
");
#nullable restore
#line 27 "C:\Users\DIEGO\Documents\Proyectos .Net Core\Empresa\FrontEnd\Pages\Directivos\Detalle.cshtml"
         foreach (var empleado in Model.listadoEmpleados)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <th scope=\"row\">");
#nullable restore
#line 30 "C:\Users\DIEGO\Documents\Proyectos .Net Core\Empresa\FrontEnd\Pages\Directivos\Detalle.cshtml"
                           Write(empleado.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <td>");
#nullable restore
#line 31 "C:\Users\DIEGO\Documents\Proyectos .Net Core\Empresa\FrontEnd\Pages\Directivos\Detalle.cshtml"
               Write(empleado.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 32 "C:\Users\DIEGO\Documents\Proyectos .Net Core\Empresa\FrontEnd\Pages\Directivos\Detalle.cshtml"
               Write(empleado.Fecha_Nacimiento.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 33 "C:\Users\DIEGO\Documents\Proyectos .Net Core\Empresa\FrontEnd\Pages\Directivos\Detalle.cshtml"
               Write(empleado.Sueldo_Bruto.ToString("C"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 35 "C:\Users\DIEGO\Documents\Proyectos .Net Core\Empresa\FrontEnd\Pages\Directivos\Detalle.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n<br>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "433812e20e076b1575447915db276c525bff50077580", async() => {
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FrontEnd.Pages.Directivos.DetalleModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<FrontEnd.Pages.Directivos.DetalleModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<FrontEnd.Pages.Directivos.DetalleModel>)PageContext?.ViewData;
        public FrontEnd.Pages.Directivos.DetalleModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
