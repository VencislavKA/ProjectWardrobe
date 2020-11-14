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
        public string TopImage { get; set; }

        [Required]
        public string MiddleImage { get; set; }

        [Required]
        public string BatomImage { get; set; }
    }
}
