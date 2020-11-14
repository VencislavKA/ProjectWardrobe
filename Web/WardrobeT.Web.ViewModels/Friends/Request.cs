using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Wardrobe.Data;

namespace WardrobeT.Web.ViewModels.Friends
{
    public class Request
    {
        //private readonly ApplicationDbContext db;

        public Request(IdentityUser requester,IdentityUser requested)
        {
            //this.db = db;
            this.Requester = requester;
            this.Requsted = requested;
        }
        public IdentityUser Requester { get; set; }
        public IdentityUser Requsted { get; set; }
        //public void AcceptRequst()
        //{
        //    if (this.Requsted == null || this.Requester == null)
        //    {
        //        throw new InvalidOperationException();
        //    }
        //    else if (!db.Friends.Any(x => x.RequstedPerson == this.Requsted && x.FriendRequester == this.Requester))
        //    {
        //        var friends = db.Friends.FirstOrDefault(x => x.RequstedPerson == this.Requsted
        //            && x.FriendRequester == this.Requester);
        //        friends.Status = FriendRequestStatus.Accepted;
        //    }
        //    else 
        //    {
        //        throw new InvalidOperationException();
        //    }
        //}
        //public void RefuseRequest()
        //{
        //    if (this.Requsted == null || this.Requester == null)
        //    {
        //        throw new InvalidOperationException();
        //    }
        //    else if (!db.Friends.Any(x => x.RequstedPerson == this.Requsted && x.FriendRequester == this.Requester))
        //    {
        //        var friends = db.Friends.FirstOrDefault(x => x.RequstedPerson == this.Requsted
        //            && x.FriendRequester == this.Requester);
        //        friends.Status = FriendRequestStatus.Refused;
        //    }
        //    else
        //    {
        //        throw new InvalidOperationException();
        //    }
        //}
    }
}
