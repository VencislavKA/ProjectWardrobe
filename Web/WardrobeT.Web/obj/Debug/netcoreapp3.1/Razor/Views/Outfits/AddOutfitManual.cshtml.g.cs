#pragma checksum "C:\Users\Ventcy\Documents\Project\Web\WardrobeT.Web\Views\Outfits\AddOutfitManual.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5ebbefe0a9e35b38746b8e7d2e329d8454f89043"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Outfits_AddOutfitManual), @"mvc.1.0.view", @"/Views/Outfits/AddOutfitManual.cshtml")]
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
#line 1 "C:\Users\Ventcy\Documents\Project\Web\WardrobeT.Web\Views\_ViewImports.cshtml"
using WardrobeT;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Ventcy\Documents\Project\Web\WardrobeT.Web\Views\_ViewImports.cshtml"
using WardrobeT.Web.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Ventcy\Documents\Project\Web\WardrobeT.Web\Views\_ViewImports.cshtml"
using WardrobeT.Web.ViewModels.Friends;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Ventcy\Documents\Project\Web\WardrobeT.Web\Views\_ViewImports.cshtml"
using WardrobeT.Data.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Ventcy\Documents\Project\Web\WardrobeT.Web\Views\_ViewImports.cshtml"
using WardrobeT.Web.ViewModels.Search;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Ventcy\Documents\Project\Web\WardrobeT.Web\Views\_ViewImports.cshtml"
using WardrobeT.Web.ViewModels.Home;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Ventcy\Documents\Project\Web\WardrobeT.Web\Views\_ViewImports.cshtml"
using WardrobeT.Web.ViewModels.Outfits;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Ventcy\Documents\Project\Web\WardrobeT.Web\Views\_ViewImports.cshtml"
using WardrobeT.Web.ViewModels.Users;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Ventcy\Documents\Project\Web\WardrobeT.Web\Views\_ViewImports.cshtml"
using WardrobeT.Web.ViewModels.Wardrobe;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Ventcy\Documents\Project\Web\WardrobeT.Web\Views\_ViewImports.cshtml"
using WardrobeT.Web.ViewModels.Feed;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5ebbefe0a9e35b38746b8e7d2e329d8454f89043", @"/Views/Outfits/AddOutfitManual.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f75d3b452022324344dbe8605236ef2d4303c934", @"/Views/_ViewImports.cshtml")]
    public class Views_Outfits_AddOutfitManual : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AddOutfitManualViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("col text-center"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Ventcy\Documents\Project\Web\WardrobeT.Web\Views\Outfits\AddOutfitManual.cshtml"
  
    ViewData["Title"] = "AddOutfit";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"container\">\r\n    <div class=\"col\">\r\n");
#nullable restore
#line 7 "C:\Users\Ventcy\Documents\Project\Web\WardrobeT.Web\Views\Outfits\AddOutfitManual.cshtml"
         if (Model.Tops.Count() < 1 || Model.Middles.Count() < 1 || Model.Bottoms.Count() < 1)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <p class=\"text-center mt-5  text-light\">\r\n                Not enought clothes to add outfit.\r\n            </p>\r\n");
