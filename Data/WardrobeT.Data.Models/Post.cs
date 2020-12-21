using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using WardrobeT.Data.Common.Models;
using WardrobeT.Data.Models;

namespace WardrobeT.Services.Data
{
    public class Post : BaseModel<string>
    {
        public Post()
        {
            this.Id = Guid.NewGuid().ToString();
        }

        [Required]
        public ApplicationUser Owner { get; set; }

        public string PostImage { get; set; }
    }
}
