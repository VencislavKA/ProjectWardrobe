namespace WardrobeT.Services.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Text;

    using WardrobeT.Data.Common.Models;
    using WardrobeT.Data.Models;

    public class WearPost : BaseModel<string>
    {
        public WearPost()
        {
            this.Id = Guid.NewGuid().ToString();
        }

        public Wear Wear { get; set; }

        [Required]
        [Range(0, int.MaxValue)]
        public int Likes { get; set; }
    }
}
