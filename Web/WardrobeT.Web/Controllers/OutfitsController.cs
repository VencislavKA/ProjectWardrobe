namespace WardrobeT.Web.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Security.Principal;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.EntityFrameworkCore;
    using WardrobeT.Data;
    using WardrobeT.Data.Models;
    using WardrobeT.Data.Models.Enums;
    using WardrobeT.Services.Data;
    using WardrobeT.Web.ViewModels.Outfits;

    public class OutfitsController : BaseController
    {
        public OutfitsController(IOutfitsService outfitsService, IWearsService wearsService)
        {
            this.OutfitsService = outfitsService;
            this.WearsService = wearsService;
        }

        public IOutfitsService OutfitsService { get; }

        public IWearsService WearsService { get; }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> AddOutfitManual()
        {
            var tops = await this.WearsService.GetTopsAsync(this.User.Identity.Name);
            var middles = await this.WearsService.GetMiddlesAsync(this.User.Identity.Name);
            var bottoms = await this.WearsService.GetBottomsAsync(this.User.Identity.Name);

            var viewModel = new AddOutfitManualViewModel
            {
                Tops = tops,
                Middles = middles,
                Bottoms = bottoms,
            };

            return this.View(viewModel);
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> AddOutfitManual(AddManualInputModel model)
        {
            if (model.Top == null || model.Middle == null || model.Bottom == null)
            {
                return this.RedirectToAction("Error", "Home");
            }

            await this.OutfitsService.CreateOutfitAsync(model.Top, model.Middle, model.Bottom);
            return this.RedirectToAction("Index");
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> Index()
        {
            List<Outfit> outfits = await this.OutfitsService.GetOutfitsAsync(this.User.Identity.Name);
            var modelView = new OutfitsViewModel
            {
                Outfits = outfits,
            };
            return this.View(modelView);
        }

        [Authorize]
        public async Task<IActionResult> AddOutfit(AddOutfitInputModel model)
        {
            await this.OutfitsService.CreateOutfitAsync(model.topId, model.middleId, model.bottomId);
            return this.Redirect(model.url);
        }

        [Authorize]
        public async Task<IActionResult> DeleteOutfit(string id)
        {
            await this.OutfitsService.DeleteOutfitAsync(this.User.Identity.Name, id);
            return this.RedirectToAction("Index");
        }
    }
}
