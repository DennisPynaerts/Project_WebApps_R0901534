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

namespace Project_WebApps_R0901534_ASP.Controllers
{
    public class AdminController : Controller
    {
        private UserManager<Gebruiker> _userManager;
        private RoleManager<IdentityRole> _roleManager;
        private readonly ILogger<AdminController> _logger;
        private readonly ForzaContext _ctx;

        public AdminController(UserManager<Gebruiker> userManager, RoleManager<IdentityRole> roleManager, ILogger<AdminController> logger, ForzaContext ctx)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _logger = logger;
            _ctx = ctx;
        }

        public IActionResult Index()
        {
            GebruikersListViewModel viewModel = new GebruikersListViewModel();
            {
                viewModel.Gebruikers = _userManager.Users.ToList();
            };
            return View(viewModel);
        }

        public async Task<IActionResult> CreateGebruiker(CreateGebruikerViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                Gebruiker gebruiker = new Gebruiker() { };

                IdentityResult res = await _userManager.CreateAsync(gebruiker);
                if (res.Succeeded) return RedirectToAction("Index");
                else
                {
                    foreach (IdentityError error in res.Errors)
                        ModelState.AddModelError("", error.Description);
                }
            }
            return View(viewModel);
        }

        public IActionResult DetailsGebruiker(string id)
        {
            Gebruiker gebruiker = _userManager.Users.Where(g => g.Id == id).FirstOrDefault();
            if (gebruiker != null)
            {
                GebruikerDetailsViewModel viewModel = new GebruikerDetailsViewModel() { };
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

        public IActionResult VerwijderGebruiker()
        {
            return View();
        }

        [HttpGet]
        public IActionResult AdminOverMij(int id = 1)
        {
            OverMij overMij = _ctx.OverMijs.Where(o => o.OverMijId == id).FirstOrDefault();

            if (overMij == null) return NotFound();

            UpdateOverMijViewModel vm = new UpdateOverMijViewModel()
            {
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
        public async Task<IActionResult> UpdateOverMij(int id, UpdateOverMijViewModel viewModel)
        {
            if (id != viewModel.OverMijId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    OverMij overMij = new OverMij()
                    {
                        TitelPersInfo = viewModel.TitelPersInfo,
                        TekstPersInfo = viewModel.TekstPersInfo,
                        TitelAppInfo = viewModel.TitelAppInfo,
                        TekstAppInfo = viewModel.TekstAppInfo,
                        Afbeelding1 = viewModel.Afbeelding1,
                        Afbeelding2 = viewModel.Afbeelding2
                    };
                    _ctx.Update(overMij);
                    await _ctx.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException e)
                {
                    if (!_ctx.OverMijs.Any(d => d.OverMijId == viewModel.OverMijId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(viewModel);
        }

        public IActionResult Circuit()
        {
            return View();
        }
    }
}