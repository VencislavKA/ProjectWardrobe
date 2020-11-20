using System;
using System.Collections.Generic;
using System.Text;
using WardrobeT.Data.Models;

namespace WardrobeT.Web.ViewModels.Users
{
    public class WardrobeViewModel
    {
        public ICollection<Wear> Wears { get; set; }
    }
}
