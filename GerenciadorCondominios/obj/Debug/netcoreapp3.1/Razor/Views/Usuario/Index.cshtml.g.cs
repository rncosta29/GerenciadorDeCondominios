#pragma checksum "C:\Treinamento\APSNET\GerenciadorDeCondominios\GerenciadorCondominios\Views\Usuario\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "caf0083ab207ccadb23f294504ca1f9761cb9fe0"
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
#line 1 "C:\Treinamento\APSNET\GerenciadorDeCondominios\GerenciadorCondominios\Views\_ViewImports.cshtml"
using GerenciadorCondominios;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Treinamento\APSNET\GerenciadorDeCondominios\GerenciadorCondominios\Views\_ViewImports.cshtml"
using GerenciadorCondominios.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Treinamento\APSNET\GerenciadorDeCondominios\GerenciadorCondominios\Views\Usuario\Index.cshtml"
using GerenciadorCondominios.BLL.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"caf0083ab207ccadb23f294504ca1f9761cb9fe0", @"/Views/Usuario/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ca0cfb221ef3ab357afb8a1c2acf66aa8d50e076", @"/Views/_ViewImports.cshtml")]
    public class Views_Usuario_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<GerenciadorCondominios.BLL.Models.Usuario>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn-floating blue darken-4"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Usuario", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "GerenciarUsuarios", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/OperacoesUsuario.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Treinamento\APSNET\GerenciadorDeCondominios\GerenciadorCondominios\Views\Usuario\Index.cshtml"
  
    ViewData["Title"] = "Moradores cadastrados";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""tabelas"">
    <div class=""collection with-header"">
        <div class=""collection-header grey darken-1"">
            <div class=""row"">
                <div class=""col s10"">
                    <h6 class=""white-text"">Moradores cadastrados</h6>
                </div>

                <div class=""col s2"">

                </div>
            </div>
        </div>

        <div class=""collection-item"">
            <table class=""table-striped highlight"">
                <thead>
                    <tr>
                        <th>
                            Nome
                        </th>

                        <th>
                            CPF
                        </th>

                        <th>
                            Email
                        </th>

                        <th>
                            Telefone
                        </th>

                        <th>
                            Status
                        </th>
 ");
            WriteLiteral("                   </tr>\r\n                </thead>\r\n                <tbody>\r\n");
#nullable restore
#line 48 "C:\Treinamento\APSNET\GerenciadorDeCondominios\GerenciadorCondominios\Views\Usuario\Index.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>\r\n                                ");
#nullable restore
#line 52 "C:\Treinamento\APSNET\GerenciadorDeCondominios\GerenciadorCondominios\Views\Usuario\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.UserName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n\r\n                            <td>\r\n                                ");
#nullable restore
#line 56 "C:\Treinamento\APSNET\GerenciadorDeCondominios\GerenciadorCondominios\Views\Usuario\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.CPF));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n\r\n                            <td>\r\n                                ");
#nullable restore
#line 60 "C:\Treinamento\APSNET\GerenciadorDeCondominios\GerenciadorCondominios\Views\Usuario\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n\r\n                            <td>\r\n                                ");
#nullable restore
#line 64 "C:\Treinamento\APSNET\GerenciadorDeCondominios\GerenciadorCondominios\Views\Usuario\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.PhoneNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n\r\n");
#nullable restore
#line 67 "C:\Treinamento\APSNET\GerenciadorDeCondominios\GerenciadorCondominios\Views\Usuario\Index.cshtml"
                             if (item.Status == StatusConta.Analisando)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <td>\r\n                                    <span class=\"new badge purple darken-3\" data-badge-caption=\"\"");
            BeginWriteAttribute("id", " id=\"", 2199, "\"", 2212, 1);
