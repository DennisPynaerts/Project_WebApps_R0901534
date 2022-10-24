using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Project_WebApps_R0901534_ASP.Models
{
    public class AutoKlasse
    {
        // Primary Key

        public int AutoKlasseId { get; set; }

        // Foreign Keys
        [Required]
        public int GebruikerAutoId { get; set; }

        [Required]
        public int KlasseId { get; set; }

        // Navigation Properties

        public GebruikerAuto GebruikerAuto { get; set; }
        public Klasse Klasse { get; set; }
        public virtual ICollection<GebruikerAuto> GebruikerAutos { get; set; }
    }
}