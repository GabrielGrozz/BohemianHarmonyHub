using Microsoft.AspNetCore.Mvc;

namespace BohemianHarmonyHub.Controllers
{
    public class BandsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
