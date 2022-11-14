using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Project_WebApps_R0901534_ASP.Models
{
    public class Klasse
    {
        // Primary Key
        public int KlasseId { get; set; }

        // Attributes
        [Required]
        public char Naam { get; set; }

        public int MinPI { get; set; }
        public int MaxPI { get; set; }

        public virtual ICollection<AutoKlasse> AutoKlasses { get; set; }
    }
}