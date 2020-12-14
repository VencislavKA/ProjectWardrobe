namespace WardrobeT.Web.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.EntityFrameworkCore;
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
        public async Task<IActionResult> MyProfile()
        {
            //vsqko da mine kato metod ot profile servic-a
                ApplicationUser user = await this.Db.Users.FirstOrDefaultAsync(x => x.UserName == this.User.Identity.Name);
                List<Wear> wears = await this.Db.Wears.Select(x => x).Where(x => x.Owner == user).ToListAsync();
                //nenujen transfer move samo counta da slagam vmesto celiq list ot obekt
                    List<Followers> followers = await this.Db.Followers.Select(x => x).Where(x => x.Followed == user).ToListAsync();
                    List<Followers> following = await this.Db.Followers.Select(x => x).Where(x => x.User == user).ToListAsync();
                //
            //

            var profileViewModel = new ProfileViewModel
            {
                Username = user.UserName,
                Email = user.Email,
                Wears = wears,
                Followers = followers,
                Following = following,
                ProfilePicUrl = user.ProfilePicture,
            };
            return this.View(profileViewModel);
        }
    }
}
