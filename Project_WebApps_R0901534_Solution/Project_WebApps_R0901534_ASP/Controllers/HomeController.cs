using Microsoft.AspNetCore.Mvc;

namespace Project_WebApps_R0901534_ASP.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}