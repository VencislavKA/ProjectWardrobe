using Microsoft.AspNetCore.Identity;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace WardrobeT.Web.ViewModels.Friends
{ 
    public class FriendRequestViewModel
    {
        public FriendRequestViewModel()
        {
            this.Request = new HashSet<IdentityUser>();
        }
        public int RequestCount { get { return Request.Count(); } }
        public HashSet<IdentityUser> Request { get; set; }
    }
}
