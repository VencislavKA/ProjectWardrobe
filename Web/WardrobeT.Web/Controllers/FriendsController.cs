using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WardrobeT.Data;
using WardrobeT.Data.Models;
using WardrobeT.Web.ViewModels.Friends;
using WardrobeT.Web.ViewModels.Search;

namespace WardrobeT.Web.Controllers
{
    public class FriendsController : Controller
    {
        private readonly ApplicationDbContext Db;

        public FriendsController(ApplicationDbContext db)
        {
            this.Db = db;
        }

        public async Task<IActionResult> Followers()
        {
            List<ApplicationUser> profiles = this.Db.Followers.Where(x => x.Followed.UserName == this.User.Identity.Name).Select(x => x.User).ToList();
            var searchResult = new FollowViewModel();
            foreach (var user in profiles)
            {
                if (this.Db.Followers.Where(x => x.User.UserName == this.User.Identity.Name && x.Followed.UserName == user.UserName).FirstOrDefault() == null)
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
            return this.View(searchResult);
        }

        public async Task<IActionResult> Following()
        {
            List<ApplicationUser> profiles = this.Db.Followers.Where(x => x.User.UserName == this.User.Identity.Name).Select(x => x.Followed).ToList();
            var searchResult = new FollowViewModel();
            foreach (var user in profiles)
            {
                if (this.Db.Followers.Where(x => x.User.UserName == this.User.Identity.Name && x.Followed.UserName == user.UserName).FirstOrDefault() == null)
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
            return this.View(searchResult);
        }
    }
}
