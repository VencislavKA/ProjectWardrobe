using System;
using System.Collections.Generic;
using System.Text;
using WardrobeT.Data.Models;

namespace WardrobeT.Web.ViewModels.Search
{
    public class SearchResultViewModel
    {
        public SearchResultViewModel()
        {
            this.Users = new HashSet<SearchProfile>();
        }

        public ICollection<SearchProfile> Users { get; set; }

        public string Search { get; set; }
    }
}
