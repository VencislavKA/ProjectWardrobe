#pragma checksum "C:\Users\Ventcy\Documents\Project\Web\WardrobeT.Web\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4521f8b87cd2770ffde0c3ac77bb2fc71c106fe3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4521f8b87cd2770ffde0c3ac77bb2fc71c106fe3", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f75d3b452022324344dbe8605236ef2d4303c934", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IndexHomeViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger btn-lg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Identity", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Account/Register", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\Ventcy\Documents\Project\Web\WardrobeT.Web\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<style>
    .leftBtn {
        border-radius: 5px 0px 0px 5px;
        background: rgb(0,0,0);
        background: linear-gradient(90deg, rgba(0,0,0,1) 0%, rgba(34,34,34,1) 34%, rgba(91,91,91,1) 58%, rgba(146,146,146,1) 71%, rgba(255,255,255,1) 100%);
    }

    .rightBtn {
        border-radius: 0px 5px 5px 0px;
        background: rgb(255,255,255);
        background: linear-gradient(90deg, rgba(255,255,255,1) 0%, rgba(146,146,146,1) 25%, rgba(91,91,91,1) 45%, rgba(34,34,34,1) 70%, rgba(0,0,0,1) 100%);
    }
</style>

");
#nullable restore
#line 19 "C:\Users\Ventcy\Documents\Project\Web\WardrobeT.Web\Views\Home\Index.cshtml"
 if (User.Identity.IsAuthenticated)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"container-fluid\">\r\n    <div class=\"row\">\r\n        <div class=\"col\">\r\n            <div id=\"myCarousel\" class=\"carousel slide\" data-ride=\"carousel\">\r\n                <div class=\"carousel-inner\">\r\n");
