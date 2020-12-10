using System;
using System.Collections.Generic;
using System.Text;
using WardrobeT.Data.Models;

namespace WardrobeT.Web.ViewModels.Wardrobe
{
    public class OutfitsViewModel
    {
        public OutfitsViewModel()
        {
            this.Outfits = new HashSet<Outfit>();
        }

        public ICollection<Outfit> Outfits { get; set; }
    }
}
