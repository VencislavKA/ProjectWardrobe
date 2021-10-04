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
            // TODO: let to edit cover photos

            ApplicationUser user = await this.UsersService.GetUserAsync(this.User.Identity.Name);
            var wears = await this.WearsService.GetWearsAsync(this.User.Identity.Name);
            var followers = this.FollowersService.GetFollowers(this.User.Identity.Name);
            var following = this.FollowersService.GetFollowing(this.User.Identity.Name);

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
            // TODO: let people see others followers and following profiles

            // TODO: change the possition of unfollow and follow btn

            ApplicationUser user = await this.UsersService.GetUserByIdAsync(id);
            if (user == null)
            {
                return this.NotFound();
            }

            var wears = await this.WearsService.GetWearsAsync(user.UserName);
            var followers = this.FollowersService.GetFollowers(user.UserName);
            var following = this.FollowersService.GetFollowing(user.UserName);
            var userfollowed = this.UsersService.SearchUsersAsync(this.User.Identity.Name, user.UserName).Result.FirstOrDefault();
            var isFollowed = userfollowed.IsFollowed;

            var profileViewModel = new ProfileViewModel
            {
                Id = user.Id,
                IsFollowed = isFollowed,
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
