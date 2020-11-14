using Microsoft.AspNetCore.Identity;
using System;
using WardrobeT.Data.Models.Enums;

namespace WardrobeT.Data.Models
{
    public class Friends
    {
        public Friends()
        {
            this.Id = Guid.NewGuid().ToString();
        }

        public string Id { get; set; }

        public IdentityUser FriendRequester { get; set; }

        public IdentityUser RequstedPerson { get; set; }

        public FriendRequestStatus Status { get; set; }
    }
}
