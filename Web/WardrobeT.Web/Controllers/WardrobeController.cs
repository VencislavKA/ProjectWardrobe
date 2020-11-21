using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WardrobeT.Data;
using WardrobeT.Data.Models;
using WardrobeT.Data.Models.Enums;
using WardrobeT.Web.ViewModels.Users;

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
            //this.Db.Wears.Add(new Wear
            //{
            //    ImageUrl = "/images/top.webp",
            //    Type = this.Db.TypesOfCloath.FirstOrDefault(),
            //    Season = Season.Autumn,
            //    Owner = user,
            //});
            //this.Db.SaveChanges();
            return this.View();
        }

        //[HttpPost]
        //public IActionResult AddWear(Add)
        //{
        //    return this.View();
        //}

    }
}
