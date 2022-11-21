using Project_WebApps_R0901534_ASP.Areas.Identity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project_WebApps_R0901534_ASP.Models
{
    public class GebruikerAuto
    {
        // Primary Key
        public int GebruikerAutoId { get; set; }

        // Foreign Keys

        public int AutoId { get; set; }
        [ForeignKey("Gebruiker")]
        public string GebruikerId { get; set; }

        // Navigation Properties

        public Auto Auto { get; set; }
        public Gebruiker Gebruiker { get; set; }
        public virtual ICollection<AutoKlasse> AutoKlasses { get; set; }
    }
}