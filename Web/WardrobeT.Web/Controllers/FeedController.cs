namespace WardrobeT.Web.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Mvc;

    public class FeedController : BaseController
    {
        public async Task<IActionResult> Index()
        {
            return this.View();
        }
    }
}
