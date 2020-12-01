namespace WardrobeT.Web.ViewModels.Search
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    using WardrobeT.Data.Models;

    public class SearchResultViewModel
    {
        public SearchResultViewModel()
        {
            this.Users = new HashSet<User>();
        }

        public ICollection<User> Users { get; set; }

        public string Search { get; set; }
    }
}
