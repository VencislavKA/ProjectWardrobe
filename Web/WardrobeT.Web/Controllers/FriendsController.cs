using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WardrobeT.Web.Controllers
{
    public class FriendsController : Controller
    {
        public async Task<IActionResult> Followers()
        {
            return this.View();
        }

        public async Task<IActionResult> Following()
        {
            return this.View();
        }

        public async Task<IActionResult> MyFriends()
        {
            return this.View();
        }

        public async Task<IActionResult> FindFrind()
        {
            return this.View();
        }
    }
}
