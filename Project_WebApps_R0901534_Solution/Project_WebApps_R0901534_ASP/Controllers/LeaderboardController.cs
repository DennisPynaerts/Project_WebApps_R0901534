using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.Extensions.Logging;
using Project_WebApps_R0901534_ASP.Areas.Identity;
using Project_WebApps_R0901534_ASP.Data;
using Project_WebApps_R0901534_ASP.Models;
using Project_WebApps_R0901534_ASP.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Threading.Tasks;

namespace Project_WebApps_R0901534_ASP.Controllers
{
    public class LeaderboardController : Controller
    {
        private readonly ILogger<LeaderboardController> _logger;
        private readonly ForzaContext _ctx;
        private UserManager<Gebruiker> _userManager;

        public LeaderboardController(ILogger<LeaderboardController> logger, ForzaContext ctx, UserManager<Gebruiker> userManager)
        {
            _logger = logger;
            _ctx = ctx;
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            var tracks = _ctx.Circuits;

            CircuitListViewModel circuitListViewModel = new CircuitListViewModel();
            circuitListViewModel.Circuits = tracks.OrderBy(c => c.Naam).ToList();

            return View(circuitListViewModel);
        }

        #region leaderboards tonen

        [HttpGet]
        public IActionResult Detail(int id, LaptimeListViewModel viewModel)
        {
            string userName = User.Identity.Name;

            Circuit circuit = _ctx.Circuits.Where(c => c.CircuitId == id).FirstOrDefault();

            List<Laptime> laptimes = _ctx.Laptimes.Include(l => l.AutoKlasse).ToList();
            laptimes = _ctx.Laptimes.Include(l => l.AutoKlasse.Klasse).ToList();
            laptimes = _ctx.Laptimes.Include(l => l.AutoKlasse.GebruikerAuto).ToList();
            laptimes = _ctx.Laptimes.Include(l => l.AutoKlasse.GebruikerAuto.Gebruiker).ToList();
            laptimes = _ctx.Laptimes.Include(l => l.AutoKlasse.GebruikerAuto.Auto).ThenInclude(l => l.Model).ThenInclude(l => l.Merk).ToList();
            laptimes = _ctx.Laptimes.Where(l => l.CircuitId == id).OrderBy(x => x.Rondetijd).ToList();

            List<GebruikerAuto> gebruikerAutos = _ctx.GebruikerAutos.Include(x => x.Auto)
                .ThenInclude(x => x.Model)
                .ThenInclude(x => x.Merk)
                .Include(x => x.Gebruiker)
                .Where(x => x.Gebruiker.UserName == userName)
               .ToList();

            viewModel.GebruikerAutos = new List<SelectListItem>();
            foreach (var auto in gebruikerAutos)
            {
                if (auto.Auto != null)
                {
                    viewModel.GebruikerAutos.Add(new SelectListItem() { Text = auto.Auto.Model.Merk.Naam + " " + auto.Auto.Model.Naam, Value = auto.GebruikerAutoId.ToString(), Selected = false });
                }                
            }

            if (circuit == null)
                return RedirectToAction("Index");
            else
            {
                LaptimeListViewModel vm = new LaptimeListViewModel()
                {
                    Laptimes = laptimes,
                    Circuit = circuit,
                    GebruikerAutos = viewModel.GebruikerAutos
                };
                return View(vm);
            }
        }

        #endregion

        public async Task<IActionResult> CircuitToevoegen(CreateCircuitViewModel viewModel, int id)
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

