namespace WardrobeT.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Text;

    using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
    using WardrobeT.Data.Common.Models;

    public class OutfitPost : BaseModel<string>
    {
        public OutfitPost()
        {
            this.Id = Guid.NewGuid().ToString();
            this.Likes = new List<ApplicationUser>();
        }

        [Required]
        public Outfit Outfit { get; set; }

        [Required]
        public List<ApplicationUser> Likes { get; set; }
    }
}
