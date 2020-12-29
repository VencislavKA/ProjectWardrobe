using System;
using System.Collections.Generic;
using System.Text;
using WardrobeT.Data.Models;

namespace WardrobeT.Web.ViewModels.Feed
{
    public class IndexFeedOutfitPost
    {
        public OutfitPost Post { get; set; }

        public bool Liked { get; set; }
    }
}
