using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WardrobeT.Web.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Profile()
        {
            return View();
        }
        public IActionResult Outfits()
        {
            return View();
        }
        public IActionResult Wardrobe()
        {
            return View();
        }
    }
}
