namespace WardrobeT.Web.ViewModels.Feed
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    using WardrobeT.Data.Models;
    using WardrobeT.Services.Data;

    public class IndexFeedWearPost
    {
        public WearPost Post { get; set; }

        public bool Liked { get; set; }
    }
}
