#pragma checksum "D:\Documents\Cursos\FIB\Engenharia_de_Software\dot_net_avancado\projetos\PrjBiblioteca\Views\Home\Components\ListagemLivros\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b86a04111ec9db9b707d58b4d5704b2eb1039bd0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Components_ListagemLivros_Default), @"mvc.1.0.view", @"/Views/Home/Components/ListagemLivros/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Components/ListagemLivros/Default.cshtml", typeof(AspNetCore.Views_Home_Components_ListagemLivros_Default))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b86a04111ec9db9b707d58b4d5704b2eb1039bd0", @"/Views/Home/Components/ListagemLivros/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"09d6db75e6300a87dc7e310818a0f6ab2f03017b", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Components_ListagemLivros_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<PrjBiblioteca.Models.Livro>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Carrinho", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Adicionar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(48, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\Documents\Cursos\FIB\Engenharia_de_Software\dot_net_avancado\projetos\PrjBiblioteca\Views\Home\Components\ListagemLivros\Default.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(77, 21, true);
            WriteLiteral("\r\n<div class=\"row\">\r\n");
            EndContext();
#line 8 "D:\Documents\Cursos\FIB\Engenharia_de_Software\dot_net_avancado\projetos\PrjBiblioteca\Views\Home\Components\ListagemLivros\Default.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
            BeginContext(139, 88, true);
            WriteLiteral("        <div class=\"col-md-4\">\r\n            <div class=\"card\" style=\"width: 20rem;\">\r\n\r\n");
            EndContext();
            BeginContext(311, 81, true);
            WriteLiteral("                \r\n                <div class=\"card-header\">\r\n                    ");
            EndContext();
            BeginContext(393, 11, false);
#line 16 "D:\Documents\Cursos\FIB\Engenharia_de_Software\dot_net_avancado\projetos\PrjBiblioteca\Views\Home\Components\ListagemLivros\Default.cshtml"
               Write(item.Titulo);

#line default
#line hidden
            EndContext();
            BeginContext(404, 122, true);
            WriteLiteral("\r\n                </div>\r\n\r\n                <div class=\"card-body\">\r\n                    <p class=\"card-text\">Quantidade: ");
            EndContext();
            BeginContext(527, 15, false);
#line 20 "D:\Documents\Cursos\FIB\Engenharia_de_Software\dot_net_avancado\projetos\PrjBiblioteca\Views\Home\Components\ListagemLivros\Default.cshtml"
                                                Write(item.Quantidade);

#line default
#line hidden
            EndContext();
            BeginContext(542, 108, true);
            WriteLiteral("</p>\r\n                </div>\r\n\r\n                <div class=\"card-footer text-muted\">\r\n\r\n                    ");
            EndContext();
            BeginContext(650, 178, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b86a04111ec9db9b707d58b4d5704b2eb1039bd06763", async() => {
                BeginContext(761, 63, true);
                WriteLiteral("\r\n                        Add ao Carrinho\r\n                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 25 "D:\Documents\Cursos\FIB\Engenharia_de_Software\dot_net_avancado\projetos\PrjBiblioteca\Views\Home\Components\ListagemLivros\Default.cshtml"
                                                                                      WriteLiteral(item.LivroId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(828, 80, true);
            WriteLiteral("\r\n                    \r\n                </div>\r\n            </div>\r\n    </div>\r\n");
            EndContext();
#line 32 "D:\Documents\Cursos\FIB\Engenharia_de_Software\dot_net_avancado\projetos\PrjBiblioteca\Views\Home\Components\ListagemLivros\Default.cshtml"
}

#line default
#line hidden
            BeginContext(911, 8, true);
            WriteLiteral("</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<PrjBiblioteca.Models.Livro>> Html { get; private set; }
    }
}
#pragma warning restore 1591
