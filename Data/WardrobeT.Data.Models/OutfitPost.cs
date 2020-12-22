namespace WardrobeT.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Text;

    using WardrobeT.Data.Common.Models;

    public class OutfitPost : BaseModel<string>
    {
        public OutfitPost()
        {
            this.Id = Guid.NewGuid().ToString();
        }

        [Required]
        public Outfit Outfit { get; set; }

        [Required]
        [Range(0, int.MaxValue)]
        public int Likes { get; set; }
    }
}
