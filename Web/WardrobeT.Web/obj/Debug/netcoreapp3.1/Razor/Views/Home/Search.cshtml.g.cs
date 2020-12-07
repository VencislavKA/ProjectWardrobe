#pragma checksum "C:\Users\Ventcy\Documents\Project\Web\WardrobeT.Web\Views\Home\Search.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "698d3f35106ab8e2cef701b082c50f99f4f256f7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Search), @"mvc.1.0.view", @"/Views/Home/Search.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"698d3f35106ab8e2cef701b082c50f99f4f256f7", @"/Views/Home/Search.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2aca9a01c2d705d2e721f44b2725bb146b211804", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Search : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SearchResultViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Ventcy\Documents\Project\Web\WardrobeT.Web\Views\Home\Search.cshtml"
  
    ViewData["Title"] = "Search";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"row\">\r\n\r\n");
#nullable restore
#line 7 "C:\Users\Ventcy\Documents\Project\Web\WardrobeT.Web\Views\Home\Search.cshtml"
     if (Model.Users.Count == 0)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h5 class=\"mt-4 text-muted\">No search result</h5>\r\n");
#nullable restore
#line 10 "C:\Users\Ventcy\Documents\Project\Web\WardrobeT.Web\Views\Home\Search.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Ventcy\Documents\Project\Web\WardrobeT.Web\Views\Home\Search.cshtml"
     foreach (var item in Model.Users)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"col\">\r\n            <div class=\"card text-white bg-dark mb-3\" style=\"width: 18rem;\">\r\n");
#nullable restore
#line 15 "C:\Users\Ventcy\Documents\Project\Web\WardrobeT.Web\Views\Home\Search.cshtml"
                 if (item.ProfilePictureUrl != null)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <img");
            BeginWriteAttribute("src", " src=\"", 449, "\"", 478, 1);
#nullable restore
#line 17 "C:\Users\Ventcy\Documents\Project\Web\WardrobeT.Web\Views\Home\Search.cshtml"
WriteAttributeValue("", 455, item.ProfilePictureUrl, 455, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-fluid\">\r\n");
#nullable restore
#line 18 "C:\Users\Ventcy\Documents\Project\Web\WardrobeT.Web\Views\Home\Search.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <img src=\"https://st2.depositphotos.com/1032921/5237/v/600/depositphotos_52374307-stock-illustration-blue-profile-icon.jpg\" class=\"img-fluid\">\r\n");
#nullable restore
#line 22 "C:\Users\Ventcy\Documents\Project\Web\WardrobeT.Web\Views\Home\Search.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"card-body text-center\">\r\n                    <h5>");
#nullable restore
#line 24 "C:\Users\Ventcy\Documents\Project\Web\WardrobeT.Web\Views\Home\Search.cshtml"
                   Write(item.Profile);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                    <div class=\"text-center\">\r\n");
#nullable restore
#line 26 "C:\Users\Ventcy\Documents\Project\Web\WardrobeT.Web\Views\Home\Search.cshtml"
                         if (item.IsFollowed == false)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <a class=\"btn btn-danger\"");
            BeginWriteAttribute("href", " href=\"", 1023, "\"", 1086, 4);
            WriteAttributeValue("", 1030, "/Home/Follow?FollowId=", 1030, 22, true);
#nullable restore
#line 28 "C:\Users\Ventcy\Documents\Project\Web\WardrobeT.Web\Views\Home\Search.cshtml"
WriteAttributeValue("", 1052, item.ProfileId, 1052, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1067, "&&url=", 1067, 6, true);
#nullable restore
#line 28 "C:\Users\Ventcy\Documents\Project\Web\WardrobeT.Web\Views\Home\Search.cshtml"
WriteAttributeValue("", 1073, Model.Search, 1073, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Follow</a>\r\n");
#nullable restore
#line 29 "C:\Users\Ventcy\Documents\Project\Web\WardrobeT.Web\Views\Home\Search.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <a class=\"btn btn-dark\">Following</a>\r\n");
#nullable restore
#line 33 "C:\Users\Ventcy\Documents\Project\Web\WardrobeT.Web\Views\Home\Search.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 38 "C:\Users\Ventcy\Documents\Project\Web\WardrobeT.Web\Views\Home\Search.cshtml"
     }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n<script>\r\n    function follow() {\r\n\r\n    }\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SearchResultViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
