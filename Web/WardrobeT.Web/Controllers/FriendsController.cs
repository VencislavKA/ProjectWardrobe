using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WardrobeT.Data;
using WardrobeT.Data.Models;
using WardrobeT.Services.Data;
using WardrobeT.Web.ViewModels.Friends;
using WardrobeT.Web.ViewModels.Search;

namespace WardrobeT.Web.Controllers
{
    public class FriendsController : Controller
    {
        private readonly ApplicationDbContext Db;
        private readonly IFollowersService followersService;

        public FriendsController(ApplicationDbContext db, IFollowersService service)
        {
            this.Db = db;
            this.followersService = service;
        }

        public async Task<IActionResult> Followers()
        {
            var searchResult = new FollowViewModel();
            searchResult.Profiles = await this.followersService.GetFollowersAsync(this.User.Identity.Name);
            return this.View(searchResult);
        }

        public async Task<IActionResult> Following()
        {
            // as get following in followers service and returns list of users
            List<ApplicationUser> profiles = await this.Db.Followers.Where(x => x.User.UserName == this.User.Identity.Name).Select(x => x.Followed).ToListAsync();
            var searchResult = new FollowViewModel();
            foreach (var user in profiles)
            {
                if (await this.Db.Followers.Where(x => x.User.UserName == this.User.Identity.Name && x.Followed.UserName == user.UserName).FirstOrDefaultAsync() == null)
                {
                    searchResult.Profiles.Add(new User
                    {
                        ProfilePictureUrl = user.ProfilePicture,
                        ProfileId = user.Id,
                        Profile = user.UserName,
                        IsFollowed = false,
                    });
                }
                else
                {
                    searchResult.Profiles.Add(new User
                    {
                        ProfilePictureUrl = user.ProfilePicture,
                        ProfileId = user.Id,
                        Profile = user.UserName,
                        IsFollowed = true,
                    });
                }
            }
            //
            return this.View(searchResult);
        }
    }
}
