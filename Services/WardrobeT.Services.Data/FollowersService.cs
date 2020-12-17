using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using WardrobeT.Data.Models;
using WardrobeT.Data;
using WardrobeT.Data.Common.Repositories;
using System.Threading.Tasks;
using WardrobeT.Web.ViewModels.Search;
using System.Linq;

namespace WardrobeT.Services.Data
{
    public class FollowersService : IFollowersService
    {
        private IRepository<Followers> FollowersReporsitory { get; }

        public FollowersService(IRepository<Followers> followersReporsitory)
        {
            FollowersReporsitory = followersReporsitory;
        }

        public async Task<ICollection<User>> GetFollowersAsync(string Username)
        {
            List<ApplicationUser> profiles = await this.FollowersReporsitory.All().Where(x => x.Followed.UserName == Username)
                .Select(x => x.User).ToListAsync();
            List<User> result = new List<User>();
            foreach (var user in profiles)
            {
                if (await this.FollowersReporsitory.All().Where(x => x.User.UserName == Username && x.Followed.UserName == user.UserName).FirstOrDefaultAsync() == null)
                {
                    result.Add(new User
                    {
                        ProfilePictureUrl = user.ProfilePicture,
                        ProfileId = user.Id,
                        Profile = user.UserName,
                        IsFollowed = false,
                    });
                }
                else
                {
                    result.Add(new User
                    {
                        ProfilePictureUrl = user.ProfilePicture,
                        ProfileId = user.Id,
                        Profile = user.UserName,
                        IsFollowed = true,
                    });
                }
            }

            return result;
        }

        public async Task<ICollection<User>> GetFollowingAsync(string Username)
        {
            throw new NotImplementedException();
        }
    }
}
