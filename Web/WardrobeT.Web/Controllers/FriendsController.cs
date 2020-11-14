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
        //public FriendsService FriendsService { get; }

        public FriendsController()
        {
            //FriendsService = friendsService;
        }

        public IActionResult FriendRequests()
        {
            //var FriendRequests = FriendsService.GetAllRequsetsForUser(User);
            return View();
        }

        public IActionResult MyFriends()
        {
            return View();
        }

        public IActionResult FindFrind()
        {
            return View();
        }
    }
}
