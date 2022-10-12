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

        [MaxLength(3, ErrorMessage = "De aandrijflijn moet 3 karakters lang zijn!"), MinLength(3, ErrorMessage = "De aandrijflijn moet 3 karakters lang zijn!")]
        public string Aandrijflijn { get; set; }

        public int Bouwjaar { get; set; }

        [Required(ErrorMessage = "Gelieve een totale PI in te vullen!")]
        public int TotalePI { get; set; }

        // Foreign Keys
        [Required]
        public int MerkId { get; set; }

        [Required]
        public int ModelId { get; set; }

        // Navigation Properties

        public Merk Merk { get; set; }
        public Model Model { get; set; }
    }
}