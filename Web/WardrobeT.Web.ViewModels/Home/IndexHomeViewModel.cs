using System;
using System.Collections.Generic;
using System.Text;
using WardrobeT.Data.Models;

namespace WardrobeT.Web.ViewModels.Home
{
    public class IndexHomeViewModel
    {
        public IndexHomeViewModel()
        {
            this.Outfits = new HashSet<Outfit>();
        }

        public ICollection<Outfit> Outfits { get; set; }

    }
}
