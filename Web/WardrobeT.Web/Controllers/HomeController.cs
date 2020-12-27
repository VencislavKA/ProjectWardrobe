namespace WardrobeT.Web.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.EntityFrameworkCore;
    using WardrobeT.Data;
    using WardrobeT.Data.Common.Repositories;
    using WardrobeT.Data.Models;
    using WardrobeT.Data.Models.Enums;
    using WardrobeT.Services.Data;
    using WardrobeT.Web.ViewModels;
    using WardrobeT.Web.ViewModels.Home;
    using WardrobeT.Web.ViewModels.Search;

    public class HomeController : BaseController
    {
        public HomeController(
            IFollowersService followersService,
            IOutfitsService outfitsService,
            IUsersService usersService)
        {
            this.FollowersService = followersService;
            this.OutfitsService = outfitsService;
            this.UsersService = usersService;
        }

        public IFollowersService FollowersService { get; }

        public IOutfitsService OutfitsService { get; }

        public IUsersService UsersService { get; }

        [Authorize]
        public async Task<IActionResult> Index()
        {
            var indexHomeViewModel = new IndexHomeViewModel();
            var outfits = await this.OutfitsService.GetMyOutfitsAsync(this.User.Identity.Name);
            if (outfits == null)
            {
                return this.View(indexHomeViewModel);
            }

            indexHomeViewModel.Outfits = outfits;
            return this.View(indexHomeViewModel);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return this.View(
                new ErrorViewModel { RequestId = Activity.Current?.Id ?? this.HttpContext.TraceIdentifier });
        }

        [Authorize]
        public async Task<IActionResult> Follow(string followId, string url)
        {
            var result = await this.FollowersService.FollowAsync(this.User.Identity.Name, followId);
            if (result == null)
            {
                return this.NotFound();
            }

            return this.Redirect(string.Empty + url);
        }

        public async Task<IActionResult> Search(string search)
        {
            var searchResult = new SearchResultViewModel();
            searchResult.Search = "/Home/Search?search=" + search;

            if (string.IsNullOrWhiteSpace(search))
            {
                return this.View(searchResult);
            }

            searchResult.Users = await this.UsersService.SearchUsersAsync(this.User.Identity.Name, search);
            return this.View(searchResult);
        }
    }
}
