using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Wardrobe.Data;
using WardrobeT.Data;
using WardrobeT.Data.Models;
using WardrobeT.Data.Models.Enums;
using WardrobeT.Web.ViewModels.Users;
using WardrobeT.Web.ViewModels.Wardrobe;

namespace WardrobeT.Web.Controllers
{
    public class WardrobeController : Controller
    {
        public ApplicationDbContext Db { get; }

        public WardrobeController(ApplicationDbContext db)
        {
            Db = db;
        }

        public IActionResult Outfits()
        {
            return this.View();
        }

        public IActionResult Index()
        {
            ApplicationUser user = this.Db.Users.FirstOrDefault(x => x.UserName == this.User.Identity.Name);
            List<Wear> wears = this.Db.Wears.Select(x => x).Where(x => x.Owner == user).ToList();

            var wardrobeViewModel = new WardrobeViewModel
            {
                Wears = wears,
            };

            return this.View(wardrobeViewModel);
        }

        [HttpGet]
        public IActionResult AddWear()
        {
            var addWear = new AddWearModel
            {
                Seasons = new List<Season>() { Season.Autumn, Season.Spring, Season.Summer, Season.Winter },
            };
            return this.View(addWear);
        }

        [HttpPost]
        public IActionResult AddWear(AddWearModel model)
        {
            return this.View(model);
        }
    }
}
