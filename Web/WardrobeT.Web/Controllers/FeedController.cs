namespace WardrobeT.Web.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Security.Cryptography.X509Certificates;
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Authorization;
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

        [Authorize]
        public async Task<IActionResult> Index()
        {
            var outfitposts = await this.FeedService.GetOutfitPostsAsync(this.User.Identity.Name);
            var wearposts = await this.FeedService.GetWearPostsAsync(this.User.Identity.Name);

            List<IndexFeedWearPost> wears = new List<IndexFeedWearPost>();
            List<IndexFeedOutfitPost> outfits = new List<IndexFeedOutfitPost>();

            foreach (var wear in wearposts)
            {
                if (wear.Likes.Where(x => x.UserName == this.User.Identity.Name).FirstOrDefault() == null)
                {
                    wears.Add(new IndexFeedWearPost()
                    {
                        Post = wear,
                        Liked = false,
                    });
                    continue;
                }

                wears.Add(new IndexFeedWearPost()
                {
                    Post = wear,
                    Liked = true,
                });
            }

            foreach (var outfit in outfitposts)
            {
                if (outfit.Likes.Where(x => x.UserName == this.User.Identity.Name).FirstOrDefault() == null)
                {
                    outfits.Add(new IndexFeedOutfitPost()
                    {
                        Post = outfit,
                        Liked = false,
                    });
                    continue;
                }

                outfits.Add(new IndexFeedOutfitPost()
                {
                    Post = outfit,
                    Liked = true,
                });
            }

            var view = new IndexFeedViewModel()
            {
                OutfitPosts = outfits,
                WearPosts = wears,
            };
            return this.View(view);
        }

        [Authorize]
        public async Task<IActionResult> MakePublicWear(string id)
        {
            var result = await this.FeedService.MakeWearPublicAsync(id);
            if (result == null)
            {
                return this.NotFound();
            }

            return this.RedirectToAction("Index", "Wardrobe");
        }

        [Authorize]
        public async Task<IActionResult> MakePrivateWear(string id)
        {
            var result = await this.FeedService.MakeWearPrivateAsync(id);
            if (result == null)
            {
                return this.NotFound();
            }

            return this.RedirectToAction("Index", "Wardrobe");
        }

        [Authorize]
        public async Task<IActionResult> MakePublicOutfit(string id)
        {
            var result = await this.FeedService.MakeOutfitPublicAsync(id);
            if (result == null)
            {
                return this.NotFound();
            }

            return this.RedirectToAction("Index", "Outfits");
        }

        [Authorize]
        public async Task<IActionResult> MakePrivateOutfit(string id)
        {
            var result = await this.FeedService.MakeOutfitPrivateAsync(id);
            if (result == null)
            {
                return this.NotFound();
            }

            return this.RedirectToAction("Index", "Outfits");
        }
    }
}
