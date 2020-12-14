using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WardrobeT.Data;
using WardrobeT.Data.Models;
using WardrobeT.Data.Models.Enums;
using WardrobeT.Web.ViewModels.Outfits;

namespace WardrobeT.Web.Controllers
{
    public class OutfitsController : Controller
    {
        public ApplicationDbContext Db { get; }

        public OutfitsController(ApplicationDbContext db)
        {
            Db = db;
        }

        [HttpGet]
        public async Task<IActionResult> AddOutfitManual()
        {
            // in wardrobe service add metoths getMytops,getMymiddles and getMyBottom
            var tops = await this.Db.Wears.Where(x => x.Owner.UserName == this.User.Identity.Name
                                                    && x.Type.Cover == Cover.top)
                                                .Select(x => x).ToListAsync();

            var middles = await this.Db.Wears.Where(x => x.Owner.UserName == this.User.Identity.Name
                                                    && x.Type.Cover == Cover.middle)
                                                .Select(x => x).ToListAsync();

            var bottoms = await this.Db.Wears.Where(x => x.Owner.UserName == this.User.Identity.Name
                                                    && x.Type.Cover == Cover.bottom)
                                                .Select(x => x).ToListAsync();

            var viewModel = new AddOutfitManualViewModel
            {
                Tops = tops,
                Middles = middles,
                Bottoms = bottoms,
            };

            return this.View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> AddOutfitManual(AddManualInputModel model)
        {
            // as createOutfit in outfits controller
            var top = await this.Db.Wears.FindAsync(model.Top);
            var middle = await this.Db.Wears.FindAsync(model.Middle);
            var bottom = await this.Db.Wears.FindAsync(model.Bottom);
            await this.Db.Outfits.AddAsync(new Outfit
            {
                Top = top,
                Middle = middle,
                Bottom = bottom,
            });
            await this.Db.SaveChangesAsync();
            //
            return this.RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            //get myOutfits
            List<Outfit> outfits = await this.Db.Outfits.Where(x => x.Top.Owner.UserName == this.User.Identity.Name)
                .Select(x => x)
                .Include(x => x.Top)
                .Include(x => x.Middle)
                .Include(x => x.Bottom)
                .ToListAsync();
            //
            var modelView = new OutfitsViewModel
            {
                Outfits = outfits,
            };
            return this.View(modelView);
        }

        public async Task<IActionResult> AddOutfit(AddOutfitInputModel model)
        {
            Wear topWear = await this.Db.Wears.Where(x => x.Id == model.topId).Select(x => x).FirstOrDefaultAsync();
            Wear middleWear = await this.Db.Wears.Where(x => x.Id == model.middleId).Select(x => x).FirstOrDefaultAsync();
            Wear bottumWear = await this.Db.Wears.Where(x => x.Id == model.bottomId).Select(x => x).FirstOrDefaultAsync();
            if (topWear != null && middleWear != null && bottumWear != null)
            {
                var user = this.Db.Users.Where(x => x.UserName == this.User.Identity.Name).Select(x => x).FirstOrDefault();
                if (topWear.Owner == user)
                {
                    await this.Db.Outfits.AddAsync(new Outfit()
                    {
                        Top = topWear,
                        Middle = middleWear,
                        Bottom = bottumWear,
                    });
                    await this.Db.SaveChangesAsync();
                }
            }

            return this.Redirect(model.url);
        }

        public async Task<IActionResult> DeleteOutfit(string id)
        {
            if (await this.Db.Outfits.FindAsync(id) != null &&
                await this.Db.Outfits.Include(x => x.Top).Where(x => x.Top.Owner.UserName == this.User.Identity.Name && x.Id == id).FirstOrDefaultAsync() != null)
            {
                this.Db.Outfits.Remove(await this.Db.Outfits.FindAsync(id));
                await this.Db.SaveChangesAsync();
            }

            return this.RedirectToAction("Index");
        }
    }
}
