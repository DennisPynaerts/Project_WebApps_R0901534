using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Project_WebApps_R0901534_ASP.Models
{
    public class Merk
    {
        // Primary Key

        public int MerkId { get; set; }

        // Attributes

        [Required(ErrorMessage = "Gelieve een naam in te vullen!")]
        public string Naam { get; set; }

        // Navigation Properties

        [Required]
        public int ModelId { get; set; }

        public Model Model { get; set; }
        public virtual ICollection<Model> Models { get; set; }
    }
}