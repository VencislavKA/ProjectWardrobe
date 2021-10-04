namespace WardrobeT.Services.Data
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using Microsoft.EntityFrameworkCore;
    using WardrobeT.Data.Common.Repositories;
    using WardrobeT.Data.Models;
    using WardrobeT.Web.ViewModels.Search;

    public class UserService : IUsersService
    {
        public UserService(
            IRepository<ApplicationUser> repository,
            IRepository<Followers> followersRepository,
            IFollowersService followersService)
        {
            this.FollowersService = followersService;
            this.UserRepository = repository;
            this.FollowersRepository = followersRepository;
        }

        public IRepository<ApplicationUser> UserRepository { get; }

        public IRepository<Followers> FollowersRepository { get; }

        public IFollowersService FollowersService { get; set; }

        public async Task<ICollection<User>> SearchUsersAsync(string username, string search)
        {
            List<ApplicationUser> users = await this.UserRepository.All().ToListAsync();
            List<User> result = new List<User>();

            foreach (var user in users)
            {
                if (user.NormalizedUserName.Contains(search.ToUpper()) && user.UserName != username)
                {
                    if (await this.FollowersRepository.All().Where(x => x.User.UserName == username && x.Followed.UserName == user.UserName).FirstOrDefaultAsync() == null)
                    {
                        result.Add(new User
                        {
                            Id = user.Id,
                            ProfilePictureUrl = user.ProfilePicture,
                            ProfileId = user.Id,
                            Profile = user.UserName,
                            Followers = this.FollowersService.GetFollowers(user.UserName).Count,
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
                            Followers = this.FollowersService.GetFollowers(user.UserName).Count,
                            IsFollowed = true,
                        });
                    }
                }
            }

            return result;
        }

        public async Task<ApplicationUser> GetUserAsync(string username)
            => await this.UserRepository.All().FirstOrDefaultAsync(x => x.UserName == username);

        public async Task<ApplicationUser> GetUserByIdAsync(string id)
            => await this.UserRepository.All().FirstOrDefaultAsync(x => x.Id == id);
    }
}
