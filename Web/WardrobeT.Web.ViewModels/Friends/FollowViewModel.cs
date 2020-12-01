namespace WardrobeT.Web.ViewModels.Friends
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    using WardrobeT.Data.Models;
    using WardrobeT.Web.ViewModels.Search;

    public class FollowViewModel
    {
        public FollowViewModel()
        {
            this.Profiles = new HashSet<User>();
        }

        public ICollection<User> Profiles { get; set; }
    }
}