#nullable restore
#line 12 "C:\Users\Ventcy\Documents\Project\Web\WardrobeT.Web\Views\Outfits\AddOutfitManual.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5ebbefe0a9e35b38746b8e7d2e329d8454f890436468", async() => {
                WriteLiteral(@"
                <h4 class=""font-weight-light text-left mt-4 mb-0  text-light"">Select outer wear:</h4>
                <hr class=""mt-2 mb-5 bg-light"">
                <div class=""form-check"">
                    <div class=""row text-center text-lg-left"">
");
#nullable restore
#line 20 "C:\Users\Ventcy\Documents\Project\Web\WardrobeT.Web\Views\Outfits\AddOutfitManual.cshtml"
                         for (int i = 0; i < Model.Tops.Count; i++)
                        {
                            var item = Model.Tops.ElementAt(i);
                            if (i == 0)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <div class=\"col-lg-3 col-md-4 col-6\">\r\n                                    <input class=\"form-check-input\" type=\"radio\" name=\"Top\"");
                BeginWriteAttribute("id", " id=\"", 1104, "\"", 1117, 1);
#nullable restore
#line 26 "C:\Users\Ventcy\Documents\Project\Web\WardrobeT.Web\Views\Outfits\AddOutfitManual.cshtml"
WriteAttributeValue("", 1109, item.Id, 1109, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 1118, "\"", 1134, 1);
#nullable restore
#line 26 "C:\Users\Ventcy\Documents\Project\Web\WardrobeT.Web\Views\Outfits\AddOutfitManual.cshtml"
WriteAttributeValue("", 1126, item.Id, 1126, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" checked>\r\n                                    <label class=\"form-check-label\"");
                BeginWriteAttribute("for", " for=\"", 1213, "\"", 1227, 1);
#nullable restore
#line 27 "C:\Users\Ventcy\Documents\Project\Web\WardrobeT.Web\Views\Outfits\AddOutfitManual.cshtml"
WriteAttributeValue("", 1219, item.Id, 1219, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                                        <img class=\"img-fluid img-thumbnail\"");
                BeginWriteAttribute("src", " src=\"", 1307, "\"", 1327, 1);
#nullable restore
#line 28 "C:\Users\Ventcy\Documents\Project\Web\WardrobeT.Web\Views\Outfits\AddOutfitManual.cshtml"
WriteAttributeValue("", 1313, item.ImageUrl, 1313, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" alt=\"Can\'t load this image\">\r\n                                    </label>\r\n                                </div>\r\n");
#nullable restore
#line 31 "C:\Users\Ventcy\Documents\Project\Web\WardrobeT.Web\Views\Outfits\AddOutfitManual.cshtml"
                                continue;
                            }

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <div class=\"col-lg-3 col-md-4 col-6\">\r\n                                <input class=\"form-check-input\" type=\"radio\" name=\"Top\"");
                BeginWriteAttribute("id", " id=\"", 1673, "\"", 1686, 1);
#nullable restore
#line 34 "C:\Users\Ventcy\Documents\Project\Web\WardrobeT.Web\Views\Outfits\AddOutfitManual.cshtml"
WriteAttributeValue("", 1678, item.Id, 1678, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 1687, "\"", 1703, 1);
#nullable restore
#line 34 "C:\Users\Ventcy\Documents\Project\Web\WardrobeT.Web\Views\Outfits\AddOutfitManual.cshtml"
WriteAttributeValue("", 1695, item.Id, 1695, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                                <label class=\"form-check-label\"");
                BeginWriteAttribute("for", " for=\"", 1770, "\"", 1784, 1);
#nullable restore
#line 35 "C:\Users\Ventcy\Documents\Project\Web\WardrobeT.Web\Views\Outfits\AddOutfitManual.cshtml"
WriteAttributeValue("", 1776, item.Id, 1776, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                                    <img class=\"img-fluid img-thumbnail\"");
                BeginWriteAttribute("src", " src=\"", 1860, "\"", 1880, 1);
#nullable restore
#line 36 "C:\Users\Ventcy\Documents\Project\Web\WardrobeT.Web\Views\Outfits\AddOutfitManual.cshtml"
WriteAttributeValue("", 1866, item.ImageUrl, 1866, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" alt=\"Can\'t load this image\">\r\n                                </label>\r\n                            </div>\r\n");
#nullable restore
#line 39 "C:\Users\Ventcy\Documents\Project\Web\WardrobeT.Web\Views\Outfits\AddOutfitManual.cshtml"
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                    </div>
                </div>
                <h4 class=""font-weight-light text-left mt-4 mb-0  text-light"">Select shirts:</h4>
                <hr class=""mt-2 mb-5 bg-light"">
                <div class=""form-check"">
                    <div class=""row text-center text-lg-left"">
");
#nullable restore
#line 46 "C:\Users\Ventcy\Documents\Project\Web\WardrobeT.Web\Views\Outfits\AddOutfitManual.cshtml"
                         for (int i = 0; i < Model.Middles.Count; i++)
                        {
                            var item = Model.Middles.ElementAt(i);
                            if (i == 0)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <div class=\"col-lg-3 col-md-4 col-6\">\r\n                                    <input class=\"form-check-input\" type=\"radio\" name=\"Middle\"");
                BeginWriteAttribute("id", " id=\"", 2727, "\"", 2740, 1);
