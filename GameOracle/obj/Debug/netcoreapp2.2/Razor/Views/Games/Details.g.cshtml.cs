#pragma checksum "C:\Users\Tiffany.Chen\Repositories\GameOracleAspNetCore\GameOracle\Views\Games\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0ef0012a63572517069e69ef291f317301706886"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Games_Details), @"mvc.1.0.view", @"/Views/Games/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Games/Details.cshtml", typeof(AspNetCore.Views_Games_Details))]
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
#line 1 "C:\Users\Tiffany.Chen\Repositories\GameOracleAspNetCore\GameOracle\Views\_ViewImports.cshtml"
using GameOracle;

#line default
#line hidden
#line 2 "C:\Users\Tiffany.Chen\Repositories\GameOracleAspNetCore\GameOracle\Views\_ViewImports.cshtml"
using GameOracle.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0ef0012a63572517069e69ef291f317301706886", @"/Views/Games/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d656aeca6c3b83685ffa109cf88925d6bf67f7b1", @"/Views/_ViewImports.cshtml")]
    public class Views_Games_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GameOracle.Models.Game>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(31, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Tiffany.Chen\Repositories\GameOracleAspNetCore\GameOracle\Views\Games\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(123, 127, true);
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>Game</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(251, 38, false);
#line 15 "C:\Users\Tiffany.Chen\Repositories\GameOracleAspNetCore\GameOracle\Views\Games\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(289, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(353, 34, false);
#line 18 "C:\Users\Tiffany.Chen\Repositories\GameOracleAspNetCore\GameOracle\Views\Games\Details.cshtml"
       Write(Html.DisplayFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(387, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(450, 40, false);
#line 21 "C:\Users\Tiffany.Chen\Repositories\GameOracleAspNetCore\GameOracle\Views\Games\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(490, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(554, 36, false);
#line 24 "C:\Users\Tiffany.Chen\Repositories\GameOracleAspNetCore\GameOracle\Views\Games\Details.cshtml"
       Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(590, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(653, 46, false);
#line 27 "C:\Users\Tiffany.Chen\Repositories\GameOracleAspNetCore\GameOracle\Views\Games\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.MinPlayers));

#line default
#line hidden
            EndContext();
            BeginContext(699, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(763, 42, false);
#line 30 "C:\Users\Tiffany.Chen\Repositories\GameOracleAspNetCore\GameOracle\Views\Games\Details.cshtml"
       Write(Html.DisplayFor(model => model.MinPlayers));

#line default
#line hidden
            EndContext();
            BeginContext(805, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(868, 46, false);
#line 33 "C:\Users\Tiffany.Chen\Repositories\GameOracleAspNetCore\GameOracle\Views\Games\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.MaxPlayers));

#line default
#line hidden
            EndContext();
            BeginContext(914, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(978, 42, false);
#line 36 "C:\Users\Tiffany.Chen\Repositories\GameOracleAspNetCore\GameOracle\Views\Games\Details.cshtml"
       Write(Html.DisplayFor(model => model.MaxPlayers));

#line default
#line hidden
            EndContext();
            BeginContext(1020, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1083, 47, false);
#line 39 "C:\Users\Tiffany.Chen\Repositories\GameOracleAspNetCore\GameOracle\Views\Games\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.IsExpansion));

#line default
#line hidden
            EndContext();
            BeginContext(1130, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1194, 43, false);
#line 42 "C:\Users\Tiffany.Chen\Repositories\GameOracleAspNetCore\GameOracle\Views\Games\Details.cshtml"
       Write(Html.DisplayFor(model => model.IsExpansion));

#line default
#line hidden
            EndContext();
            BeginContext(1237, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1300, 46, false);
#line 45 "C:\Users\Tiffany.Chen\Repositories\GameOracleAspNetCore\GameOracle\Views\Games\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.BaseGameId));

#line default
#line hidden
            EndContext();
            BeginContext(1346, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1410, 42, false);
#line 48 "C:\Users\Tiffany.Chen\Repositories\GameOracleAspNetCore\GameOracle\Views\Games\Details.cshtml"
       Write(Html.DisplayFor(model => model.BaseGameId));

#line default
#line hidden
            EndContext();
            BeginContext(1452, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1500, 68, false);
#line 53 "C:\Users\Tiffany.Chen\Repositories\GameOracleAspNetCore\GameOracle\Views\Games\Details.cshtml"
Write(Html.ActionLink("Edit", "Edit", new { /* id = Model.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(1568, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(1576, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0ef0012a63572517069e69ef291f3173017068869642", async() => {
                BeginContext(1598, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1614, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GameOracle.Models.Game> Html { get; private set; }
    }
}
#pragma warning restore 1591
