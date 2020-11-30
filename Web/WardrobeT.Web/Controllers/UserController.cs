namespace WardrobeT.Web.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;
    using WardrobeT.Data;
    using WardrobeT.Data.Models;
    using WardrobeT.Data.Models.Enums;
    using WardrobeT.Data.Repositories;
    using WardrobeT.Web.ViewModels.Users;

    public class UserController : Controller
    {
        public ApplicationDbContext Db { get; }

        public UserController(ApplicationDbContext db)
        {
            this.Db = db;
        }

        [HttpGet]
        public async Task<IActionResult> Profile()
        {
            ApplicationUser user = this.Db.Users.FirstOrDefault(x => x.UserName == this.User.Identity.Name);
            List<Wear> wears = this.Db.Wears.Select(x => x).Where(x => x.Owner == user).ToList();
            List<Followers> followers = this.Db.Followers.Select(x => x).Where(x => x.Followed == user).ToList();
            List<Followers> following = this.Db.Followers.Select(x => x).Where(x => x.User == user).ToList();


            var profileViewModel = new ProfileViewModel
            {
                Username = user.UserName,
                Email = user.Email,
                Wears = wears,
                Followers = followers,
                Following = following,
            };
            return this.View(profileViewModel);
        }
        public async Task<IActionResult> SetProfilePicture()
        {
            return this.View();
        }

        [HttpPost]
        public async Task<IActionResult> SetProfilePicture(IFormFile profilePic)
        {

            return this.View();
        }

        public async Task<IActionResult> Notifications()
        {
            return this.View();
        }
    }
}
