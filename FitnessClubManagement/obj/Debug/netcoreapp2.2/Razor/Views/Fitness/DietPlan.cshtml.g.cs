#pragma checksum "D:\IIHT\Task-12\InMemory\FitnessClubManagement\Views\Fitness\DietPlan.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e03727b35cbcc3c59255962eb9f884a4d54841dd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Fitness_DietPlan), @"mvc.1.0.view", @"/Views/Fitness/DietPlan.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Fitness/DietPlan.cshtml", typeof(AspNetCore.Views_Fitness_DietPlan))]
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
#line 1 "D:\IIHT\Task-12\InMemory\FitnessClubManagement\Views\_ViewImports.cshtml"
using FitnessClubManagement;

#line default
#line hidden
#line 2 "D:\IIHT\Task-12\InMemory\FitnessClubManagement\Views\_ViewImports.cshtml"
using FitnessClubManagement.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e03727b35cbcc3c59255962eb9f884a4d54841dd", @"/Views/Fitness/DietPlan.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"80b940252428d2d3b648f0af8e95dc5faab4018d", @"/Views/_ViewImports.cshtml")]
    public class Views_Fitness_DietPlan : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<FitnessClubManagement.Entities.DietPlan>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\IIHT\Task-12\InMemory\FitnessClubManagement\Views\Fitness\DietPlan.cshtml"
  
    ViewData["Title"] = "DietPlan";

#line default
#line hidden
            BeginContext(105, 47, true);
            WriteLiteral("\r\n<h1>DietPlan</h1>\r\n\r\n<div class=\"row mb-2\">\r\n");
            EndContext();
#line 9 "D:\IIHT\Task-12\InMemory\FitnessClubManagement\Views\Fitness\DietPlan.cshtml"
     foreach (var diet in Model)
    {

#line default
#line hidden
            BeginContext(193, 264, true);
            WriteLiteral(@"        <div class=""col-md-12"">
            <div class=""card flex-md-row mb-4 box-shadow h-auto"">
                <div class=""card-body d-flex flex-column align-items-start"">
                    <strong class=""d-inline-block mb-2 text-primary"">Plan Overview :- ");
            EndContext();
            BeginContext(458, 17, false);
#line 14 "D:\IIHT\Task-12\InMemory\FitnessClubManagement\Views\Fitness\DietPlan.cshtml"
                                                                                 Write(diet.PlanOverview);

#line default
#line hidden
            EndContext();
            BeginContext(475, 104, true);
            WriteLiteral("</strong>\r\n                    <h3 class=\"mb-0\">\r\n                        <a class=\"text-dark\" href=\"#\">");
            EndContext();
            BeginContext(580, 9, false);
#line 16 "D:\IIHT\Task-12\InMemory\FitnessClubManagement\Views\Fitness\DietPlan.cshtml"
                                                 Write(diet.Name);

#line default
#line hidden
            EndContext();
            BeginContext(589, 113, true);
            WriteLiteral("</a>\r\n                    </h3>\r\n                    <div class=\"mb-1 text-muted\"><strong>Description : </strong>");
            EndContext();
            BeginContext(703, 17, false);
#line 18 "D:\IIHT\Task-12\InMemory\FitnessClubManagement\Views\Fitness\DietPlan.cshtml"
                                                                           Write(diet.Descriprtion);

#line default
#line hidden
            EndContext();
            BeginContext(720, 30, true);
            WriteLiteral("</div>\r\n                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 750, "\"", 863, 1);
#line 19 "D:\IIHT\Task-12\InMemory\FitnessClubManagement\Views\Fitness\DietPlan.cshtml"
WriteAttributeValue("", 757, Url.Action("DietPlanDetails","Fitness", new { DietplanId = diet.DietplanId, @class = "btn btn-primary" }), 757, 106, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(864, 86, true);
            WriteLiteral(">Continue reading...</a>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
            EndContext();
#line 23 "D:\IIHT\Task-12\InMemory\FitnessClubManagement\Views\Fitness\DietPlan.cshtml"
     }

#line default
#line hidden
            BeginContext(958, 10, true);
            WriteLiteral("</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<FitnessClubManagement.Entities.DietPlan>> Html { get; private set; }
    }
}
#pragma warning restore 1591
