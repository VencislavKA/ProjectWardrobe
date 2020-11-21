namespace WardrobeT.Data.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    using Microsoft.AspNetCore.Identity;
    using Wardrobe.Data;
    using WardrobeT.Data.Common.Models;
    using WardrobeT.Data.Models.Enums;

    public class Wear : BaseModel<string>
    {
        public Wear()
        {
            this.Id = Guid.NewGuid().ToString();
        }

        [Required]
        public string ImageUrl { get; set; }

        [Required]
        public TypeOfWear Type { get; set; }

        [Required]
        public Season Season { get; set; }

        [Required]
        public ApplicationUser Owner { get; set; }

        //[Required]
        //public Style Style { get; set; }
    }
}
