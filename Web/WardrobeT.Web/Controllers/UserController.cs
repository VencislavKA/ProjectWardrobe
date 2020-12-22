namespace WardrobeT.Web.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.CodeAnalysis.CSharp.Syntax;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Storage;
    using Microsoft.Extensions.DependencyInjection;
    using WardrobeT.Data;
    using WardrobeT.Data.Models;
    using WardrobeT.Data.Models.Enums;
    using WardrobeT.Data.Repositories;
    using WardrobeT.Services.Data;
    using WardrobeT.Web.ViewModels.Users;

    public class UserController : BaseController
    {
        public UserController(
            IUsersService usersService,
            IWearsService wearsService,
            IFollowersService followersService)
        {
            this.UsersService = usersService;
            this.WearsService = wearsService;
            this.FollowersService = followersService;
        }

        public IUsersService UsersService { get; }

        public IWearsService WearsService { get; }

        public IFollowersService FollowersService { get; }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> MyProfile()
        {
            ApplicationUser user = await this.UsersService.GetUserAsync(this.User.Identity.Name);
            var wears = await this.WearsService.GetWearsAsync(this.User.Identity.Name);
            var followers = await this.FollowersService.GetFollowersAsync(this.User.Identity.Name);
            var following = await this.FollowersService.GetFollowingAsync(this.User.Identity.Name);

            var profileViewModel = new ProfileViewModel
            {
                Username = user.UserName,
                Email = user.Email,
                Wears = wears,
                Followers = followers.Count(),
                Following = following.Count(),
                ProfilePicUrl = user.ProfilePicture,
            };
            return this.View(profileViewModel);
        }

        [HttpGet]
        public async Task<IActionResult> Profile(string id)
        {
            ApplicationUser user = await this.UsersService.GetUserByIdAsync(id);
            if (user == null)
            {
                return this.NotFound();
            }

            var wears = await this.WearsService.GetWearsAsync(user.UserName);
            var followers = await this.FollowersService.GetFollowersAsync(user.UserName);
            var following = await this.FollowersService.GetFollowingAsync(user.UserName);

            var profileViewModel = new ProfileViewModel
            {
                Username = user.UserName,
                Email = user.Email,
                Wears = wears,
                Followers = followers.Count(),
                Following = following.Count(),
                ProfilePicUrl = user.ProfilePicture,
            };
            return this.View(profileViewModel);
        }
    }
}
