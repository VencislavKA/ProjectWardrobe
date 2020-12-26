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
            this.OutfitPosts = new List<OutfitPost>();
            this.WearPosts = new List<WearPost>();
        }

        public List<WearPost> WearPosts { get; set; }

        public List<OutfitPost> OutfitPosts { get; set; }
    }
}
