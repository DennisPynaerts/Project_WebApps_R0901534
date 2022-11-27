using Microsoft.AspNetCore.Identity;
using Project_WebApps_R0901534_ASP.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project_WebApps_R0901534_ASP.Areas.Identity
{
    public class Gebruiker : IdentityUser
    {
        // [DatabaseGenerated(DatabaseGeneratedOption.Identity), Key]
        // public int GebruikerId { get; set; }
        // public override string Id { get; set; } <-- uncommenten als gebruikers niet met script geinsert kunnen worden!!! enkel deze regel!!!
        public string Nickname { get; set; }
        public string Emailadres { get; set; }
        public string Wachtwoord { get; set; }
        public bool IsAdmin { get; set; }

        // Foreign Keys
        public int? OverMijId { get; set; }

        // Navigation Properties
        public OverMij OverMij { get; set; }
        public virtual ICollection<GebruikerAuto> GebruikerAutos { get; set; }
    }
}