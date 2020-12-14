using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace WardrobeT.Web.ViewModels.Outfits
{
    public class AddOutfitInputModel
    {
        [Required]
        public string topId { get; set; }

        [Required]
        public string middleId { get; set; }

        [Required]
        public string bottomId { get; set; }

        [Required]
        public string url { get; set; }
    }
}
