using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Text;
using WardrobeT.Data.Models;

namespace WardrobeT.Web.ViewModels.Users
{
    public class ProfileViewModel
    {
        public ProfileViewModel()
        {
            this.Wears = new HashSet<Wear>();
            this.Followers = new HashSet<Followers>();
            this.Following = new HashSet<Followers>();
        }
        public string ProfilePicUrl { get; set; }

        public string Username { get; set; }

        public string Email { get; set; }

        public ICollection<Wear> Wears { get; set; }

        public ICollection<Followers> Followers { get; set; }

        public ICollection<Followers> Following { get; set; }
    }
}
