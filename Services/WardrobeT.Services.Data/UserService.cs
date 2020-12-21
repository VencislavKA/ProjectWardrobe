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
            IRepository<Followers> followersRepository)
        {
            this.UserRepository = repository;
            this.FollowersRepository = followersRepository;
        }

        public IRepository<ApplicationUser> UserRepository { get; }

        public IRepository<Followers> FollowersRepository { get; }

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
            }

            return result;
        }

        public async Task<ApplicationUser> GetUserAsync(string username)
            => await this.UserRepository.All().FirstOrDefaultAsync(x => x.UserName == username);

        public async Task<ApplicationUser> GetUserByIdAsync(string id)
            => await this.UserRepository.All().FirstOrDefaultAsync(x => x.Id == id);
    }
}
