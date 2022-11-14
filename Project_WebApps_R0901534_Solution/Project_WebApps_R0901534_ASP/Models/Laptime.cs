using System;
using System.ComponentModel.DataAnnotations;

namespace Project_WebApps_R0901534_ASP.Models
{
    public class Laptime
    {
        // Primary Key

        public int LaptimeId { get; set; }

        // Foreign Keys
        public int AutoKlasseId { get; set; }
        public int CircuitId { get; set; }

        // Attributes

        [DataType(DataType.Date)]
        public DateTime Datum { get; set; }

        [Required(ErrorMessage = "Gelieve een rondetijd in te vullen!"), MaxLength(9, ErrorMessage = "Een rondetijd moet 9 karakters lang zijn [00.00.000]!"),
        MinLength(9, ErrorMessage = "Een rondetijd moet 9 karakters lang zijn [00.00.000]!")]
        public string Rondetijd { get; set; }

        // Navigation Properties

        public AutoKlasse AutoKlasse { get; set; }
        public Circuit Circuit { get; set; }
    }
}