#pragma checksum "D:\IIHT\Task-12\InMemory\FitnessClubManagement\Views\Fitness\DietPlanDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c1fb1de052bbc4cb010f23eba3fe1b50706010ba"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Fitness_DietPlanDetails), @"mvc.1.0.view", @"/Views/Fitness/DietPlanDetails.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Fitness/DietPlanDetails.cshtml", typeof(AspNetCore.Views_Fitness_DietPlanDetails))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c1fb1de052bbc4cb010f23eba3fe1b50706010ba", @"/Views/Fitness/DietPlanDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"80b940252428d2d3b648f0af8e95dc5faab4018d", @"/Views/_ViewImports.cshtml")]
    public class Views_Fitness_DietPlanDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FitnessClubManagement.Entities.DietPlan>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\IIHT\Task-12\InMemory\FitnessClubManagement\Views\Fitness\DietPlanDetails.cshtml"
  
    ViewData["Title"] = "Diet Plan Details";

#line default
#line hidden
            BeginContext(101, 501, true);
            WriteLiteral(@"<div class=""card"" style=""width:100%; margin-top:10px;"">
    <div class=""card-header bg-dark text-white"">
        <h5>Diet Plan Details</h5>
    </div>
    <div class=""card-body"">
        <div class=""row mb-2"">
            <div class=""col-md-12"">
                <div class=""card flex-md-row mb-4 box-shadow h-auto"">
                    <div class=""card-body d-flex flex-column align-items-start"">
                        <strong class=""d-inline-block mb-2 text-primary"">Diet Plan Overview :- ");
            EndContext();
            BeginContext(603, 36, false);
#line 14 "D:\IIHT\Task-12\InMemory\FitnessClubManagement\Views\Fitness\DietPlanDetails.cshtml"
                                                                                          Write(Html.DisplayFor(m => m.PlanOverview));

#line default
#line hidden
            EndContext();
            BeginContext(639, 112, true);
            WriteLiteral("</strong>\r\n                        <h3 class=\"mb-0\">\r\n                            <a class=\"text-dark\" href=\"#\">");
            EndContext();
            BeginContext(752, 28, false);
#line 16 "D:\IIHT\Task-12\InMemory\FitnessClubManagement\Views\Fitness\DietPlanDetails.cshtml"
                                                     Write(Html.DisplayFor(m => m.Name));

#line default
#line hidden
            EndContext();
            BeginContext(780, 120, true);
            WriteLiteral("</a>\r\n                        </h3>\r\n                        <div class=\"mb-1 text-dark\"><strong>Description : </strong>");
            EndContext();
            BeginContext(901, 36, false);
#line 18 "D:\IIHT\Task-12\InMemory\FitnessClubManagement\Views\Fitness\DietPlanDetails.cshtml"
                                                                              Write(Html.DisplayFor(m => m.Descriprtion));

#line default
#line hidden
            EndContext();
            BeginContext(937, 89, true);
            WriteLiteral("</div>\r\n                        <p class=\"card-text mb-auto\"><strong>History :- </strong>");
            EndContext();
            BeginContext(1027, 31, false);
#line 19 "D:\IIHT\Task-12\InMemory\FitnessClubManagement\Views\Fitness\DietPlanDetails.cshtml"
                                                                            Write(Html.DisplayFor(m => m.History));

#line default
#line hidden
            EndContext();
            BeginContext(1058, 101, true);
            WriteLiteral("</p>\r\n                        <p class=\"card-text mb-auto\"><strong>Meal Timing Frequency :- </strong>");
            EndContext();
            BeginContext(1160, 43, false);
#line 20 "D:\IIHT\Task-12\InMemory\FitnessClubManagement\Views\Fitness\DietPlanDetails.cshtml"
                                                                                          Write(Html.DisplayFor(m => m.MealTimingFrequency));

#line default
#line hidden
            EndContext();
            BeginContext(1203, 104, true);
            WriteLiteral("</p>\r\n                        <p class=\"card-text mb-auto\"><strong>Restrictions Limitations :- </strong>");
            EndContext();
            BeginContext(1308, 47, false);
#line 21 "D:\IIHT\Task-12\InMemory\FitnessClubManagement\Views\Fitness\DietPlanDetails.cshtml"
                                                                                             Write(Html.DisplayFor(m => m.RestrictionsLimitations));

#line default
#line hidden
            EndContext();
            BeginContext(1355, 86, true);
            WriteLiteral("</p>\r\n                        <p class=\"card-text mb-auto\"><strong>Phases :- </strong>");
            EndContext();
            BeginContext(1442, 30, false);
#line 22 "D:\IIHT\Task-12\InMemory\FitnessClubManagement\Views\Fitness\DietPlanDetails.cshtml"
                                                                           Write(Html.DisplayFor(m => m.Phases));

#line default
#line hidden
            EndContext();
            BeginContext(1472, 94, true);
            WriteLiteral("</p>\r\n                        <p class=\"card-text mb-auto\"><strong>BestSuited For :- </strong>");
            EndContext();
            BeginContext(1567, 37, false);
#line 23 "D:\IIHT\Task-12\InMemory\FitnessClubManagement\Views\Fitness\DietPlanDetails.cshtml"
                                                                                   Write(Html.DisplayFor(m => m.BestSuitedFor));

#line default
#line hidden
            EndContext();
            BeginContext(1604, 93, true);
            WriteLiteral("</p>\r\n                        <p class=\"card-text mb-auto\"><strong>How To Follow :- </strong>");
            EndContext();
            BeginContext(1698, 35, false);
#line 24 "D:\IIHT\Task-12\InMemory\FitnessClubManagement\Views\Fitness\DietPlanDetails.cshtml"
                                                                                  Write(Html.DisplayFor(m => m.HowToFollow));

#line default
#line hidden
            EndContext();
            BeginContext(1733, 90, true);
            WriteLiteral("</p>\r\n                        <p class=\"card-text mb-auto\"><strong>Conclusion :- </strong>");
            EndContext();
            BeginContext(1824, 34, false);
#line 25 "D:\IIHT\Task-12\InMemory\FitnessClubManagement\Views\Fitness\DietPlanDetails.cshtml"
                                                                               Write(Html.DisplayFor(m => m.Conclusion));

#line default
#line hidden
            EndContext();
            BeginContext(1858, 119, true);
            WriteLiteral("</p>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n        <p>\r\n            ");
            EndContext();
            BeginContext(1978, 95, false);
#line 31 "D:\IIHT\Task-12\InMemory\FitnessClubManagement\Views\Fitness\DietPlanDetails.cshtml"
       Write(Html.ActionLink("Back to Diet Plan", "DietPlan", "Fitness", new { @class = "btn btn-primary" }));

#line default
#line hidden
            EndContext();
            BeginContext(2073, 34, true);
            WriteLiteral("\r\n        </p>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FitnessClubManagement.Entities.DietPlan> Html { get; private set; }
    }
}
#pragma warning restore 1591