#nullable restore
#line 26 "C:\Users\Ventcy\Documents\Project\Web\WardrobeT.Web\Views\Home\Index.cshtml"
                     if (Model.Outfits.Count != 0)
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "C:\Users\Ventcy\Documents\Project\Web\WardrobeT.Web\Views\Home\Index.cshtml"
                         for (int i = 0; i < Model.Outfits.Count; i++)
                        {
                            Outfit item = Model.Outfits.ElementAt(i);
                            if (i == 0)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                <div class=""carousel-item active bg-light rounded-lg"">
                                    <div class=""container"">
                                        <div class=""row"">
                                            <a class=""btn mx-auto mb-3""");
            BeginWriteAttribute("href", " href=\"", 1454, "\"", 1557, 7);
            WriteAttributeValue("", 1461, "/Outfits/AddOutfit?topId=", 1461, 25, true);
#nullable restore
#line 36 "C:\Users\Ventcy\Documents\Project\Web\WardrobeT.Web\Views\Home\Index.cshtml"
WriteAttributeValue("", 1486, item.Top.Id, 1486, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1498, "&&middleId=", 1498, 11, true);
#nullable restore
#line 36 "C:\Users\Ventcy\Documents\Project\Web\WardrobeT.Web\Views\Home\Index.cshtml"
WriteAttributeValue("", 1509, item.Middle.Id, 1509, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1524, "&&bottomId=", 1524, 11, true);
#nullable restore
#line 36 "C:\Users\Ventcy\Documents\Project\Web\WardrobeT.Web\Views\Home\Index.cshtml"
WriteAttributeValue("", 1535, item.Bottom.Id, 1535, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1550, "&&url=/", 1550, 7, true);
            EndWriteAttribute();
            WriteLiteral(@">
                                                <svg width=""3em"" height=""3em"" viewBox=""0 0 16 16"" class=""bi bi-bookmark-star"" fill=""currentColor"" xmlns=""http://www.w3.org/2000/svg"">
                                                    <path fill-rule=""evenodd"" d=""M2 2a2 2 0 0 1 2-2h8a2 2 0 0 1 2 2v13.5a.5.5 0 0 1-.777.416L8 13.101l-5.223 2.815A.5.5 0 0 1 2 15.5V2zm2-1a1 1 0 0 0-1 1v12.566l4.723-2.482a.5.5 0 0 1 .554 0L13 14.566V2a1 1 0 0 0-1-1H4z"" />
                                                    <path d=""M7.84 4.1a.178.178 0 0 1 .32 0l.634 1.285a.178.178 0 0 0 .134.098l1.42.206c.145.021.204.2.098.303L9.42 6.993a.178.178 0 0 0-.051.158l.242 1.414a.178.178 0 0 1-.258.187l-1.27-.668a.178.178 0 0 0-.165 0l-1.27.668a.178.178 0 0 1-.257-.187l.242-1.414a.178.178 0 0 0-.05-.158l-1.03-1.001a.178.178 0 0 1 .098-.303l1.42-.206a.178.178 0 0 0 .134-.098L7.84 4.1z"" />
                                                </svg>
                                            </a>
                                        ");
            WriteLiteral("</div>\r\n                                        <div class=\"row\">\r\n                                            <img class=\"w-25 rounded mx-auto d-block\"");
            BeginWriteAttribute("src", " src=\"", 2734, "\"", 2758, 1);
#nullable restore
#line 44 "C:\Users\Ventcy\Documents\Project\Web\WardrobeT.Web\Views\Home\Index.cshtml"
WriteAttributeValue("", 2740, item.Top.ImageUrl, 2740, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"There was a problem to load this image\" />\r\n                                        </div>\r\n                                        <div class=\"row\">\r\n                                            <img class=\"w-25 rounded mx-auto d-block\"");
            BeginWriteAttribute("src", " src=\"", 3001, "\"", 3028, 1);
#nullable restore
#line 47 "C:\Users\Ventcy\Documents\Project\Web\WardrobeT.Web\Views\Home\Index.cshtml"
WriteAttributeValue("", 3007, item.Middle.ImageUrl, 3007, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"There was a problem to load this image\" />\r\n                                        </div>\r\n                                        <div class=\"row\">\r\n                                            <img class=\"w-25 rounded mx-auto d-block\"");
            BeginWriteAttribute("src", " src=\"", 3271, "\"", 3298, 1);
#nullable restore
#line 50 "C:\Users\Ventcy\Documents\Project\Web\WardrobeT.Web\Views\Home\Index.cshtml"
WriteAttributeValue("", 3277, item.Bottom.ImageUrl, 3277, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"There was a problem to load this image\" />\r\n                                        </div>\r\n                                    </div>\r\n                                </div>\r\n");
#nullable restore
#line 54 "C:\Users\Ventcy\Documents\Project\Web\WardrobeT.Web\Views\Home\Index.cshtml"
                                continue;
                            }


#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            <div class=""carousel-item bg-light rounded-lg"">
                                <div class=""container"">
                                    <div class=""row"">
                                        <a class=""btn mx-auto mb-3""");
            BeginWriteAttribute("href", " href=\"", 3813, "\"", 3916, 7);
            WriteAttributeValue("", 3820, "/Outfits/AddOutfit?topId=", 3820, 25, true);
