namespace WardrobeT.Web.Controllers
{
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
    using Microsoft.EntityFrameworkCore;
    using Wardrobe.Data;
    using WardrobeT.Data;
    using WardrobeT.Data.Models;
    using WardrobeT.Data.Models.Enums;
    using WardrobeT.Services.Data;
    using WardrobeT.Services.Mapping;
    using WardrobeT.Web.ViewModels.Users;
    using WardrobeT.Web.ViewModels.Wardrobe;

    public class WardrobeController : Controller
    {
        [Obsolete]
        public WardrobeController(ApplicationDbContext db, IHostingEnvironment environment, IWearsService wearsService)
        {
            this.Db = db;
            this.Environment = environment;
            this.WearsService = wearsService;
        }


        public ApplicationDbContext Db { get; }

        [Obsolete]
        public IHostingEnvironment Environment { get; }

        public IWearsService WearsService { get; }

        public async Task<IActionResult> Index()
        {
            var wears = await this.WearsService.GetWearsAsync(this.User.Identity.Name);
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
                WearsType = await this.WearsService.GetTypeOfWearsAsync(),
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

            await this.WearsService.CreateWearAsync(model.WearType, model.Season, model.Color, imagePath, this.User.Identity.Name);

            return this.Redirect("Index");
        }

        public async Task<IActionResult> DeleteWear(string id)
        {
            await this.WearsService.DeleteWearAsync(id, this.User.Identity.Name);
            return this.RedirectToAction("Index");
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
