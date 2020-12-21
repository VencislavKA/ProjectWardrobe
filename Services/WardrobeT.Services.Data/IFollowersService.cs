namespace WardrobeT.Services.Data
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using WardrobeT.Data.Models;
    using WardrobeT.Web.ViewModels.Search;

    public interface IFollowersService
    {
        public Task<ICollection<User>> GetFollowersAsync(string username);

        public Task<ICollection<User>> GetFollowingAsync(string username);

        public Task<string> FollowAsync(string username, string followId);
    }
}
