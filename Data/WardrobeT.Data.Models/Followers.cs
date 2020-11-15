namespace WardrobeT.Data.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    using Microsoft.AspNetCore.Identity;
    using WardrobeT.Data.Common.Models;
    using WardrobeT.Data.Models.Enums;

    public class Followers : BaseModel<string>
    {
        public Followers()
        {
            this.Id = Guid.NewGuid().ToString();
        }

        [Required]
        public ApplicationUser User { get; set; }

        [Required]
        public ApplicationUser Followerd { get; set; }
    }
}
