using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Project_WebApps_R0901534_ASP.Models
{
    public class Auto
    {
        // Primary Key
        [Key]
        public int AutoId { get; set; }

        // Attributes

        public int BasisPI { get; set; }
        public int PK { get; set; }

        public enum Aandrijflijn
        { AWD, RWD, FWD }

        public Aandrijflijn Aandrijving { get; set; }

        public int Bouwjaar { get; set; }

        [Required(ErrorMessage = "Gelieve een totale PI in te vullen!")]
        public int TotalePI { get; set; }

        public int Kostprijs { get; set; }

        // Foreign Keys
        public int MerkId { get; set; }

        // Navigation Properties
        public Merk Merk { get; set; }
        public virtual ICollection<GebruikerAuto> GebruikerAutos { get; set; }
    }
}