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
        }
        public string ProfilePicUrl { get; set; }

        public string Username { get; set; }

        public string Email { get; set; }

        public ICollection<Wear> Wears { get; set; }

        public int Followers { get; set; }

        public int Following { get; set; }
    }
}
