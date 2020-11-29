namespace WardrobeT.Web.Controllers
{
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using WardrobeT.Data;
    using WardrobeT.Data.Models;
    using WardrobeT.Web.ViewModels;
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
            return this.View();
        }

        public async Task<IActionResult> Privacy()
        {
            return this.View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public async Task<IActionResult> Error()
        {
            return this.View(
                new ErrorViewModel { RequestId = Activity.Current?.Id ?? this.HttpContext.TraceIdentifier });
        }

        [Authorize]
        public async Task<IActionResult> Follow(string FollowId, string s)
        {
            var user = this.Db.Users.Select(x => x).Where(x => x.UserName == this.User.Identity.Name).FirstOrDefault();
            if (this.Db.Users.Find(FollowId) == null)
            {
                return this.RedirectToAction("Error");
            }
            var follow = this.Db.Users.Select(x => x).Where(x => x.Id == FollowId).FirstOrDefault();
            if (FollowId != user.Id && !this.Db.Followers.Any(x => x.User.Id == user.Id && x.Followed.Id == follow.Id))
            {
                Followers followers = new Followers
                {
                    User = user,
                    Followed = follow,
                };
                this.Db.Followers.AddAsync(followers);
                this.Db.SaveChanges();
                return this.Redirect($"/Home/Search?search=" + s);
            }
            return this.RedirectToAction("Error");
        }

        public async Task<IActionResult> Search(string search)
        {
            List<ApplicationUser> users = this.Db.Users.Select(x => x).ToList();
            var searchResult = new SearchResultViewModel();
            searchResult.Search = search;
            if (string.IsNullOrWhiteSpace(search))
            {
                return this.View(searchResult);
            }
            foreach (var user in users)
            {
                if (user.UserName == this.User.Identity.Name)
                {

                }
                else if (user.NormalizedUserName.Contains(search.ToUpper()))
                {
                    //if the user followes the searced user
                    if (this.Db.Followers.Where(x => x.User.UserName == this.User.Identity.Name && x.Followed.UserName == user.UserName) == null)
                    {
                        searchResult.Users.Add(new SearchProfile
                        {
                            ProfileId = user.Id,
                            Profile = user.UserName,
                            IsFollowed = false,
                        });
                    }
                    else
                    {
                        searchResult.Users.Add(new SearchProfile
                        {
                            ProfileId = user.Id,
                            Profile = user.UserName,
                            IsFollowed = true,
                        });
                    }
                }
            }
            return this.View(searchResult);
        }
    }
}
