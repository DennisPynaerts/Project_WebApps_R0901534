using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Project_WebApps_R0901534_ASP.Areas.Identity.Pages.Account.Manage
{
    public partial class IndexModel : PageModel
    {
        private readonly UserManager<Gebruiker> _userManager;
        private readonly SignInManager<Gebruiker> _signInManager;

        public IndexModel(
            UserManager<Gebruiker> userManager,
            SignInManager<Gebruiker> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        [TempData]
        public string StatusMessage { get; set; }

        [BindProperty]
        public InputModel Input { get; set; }

        public class InputModel
        {
            public int GebruikerId { get; set; }
            [Required, Display(Name = "Nickname")]
            public string Nickname { get; set; }

            //[Required, Display(Name = "Wachtwoord")]
            //public string Wachtwoord { get; set; }

            [Required, EmailAddress, Display(Name = "E-mailadres")]
            public string Emailadres { get; set; }
        }

        private async Task LoadAsync(Gebruiker user)
        {
            var nickname = await Task.FromResult(user.Nickname);
            var email = await Task.FromResult(user.Emailadres);
            // var wachtwoord = await Task.FromResult(user.Wachtwoord);

            Input = new InputModel
            {
                Nickname = nickname,
                Emailadres = email
                // Wachtwoord = wachtwoord
            };
        }

        public async Task<IActionResult> OnGetAsync()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
            }

            await LoadAsync(user);
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
            }

            if (!ModelState.IsValid)
            {
                await LoadAsync(user);
                return Page();
            }

            var nickname = await _userManager.GetUserNameAsync(user);
            if (Input.Emailadres != nickname)
            {
                var setPhoneResult = await _userManager.SetUserNameAsync(user, Input.Nickname);
                if (!setPhoneResult.Succeeded)
                {
                    StatusMessage = "Er is iets fout gegaan bij het verwerken van de nickname.";
                    return RedirectToPage();
                }
            }

            //var wachtwoord = await _userManager.GetPhoneNumberAsync(user);
            //if (Input.Emailadres != wachtwoord)
            //{
            //    var setPassordResult = await _userManager.SetPhoneNumberAsync(user, Input.Wachtwoord);
            //    if (!setPassordResult.Succeeded)
            //    {
            //        StatusMessage = "Er is iets fout gegaan bij het verwerken van het wachtwoord.";
            //        return RedirectToPage();
            //    }
            //}

            var emailadres = await _userManager.GetEmailAsync(user);
            if (Input.Emailadres != emailadres)
            {
                var setEmailAddressResult = await _userManager.SetEmailAsync(user, Input.Emailadres);
                if (!setEmailAddressResult.Succeeded)
                {
                    StatusMessage = "Er is iets fout gegaan bij het verwerken van het e-mailadres.";
                    return RedirectToPage();
                }
            }

            await _signInManager.RefreshSignInAsync(user);
            StatusMessage = "Uw profiel is aangepast.";
            return RedirectToPage();
        }
    }
}