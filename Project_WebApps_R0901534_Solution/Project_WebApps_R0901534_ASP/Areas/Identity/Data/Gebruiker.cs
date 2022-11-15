using Microsoft.AspNetCore.Identity;
using Project_WebApps_R0901534_ASP.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project_WebApps_R0901534_ASP.Areas.Identity
{
    public class Gebruiker : IdentityUser
    {
        // Primary Key
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int GebruikerId { get; set; }

        // Attributes

        [Required(ErrorMessage = "Gelieve een nickname in te vullen!"), PersonalData]
        public string Nickname { get; set; }

        [Required(ErrorMessage = "Gelieve een emailadres in te vullen!"),
            MaxLength(40, ErrorMessage = "Het maximum toegelaten karakters is 40!")
            , PersonalData]
        public string Emailadres { get; set; }

        public bool IsAdmin { get; set; }
        public bool? EmailConfirmed { get; set; }
        public bool? PhoneNumberConfirmed { get; set; }
        public bool? TwoFactorEnabled { get; set; }
        public bool? LockoutEnabled { get; set; }
        public int? AccesFailedCount { get; set; }

        //[Required(ErrorMessage = "Gelieve een wachtwoord in te vullen!"), PersonalData, DataType(DataType.Password)]
        //public string Wachtwoord { get; set; }

        // Foreign Keys
        public int? OverMijId { get; set; }

        // Navigation Properties

        public OverMij OverMij { get; set; }
        public virtual ICollection<GebruikerAuto> GebruikerAutos { get; set; }
    }
}