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
            this.Likes = new List<ApplicationUser>();
        }

        [Required]
        public Wear Wear { get; set; }

        [Required]
        public List<ApplicationUser> Likes { get; set; }
    }
}
