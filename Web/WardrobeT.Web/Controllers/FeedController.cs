namespace WardrobeT.Web.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Mvc;
    using WardrobeT.Services.Data;
    using WardrobeT.Web.ViewModels.Feed;

    public class FeedController : BaseController
    {
        public FeedController(IFeedService feedService)
        {
            this.FeedService = feedService;
        }

        public IFeedService FeedService { get; }

        public async Task<IActionResult> Index()
        {
            var outfitposts = await this.FeedService.GetOutfitPostsAsync(this.User.Identity.Name);
            var wearposts = await this.FeedService.GetWearPostsAsync(this.User.Identity.Name);
            var view = new IndexFeedViewModel()
            {
                OutfitPosts = outfitposts,
                WearPosts = wearposts,
            };
            return this.View(view);
        }

        public async Task<IActionResult> MakePublicWear(string id)
        {
            var result = await this.FeedService.MakeWearPublicAsync(id);
            if (result == null)
            {
                return this.NotFound();
            }

            return this.RedirectToAction("Index", "Wardrobe");
        }

        public async Task<IActionResult> MakePublicOutfit(string id)
        {
            var result = await this.FeedService.MakeOutfitPublicAsync(id);
            if (result == null)
            {
                return this.NotFound();
            }

            return this.RedirectToAction("Index", "Outfits");
        }
    }
}
