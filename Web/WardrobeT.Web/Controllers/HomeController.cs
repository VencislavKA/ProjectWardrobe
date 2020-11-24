namespace WardrobeT.Web.Controllers
{
    using System.Diagnostics;

    using WardrobeT.Web.ViewModels;

    using Microsoft.AspNetCore.Mvc;
    using System.Threading.Tasks;

    public class HomeController : BaseController
    {
        public async Task<IActionResult> Index()
        {
            return this.View();
        }

        public async Task<IActionResult> Privacy()
        {
            return this.View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public async Task<IActionResult> Error()
        {
            return this.View(
                new ErrorViewModel { RequestId = Activity.Current?.Id ?? this.HttpContext.TraceIdentifier });
        }
    }
}
