using Microsoft.AspNetCore.Mvc;

namespace NavigationAndRouting.Controllers
{
    public class LogoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
