using Microsoft.AspNetCore.Identity;
using Project_WebApps_R0901534_ASP.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project_WebApps_R0901534_ASP.Areas.Identity
{
    public class Gebruiker : IdentityUser
    {
        // Foreign Keys
        public int? OverMijId { get; set; }

        // Navigation Properties

        public OverMij OverMij { get; set; }
        public virtual ICollection<GebruikerAuto> GebruikerAutos { get; set; }
    }
}