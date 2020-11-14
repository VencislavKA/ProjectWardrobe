namespace WardrobeT.Services.Data
{
    using System.Collections.Generic;

    using WardrobeT.Data.Models;

    public interface IFriendsService
    {
        public ICollection<ApplicationUser> GetAllFriends();

        public ICollection<ApplicationUser> GetAllFriendRequests();

        public void AcceptRequest(ApplicationUser from, ApplicationUser to);

        public void RegretRequest(ApplicationUser from, ApplicationUser to);
    }
}
