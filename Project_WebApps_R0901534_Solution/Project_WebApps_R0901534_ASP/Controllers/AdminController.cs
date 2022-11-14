using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Project_WebApps_R0901534_ASP.Areas.Identity;
using Project_WebApps_R0901534_ASP.ViewModels;

namespace Project_WebApps_R0901534_ASP.Controllers
{
    public class AdminController : Controller
    {
        private UserManager<Gebruiker> _userManager;
        private RoleManager<IdentityRole> _roleManager;

        public AdminController(UserManager<Gebruiker> userManager, RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
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
                Gebruiker gebruiker = new Gebruiker()
                {
                    Nickname = viewModel.Nickname,
                    Emailadres = viewModel.Emailadres,
                    // Wachtwoord = viewModel.Wachtwoord
                };

                IdentityResult res = await _userManager.CreateAsync(gebruiker, viewModel.Wachtwoord);
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
                GebruikerDetailsViewModel viewModel = new GebruikerDetailsViewModel()
                {
                    GebruikerId = gebruiker.GebruikerId,
                    Nickname = gebruiker.Nickname,
                    Emailadres = gebruiker.Emailadres
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

        public IActionResult VerwijderGebruiker()
        {
            return View();
        }

        public IActionResult AdminOverMij()
        {
            return View();
        }

        public IActionResult Circuit()
        {
            return View();
        }
    }
}