using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace WardrobeT.Web.ViewModels.Wardrobe
{
    public class AddWearInputModel
    {
        [Required]
        public IFormFile WearImage { get; set; }

        [Required]
        public string WearType { get; set; }

        [Required]
        public string Season { get; set; }
    }
}
