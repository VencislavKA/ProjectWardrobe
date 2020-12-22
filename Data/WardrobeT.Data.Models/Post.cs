namespace WardrobeT.Services.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Text;

    using WardrobeT.Data.Common.Models;
    using WardrobeT.Data.Models;

    public class Post : BaseModel<string>
    {
        public Post()
        {
            this.Id = Guid.NewGuid().ToString();
        }

        [Required]
        public ApplicationUser Owner { get; set; }

        [Required]
        public string PostImage { get; set; }

        [Required]
        [Range(0, int.MaxValue)]
        public int Likes { get; set; }
    }
}
