using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace WardrobeT.Web.ViewModels.Outfits
{
    public class AddManualInputModel
    {
        [Required]
        public string Top { get; set; }

        [Required]
        public string Middle { get; set; }

        [Required]
        public string Bottom { get; set; }
    }
}
