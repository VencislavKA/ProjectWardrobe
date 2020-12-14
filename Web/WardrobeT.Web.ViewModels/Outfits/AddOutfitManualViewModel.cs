using System;
using System.Collections.Generic;
using System.Text;
using WardrobeT.Data.Models;

namespace WardrobeT.Web.ViewModels.Outfits
{
    public class AddOutfitManualViewModel
    {
        public AddOutfitManualViewModel()
        {
            this.Tops = new HashSet<Wear>();
            this.Middles = new HashSet<Wear>();
            this.Bottoms = new HashSet<Wear>();
        }

        public ICollection<Wear> Tops { get; set; }

        public ICollection<Wear> Middles { get; set; }

        public ICollection<Wear> Bottoms { get; set; }
    }
}
