using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Project_WebApps_R0901534_ASP.Models
{
    public class Merk
    {
        // Primary Key
        public int MerkId { get; set; }

        // Attributes

        [Required(ErrorMessage = "Gelieve een naam in te vullen!"), MaxLength(20, ErrorMessage = "Naam mag maar 20 karakters lang zijn!")]
        public string Naam { get; set; }

        // Foreign key
        public int ModelId { get; set; }

        // Navigation properties

        public Model Model { get; set; }
        public virtual ICollection<Auto> Autos { get; set; }
    }
}