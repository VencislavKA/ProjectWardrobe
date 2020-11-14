namespace Wardrobe.Data
{
    using System.ComponentModel.DataAnnotations;

    using WardrobeT.Data.Common.Models;

    public class TypeOfCloath : BaseModel<string>
    {
        [Required]
        public string Type { get; set; }

        [Required]
        public bool Official { get; set; }

        [Required]
        public bool CanBeUsedAlone { get; set; }
    }
}
