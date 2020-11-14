using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Wardrobe.Data;
using WardrobeT.Data.Common.Models;
using WardrobeT.Data.Models.Enums;

namespace WardrobeT.Data.Models
{
    public class Cloath : BaseModel<string>
    {
        [Required]
        public string ImageUrl { get; set; }

        [Required]
        public TypeOfCloath Type { get; set; }

        [Required]
        public Season Season { get; set; }

        [Required]
        public Style Style { get; set; }

        [Required]
        public IdentityUser Owner { get; set; }
    }
}
