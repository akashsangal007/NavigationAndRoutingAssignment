using Microsoft.AspNetCore.Mvc;

namespace NavigationAndRouting.Areas.User.Controllers
{
    public class UserController : Controller
    {
        [Area("User")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
