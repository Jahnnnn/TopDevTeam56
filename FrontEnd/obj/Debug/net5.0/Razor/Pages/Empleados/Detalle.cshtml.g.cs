#pragma checksum "C:\Users\DIEGO\Documents\Proyectos .Net Core\Empresa\FrontEnd\Pages\Empleados\Detalle.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7938c97915dac2d0086e1d03a7335f15ec7ba0b0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(FrontEnd.Pages.Empleados.Pages_Empleados_Detalle), @"mvc.1.0.razor-page", @"/Pages/Empleados/Detalle.cshtml")]
namespace FrontEnd.Pages.Empleados
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7938c97915dac2d0086e1d03a7335f15ec7ba0b0", @"/Pages/Empleados/Detalle.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9f31024f321d31a654453198d9422fbb8d2a0cd", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Empleados_Detalle : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
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
            WriteLiteral("<h2 class=\"text-center\">Detalle del Empleado</h2>\r\n<br>\r\n<div class=\"card\">\r\n    <div class=\"card-body\">\r\n        <p><strong>Nombre completo: </strong>");
#nullable restore
#line 9 "C:\Users\DIEGO\Documents\Proyectos .Net Core\Empresa\FrontEnd\Pages\Empleados\Detalle.cshtml"
                                        Write(Model.Empleado.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <p><strong>Fecha de nacimiento: </strong>");
#nullable restore
#line 10 "C:\Users\DIEGO\Documents\Proyectos .Net Core\Empresa\FrontEnd\Pages\Empleados\Detalle.cshtml"
                                            Write(Model.Empleado.Fecha_Nacimiento.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <p><strong>Sueldo bruto: </strong>");
#nullable restore
#line 11 "C:\Users\DIEGO\Documents\Proyectos .Net Core\Empresa\FrontEnd\Pages\Empleados\Detalle.cshtml"
                                     Write(Model.Empleado.Sueldo_Bruto.ToString("C"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <p><strong>Empresa a la que pertenece: </strong>");
#nullable restore
#line 12 "C:\Users\DIEGO\Documents\Proyectos .Net Core\Empresa\FrontEnd\Pages\Empleados\Detalle.cshtml"
                                                   Write(Model.Empresa.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <p><strong>Directivo bajo el cual se encuentra a cargo: </strong>");
#nullable restore
#line 13 "C:\Users\DIEGO\Documents\Proyectos .Net Core\Empresa\FrontEnd\Pages\Empleados\Detalle.cshtml"
                                                                    Write(Model.Directivo.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    </div>\r\n</div>\r\n<br>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7938c97915dac2d0086e1d03a7335f15ec7ba0b05528", async() => {
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FrontEnd.Pages.Empleados.DetalleModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<FrontEnd.Pages.Empleados.DetalleModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<FrontEnd.Pages.Empleados.DetalleModel>)PageContext?.ViewData;
        public FrontEnd.Pages.Empleados.DetalleModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
