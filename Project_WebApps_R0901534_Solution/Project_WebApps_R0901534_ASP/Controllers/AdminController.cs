using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Project_WebApps_R0901534_ASP.Areas.Identity;
using Project_WebApps_R0901534_ASP.ViewModels;
using Microsoft.Extensions.Logging;
using Project_WebApps_R0901534_ASP.Data;
using Project_WebApps_R0901534_ASP.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.AspNetCore.Components.Server.Circuits;
using Circuit = Project_WebApps_R0901534_ASP.Models.Circuit;
using System.Numerics;
using Microsoft.AspNetCore.Hosting;
using System.Collections.Generic;
using System.IO;
using Microsoft.AspNetCore.Http;

namespace Project_WebApps_R0901534_ASP.Controllers
{
    public class AdminController : Controller
    {
        #region Attributes

        private UserManager<Gebruiker> _userManager;
        private RoleManager<IdentityRole> _roleManager;
        private readonly ILogger<AdminController> _logger;
        private readonly ForzaContext _ctx;
        private IWebHostEnvironment _environment;

        #endregion

        public AdminController(UserManager<Gebruiker> userManager, RoleManager<IdentityRole> roleManager, ILogger<AdminController> logger, ForzaContext ctx, IWebHostEnvironment environment)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _logger = logger;
            _ctx = ctx;
            _environment = environment;
        }

        #region RollenBeheer

        public IActionResult RollenBeheer()
        {
            RollenBeheerViewModel vm = new RollenBeheerViewModel()
            {
                Gebruikers = new SelectList(_userManager.Users.ToList(), "Id", "UserName"),
                Rollen = new SelectList(_roleManager.Roles.ToList(), "Id", "Name")
            };
            return View(vm);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> RollenBeheer(RollenBeheerViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                Gebruiker user = await _userManager.FindByIdAsync(viewModel.Id);
                IdentityRole role = await _roleManager.FindByIdAsync(viewModel.RolId);
                if (user != null && role != null)
                {
                    IdentityResult result = await _userManager.AddToRoleAsync(user, role.Name);
                    if (result.Succeeded)
                        return RedirectToAction("RollenBeheer");
                        
                    else
                    {
                        foreach (IdentityError error in result.Errors)
                            ModelState.AddModelError("", error.Description);
                    }
                }
                else
                    ModelState.AddModelError("", "Gebruiker of rol niet gevonden");
            }
            return View(viewModel);
        }

        #endregion

        #region Index
        public IActionResult Index()
        {
            GebruikersListViewModel viewModel = new GebruikersListViewModel();
            {
                viewModel.Gebruikers = _userManager.Users.ToList();
            };
            return View(viewModel);
        }

        #endregion

        #region Create gebruiker

        //public async Task<IActionResult> CreateGebruiker(CreateGebruikerViewModel viewModel)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        Gebruiker gebruiker = new Gebruiker() { };

        //        IdentityResult res = await _userManager.CreateAsync(gebruiker);
        //        if (res.Succeeded) return RedirectToAction("Index");
        //        else
        //        {
        //            foreach (IdentityError error in res.Errors)
        //                ModelState.AddModelError("", error.Description);
        //        }
        //    }
        //    return View(viewModel);
        //}

        #endregion

        #region Gebruiker details
        public IActionResult GebruikerDetails(string id)
        {
            Gebruiker gebruiker = _userManager.Users.Where(g => g.Id == id).FirstOrDefault();
            if (gebruiker != null)
            {
                GebruikerDetailsViewModel viewModel = new GebruikerDetailsViewModel() 
                {
                    Nickname = gebruiker.Nickname,
                    Email = gebruiker.Emailadres
                };
                return View(viewModel);
            }
            else
            {
                GebruikersListViewModel viewModel = new GebruikersListViewModel()
                {
                    Gebruikers = _userManager.Users.ToList()
                };
                return View("Index", viewModel);
            }
        }

        #endregion

        #region Verwijder gebruiker
        public async Task<IActionResult> VerwijderGebruiker(string id)
        {
            Gebruiker user = await _userManager.FindByIdAsync(id);
            if (user != null)
            {
                IdentityResult result = await _userManager.DeleteAsync(user);
                if (result.Succeeded)
                    return RedirectToAction("Index");
                else
                    foreach (IdentityError error in result.Errors)
                        ModelState.AddModelError("", error.Description);
            }
            else
                ModelState.AddModelError("", "User Not Found");
            return View("Index", _userManager.Users.ToList());
        }

        #endregion

