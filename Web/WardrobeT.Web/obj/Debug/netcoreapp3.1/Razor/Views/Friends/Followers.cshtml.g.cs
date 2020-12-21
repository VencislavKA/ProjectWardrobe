#pragma checksum "C:\Users\Ventcy\Documents\Project\Web\WardrobeT.Web\Views\Friends\Followers.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "373cfefc07af8b966049bb7d62a89ac8245fd80c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Friends_Followers), @"mvc.1.0.view", @"/Views/Friends/Followers.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"373cfefc07af8b966049bb7d62a89ac8245fd80c", @"/Views/Friends/Followers.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b0abb65d846b7fe1da830c176fb4437c02c5ff2f", @"/Views/_ViewImports.cshtml")]
    public class Views_Friends_Followers : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FollowViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Ventcy\Documents\Project\Web\WardrobeT.Web\Views\Friends\Followers.cshtml"
  
    ViewData["Title"] = "Followers";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1 class=\"font-weight-light text-center text-lg-left mt-4 mb-0\">");
#nullable restore
#line 6 "C:\Users\Ventcy\Documents\Project\Web\WardrobeT.Web\Views\Friends\Followers.cshtml"
                                                            Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n<hr class=\"mt-2 mb-5\">\r\n\r\n<div class=\"container\">\r\n    <p class=\"text-right text-muted\">\r\n        count: ");
#nullable restore
#line 12 "C:\Users\Ventcy\Documents\Project\Web\WardrobeT.Web\Views\Friends\Followers.cshtml"
          Write(Model.Profiles.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </p>\r\n    <div class=\"row \">\r\n");
#nullable restore
#line 15 "C:\Users\Ventcy\Documents\Project\Web\WardrobeT.Web\Views\Friends\Followers.cshtml"
         if (Model.Profiles.Count == 0)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"w-100\">\r\n                <p class=\"text-center text-muted mt-5\">\r\n                    No followers yet\r\n                </p>\r\n            </div>\r\n");
#nullable restore
#line 22 "C:\Users\Ventcy\Documents\Project\Web\WardrobeT.Web\Views\Friends\Followers.cshtml"
        }
        else
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\Users\Ventcy\Documents\Project\Web\WardrobeT.Web\Views\Friends\Followers.cshtml"
             foreach (var item in Model.Profiles)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col\">\r\n                    <div class=\"card text-white bg-dark mb-3\" style=\"width: 18rem;\">\r\n");
#nullable restore
#line 29 "C:\Users\Ventcy\Documents\Project\Web\WardrobeT.Web\Views\Friends\Followers.cshtml"
                         if (item.ProfilePictureUrl != null)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <a");
            BeginWriteAttribute("href", " href=\"", 889, "\"", 921, 2);
            WriteAttributeValue("", 896, "/User/Profile?id=", 896, 17, true);
#nullable restore
#line 31 "C:\Users\Ventcy\Documents\Project\Web\WardrobeT.Web\Views\Friends\Followers.cshtml"
WriteAttributeValue("", 913, item.Id, 913, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                <img");
            BeginWriteAttribute("src", " src=\"", 961, "\"", 990, 1);
#nullable restore
#line 32 "C:\Users\Ventcy\Documents\Project\Web\WardrobeT.Web\Views\Friends\Followers.cshtml"
WriteAttributeValue("", 967, item.ProfilePictureUrl, 967, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-fluid\">\r\n                            </a>\r\n");
#nullable restore
#line 34 "C:\Users\Ventcy\Documents\Project\Web\WardrobeT.Web\Views\Friends\Followers.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <a");
            BeginWriteAttribute("href", " href=\"", 1160, "\"", 1192, 2);
            WriteAttributeValue("", 1167, "/User/Profile?id=", 1167, 17, true);
#nullable restore
#line 37 "C:\Users\Ventcy\Documents\Project\Web\WardrobeT.Web\Views\Friends\Followers.cshtml"
WriteAttributeValue("", 1184, item.Id, 1184, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                <img src=\"https://st2.depositphotos.com/1032921/5237/v/600/depositphotos_52374307-stock-illustration-blue-profile-icon.jpg\" class=\"img-fluid\">\r\n                            </a>\r\n");
#nullable restore
#line 40 "C:\Users\Ventcy\Documents\Project\Web\WardrobeT.Web\Views\Friends\Followers.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"card-body text-center\">\r\n                            <h5>");
#nullable restore
#line 42 "C:\Users\Ventcy\Documents\Project\Web\WardrobeT.Web\Views\Friends\Followers.cshtml"
                           Write(item.Profile);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                            <div class=\"text-center\">\r\n");
#nullable restore
#line 44 "C:\Users\Ventcy\Documents\Project\Web\WardrobeT.Web\Views\Friends\Followers.cshtml"
                                 if (item.IsFollowed == false)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <a class=\"btn btn-danger\"");
            BeginWriteAttribute("href", " href=\"", 1761, "\"", 1829, 3);
            WriteAttributeValue("", 1768, "/Home/Follow?FollowId=", 1768, 22, true);
#nullable restore
#line 46 "C:\Users\Ventcy\Documents\Project\Web\WardrobeT.Web\Views\Friends\Followers.cshtml"
WriteAttributeValue("", 1790, item.ProfileId, 1790, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1805, "&&url=/Friends/Followers", 1805, 24, true);
            EndWriteAttribute();
            WriteLiteral(">Follow</a>\r\n");
#nullable restore
#line 47 "C:\Users\Ventcy\Documents\Project\Web\WardrobeT.Web\Views\Friends\Followers.cshtml"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <a class=\"btn btn-dark\">Following</a>\r\n");
#nullable restore
#line 51 "C:\Users\Ventcy\Documents\Project\Web\WardrobeT.Web\Views\Friends\Followers.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 56 "C:\Users\Ventcy\Documents\Project\Web\WardrobeT.Web\Views\Friends\Followers.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 56 "C:\Users\Ventcy\Documents\Project\Web\WardrobeT.Web\Views\Friends\Followers.cshtml"
             
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FollowViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
