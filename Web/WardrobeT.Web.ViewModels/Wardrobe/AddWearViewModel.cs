using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Wardrobe.Data;
using WardrobeT.Data.Models.Enums;

namespace WardrobeT.Web.ViewModels.Wardrobe
{
    public class AddWearViewModel
    {
        public AddWearViewModel()
        {
            this.WearsType = new HashSet<TypeOfWear>();
            this.Seasons = new HashSet<Season>();
        }

        [Required]
        [Display(Name = "Select image of the wear")]
        public IFormFile WearImage { get; set; }

        [Required]
        [Display(Name = "What is the tipe of the wear?")]
        public ICollection<TypeOfWear> WearsType { get; set; }

        [Required]
        [Display(Name = "For which season is this wear?")]
        public ICollection<Season> Seasons { get; set; }
    }
}
