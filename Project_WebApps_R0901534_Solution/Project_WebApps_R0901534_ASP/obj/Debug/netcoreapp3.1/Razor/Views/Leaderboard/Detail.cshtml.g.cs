#pragma checksum "C:\TM\GIT\Project_WebApps_R0901534\Project_WebApps_R0901534_Solution\Project_WebApps_R0901534_ASP\Views\Leaderboard\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8678206e8aeefd0ecc95841a3fd86d96f855954b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Project_WebApps_R0901534_ASP.Pages.Leaderboard.Views_Leaderboard_Detail), @"mvc.1.0.view", @"/Views/Leaderboard/Detail.cshtml")]
namespace Project_WebApps_R0901534_ASP.Pages.Leaderboard
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
#line 1 "C:\TM\GIT\Project_WebApps_R0901534\Project_WebApps_R0901534_Solution\Project_WebApps_R0901534_ASP\Views\_ViewImports.cshtml"
using Project_WebApps_R0901534_ASP;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8678206e8aeefd0ecc95841a3fd86d96f855954b", @"/Views/Leaderboard/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1ca71ac2ad8f47b4f10f03997b75ab342e7a2bd1", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Leaderboard_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Project_WebApps_R0901534_ASP.ViewModels.CircuitDetailViewModel>
    #nullable disable
    {
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\TM\GIT\Project_WebApps_R0901534\Project_WebApps_R0901534_Solution\Project_WebApps_R0901534_ASP\Views\Leaderboard\Detail.cshtml"
  
    ViewData["Title"] = "Leaderboard - ";

#line default
#line hidden
#nullable disable
            WriteLiteral("// omzetten naar laptime viewmodel\r\n\r\n<h1 class=\"text-center mt-5 mb-5 me-1\">");
#nullable restore
#line 7 "C:\TM\GIT\Project_WebApps_R0901534\Project_WebApps_R0901534_Solution\Project_WebApps_R0901534_ASP\Views\Leaderboard\Detail.cshtml"
                                  Write(Model.Naam);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1>

<div class=""table-responsive rounded"">
    <table class=""table bg-warning table-striped border border-light"">
        <thead>
            <tr>
                <th class=""text-sm-left text-light"">POS</th>
                <th class=""text-sm-left text-light"">Klasse</th>
                <th class=""text-sm-left text-light"">Auto</th>
                <th class=""text-sm-left text-light"">Rondetijd</th>
                <th class=""text-sm-left text-light"">Handling</th>
                <th class=""text-sm-left text-light"">Datum</th>
                <th class=""text-sm-left text-light"">Nickname</th>
            </tr>
        </thead>
        <tbody>
            <tr>
                <td>1</td>
                <td>S800</td>
                <td>Lamborghini Reventon</td>
                <td>01.30.568</td>
                <td>6.5H</td>
                <td>19-11-2022</td>
                <td>LeRacer</td>
            </tr>
            <tr>
                <td>2</td>
                <td>S800</td>
");
            WriteLiteral(@"                <td>Lamborghini Diablo</td>
                <td>01.30.864</td>
                <td>6.2H</td>
                <td>18-11-2022</td>
                <td>LeRacer</td>
            </tr>
            <tr>
                <td>3</td>
                <td>S800</td>
                <td>Ford GT</td>
                <td>01.30.931</td>
                <td>6.4H</td>
                <td>17-11-2022</td>
                <td>LeRacer</td>
            </tr>
        </tbody>
    </table>
</div>

    <h1 class=""text-center mt-5 mb-5"">Rondetijd toevoegen</h1>

    
    <div class=""container-fluid bg-warning p-5 mb-3 border border-light rounded"">
        <fieldset>
            <legend class=""text-center mb-5"">Rondetijd registreren</legend>
        <div class=""row"">
            <div class=""col-md-6 col-sm-12"">
                <select class=""p-1"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8678206e8aeefd0ecc95841a3fd86d96f855954b5807", async() => {
                WriteLiteral("Auto\'s");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8678206e8aeefd0ecc95841a3fd86d96f855954b6786", async() => {
                WriteLiteral("Ford GT 6.4H");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8678206e8aeefd0ecc95841a3fd86d96f855954b7770", async() => {
                WriteLiteral("Option 2");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8678206e8aeefd0ecc95841a3fd86d96f855954b8750", async() => {
                WriteLiteral("Option 3");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                </select>
            </div>
            <div class=""col-md-6 col-sm-12"">
                <input type=""text"" class=""mt-1"" placeholder=""Rondetijd {00.00.000}"" />
            </div>
        </div>        
    <div class=""d-grid gap-2 d-md-flex justify-content-md-start mt-3"">
        <button class=""btn-dark border border-light rounded py-1 px-2"">Voeg rondetijd toe</button>
    </div>
    </fieldset>
    <fieldset class=""mt-4"">
        <legend class=""text-center mb-5"">Voeg auto + rondetijd toe</legend>
        <div class=""row"">
            <div class=""col-md-6 col-sm-12"">
                <input type=""text"" class=""mt-1"" placeholder=""Merk"" />
            </div>
            <div class=""col-md-6 col-sm-12"">
                <input type=""text"" class=""mt-1"" placeholder=""Model"" />
            </div>
        </div>
        <div class=""row mt-2"">
            <div class=""col-md-6 col-sm-12"">
                <input type=""text"" class=""mt-1"" placeholder=""Handling"" />
            </div>");
            WriteLiteral(@"
            <div class=""col-md-6 col-sm-12"">
                <input type=""text"" class=""mt-1"" placeholder=""PI"" />
            </div>
        </div>
        <div class=""row mt-2"">
            <div class=""col-md-6 col-sm-12"">
                <input type=""text"" class=""mt-1"" placeholder=""Rondetijd {00.00.000}"" />
            </div>
            <div class=""col-md-6 col-sm-12"">
                <button class=""btn-dark border border-light rounded py-1 px-2"">Voeg rondetijd toe</button>
            </div>
        </div>
    </fieldset>
    </div>

    ");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Project_WebApps_R0901534_ASP.ViewModels.CircuitDetailViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
