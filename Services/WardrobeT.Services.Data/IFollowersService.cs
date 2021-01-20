namespace WardrobeT.Services.Data
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using WardrobeT.Data.Models;
    using WardrobeT.Web.ViewModels.Search;

    public interface IFollowersService
    {
        public ICollection<User> GetFollowers(string username);

        public ICollection<User> GetFollowing(string username);

        public Task<string> FollowAsync(string username, string followId);

        public Task<string> UnfollowAsync(string username, string unfollowId);
    }
}
