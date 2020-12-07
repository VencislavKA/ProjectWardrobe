using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
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

        [Obsolete]
        public IHostingEnvironment Environment { get; }

        [Obsolete]
        public WardrobeController(ApplicationDbContext db, IHostingEnvironment environment)
        {
            this.Db = db;
            this.Environment = environment;
        }

        public async Task<IActionResult> Outfits()
        {
            return this.View();
        }

        public async Task<IActionResult> Index()
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
        public async Task<IActionResult> AddWear()
        {
            var addWear = new AddWearViewModel
            {
                WearsType = this.Db.TypesOfWears.Select(x => x).OrderBy(x => x.Type).ToList(),
                Colors = new List<Color>
                {
                    Color.Amber, Color.Aqua, Color.Black, Color.Blue, Color.Blue_gray, Color.Brown,
                    Color.Coral, Color.Dark_green, Color.Eed, Color.Green, Color.Grey, Color.Indigo, Color.Lime, Color.Maroon, Color.Mustard,
                    Color.Navy, Color.Orange, Color.Peach, Color.Pea_green, Color.Pink, Color.Purple, Color.Teal, Color.Violet, Color.White,
                    Color.Yellow,
                },
                Seasons = new List<Season>() { Season.Autumn, Season.Spring, Season.Summer, Season.Winter },
            };
            return this.View(addWear);
        }

        [HttpPost]
        [Obsolete]
        public async Task<IActionResult> AddWear(AddWearInputModel model)
        {
            // proveri dali v snimkata nqma zlonameren kod
            string imagePath = this.StoreFileAsync(model.WearImage).Result;
            if (imagePath == null)
            {
                return this.Redirect("AddWear");
            }

            var type = this.Db.TypesOfWears.FirstOrDefault(x => x.Id == model.WearType);
            Season season;
            Color color;
            _ = Enum.TryParse(model.Season, true, out season);
            _ = Enum.TryParse(model.Color, true, out color);
            ApplicationUser user = this.Db.Users.FirstOrDefault(x => x.UserName == this.User.Identity.Name);
            var wear = new Wear
            {
                ImageUrl = imagePath,
                Type = type,
                Season = season,
                Color = color,
                Owner = user,
            };
            _ = this.Db.Wears.AddAsync(wear);
            this.Db.SaveChanges();
            return this.Redirect("Index");
        }

        [HttpPost]
        public async Task<IActionResult> DeleteWear(string id)
        {
            if (this.Db.Wears.Find(id) != null)
            {
                this.Db.Wears.Remove(this.Db.Wears.Find(id));
            }
            return this.RedirectToAction("Index", "Wardrobe");
        }

        [Obsolete]
        private async Task<string> StoreFileAsync(IFormFile file)
        {
            if (file != null && file.Length > 0)
            {
                var imagePath = @"\Wardrobe\Images\";
                var uploadPath = this.Environment.WebRootPath + imagePath;

                if (!Directory.Exists(uploadPath))
                {
                    Directory.CreateDirectory(uploadPath);
                }

                var uniqFileName = Guid.NewGuid().ToString();
                var filename = Path.GetFileName(uniqFileName + "." + file.FileName.Split(".")[1].ToLower());
                string fullPath = uploadPath + filename;

                imagePath = imagePath + @"\";
                var filePath = @".." + Path.Combine(imagePath, filename);

                using (var fileStream = new FileStream(fullPath, FileMode.Create))
                {
                    await file.CopyToAsync(fileStream);
                }

                return filePath;
            }
            else
            {
                return null;
            }
        }
    }
}
