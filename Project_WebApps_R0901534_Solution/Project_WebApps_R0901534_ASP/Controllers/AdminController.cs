using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Project_WebApps_R0901534_ASP.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}