#nullable restore
#line 60 "C:\Users\Ventcy\Documents\Project\Web\WardrobeT.Web\Views\Home\Index.cshtml"
WriteAttributeValue("", 3845, item.Top.Id, 3845, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3857, "&&middleId=", 3857, 11, true);
#nullable restore
#line 60 "C:\Users\Ventcy\Documents\Project\Web\WardrobeT.Web\Views\Home\Index.cshtml"
WriteAttributeValue("", 3868, item.Middle.Id, 3868, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3883, "&&bottomId=", 3883, 11, true);
#nullable restore
#line 60 "C:\Users\Ventcy\Documents\Project\Web\WardrobeT.Web\Views\Home\Index.cshtml"
WriteAttributeValue("", 3894, item.Bottom.Id, 3894, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3909, "&&url=/", 3909, 7, true);
            EndWriteAttribute();
            WriteLiteral(@">
                                            <svg width=""3em"" height=""3em"" viewBox=""0 0 16 16"" class=""bi bi-bookmark-star"" fill=""currentColor"" xmlns=""http://www.w3.org/2000/svg"">
                                                <path fill-rule=""evenodd"" d=""M2 2a2 2 0 0 1 2-2h8a2 2 0 0 1 2 2v13.5a.5.5 0 0 1-.777.416L8 13.101l-5.223 2.815A.5.5 0 0 1 2 15.5V2zm2-1a1 1 0 0 0-1 1v12.566l4.723-2.482a.5.5 0 0 1 .554 0L13 14.566V2a1 1 0 0 0-1-1H4z"" />
                                                <path d=""M7.84 4.1a.178.178 0 0 1 .32 0l.634 1.285a.178.178 0 0 0 .134.098l1.42.206c.145.021.204.2.098.303L9.42 6.993a.178.178 0 0 0-.051.158l.242 1.414a.178.178 0 0 1-.258.187l-1.27-.668a.178.178 0 0 0-.165 0l-1.27.668a.178.178 0 0 1-.257-.187l.242-1.414a.178.178 0 0 0-.05-.158l-1.03-1.001a.178.178 0 0 1 .098-.303l1.42-.206a.178.178 0 0 0 .134-.098L7.84 4.1z"" />
                                            </svg>
                                        </a>
                                    </div>
                ");
            WriteLiteral("                    <div class=\"row\">\r\n                                        <img class=\"w-25 rounded mx-auto d-block\"");
            BeginWriteAttribute("src", " src=\"", 5061, "\"", 5085, 1);
#nullable restore
#line 68 "C:\Users\Ventcy\Documents\Project\Web\WardrobeT.Web\Views\Home\Index.cshtml"
WriteAttributeValue("", 5067, item.Top.ImageUrl, 5067, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"There was a problem to load this image\" />\r\n                                    </div>\r\n                                    <div class=\"row\">\r\n                                        <img class=\"w-25 rounded mx-auto d-block\"");
            BeginWriteAttribute("src", " src=\"", 5316, "\"", 5343, 1);
#nullable restore
#line 71 "C:\Users\Ventcy\Documents\Project\Web\WardrobeT.Web\Views\Home\Index.cshtml"
WriteAttributeValue("", 5322, item.Middle.ImageUrl, 5322, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"There was a problem to load this image\" />\r\n                                    </div>\r\n                                    <div class=\"row\">\r\n                                        <img class=\"w-25 rounded mx-auto d-block\"");
            BeginWriteAttribute("src", " src=\"", 5574, "\"", 5601, 1);
#nullable restore
#line 74 "C:\Users\Ventcy\Documents\Project\Web\WardrobeT.Web\Views\Home\Index.cshtml"
WriteAttributeValue("", 5580, item.Bottom.ImageUrl, 5580, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"There was a problem to load this image\" />\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n");
#nullable restore
#line 78 "C:\Users\Ventcy\Documents\Project\Web\WardrobeT.Web\Views\Home\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <a class=""carousel-control-prev w-25 leftBtn"" href=""#myCarousel"" role=""button"" data-slide=""prev"" style=""background-color:black"">
                            <span class=""carousel-control-prev-icon"" aria-hidden=""true""></span>
                            <span class=""sr-only"">Previous</span>
                        </a>
                        <a class=""carousel-control-next w-25 rightBtn"" href=""#myCarousel"" role=""button"" data-slide=""next"" style=""background-color:black"">
                            <span class=""carousel-control-next-icon"" aria-hidden=""true""></span>
                            <span class=""sr-only"">Next</span>
                        </a>
");
#nullable restore
#line 88 "C:\Users\Ventcy\Documents\Project\Web\WardrobeT.Web\Views\Home\Index.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <div class=""jumbotron"">
                            <h1 class=""display-4 text-xl-center"">There is not enought wears and we can not make you an outfit</h1>
                            <hr class=""my-4"">
                            <p class=""text-center"">Plese add more wears to your wardrobe!</p>
                        </div>
");
#nullable restore
#line 96 "C:\Users\Ventcy\Documents\Project\Web\WardrobeT.Web\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
#nullable restore
#line 102 "C:\Users\Ventcy\Documents\Project\Web\WardrobeT.Web\Views\Home\Index.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""jumbotron text-center"">
        <h1 class=""display-4"">Hello, user!</h1>
        <p class=""lead"">This is a simple platform in which you can upload all of your wears and we will offer you outfits.</p>
        <hr class=""my-4"">
        <p>You want to register just click it is so easy!</p>
        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4521f8b87cd2770ffde0c3ac77bb2fc71c106fe319265", async() => {
                WriteLiteral("Register");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n");
#nullable restore
#line 112 "C:\Users\Ventcy\Documents\Project\Web\WardrobeT.Web\Views\Home\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<script>\r\n    $(\'.carousel\').carousel({\r\n        interval: false,\r\n    });\r\n</script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexHomeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
