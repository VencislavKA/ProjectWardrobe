#pragma checksum "C:\Users\Ventcy\Documents\Project\Web\WardrobeT.Web\Views\Outfits\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f8780c4b393d09c915b438bf371792249a7e2d4b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Outfits_Index), @"mvc.1.0.view", @"/Views/Outfits/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f8780c4b393d09c915b438bf371792249a7e2d4b", @"/Views/Outfits/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f75d3b452022324344dbe8605236ef2d4303c934", @"/Views/_ViewImports.cshtml")]
    public class Views_Outfits_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<OutfitsViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Ventcy\Documents\Project\Web\WardrobeT.Web\Views\Outfits\Index.cshtml"
  
    ViewData["Title"] = "Outfits";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container\">\r\n\r\n    <h1 class=\"font-weight-light text-center text-lg-left mt-4 mb-0  text-light\">");
#nullable restore
#line 8 "C:\Users\Ventcy\Documents\Project\Web\WardrobeT.Web\Views\Outfits\Index.cshtml"
                                                                            Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n    <hr class=\"mt-2 mb-5 bg-light\">\r\n\r\n    <div class=\"row text-center text-lg-left\">\r\n");
#nullable restore
#line 13 "C:\Users\Ventcy\Documents\Project\Web\WardrobeT.Web\Views\Outfits\Index.cshtml"
         foreach (var item in Model.Outfits)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <div class=""col-lg-3 col-md-4 col-6"">
                <div class=""dropdown mt-3"">
                    <button class=""btn btn-outline-light"" type=""button"" id=""dropdownMenuButton"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                        <div class=""row ml-1 mr-1"">
                            <img class=""img-fluid""");
            BeginWriteAttribute("src", " src=\"", 712, "\"", 736, 1);
#nullable restore
#line 19 "C:\Users\Ventcy\Documents\Project\Web\WardrobeT.Web\Views\Outfits\Index.cshtml"
WriteAttributeValue("", 718, item.Top.ImageUrl, 718, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Can\'t load this image\" />\r\n                        </div>\r\n                        <div class=\"row ml-1 mr-1\">\r\n                            <img class=\"img-fluid \"");
            BeginWriteAttribute("src", " src=\"", 906, "\"", 933, 1);
#nullable restore
#line 22 "C:\Users\Ventcy\Documents\Project\Web\WardrobeT.Web\Views\Outfits\Index.cshtml"
WriteAttributeValue("", 912, item.Middle.ImageUrl, 912, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Can\'t load this image\" />\r\n                        </div>\r\n                        <div class=\"row ml-1 mr-1\">\r\n                            <img class=\"img-fluid \"");
            BeginWriteAttribute("src", " src=\"", 1103, "\"", 1130, 1);
#nullable restore
#line 25 "C:\Users\Ventcy\Documents\Project\Web\WardrobeT.Web\Views\Outfits\Index.cshtml"
WriteAttributeValue("", 1109, item.Bottom.ImageUrl, 1109, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Can\'t load this image\" />\r\n                        </div>\r\n                    </button>\r\n                    <div class=\"dropdown-menu\" aria-labelledby=\"dropdownMenuButton\">\r\n");
#nullable restore
#line 29 "C:\Users\Ventcy\Documents\Project\Web\WardrobeT.Web\Views\Outfits\Index.cshtml"
                         if (item.IsPublic == false)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <a class=\"dropdown-item\"");
            BeginWriteAttribute("href", " href=\"", 1446, "\"", 1487, 2);
            WriteAttributeValue("", 1453, "/Feed/MakePublicOutfit?id=", 1453, 26, true);
#nullable restore
#line 31 "C:\Users\Ventcy\Documents\Project\Web\WardrobeT.Web\Views\Outfits\Index.cshtml"
WriteAttributeValue("", 1479, item.Id, 1479, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Make public</a>\r\n");
#nullable restore
#line 32 "C:\Users\Ventcy\Documents\Project\Web\WardrobeT.Web\Views\Outfits\Index.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <a class=\"dropdown-item\"");
            BeginWriteAttribute("href", " href=\"", 1642, "\"", 1684, 2);
            WriteAttributeValue("", 1649, "/Feed/MakePrivateOutfit?id=", 1649, 27, true);
#nullable restore
#line 35 "C:\Users\Ventcy\Documents\Project\Web\WardrobeT.Web\Views\Outfits\Index.cshtml"
WriteAttributeValue("", 1676, item.Id, 1676, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Make private</a>\r\n");
#nullable restore
#line 36 "C:\Users\Ventcy\Documents\Project\Web\WardrobeT.Web\Views\Outfits\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"dropdown-divider\"></div>\r\n                        <a class=\"dropdown-item text-danger\"");
            BeginWriteAttribute("href", " href=\"", 1853, "\"", 1893, 2);
            WriteAttributeValue("", 1860, "/Outfits/DeleteOutfit?id=", 1860, 25, true);
#nullable restore
#line 38 "C:\Users\Ventcy\Documents\Project\Web\WardrobeT.Web\Views\Outfits\Index.cshtml"
WriteAttributeValue("", 1885, item.Id, 1885, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Delete</a>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 42 "C:\Users\Ventcy\Documents\Project\Web\WardrobeT.Web\Views\Outfits\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <div class=""col-lg-3 col-md-4 col-6"">
            <a class=""btn btn-dark d-block mb-4 h-100 w-100"" href=""/Outfits/AddOutfitManual"">
                <div class=""row h-100"">
                    <div class=""col-sm-12 my-auto"">
                        <img class=""img-fluid img-thumbnail"" src=""/images/plus.png"" style=""opacity:0.2"" />
                    </div>
                </div>
            </a>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OutfitsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
