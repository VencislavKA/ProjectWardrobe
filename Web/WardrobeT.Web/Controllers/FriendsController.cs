namespace WardrobeT.Web.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.EntityFrameworkCore;
    using WardrobeT.Data;
    using WardrobeT.Data.Models;
    using WardrobeT.Services.Data;
    using WardrobeT.Web.ViewModels.Friends;
    using WardrobeT.Web.ViewModels.Search;

    [Authorize]
    public class FriendsController : BaseController
    {
        private readonly IFollowersService followersService;

        public FriendsController(IFollowersService service)
        {
            this.followersService = service;
        }

        public IActionResult Followers()
        {
            var searchResult = new FollowViewModel();
            searchResult.Profiles = this.followersService.GetFollowers(this.User.Identity.Name);
            return this.View(searchResult);
        }

        public IActionResult Following()
        {
            var searchResult = new FollowViewModel();
            searchResult.Profiles = this.followersService.GetFollowing(this.User.Identity.Name);
            return this.View(searchResult);
        }
    }
}