#nullable restore
#line 70 "C:\Treinamento\APSNET\GerenciadorDeCondominios\GerenciadorCondominios\Views\Usuario\Index.cshtml"
WriteAttributeValue("", 2204, item.Id, 2204, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 70 "C:\Treinamento\APSNET\GerenciadorDeCondominios\GerenciadorCondominios\Views\Usuario\Index.cshtml"
                                                                                                           Write(Html.DisplayFor(modelItem => item.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                </td>\r\n");
            WriteLiteral("                                <td");
            BeginWriteAttribute("class", " class=\"", 2341, "\"", 2357, 1);
#nullable restore
#line 73 "C:\Treinamento\APSNET\GerenciadorDeCondominios\GerenciadorCondominios\Views\Usuario\Index.cshtml"
WriteAttributeValue("", 2349, item.Id, 2349, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    <a class=\"btn-floating blue darken-3 btnAprovar tooltip\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2453, "\"", 2507, 6);
            WriteAttributeValue("", 2463, "AprovarUsuario(\'", 2463, 16, true);
#nullable restore
#line 74 "C:\Treinamento\APSNET\GerenciadorDeCondominios\GerenciadorCondominios\Views\Usuario\Index.cshtml"
WriteAttributeValue("", 2479, item.Id, 2479, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2487, "\',", 2487, 2, true);
            WriteAttributeValue(" ", 2489, "\'", 2490, 2, true);
#nullable restore
#line 74 "C:\Treinamento\APSNET\GerenciadorDeCondominios\GerenciadorCondominios\Views\Usuario\Index.cshtml"
WriteAttributeValue("", 2491, item.UserName, 2491, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2505, "\')", 2505, 2, true);
            EndWriteAttribute();
            WriteLiteral(" data-position=\"right\" data-tooltip=\"Aprovar Usuario\"><i class=\"material-icons\">thumb_up</i></a>\r\n                                    <a class=\"btn-floating red darken-4 btnReprovar tooltip\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2698, "\"", 2735, 3);
            WriteAttributeValue("", 2708, "ReprovarUsuario(\'", 2708, 17, true);
#nullable restore
#line 75 "C:\Treinamento\APSNET\GerenciadorDeCondominios\GerenciadorCondominios\Views\Usuario\Index.cshtml"
WriteAttributeValue("", 2725, item.Id, 2725, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2733, "\')", 2733, 2, true);
            EndWriteAttribute();
            WriteLiteral(" data-position=\"right\" data-tooltip=\"Reprovar Usuario\"><i class=\"material-icons\">thumb_down</i></a>\r\n                                </td>\r\n");
#nullable restore
#line 77 "C:\Treinamento\APSNET\GerenciadorDeCondominios\GerenciadorCondominios\Views\Usuario\Index.cshtml"
                            }
                            else if (item.Status == StatusConta.Aprovado)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <td>\r\n                                    <span class=\"new badge green darken-3\" data-badge-caption=\"\">");
#nullable restore
#line 81 "C:\Treinamento\APSNET\GerenciadorDeCondominios\GerenciadorCondominios\Views\Usuario\Index.cshtml"
                                                                                            Write(Html.DisplayFor(modelItem => item.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                </td>\r\n");
            WriteLiteral("                                <td>\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "caf0083ab207ccadb23f294504ca1f9761cb9fe012820", async() => {
                WriteLiteral("<i class=\"material-icons\">group</i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-usuarioId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 85 "C:\Treinamento\APSNET\GerenciadorDeCondominios\GerenciadorCondominios\Views\Usuario\Index.cshtml"
                                                                                                                                           WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["usuarioId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-usuarioId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["usuarioId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 85 "C:\Treinamento\APSNET\GerenciadorDeCondominios\GerenciadorCondominios\Views\Usuario\Index.cshtml"
                                                                                                                                                                     WriteLiteral(item.UserName);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["name"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-name", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["name"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                </td>\r\n");
#nullable restore
#line 87 "C:\Treinamento\APSNET\GerenciadorDeCondominios\GerenciadorCondominios\Views\Usuario\Index.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <td>\r\n                                    <span class=\"new badge orange darken-3\" data-badge-caption=\"\">");
#nullable restore
#line 91 "C:\Treinamento\APSNET\GerenciadorDeCondominios\GerenciadorCondominios\Views\Usuario\Index.cshtml"
                                                                                             Write(Html.DisplayFor(modelItem => item.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                </td>\r\n");
#nullable restore
#line 93 "C:\Treinamento\APSNET\GerenciadorDeCondominios\GerenciadorCondominios\Views\Usuario\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tr>\r\n");
#nullable restore
#line 95 "C:\Treinamento\APSNET\GerenciadorDeCondominios\GerenciadorCondominios\Views\Usuario\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\r\n            </table>\r\n\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "caf0083ab207ccadb23f294504ca1f9761cb9fe017885", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<GerenciadorCondominios.BLL.Models.Usuario>> Html { get; private set; }
    }
}
#pragma warning restore 1591
