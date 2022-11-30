using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Project_WebApps_R0901534_ASP.Data;
using Project_WebApps_R0901534_ASP.Models;
using Project_WebApps_R0901534_ASP.ViewModels;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

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
            circuitListViewModel.Circuits = tracks.OrderBy(c => c.Naam).ToList();

            return View(circuitListViewModel);
        }

        #region leaderboards tonen

        public IActionResult Detail(int id)
        {
            List<Laptime> laptimes = _ctx.Laptimes
                .Include(c => c.Circuit).Where(c => c.CircuitId == id)
                .ToList();

            Circuit circuit = _ctx.Circuits.Where(c => c.CircuitId == id).FirstOrDefault();
            laptimes = _ctx.Laptimes.Include(l => l.AutoKlasse).ToList();
            laptimes = _ctx.Laptimes.Include(l => l.AutoKlasse.Klasse).ToList();
            laptimes = _ctx.Laptimes.Include(l => l.AutoKlasse.GebruikerAuto).ToList();
            laptimes = _ctx.Laptimes.Include(l => l.AutoKlasse.GebruikerAuto.Gebruiker).ToList();
            laptimes = _ctx.Laptimes.Include(l => l.AutoKlasse.GebruikerAuto.Auto).ToList();
            laptimes = _ctx.Laptimes.Include(l => l.AutoKlasse.GebruikerAuto.Auto.Model).ToList();
            laptimes = _ctx.Laptimes.Include(l => l.AutoKlasse.GebruikerAuto.Auto.Model.Merk).ToList();
            laptimes = _ctx.Laptimes.Where(l => l.CircuitId == id).ToList();

            if (circuit == null)
                return RedirectToAction("Index");
            else
            {
                LaptimeListViewModel vm = new LaptimeListViewModel()
                {
                    Laptimes = laptimes,
                    Circuit = circuit
                };
                return View(vm);
            }
        }

        #endregion

        public async Task<IActionResult> CircuitToevoegen(CreateCircuitViewModel viewModel)
        {
           

            if (ModelState.IsValid)
            {
                _ctx.Add(new Circuit()
                {
                    Naam = viewModel.Naam,
                });
                await _ctx.SaveChangesAsync();
                return RedirectToAction("Circuit");
            }
            return View(viewModel);
        }
    }
}