        #region Edit OverMij
        public async Task<IActionResult> AdminOverMij(int? id)
        {
            if (id == null) return NotFound();

            var overMij = await _ctx.OverMijs.FindAsync(id);

            if (overMij == null) return NotFound();

            UpdateOverMijViewModel vm = new UpdateOverMijViewModel()
            {
                OverMijId = overMij.OverMijId,
                TitelAppInfo = overMij.TitelAppInfo,
                TekstAppInfo = overMij.TekstAppInfo,
                TitelPersInfo = overMij.TitelPersInfo,
                TekstPersInfo = overMij.TekstPersInfo,
                Afbeelding1 = overMij.Afbeelding1,
                Afbeelding2 = overMij.Afbeelding2
            };

            return View(vm);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> UpdateOverMij(int id, UpdateOverMijViewModel overMijViewModel)
        {
            if (id != overMijViewModel.OverMijId) return NotFound();

            if (ModelState.IsValid)
            {
                try
                {
                    OverMij overMij = new OverMij()
                    {
                        OverMijId = overMijViewModel.OverMijId,
                        TitelAppInfo = overMijViewModel.TitelAppInfo,
                        TekstAppInfo = overMijViewModel.TekstAppInfo,
                        TitelPersInfo = overMijViewModel.TitelPersInfo,
                        TekstPersInfo = overMijViewModel.TekstPersInfo,
                        Afbeelding1 = overMijViewModel.Afbeelding1,
                        Afbeelding2 = overMijViewModel.Afbeelding2
                    };
                    _ctx.Update(overMij);
                    await _ctx.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!_ctx.OverMijs.Any(o => o.OverMijId == overMijViewModel.OverMijId))
                        return NotFound();
                    else 
                        throw;
                }
                return RedirectToAction("Index");
            }
            return View(overMijViewModel);
        }

        #endregion

        #region Circuits
        public IActionResult Circuit()
        {
            CircuitListViewModel viewModel = new CircuitListViewModel();
            {
                viewModel.Circuits = _ctx.Circuits.ToList();
            };
            return View(viewModel);
        }

        public IActionResult CircuitDetails(int id)
        {
            Circuit circuit = _ctx.Circuits.Where(c => c.CircuitId == id).FirstOrDefault();
            if (circuit != null)
            {
                CircuitDetailViewModel viewModel = new CircuitDetailViewModel()
                {
                    Naam = circuit.Naam,
                    Afbeelding = circuit.Afbeelding,
                    CircuitId = id
                };
                return View(viewModel);
            }
            else
            {
                CircuitListViewModel viewModel = new CircuitListViewModel()
                {
                    Circuits = _ctx.Circuits.ToList()
                };
                return View("Circuit", viewModel);
            }
        }

        public IActionResult CircuitToevoegen()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> CircuitToevoegen(CreateCircuitViewModel viewModel, IFormFile postedFile)
        {
            string path = Path.Combine(this._environment.WebRootPath, "circuits");
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            string fileName = string.Empty;

            if (postedFile.Length > 0)
            {
                fileName = Path.GetFileName(postedFile.FileName);

                using (var stream = new FileStream(Path.Combine(path, fileName), FileMode.Create))
                {
                    stream.Position = 0;
                    await postedFile.CopyToAsync(stream);
                }
            }

            if (ModelState.IsValid)
            {
                _ctx.Add(new Circuit()
                {
                    Naam = viewModel.Naam,
                    Afbeelding = viewModel.Naam + System.IO.Path.GetExtension(fileName)
                }) ;
                await _ctx.SaveChangesAsync();
                return RedirectToAction("Circuit");
            }
            return View(viewModel);
        }

        public async Task<IActionResult> CircuitAanpassen(int? id)
        {
            if (id == null)
                return NotFound();

            var circuit = await _ctx.Circuits.FindAsync(id);

            if (circuit == null)
                return NotFound();

            EditCircuitViewModel viewModel = new EditCircuitViewModel()
            {
                CircuitId = circuit.CircuitId,
                Naam = circuit.Naam,
                Afbeelding = circuit.Afbeelding
            };

            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CircuitAanpassen(int id, EditCircuitViewModel viewModel)
        {
            if (id != viewModel.CircuitId)
                return NotFound();

            if (ModelState.IsValid)
            {
                try
                {
                    Circuit circuit = new Circuit()
                    {
                        CircuitId= viewModel.CircuitId,
                        Naam= viewModel.Naam,   
                        Afbeelding = viewModel.Afbeelding
                    };
                    _ctx.Update(circuit);
                    await _ctx.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!_ctx.Circuits.Any(c => c.CircuitId == viewModel.CircuitId))
                        return NotFound();
                    else
                        throw;
                }
                return RedirectToAction(nameof(Circuit));
            }
            return View(viewModel);
        }

        public async Task<IActionResult> VerwijderCircuit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var circuit = await _ctx.Circuits.FindAsync(id);
            if (circuit == null)
                return NotFound();

            DeleteCircuitViewModel viewModel = new DeleteCircuitViewModel()
            {
                CircuitId = circuit.CircuitId,
                Naam = circuit.Naam,
                Afbeelding=circuit.Afbeelding
            };
            return View(viewModel);
        }

        [HttpPost, ActionName("VerwijderCircuit")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> VerwijderCircuit(int id)
        {
            var circuit = await _ctx.Circuits.FindAsync(id);
            _ctx.Circuits.Remove(circuit);
            await _ctx.SaveChangesAsync();
            return RedirectToAction(nameof(Circuit));
        }

        #endregion
    }
}