#nullable restore
#line 52 "C:\Users\Ventcy\Documents\Project\Web\WardrobeT.Web\Views\Outfits\AddOutfitManual.cshtml"
WriteAttributeValue("", 2732, item.Id, 2732, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 2741, "\"", 2757, 1);
#nullable restore
#line 52 "C:\Users\Ventcy\Documents\Project\Web\WardrobeT.Web\Views\Outfits\AddOutfitManual.cshtml"
WriteAttributeValue("", 2749, item.Id, 2749, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" checked>\r\n                                    <label class=\"form-check-label\"");
                BeginWriteAttribute("for", " for=\"", 2836, "\"", 2850, 1);
#nullable restore
#line 53 "C:\Users\Ventcy\Documents\Project\Web\WardrobeT.Web\Views\Outfits\AddOutfitManual.cshtml"
WriteAttributeValue("", 2842, item.Id, 2842, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                                        <img class=\"img-fluid img-thumbnail\"");
                BeginWriteAttribute("src", " src=\"", 2930, "\"", 2950, 1);
#nullable restore
#line 54 "C:\Users\Ventcy\Documents\Project\Web\WardrobeT.Web\Views\Outfits\AddOutfitManual.cshtml"
WriteAttributeValue("", 2936, item.ImageUrl, 2936, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" alt=\"Can\'t load this image\">\r\n                                    </label>\r\n                                </div>\r\n");
#nullable restore
#line 57 "C:\Users\Ventcy\Documents\Project\Web\WardrobeT.Web\Views\Outfits\AddOutfitManual.cshtml"
                                continue;
                            }

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <div class=\"col-lg-3 col-md-4 col-6\">\r\n                                <input class=\"form-check-input\" type=\"radio\" name=\"Middle\"");
                BeginWriteAttribute("id", " id=\"", 3299, "\"", 3312, 1);
#nullable restore
#line 60 "C:\Users\Ventcy\Documents\Project\Web\WardrobeT.Web\Views\Outfits\AddOutfitManual.cshtml"
WriteAttributeValue("", 3304, item.Id, 3304, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 3313, "\"", 3329, 1);
#nullable restore
#line 60 "C:\Users\Ventcy\Documents\Project\Web\WardrobeT.Web\Views\Outfits\AddOutfitManual.cshtml"
WriteAttributeValue("", 3321, item.Id, 3321, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                                <label class=\"form-check-label\"");
                BeginWriteAttribute("for", " for=\"", 3396, "\"", 3410, 1);
#nullable restore
#line 61 "C:\Users\Ventcy\Documents\Project\Web\WardrobeT.Web\Views\Outfits\AddOutfitManual.cshtml"
WriteAttributeValue("", 3402, item.Id, 3402, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                                    <img class=\"img-fluid img-thumbnail\"");
                BeginWriteAttribute("src", " src=\"", 3486, "\"", 3506, 1);
#nullable restore
#line 62 "C:\Users\Ventcy\Documents\Project\Web\WardrobeT.Web\Views\Outfits\AddOutfitManual.cshtml"
WriteAttributeValue("", 3492, item.ImageUrl, 3492, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" alt=\"Can\'t load this image\">\r\n                                </label>\r\n                            </div>\r\n");
#nullable restore
#line 65 "C:\Users\Ventcy\Documents\Project\Web\WardrobeT.Web\Views\Outfits\AddOutfitManual.cshtml"
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                    </div>
                </div>
                <h4 class=""font-weight-light text-left mt-4 mb-0  text-light"">Select bottoms:</h4>
                <hr class=""mt-2 mb-5 bg-light"">
                <div class=""form-check"">
                    <div class=""row text-center text-lg-left"">
");
#nullable restore
#line 72 "C:\Users\Ventcy\Documents\Project\Web\WardrobeT.Web\Views\Outfits\AddOutfitManual.cshtml"
                         for (int i = 0; i < Model.Bottoms.Count; i++)
                        {
                            var item = Model.Bottoms.ElementAt(i);
                            if (i == 0)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <div class=\"col-lg-3 col-md-4 col-6\">\r\n                                    <input class=\"form-check-input\" type=\"radio\" name=\"Bottom\"");
                BeginWriteAttribute("id", " id=\"", 4354, "\"", 4367, 1);
