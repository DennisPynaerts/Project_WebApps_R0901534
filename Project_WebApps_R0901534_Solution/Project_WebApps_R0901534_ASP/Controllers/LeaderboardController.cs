using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Project_WebApps_R0901534_ASP.Data;
using Project_WebApps_R0901534_ASP.Models;
using Project_WebApps_R0901534_ASP.ViewModels;
using System.Linq;

namespace Project_WebApps_R0901534_ASP.Controllers
{
    public class LeaderboardController : Controller
    {
        private readonly ILogger<LeaderboardController> _logger;
        private readonly ForzaContext _ctx;

        public LeaderboardController(ILogger<LeaderboardController> logger, ForzaContext ctx)
        {
            _logger = logger;
            _ctx = ctx;
        }

        public IActionResult Index()
        {
            var tracks = _ctx.Circuits;

            CircuitListViewModel circuitListViewModel = new CircuitListViewModel();
            circuitListViewModel.Circuits = tracks.ToList();

            return View(circuitListViewModel);
        }
        public IActionResult Detail(int id)
        {
            Circuit circuit = _ctx.Circuits.Where(c => c.CircuitId == id).FirstOrDefault();
            if (circuit == null)
                return RedirectToAction("Index");
            else
            {
                CircuitDetailViewModel circuitDetailViewModel = new CircuitDetailViewModel()
                {
                    Naam = circuit.Naam
                };
                return View(circuitDetailViewModel);
            }            
        }
    }
}