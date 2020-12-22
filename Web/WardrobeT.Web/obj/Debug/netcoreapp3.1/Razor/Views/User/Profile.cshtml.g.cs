#pragma checksum "C:\Users\Ventcy\Documents\Project\Web\WardrobeT.Web\Views\User\Profile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "39de143307d1e842ccc148a20b507aea72103e04"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_Profile), @"mvc.1.0.view", @"/Views/User/Profile.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"39de143307d1e842ccc148a20b507aea72103e04", @"/Views/User/Profile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b0abb65d846b7fe1da830c176fb4437c02c5ff2f", @"/Views/_ViewImports.cshtml")]
    public class Views_User_Profile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProfileViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Ventcy\Documents\Project\Web\WardrobeT.Web\Views\User\Profile.cshtml"
  
    ViewData["Title"] = "Profile";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>
    .profile-head {
        transform: translateY(5rem)
    }

    .cover {
        background-image: url(https://images.unsplash.com/photo-1530305408560-82d13781b33a?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=1352&q=80);
        background-size: cover;
        background-repeat: no-repeat;
    }

    html {
        scroll-behavior: smooth;
    }
</style>

<div class=""row"">
    <div class=""mx-auto w-100"">
        <div class=""bg-white shadow rounded overflow-hidden"">
            <div class=""px-5 pt-0 pb-4 cover"">
                <div class=""d-flex align-items-center justify-content-between mb-3"">
                </div>
                <div class=""media align-items-end profile-head"">
                    <div class=""profile mr-3"">
");
#nullable restore
#line 30 "C:\Users\Ventcy\Documents\Project\Web\WardrobeT.Web\Views\User\Profile.cshtml"
                         if (Model.ProfilePicUrl != null)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <img");
            BeginWriteAttribute("src", " src=\"", 979, "\"", 1005, 1);
#nullable restore
#line 32 "C:\Users\Ventcy\Documents\Project\Web\WardrobeT.Web\Views\User\Profile.cshtml"
WriteAttributeValue("", 985, Model.ProfilePicUrl, 985, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"130\" class=\"rounded mb-2 img-thumbnail\">\r\n");
#nullable restore
#line 33 "C:\Users\Ventcy\Documents\Project\Web\WardrobeT.Web\Views\User\Profile.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <img src=\"https://st2.depositphotos.com/1032921/5237/v/600/depositphotos_52374307-stock-illustration-blue-profile-icon.jpg\" width=\"130\" class=\"rounded mb-2 img-thumbnail\">\r\n");
#nullable restore
#line 37 "C:\Users\Ventcy\Documents\Project\Web\WardrobeT.Web\Views\User\Profile.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n                    <div class=\"media-body mb-5 text-white\">\r\n                        <h4 class=\"mt-0 mb-0\">");
#nullable restore
#line 40 "C:\Users\Ventcy\Documents\Project\Web\WardrobeT.Web\Views\User\Profile.cshtml"
                                         Write(Model.Username);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h4>
                        <p class=""small mb-4""></p>
                    </div>
                </div>
            </div>
            <div class=""bg-light p-4 d-flex justify-content-end text-center"">
                <ul class=""list-inline mb-0"">
                    <li class=""list-inline-item"">
                        <a class=""btn btn-outline-dark"" href=""#Wardrobe"">
                            <h5 class=""font-weight-bold mb-0 d-block"">");
#nullable restore
#line 49 "C:\Users\Ventcy\Documents\Project\Web\WardrobeT.Web\Views\User\Profile.cshtml"
                                                                 Write(Model.Wears.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h5><small class=""text-muted"">
                                <svg width=""1em"" height=""1em"" viewBox=""0 0 16 16"" class=""bi bi-layers-half"" fill=""currentColor"" xmlns=""http://www.w3.org/2000/svg"">
                                    <path fill-rule=""evenodd"" d=""M3.188 8L.264 9.559a.5.5 0 0 0 0 .882l7.5 4a.5.5 0 0 0 .47 0l7.5-4a.5.5 0 0 0 0-.882L12.813 8l-4.578 2.441a.5.5 0 0 1-.47 0L3.188 8z"" />
                                    <path fill-rule=""evenodd"" d=""M7.765 1.559a.5.5 0 0 1 .47 0l7.5 4a.5.5 0 0 1 0 .882l-7.5 4a.5.5 0 0 1-.47 0l-7.5-4a.5.5 0 0 1 0-.882l7.5-4zM1.563 6L8 9.433 14.438 6 8 2.567 1.562 6z"" />
                                </svg>
                                Cloaths
                            </small>
                        </a>
                    </li>
                    <li class=""list-inline-item"">
                        <a class=""btn btn-outline-dark"">
                            <h5 class=""font-weight-bold mb-0 d-block"">");
#nullable restore
#line 60 "C:\Users\Ventcy\Documents\Project\Web\WardrobeT.Web\Views\User\Profile.cshtml"
                                                                 Write(Model.Followers);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h5><small class=""text-muted""> <i class=""fas fa-user mr-1""></i>Followers</small>
                        </a>
                    </li>
                    <li class=""list-inline-item"">
                        <a class=""btn btn-outline-dark"">
                            <h5 class=""font-weight-bold mb-0 d-block"">");
#nullable restore
#line 65 "C:\Users\Ventcy\Documents\Project\Web\WardrobeT.Web\Views\User\Profile.cshtml"
                                                                 Write(Model.Following);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h5><small class=""text-muted""> <i class=""fas fa-user mr-1""></i>Following</small>
                        </a>
                    </li>
                </ul>
            </div>
            <section name=""Wardorobe"" id=""Wardrobe"">
                <div class=""py-4 px-4"">
                    <div class=""d-flex align-items-center justify-content-between mb-3"">
                        <h5 class=""mb-0"">Cloaths</h5>
                    </div>
                    <div class=""row text-center text-lg-left"">
");
#nullable restore
#line 76 "C:\Users\Ventcy\Documents\Project\Web\WardrobeT.Web\Views\User\Profile.cshtml"
                         if (Model.Wears.Count == 0)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"w-100\">\r\n                                <p class=\"text-center text-muted mt-5\">\r\n                                    No clothes added yet\r\n                                </p>\r\n                            </div>\r\n");
#nullable restore
#line 83 "C:\Users\Ventcy\Documents\Project\Web\WardrobeT.Web\Views\User\Profile.cshtml"
                        }
                        else
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 86 "C:\Users\Ventcy\Documents\Project\Web\WardrobeT.Web\Views\User\Profile.cshtml"
                             foreach (var item in Model.Wears)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\"col-lg-3 col-md-4 col-6\">\r\n                                    <a class=\"d-block mb-4 h-100\">\r\n                                        <img class=\"img-fluid img-thumbnail\"");
            BeginWriteAttribute("src", " src=\"", 4563, "\"", 4583, 1);
#nullable restore
#line 90 "C:\Users\Ventcy\Documents\Project\Web\WardrobeT.Web\Views\User\Profile.cshtml"
WriteAttributeValue("", 4569, item.ImageUrl, 4569, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 4584, "\"", 4590, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    </a>\r\n                                </div>\r\n");
#nullable restore
#line 93 "C:\Users\Ventcy\Documents\Project\Web\WardrobeT.Web\Views\User\Profile.cshtml"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 93 "C:\Users\Ventcy\Documents\Project\Web\WardrobeT.Web\Views\User\Profile.cshtml"
                             
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n                </div>\r\n            </section>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProfileViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
