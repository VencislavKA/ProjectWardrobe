using System;
using System.Collections.Generic;
using System.Text;
using WardrobeT.Data.Models;

namespace WardrobeT.Web.ViewModels.Home
{
    class SearchResultViewModel
    {
        public SearchResultViewModel()
        {
            this.ResultUsers = new HashSet<ApplicationUser>();
        }

        public ICollection<ApplicationUser> ResultUsers { get; set; }
    }
}
