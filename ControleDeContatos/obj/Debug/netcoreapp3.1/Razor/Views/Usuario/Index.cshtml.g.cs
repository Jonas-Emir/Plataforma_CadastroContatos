#pragma checksum "D:\Projetos\C#\ControleDeContatos\ControleDeContatos\Views\Usuario\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3acefbca824da29286990f5ff19809aefd84cfce"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Usuario_Index), @"mvc.1.0.view", @"/Views/Usuario/Index.cshtml")]
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
#line 1 "D:\Projetos\C#\ControleDeContatos\ControleDeContatos\Views\_ViewImports.cshtml"
using ControleDeContatos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Projetos\C#\ControleDeContatos\ControleDeContatos\Views\_ViewImports.cshtml"
using ControleDeContatos.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3acefbca824da29286990f5ff19809aefd84cfce", @"/Views/Usuario/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0e15e6b3a3754a4b191426234179754bca81c2c7", @"/Views/_ViewImports.cshtml")]
    public class Views_Usuario_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<UsuarioModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Usuario", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Criar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Editar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ApagarConfirmacao", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "D:\Projetos\C#\ControleDeContatos\ControleDeContatos\Views\Usuario\Index.cshtml"
  
    ViewData["Title"] = "Listagem de usuários";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n\r\n    <div class=\"d-grid gap-2 d-md-flex justify-content-md-start\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3acefbca824da29286990f5ff19809aefd84cfce5700", async() => {
                WriteLiteral("Adicionar novo usuário");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n    <br />\r\n\r\n");
#nullable restore
#line 13 "D:\Projetos\C#\ControleDeContatos\ControleDeContatos\Views\Usuario\Index.cshtml"
     if (TempData["MensagemSucesso"] != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"alert alert-success\" role=\"alert\">\r\n            <button type=\"button\" class=\"close-alert btn btn-danger btn-sm\" arial-label=\"Close\">X</button>\r\n            ");
#nullable restore
#line 17 "D:\Projetos\C#\ControleDeContatos\ControleDeContatos\Views\Usuario\Index.cshtml"
       Write(TempData["MensagemSucesso"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n");
#nullable restore
#line 19 "D:\Projetos\C#\ControleDeContatos\ControleDeContatos\Views\Usuario\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 21 "D:\Projetos\C#\ControleDeContatos\ControleDeContatos\Views\Usuario\Index.cshtml"
     if (TempData["MensagemErro"] != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"alert alert-danger\" role=\"alert\">\r\n            <button type=\"button\" class=\"close-alert btn btn-danger btn-sm\" arial-label=\"Close\">X</button>\r\n            ");
#nullable restore
#line 25 "D:\Projetos\C#\ControleDeContatos\ControleDeContatos\Views\Usuario\Index.cshtml"
       Write(TempData["MensagemErro"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n");
#nullable restore
#line 27 "D:\Projetos\C#\ControleDeContatos\ControleDeContatos\Views\Usuario\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    <br />

    <h1 class=""display-4"">Listagem de usuários</h1>

    <table id=""table-usuarios"" class=""display"" style=""width:100%"">
        <thead>
            <tr>
                <th scope=""col"">Código</th>
                <th scope=""col"">Nome</th>
                <th scope=""col"">Login</th>
                <th scope=""col"">E-mail</th>
                <th scope=""col"">Perfil</th>
                <th scope=""col"">Total de Contatos</th>
                <th scope=""col"">Data de Cadastro</th>
                <th scope=""col"">Ações</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 47 "D:\Projetos\C#\ControleDeContatos\ControleDeContatos\Views\Usuario\Index.cshtml"
             if (Model != null && Model.Any())
            {
                foreach (var usuario in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <th scope=\"row\">");
#nullable restore
#line 52 "D:\Projetos\C#\ControleDeContatos\ControleDeContatos\Views\Usuario\Index.cshtml"
                                   Write(usuario.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                        <td>");
#nullable restore
#line 53 "D:\Projetos\C#\ControleDeContatos\ControleDeContatos\Views\Usuario\Index.cshtml"
                       Write(usuario.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 54 "D:\Projetos\C#\ControleDeContatos\ControleDeContatos\Views\Usuario\Index.cshtml"
                       Write(usuario.Login);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 55 "D:\Projetos\C#\ControleDeContatos\ControleDeContatos\Views\Usuario\Index.cshtml"
                       Write(usuario.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 56 "D:\Projetos\C#\ControleDeContatos\ControleDeContatos\Views\Usuario\Index.cshtml"
                        Write(usuario.Perfil == ControleDeContatos.Enums.PerfilEnum.Admin ? "Administrador" : "Padrão");

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                        <td>\r\n                            <a href=\"javascript:\"");
            BeginWriteAttribute("usuario-id", " usuario-id=\"", 2060, "\"", 2084, 1);
#nullable restore
#line 58 "D:\Projetos\C#\ControleDeContatos\ControleDeContatos\Views\Usuario\Index.cshtml"
WriteAttributeValue("", 2073, usuario.Id, 2073, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-success btn-sm btn-total-contatos\">\r\n                                ");
#nullable restore
#line 59 "D:\Projetos\C#\ControleDeContatos\ControleDeContatos\Views\Usuario\Index.cshtml"
                            Write(usuario.Contatos != null && usuario.Contatos.Any() ? usuario.Contatos.Count() : 0);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </a>\r\n                        </td>\r\n                        <td>");
#nullable restore
#line 62 "D:\Projetos\C#\ControleDeContatos\ControleDeContatos\Views\Usuario\Index.cshtml"
                       Write(usuario.DataCadastro);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>\r\n                            <div class=\"btn-grup\" role=\"group\">\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3acefbca824da29286990f5ff19809aefd84cfce12859", async() => {
                WriteLiteral("Editar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 65 "D:\Projetos\C#\ControleDeContatos\ControleDeContatos\Views\Usuario\Index.cshtml"
                                                                                                    WriteLiteral(usuario.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3acefbca824da29286990f5ff19809aefd84cfce15477", async() => {
                WriteLiteral("Apagar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 66 "D:\Projetos\C#\ControleDeContatos\ControleDeContatos\Views\Usuario\Index.cshtml"
                                                                                                   WriteLiteral(usuario.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </div>\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 70 "D:\Projetos\C#\ControleDeContatos\ControleDeContatos\Views\Usuario\Index.cshtml"
                }
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr class=\"odd\"><td valign=\"top\" colspan=\"5\">Nenhum usuário encontrado</td></tr>\r\n");
#nullable restore
#line 75 "D:\Projetos\C#\ControleDeContatos\ControleDeContatos\Views\Usuario\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </tbody>
    </table>

    <div id=""modalContatosUsuario"" class=""modal"" tabindex=""-1"">
        <div class=""modal-dialog modal-lg"">
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <h5 class=""modal-title"">Listagem de Contatos</h5>
                    <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                        <span aria-hidden=""true"">&times;</span>
                    </button>
                </div>
                <div class=""modal-body"">
                   <div id=""listaContatosUsuario""></div>
                </div>
            </div>
        </div>
    </div>

</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<UsuarioModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591