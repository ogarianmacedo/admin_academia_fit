#pragma checksum "C:\xampp\htdocs\ProjetoAcademia\ProjetoAcademia\Views\Ficha\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9bacf18a95f8ae6e5f245da839fa5ed01e7e0e9d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Ficha_Details), @"mvc.1.0.view", @"/Views/Ficha/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Ficha/Details.cshtml", typeof(AspNetCore.Views_Ficha_Details))]
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
#line 1 "C:\xampp\htdocs\ProjetoAcademia\ProjetoAcademia\Views\_ViewImports.cshtml"
using ProjetoAcademia;

#line default
#line hidden
#line 2 "C:\xampp\htdocs\ProjetoAcademia\ProjetoAcademia\Views\_ViewImports.cshtml"
using ProjetoAcademia.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9bacf18a95f8ae6e5f245da839fa5ed01e7e0e9d", @"/Views/Ficha/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"488dd88fc82b7553ef2d7fa4eeb01e48da9fa1b0", @"/Views/_ViewImports.cshtml")]
    public class Views_Ficha_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProjetoAcademia.Models.Ficha>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Ficha", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-small grey darken-1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(37, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\xampp\htdocs\ProjetoAcademia\ProjetoAcademia\Views\Ficha\Details.cshtml"
  
    ViewData["Title"] = "Detalhes";

#line default
#line hidden
            BeginContext(83, 138, true);
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col s10\">\r\n        <h5>Detalhes</h5>\r\n    </div>\r\n    <div class=\"col s2\">\r\n        <p>\r\n            ");
            EndContext();
            BeginContext(221, 126, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e1ecffc378e344c0a97874b33a50d29d", async() => {
                BeginContext(337, 6, true);
                WriteLiteral("Voltar");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-AlunoId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 13 "C:\xampp\htdocs\ProjetoAcademia\ProjetoAcademia\Views\Ficha\Details.cshtml"
                                                                WriteLiteral(Model.AlunoId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["AlunoId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-AlunoId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["AlunoId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(347, 107, true);
            WriteLiteral("\r\n        </p>\r\n    </div>\r\n</div>\r\n\r\n<div class=\"collection\">\r\n    <div class=\"collection-item\">\r\n        ");
            EndContext();
            BeginContext(455, 56, false);
#line 20 "C:\xampp\htdocs\ProjetoAcademia\ProjetoAcademia\Views\Ficha\Details.cshtml"
   Write(await Component.InvokeAsync("DadosAluno", Model.AlunoId));

#line default
#line hidden
            EndContext();
            BeginContext(511, 128, true);
            WriteLiteral("\r\n    </div>\r\n\r\n    <div class=\"row collection-item\">\r\n        <div class=\"col s6\">\r\n            <p><strong>Cadastro: </strong> ");
            EndContext();
            BeginContext(640, 14, false);
#line 25 "C:\xampp\htdocs\ProjetoAcademia\ProjetoAcademia\Views\Ficha\Details.cshtml"
                                      Write(Model.Cadastro);

#line default
#line hidden
            EndContext();
            BeginContext(654, 97, true);
            WriteLiteral("</p>\r\n        </div>\r\n\r\n        <div class=\"col s6\">\r\n            <p><strong>Validade: </strong> ");
            EndContext();
            BeginContext(752, 14, false);
#line 29 "C:\xampp\htdocs\ProjetoAcademia\ProjetoAcademia\Views\Ficha\Details.cshtml"
                                      Write(Model.Validade);

#line default
#line hidden
            EndContext();
            BeginContext(766, 113, true);
            WriteLiteral("</p>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n<div class=\"collection\">\r\n    <div class=\"collection-item\">\r\n        ");
            EndContext();
            BeginContext(880, 68, false);
#line 36 "C:\xampp\htdocs\ProjetoAcademia\ProjetoAcademia\Views\Ficha\Details.cshtml"
   Write(await Component.InvokeAsync("ListagemExercicioFicha", Model.FichaId));

#line default
#line hidden
            EndContext();
            BeginContext(948, 20, true);
            WriteLiteral("\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProjetoAcademia.Models.Ficha> Html { get; private set; }
    }
}
#pragma warning restore 1591
