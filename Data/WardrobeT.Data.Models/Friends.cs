using Microsoft.AspNetCore.Identity;
using System;
using WardrobeT.Data.Common.Models;
using WardrobeT.Data.Models.Enums;

namespace WardrobeT.Data.Models
{
    public class Friends : BaseModel<string>
    {
        public Friends()
        {
            this.Id = Guid.NewGuid().ToString();
        }

        public ApplicationUser FriendRequester { get; set; }

        public ApplicationUser RequstedPerson { get; set; }

        public FriendRequestStatus Status { get; set; }
    }
}