#nullable restore
#line 78 "C:\Users\Ventcy\Documents\Project\Web\WardrobeT.Web\Views\Outfits\AddOutfitManual.cshtml"
WriteAttributeValue("", 4359, item.Id, 4359, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 4368, "\"", 4384, 1);
#nullable restore
#line 78 "C:\Users\Ventcy\Documents\Project\Web\WardrobeT.Web\Views\Outfits\AddOutfitManual.cshtml"
WriteAttributeValue("", 4376, item.Id, 4376, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" checked>\r\n                                    <label class=\"form-check-label\"");
                BeginWriteAttribute("for", " for=\"", 4463, "\"", 4477, 1);
#nullable restore
#line 79 "C:\Users\Ventcy\Documents\Project\Web\WardrobeT.Web\Views\Outfits\AddOutfitManual.cshtml"
WriteAttributeValue("", 4469, item.Id, 4469, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                                        <img class=\"img-fluid img-thumbnail\"");
                BeginWriteAttribute("src", " src=\"", 4557, "\"", 4577, 1);
#nullable restore
#line 80 "C:\Users\Ventcy\Documents\Project\Web\WardrobeT.Web\Views\Outfits\AddOutfitManual.cshtml"
WriteAttributeValue("", 4563, item.ImageUrl, 4563, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" alt=\"Can\'t load this image\">\r\n                                    </label>\r\n                                </div>\r\n");
#nullable restore
#line 83 "C:\Users\Ventcy\Documents\Project\Web\WardrobeT.Web\Views\Outfits\AddOutfitManual.cshtml"
                                continue;
                            }

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <div class=\"col-lg-3 col-md-4 col-6\">\r\n                                <input class=\"form-check-input\" type=\"radio\" name=\"Bottom\"");
                BeginWriteAttribute("id", " id=\"", 4926, "\"", 4939, 1);
#nullable restore
#line 86 "C:\Users\Ventcy\Documents\Project\Web\WardrobeT.Web\Views\Outfits\AddOutfitManual.cshtml"
WriteAttributeValue("", 4931, item.Id, 4931, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 4940, "\"", 4956, 1);
#nullable restore
#line 86 "C:\Users\Ventcy\Documents\Project\Web\WardrobeT.Web\Views\Outfits\AddOutfitManual.cshtml"
WriteAttributeValue("", 4948, item.Id, 4948, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                                <label class=\"form-check-label\"");
                BeginWriteAttribute("for", " for=\"", 5023, "\"", 5037, 1);
#nullable restore
#line 87 "C:\Users\Ventcy\Documents\Project\Web\WardrobeT.Web\Views\Outfits\AddOutfitManual.cshtml"
WriteAttributeValue("", 5029, item.Id, 5029, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                                    <img class=\"img-fluid img-thumbnail\"");
                BeginWriteAttribute("src", " src=\"", 5113, "\"", 5133, 1);
#nullable restore
#line 88 "C:\Users\Ventcy\Documents\Project\Web\WardrobeT.Web\Views\Outfits\AddOutfitManual.cshtml"
WriteAttributeValue("", 5119, item.ImageUrl, 5119, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" alt=\"Can\'t load this image\">\r\n                                </label>\r\n                            </div>\r\n");
#nullable restore
#line 91 "C:\Users\Ventcy\Documents\Project\Web\WardrobeT.Web\Views\Outfits\AddOutfitManual.cshtml"
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                    </div>
                </div>
                <button type=""submit"" class=""btn btn-success rounded-circle"">
                    <svg width=""4em"" height=""4.5em"" viewBox=""0 0 16 16"" class=""bi bi-check-circle"" fill=""currentColor"" xmlns=""http://www.w3.org/2000/svg"">
                        <path fill-rule=""evenodd"" d=""M8 15A7 7 0 1 0 8 1a7 7 0 0 0 0 14zm0 1A8 8 0 1 0 8 0a8 8 0 0 0 0 16z"" />
                        <path fill-rule=""evenodd"" d=""M10.97 4.97a.75.75 0 0 1 1.071 1.05l-3.992 4.99a.75.75 0 0 1-1.08.02L4.324 8.384a.75.75 0 1 1 1.06-1.06l2.094 2.093 3.473-4.425a.236.236 0 0 1 .02-.022z"" />
                    </svg>
                </button>
            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 101 "C:\Users\Ventcy\Documents\Project\Web\WardrobeT.Web\Views\Outfits\AddOutfitManual.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>\r\n<script>\r\n    $(\'.carousel\').carousel({\r\n        interval: false,\r\n    });\r\n</script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AddOutfitManualViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
