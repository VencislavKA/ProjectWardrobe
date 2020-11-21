using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Wardrobe.Data;
using WardrobeT.Data.Models.Enums;

namespace WardrobeT.Web.ViewModels.Wardrobe
{
    public class AddWearModel
    {
        public AddWearModel()
        {
            this.WearsType = new HashSet<SelectListItem>();
            this.Seasons = new HashSet<Season>();
        }

        public int[] WearsId { get; set; }

        [Display(Name = "What is the tipe of the wear?")]
        public ICollection<SelectListItem> WearsType { get; set; }

        public int[] SeasonsId { get; set; }

        [Display(Name = "For which season is this wear?")]
        public ICollection<Season> Seasons { get; set; }
    }
}
