namespace Wardrobe.Data
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using WardrobeT.Data.Common.Models;
    using WardrobeT.Data.Models.Enums;

    public class TypeOfWear : BaseModel<string>
    {
        public TypeOfWear()
        {
            this.Id = Guid.NewGuid().ToString();
        }

        [Required]
        public string Type { get; set; }

        [Required]
        public Cover Cover { get; set; }

        [Required]
        public bool Official { get; set; }

        [Required]
        public bool CanBeUsedAlone { get; set; }
    }
}
