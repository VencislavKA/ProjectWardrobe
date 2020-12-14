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
    using WardrobeT.Data.Models;
    using WardrobeT.Data.Models.Enums;
    using WardrobeT.Web.ViewModels;
    using WardrobeT.Web.ViewModels.Home;
    using WardrobeT.Web.ViewModels.Search;

    public class HomeController : BaseController
    {
        public ApplicationDbContext Db { get; }

        public HomeController(ApplicationDbContext db)
        {
            Db = db;
        }

        public async Task<IActionResult> Index()
        {
            // getMyOutfits in outfits controller 
            List<Wear> tops = await this.Db.Wears.Where(x => x.Owner.UserName == this.User.Identity.Name && x.Type.Cover == Cover.top).ToListAsync();
            List<Wear> middles = await this.Db.Wears.Where(x => x.Owner.UserName == this.User.Identity.Name && x.Type.Cover == Cover.middle).ToListAsync();
            List<Wear> bottoms = await this.Db.Wears.Where(x => x.Owner.UserName == this.User.Identity.Name && x.Type.Cover == Cover.bottom).ToListAsync();
            var indexHomeViewModel = new IndexHomeViewModel();
            if (tops.Count() == 0 || middles.Count() == 0 || bottoms.Count() == 0)
            {
                return this.View(indexHomeViewModel);
            }
            var randum1 = new Random();
            var randum2 = new Random();
            var randum3 = new Random();
            for (int i = 0; i < 10; i++)
            {
                indexHomeViewModel.Outfits.Add(new Outfit()
                {
                    Top = tops[randum1.Next(0, tops.Count)],
                    Middle = middles[randum2.Next(0, middles.Count)],
                    Bottom = bottoms[randum3.Next(0, bottoms.Count)],
                });
            }
            //
            return this.View(indexHomeViewModel);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public async Task<IActionResult> Error()
        {
            return this.View(
                new ErrorViewModel { RequestId = Activity.Current?.Id ?? this.HttpContext.TraceIdentifier });
        }

        [Authorize]
        public async Task<IActionResult> Follow(string FollowId, string url)
        {
            var user = await this.Db.Users.Select(x => x).Where(x => x.UserName == this.User.Identity.Name).FirstOrDefaultAsync();
            if (this.Db.Users.Find(FollowId) == null)
            {
                return this.RedirectToAction("Error");
            }
            var follow = await this.Db.Users.Select(x => x).Where(x => x.Id == FollowId).FirstOrDefaultAsync();
            if (FollowId != user.Id && !this.Db.Followers.Any(x => x.User.Id == user.Id && x.Followed.Id == follow.Id))
            {
                //as creteFollower in followers service
                Followers followers = new Followers
                {
                    User = user,
                    Followed = follow,
                };
                await this.Db.Followers.AddAsync(followers);
                await this.Db.SaveChangesAsync();
                //
                return this.Redirect(""+url);
            }

            return this.RedirectToAction("Error");
        }

        public async Task<IActionResult> Search(string search)
        {
            List<ApplicationUser> users = await this.Db.Users.Select(x => x).ToListAsync();
            var searchResult = new SearchResultViewModel();
            searchResult.Search = "/Home/Search?search=" + search;
            if (string.IsNullOrWhiteSpace(search))
            {
                return this.View(searchResult);
            }
            foreach (var user in users)
            {
                if (user.NormalizedUserName.Contains(search.ToUpper()) && user.UserName != this.User.Identity.Name)
                {
                    //as searchUser and returns list of users
                    if (await this.Db.Followers.Where(x => x.User.UserName == this.User.Identity.Name && x.Followed.UserName == user.UserName).FirstOrDefaultAsync() == null)
                    {
                        searchResult.Users.Add(new User
                        {
                            ProfilePictureUrl = user.ProfilePicture,
                            ProfileId = user.Id,
                            Profile = user.UserName,
                            IsFollowed = false,
                        });
                    }
                    else
                    {
                        searchResult.Users.Add(new User
                        {
                            ProfilePictureUrl = user.ProfilePicture,
                            ProfileId = user.Id,
                            Profile = user.UserName,
                            IsFollowed = true,
                        });
                    }
                    //
                }
            }
            return this.View(searchResult);
        }
    }
}