        #region voeg rondetijd toe
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> LaptimeToevoegen(LaptimeListViewModel viewModel)
        {
            if (ModelState.IsValid && ValidateLaptime(viewModel.Rondetijd))
            {
                GebruikerAuto gebruikerAuto = _ctx.GebruikerAutos
                    .Include(auto => auto.Auto).ThenInclude(automodel => automodel.Model)
                    .ThenInclude(automerk => automerk.Merk)
                    .Where(auto => auto.GebruikerAutoId == viewModel.GebruikerAutoId).FirstOrDefault();

                _ctx.Add(new AutoKlasse()
                {
                    GebruikerAutoId = gebruikerAuto.GebruikerAutoId,
                    KlasseId = AutoKlasseBepalen(gebruikerAuto)
                });
                _ctx.SaveChanges();

                _ctx.Add(new Laptime()
                {
                    CircuitId = viewModel.CircuitId,
                    Datum = DateTime.Now,
                    Rondetijd = viewModel.Rondetijd,
                    AutoKlasseId = _ctx.AutoKlasses.OrderByDescending(a => a.AutoKlasseId).FirstOrDefault().AutoKlasseId
                }) ;
                await _ctx.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            else return RedirectToAction("Index");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> LaptimeMetAutoToevoegen(LaptimeListViewModel viewModel)
        {
            if (ModelState.IsValid && ValidateLaptime(viewModel.Rondetijd) && viewModel.PI > 0)
            {
                MerkEnModelToevoegen(viewModel);

                #region comments

                // Minder controle op model gezien de PI kan (maar niet moet) verschillen en uitbreidbaarheid mogelijk te houden
                // Bijvoorbeeld, tekstveld voor handling erbij, als er 2 Ford Mustangs zijn met een verschillende handling en eenzelfde PI, dan zijn dit 2 verschillende modellen
                // ondanks de PI hetzelfde is, hetzelfde geld voor PK
                // Handling en PK niet inbegrepen omdat tabel anders veel te breed wordt om te tonen op kleine schermen

                // Nakijken of de gebruiker al eenzelfde model in zijn verzameling van modellen heeft, met een vergelijking van de PI van de auto
                // Als deze lijst leeg is, wordt het modelId van het laatst aangemaakte model genomen, anders wordt het modelId van het 1e element van de lijst genomen
                // Het is een lijst voor uitbreidbaarheid, moesten er in de toekomst extra properties bijkomen, kan het zijn dat er meer gefilterd moet kunnen worden

                #endregion

                List<GebruikerAuto> bestaatModel = _ctx.GebruikerAutos.Include(ga => ga.Gebruiker)
                    .Where(model => model.Auto.Model.Naam == viewModel.Modelnaam && model.Auto.TotalePI != viewModel.PI && model.Gebruiker.UserName == User.Identity.Name)
                    .ToList();

                if (!bestaatModel.Any())
                {
                    _ctx.Add(new Auto()
                    {
                        TotalePI = viewModel.PI,
                        ModelId = _ctx.Models.OrderByDescending(model => model.ModelId).FirstOrDefault().ModelId
                    });
                }
                else
                {
                    _ctx.Add(new Auto()
                    {
                        TotalePI = viewModel.PI,
                        ModelId = bestaatModel[0].Auto.ModelId
                    });                    
                }
                _ctx.SaveChanges();

                GebruikerAuto gebruikerAuto = new GebruikerAuto()
                {
                    GebruikerId = _ctx.Gebruikers.Where(x => x.UserName == User.Identity.Name).SingleOrDefault().Id,
                    AutoId = _ctx.Autos.OrderByDescending(auto => auto.AutoId).FirstOrDefault().AutoId
                };

                _ctx.Add(gebruikerAuto);
                _ctx.SaveChanges();

                _ctx.Add(new AutoKlasse()
                {
                    GebruikerAutoId = gebruikerAuto.GebruikerAutoId,
                    KlasseId = AutoKlasseBepalen(gebruikerAuto)
                });
                _ctx.SaveChanges();

                _ctx.Add(new Laptime()
                {
                    CircuitId = viewModel.CircuitId,
                    Datum = DateTime.Now,
                    Rondetijd = viewModel.Rondetijd,
                    AutoKlasseId = _ctx.AutoKlasses.OrderByDescending(a => a.AutoKlasseId).FirstOrDefault().AutoKlasseId
                });
                await _ctx.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
        }

        #endregion

        #region Extra methodes
        private void MerkEnModelToevoegen(LaptimeListViewModel vm)
        {
            // Zoeken of het merk al bestaat, zo ja, ID nemen en aan model toevoegen

            List<GebruikerAuto> bestaatMerk = _ctx.GebruikerAutos
                .Include(ga => ga.Auto)
                .ThenInclude(ga => ga.Model)
                .ThenInclude(ga => ga.Merk)
                .Where(merk => merk.Auto.Model.Merk.Naam.ToLower() == vm.Merknaam.ToLower())
                .ToList();

            if (bestaatMerk.Count == 0)
            {
                _ctx.Add(new Merk()
                {
                    Naam = vm.Merknaam
                });
                _ctx.SaveChanges();
                _ctx.Add(new Model()
                {
                    Naam = vm.Modelnaam,
                    MerkId = _ctx.Merken.OrderByDescending(merk => merk.MerkId).FirstOrDefault().MerkId
                });
                _ctx.SaveChanges();
            }
            else
            {
                _ctx.Add(new Model()
                {
                    Naam = vm.Modelnaam,
                    MerkId = bestaatMerk[0].Auto.Model.Merk.MerkId
                });
                _ctx.SaveChanges();
            }
        }
        
        private bool ValidateLaptime(string rondetijd)
        {
            if (!string.IsNullOrWhiteSpace(rondetijd))
            {
                if (rondetijd.Length == 9)
                {
                    string laptime = rondetijd;
                    string minutes = laptime.Substring(0, 2);
                    string seconds = laptime.Substring(3, 2);
                    string milliseconds = laptime.Substring(6, 3);

                    if (laptime[2] == '.' && laptime[5] == '.')
                    {
                        if (int.TryParse(minutes, out _) && int.TryParse(seconds, out _) && int.TryParse(milliseconds, out _))
                            return true;
                    }
                }                
            }
            return false;
        }

        private int AutoKlasseBepalen(GebruikerAuto auto)
        {
            if (auto.Auto.TotalePI <= 300)
                return 1;
            else if (auto.Auto.TotalePI <= 400)
                return 2;
            else if (auto.Auto.TotalePI <= 500)
                return 3;
            else if (auto.Auto.TotalePI <= 600)
                return 4;
            else if (auto.Auto.TotalePI <= 700)
                return 5;
            else if (auto.Auto.TotalePI <= 800)
                return 6;
            else if (auto.Auto.TotalePI <= 900)
                return 7;
            else if (auto.Auto.TotalePI <= 990)
                return 8;
            else if (auto.Auto.TotalePI > 990)
                return 9;

            return 0;
        }

        #endregion
    }
}