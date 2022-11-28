﻿using Microsoft.AspNetCore.Mvc;
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

        #region CreateGebruiker

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

        #region Details gebruiker
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

        public IActionResult Circuit()
        {
            return View();
        }
    }
}