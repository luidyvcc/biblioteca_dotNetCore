#pragma checksum "D:\Documents\Cursos\FIB\Engenharia_de_Software\dot_net_avancado\projetos\PrjBiblioteca\Views\UsuariosRelatorio\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1bcd4a52e60ef03a535c907fbb21f5cee0ddf05e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_UsuariosRelatorio_Index), @"mvc.1.0.view", @"/Views/UsuariosRelatorio/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/UsuariosRelatorio/Index.cshtml", typeof(AspNetCore.Views_UsuariosRelatorio_Index))]
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
#line 1 "D:\Documents\Cursos\FIB\Engenharia_de_Software\dot_net_avancado\projetos\PrjBiblioteca\Views\_ViewImports.cshtml"
using PrjBiblioteca;

#line default
#line hidden
#line 2 "D:\Documents\Cursos\FIB\Engenharia_de_Software\dot_net_avancado\projetos\PrjBiblioteca\Views\_ViewImports.cshtml"
using PrjBiblioteca.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1bcd4a52e60ef03a535c907fbb21f5cee0ddf05e", @"/Views/UsuariosRelatorio/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"09d6db75e6300a87dc7e310818a0f6ab2f03017b", @"/Views/_ViewImports.cshtml")]
    public class Views_UsuariosRelatorio_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<PrjBiblioteca.Models.Usuario>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(50, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\Documents\Cursos\FIB\Engenharia_de_Software\dot_net_avancado\projetos\PrjBiblioteca\Views\UsuariosRelatorio\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(93, 110, true);
            WriteLiteral("\r\n<h1>Relatório</h1>\r\n\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(204, 40, false);
#line 14 "D:\Documents\Cursos\FIB\Engenharia_de_Software\dot_net_avancado\projetos\PrjBiblioteca\Views\UsuariosRelatorio\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(244, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(300, 45, false);
#line 17 "D:\Documents\Cursos\FIB\Engenharia_de_Software\dot_net_avancado\projetos\PrjBiblioteca\Views\UsuariosRelatorio\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Categoria));

#line default
#line hidden
            EndContext();
            BeginContext(345, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 23 "D:\Documents\Cursos\FIB\Engenharia_de_Software\dot_net_avancado\projetos\PrjBiblioteca\Views\UsuariosRelatorio\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(463, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(512, 39, false);
#line 26 "D:\Documents\Cursos\FIB\Engenharia_de_Software\dot_net_avancado\projetos\PrjBiblioteca\Views\UsuariosRelatorio\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(551, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(607, 54, false);
#line 29 "D:\Documents\Cursos\FIB\Engenharia_de_Software\dot_net_avancado\projetos\PrjBiblioteca\Views\UsuariosRelatorio\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Categoria.Descricao));

#line default
#line hidden
            EndContext();
            BeginContext(661, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 32 "D:\Documents\Cursos\FIB\Engenharia_de_Software\dot_net_avancado\projetos\PrjBiblioteca\Views\UsuariosRelatorio\Index.cshtml"
}

#line default
#line hidden
            BeginContext(700, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<PrjBiblioteca.Models.Usuario>> Html { get; private set; }
    }
}
#pragma warning restore 1591
