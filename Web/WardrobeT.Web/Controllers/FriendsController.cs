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
        public IActionResult Followers()
        {
            return this.View();
        }

        public IActionResult Following()
        {
            return this.View();
        }

        public IActionResult MyFriends()
        {
            return this.View();
        }

        public IActionResult FindFrind()
        {
            return this.View();
        }
    }
}
