#pragma checksum "D:\Projet Amechnoue\AspCoreApp\Views\Eleves\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a02c0ea33593796273624afb53385dc5d02c4888"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Eleves_Details), @"mvc.1.0.view", @"/Views/Eleves/Details.cshtml")]
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
#line 1 "D:\Projet Amechnoue\AspCoreApp\Views\_ViewImports.cshtml"
using AspCoreApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Projet Amechnoue\AspCoreApp\Views\_ViewImports.cshtml"
using AspCoreApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a02c0ea33593796273624afb53385dc5d02c4888", @"/Views/Eleves/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"863aaa4cc2d638c923c9e363dd8c6063e019e4f9", @"/Views/_ViewImports.cshtml")]
    public class Views_Eleves_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AspCoreApp.Models.Eleve>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Eleves", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info btn-block"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Projet Amechnoue\AspCoreApp\Views\Eleves\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<hr />

<div class=""row"">
    <div class=""col-md-6 offset-md-3"">
        <div class=""card"">
            <h6 class=""text-center card-header"">Détails </h6>
            <div class=""card-body"">
                <div>
                    <dl class=""row"">
                        <dt class=""col-sm-6"">
                            ");
#nullable restore
#line 18 "D:\Projet Amechnoue\AspCoreApp\Views\Eleves\Details.cshtml"
                       Write(Html.DisplayNameFor(model => model.cne).ToUpper());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </dt>\r\n                        <dd class=\"col-sm-6\">\r\n                            ");
#nullable restore
#line 21 "D:\Projet Amechnoue\AspCoreApp\Views\Eleves\Details.cshtml"
                       Write(Html.DisplayFor(model => model.cne));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </dd>\r\n                        <dt class=\"col-sm-6\">\r\n                           Prenom\r\n                        </dt>\r\n                        <dd class=\"col-sm-6\">\r\n                            ");
#nullable restore
#line 27 "D:\Projet Amechnoue\AspCoreApp\Views\Eleves\Details.cshtml"
                       Write(Html.DisplayFor(model => model.prenom));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </dd>\r\n                        <dt class=\"col-sm-6\">\r\n                            Nom\r\n                        </dt>\r\n                        <dd class=\"col-sm-6\">\r\n                            ");
#nullable restore
#line 33 "D:\Projet Amechnoue\AspCoreApp\Views\Eleves\Details.cshtml"
                       Write(Html.DisplayFor(model => model.nom));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </dd>\r\n                        <dt class=\"col-sm-6\">\r\n                            E-mail\r\n                        </dt>\r\n                        <dd class=\"col-sm-6\">\r\n                            ");
#nullable restore
#line 39 "D:\Projet Amechnoue\AspCoreApp\Views\Eleves\Details.cshtml"
                       Write(Html.DisplayFor(model => model.email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </dd>\r\n                        <dt class=\"col-sm-6\">\r\n                            Filière\r\n                        </dt>\r\n                        <dd class=\"col-sm-6\">\r\n                            ");
#nullable restore
#line 45 "D:\Projet Amechnoue\AspCoreApp\Views\Eleves\Details.cshtml"
                       Write(Html.DisplayFor(model => model.filiere));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </dd>\r\n                        <dt class=\"col-sm-6\">\r\n                            Numéro de Téléphone\r\n                        </dt>\r\n                        <dd class=\"col-sm-6\">\r\n                            ");
#nullable restore
#line 51 "D:\Projet Amechnoue\AspCoreApp\Views\Eleves\Details.cshtml"
                       Write(Html.DisplayFor(model => model.tel));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </dd>\r\n                        <dt class=\"col-sm-6\">\r\n                            ");
#nullable restore
#line 54 "D:\Projet Amechnoue\AspCoreApp\Views\Eleves\Details.cshtml"
                       Write(Html.ActionLink("Modifier", "Edit", "Eleves", new { cne = Model.cne }, new { @class = "btn btn-warning btn-block" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </dt>\r\n                        <dd class=\"col-sm-6\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a02c0ea33593796273624afb53385dc5d02c48888121", async() => {
                WriteLiteral("Retour");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </dd>\r\n                    </dl>\r\n                    \r\n                </div>\r\n                \r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AspCoreApp.Models.Eleve> Html { get; private set; }
    }
}
#pragma warning restore 1591
