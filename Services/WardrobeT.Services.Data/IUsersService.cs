using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WardrobeT.Data.Models;
using WardrobeT.Web.ViewModels.Search;

namespace WardrobeT.Services.Data
{
    public interface IUsersService
    {
        public Task<ICollection<User>> SearchUsersAsync(string username, string search);

        public Task<ApplicationUser> GetUserAsync(string username);
    }
}
