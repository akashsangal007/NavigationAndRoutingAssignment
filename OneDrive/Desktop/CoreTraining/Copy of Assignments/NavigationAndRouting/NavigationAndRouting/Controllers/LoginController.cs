using Microsoft.AspNetCore.Mvc;
using NavigationAndRouting.Models;
using NuGet.Protocol.Plugins;

namespace NavigationAndRouting.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
      
       

        [HttpPost]
        public IActionResult Index(LoginViewModel login)
        {
            if (ModelState.IsValid)
            {
                if (login.userName == "user@gmail.com" && login.password == "12345678")
                {
                    return RedirectToAction("Index", "User", new { area = "User" });
                }
                else if (login.userName == "admin@gmail.com" && login.password == "12345678")
                {
                    return RedirectToAction("Index", "Admin", new { area = "Admin" });
                }
            }

            return RedirectToAction("Index", "Home");
        }
    }
}
