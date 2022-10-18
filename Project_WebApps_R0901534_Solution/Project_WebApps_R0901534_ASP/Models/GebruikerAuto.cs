using System.Collections.Generic;

namespace Project_WebApps_R0901534_ASP.Models
{
    public class GebruikerAuto
    {
        // Primary Key
        public int GebruikerAutoId { get; set; }

        // Foreign Keys

        public int AutoId { get; set; }
        public int GebruikerId { get; set; }

        // Navigation Properties

        public Auto Auto { get; set; }
        public Gebruiker Gebruiker { get; set; }
        public virtual ICollection<Auto> Autos { get; set; }
    }
}