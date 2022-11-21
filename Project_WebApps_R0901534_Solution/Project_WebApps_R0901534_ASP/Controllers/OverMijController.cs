using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Project_WebApps_R0901534_ASP.Data;
using Project_WebApps_R0901534_ASP.Models;
using Project_WebApps_R0901534_ASP.ViewModels;
using System.Linq;

namespace Project_WebApps_R0901534_ASP.Controllers
{
    public class OverMijController : Controller
    {
        private readonly ILogger<LeaderboardController> _logger;
        private readonly ForzaContext _ctx;

        public OverMijController(ILogger<LeaderboardController> logger, ForzaContext ctx)
        {
            _logger = logger;
            _ctx = ctx;
        }

        public IActionResult Index(int id = 1)
        {
            OverMij overMij = _ctx.OverMijs.Where(o => o.OverMijId == id).FirstOrDefault();
            if (overMij == null)
                return RedirectToAction("Index");
            else
            {
                OverMijDetailViewModel overMijDetailViewModel = new OverMijDetailViewModel()
                {
                    OverMijId = id,
                    Afbeelding1 = overMij.Afbeelding1,
                    Afbeelding2 = overMij.Afbeelding2,
                    TekstAppInfo = overMij.TekstAppInfo,
                    TitelAppInfo = overMij.TitelAppInfo,
                    TekstPersInfo = overMij.TekstPersInfo,
                    TitelPersInfo = overMij.TitelPersInfo
                };
                return View(overMijDetailViewModel);
            }
        }
    }
}