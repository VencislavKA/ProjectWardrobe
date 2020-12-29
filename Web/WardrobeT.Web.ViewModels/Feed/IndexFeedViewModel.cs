namespace WardrobeT.Web.ViewModels.Feed
{
    using System;
    using System.Collections.Generic;
    using System.Security.Cryptography.Xml;
    using System.Text;

    using WardrobeT.Data.Models;
    using WardrobeT.Services.Data;

    public class IndexFeedViewModel
    {
        public IndexFeedViewModel()
        {
            this.OutfitPosts = new List<IndexFeedOutfitPost>();
            this.WearPosts = new List<IndexFeedWearPost>();
        }

        public List<IndexFeedWearPost> WearPosts { get; set; }

        public List<IndexFeedOutfitPost> OutfitPosts { get; set; }
    }
}
