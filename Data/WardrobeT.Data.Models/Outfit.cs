namespace WardrobeT.Data.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    using WardrobeT.Data.Common.Models;

    public class Outfit : BaseModel<string>
    {
        public Outfit()
        {
            this.Id = Guid.NewGuid().ToString();
        }

        [Required]
        public Wear Top { get; set; }

        [Required]
        public Wear Middle { get; set; }

        [Required]
        public Wear Bottom { get; set; }


    }
}
