using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using WardrobeT.Data.Models;
using WardrobeT.Data;

namespace WardrobeT.Services.Data
{
    public class FriendsService : IFriendsService
    {
        public FriendsService()
        {
                
        }
        public void AcceptRequest(ApplicationUser from, ApplicationUser to)
        {
            throw new NotImplementedException();
        }

        public ICollection<ApplicationUser> GetAllFriendRequests()
        {
            throw new NotImplementedException();
        }

        public ICollection<ApplicationUser> GetAllFriends()
        {
            throw new NotImplementedException();
        }

        public void RegretRequest(ApplicationUser from, ApplicationUser to)
        {
            throw new NotImplementedException();
        }
    }
}
