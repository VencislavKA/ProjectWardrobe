namespace WardrobeT.Services.Data
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Security.Cryptography.X509Certificates;
    using System.Text;
    using System.Threading.Tasks;

    using Microsoft.EntityFrameworkCore;
    using WardrobeT.Data;
    using WardrobeT.Data.Common.Repositories;
    using WardrobeT.Data.Models;
    using WardrobeT.Web.ViewModels.Search;

    public class FollowersService : IFollowersService
    {
        public FollowersService(IRepository<Followers> followersReporsitory, IRepository<ApplicationUser> usersRepository)
        {
            this.FollowersReporsitory = followersReporsitory;
            this.UsersRepository = usersRepository;
        }

        public IRepository<ApplicationUser> UsersRepository { get; }

        private IRepository<Followers> FollowersReporsitory { get; }

        public async Task<ICollection<User>> GetFollowersAsync(string username)
        {
            List<ApplicationUser> profiles = await this.FollowersReporsitory.All().Where(x => x.Followed.UserName == username)
                .Select(x => x.User).ToListAsync();
            List<User> result = new List<User>();

            foreach (var user in profiles)
            {
                if (await this.FollowersReporsitory.All().Where(x => x.User.UserName == username &&
                        x.Followed.UserName == user.UserName).FirstOrDefaultAsync() == null)
                {
                    result.Add(new User
                    {
                        Id = user.Id,
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
                        Id = user.Id,
                        ProfilePictureUrl = user.ProfilePicture,
                        ProfileId = user.Id,
                        Profile = user.UserName,
                        IsFollowed = true,
                    });
                }
            }

            return result;
        }

        public async Task<ICollection<User>> GetFollowingAsync(string username)
        {
            List<ApplicationUser> profiles = await this.FollowersReporsitory.All()
                .Where(x => x.User.UserName == username).Select(x => x.Followed).ToListAsync();
            List<User> result = new List<User>();

            foreach (var user in profiles)
            {
                if (await this.FollowersReporsitory.All().Where(x => x.User.UserName == username &&
                        x.Followed.UserName == user.UserName).FirstOrDefaultAsync() == null)
                {
                    result.Add(new User
                    {
                        Id = user.Id,
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
                        Id = user.Id,
                        ProfilePictureUrl = user.ProfilePicture,
                        ProfileId = user.Id,
                        Profile = user.UserName,
                        IsFollowed = true,
                    });
                }
            }

            return result;
        }

        public async Task<string> FollowAsync(string username, string followId)
        {
            var user = await this.UsersRepository.All().Where(x => x.UserName == username).FirstOrDefaultAsync();
            if (this.UsersRepository.All().Where(x => x.Id == followId) == null)
            {
                return null;
            }

            var follow = await this.UsersRepository.All().Where(x => x.Id == followId).FirstOrDefaultAsync();
            if (followId != user.Id && !this.FollowersReporsitory.All().Any(x => x.User.Id == user.Id && x.Followed.Id == follow.Id))
            {
                Followers followers = new Followers
                {
                    User = user,
                    Followed = follow,
                };
                await this.FollowersReporsitory.AddAsync(followers);
                await this.FollowersReporsitory.SaveChangesAsync();
                return string.Empty;
            }

            return null;
        }

        public async Task<string> UnfollowAsync(string username, string unfollowId)
        {
            var user = await this.UsersRepository.All().Where(x => x.UserName == username).FirstOrDefaultAsync();
            if (this.UsersRepository.All().Where(x => x.Id == unfollowId) == null)
            {
                return null;
            }

            var unfollow = await this.UsersRepository.All().Where(x => x.Id == unfollowId).FirstOrDefaultAsync();
            if (unfollowId != user.Id && this.FollowersReporsitory.All().Any(x => x.User.Id == user.Id && x.Followed.Id == unfollow.Id))
            {
                var followEntity = await this.FollowersReporsitory.All().FirstOrDefaultAsync(x => x.User == user && x.Followed == unfollow);
                this.FollowersReporsitory.Delete(followEntity);
                await this.FollowersReporsitory.SaveChangesAsync();
                return string.Empty;
            }

            return null;
        }
    }
}
