using System.ComponentModel.DataAnnotations;

namespace Project_WebApps_R0901534_ASP.Models
{
    public class Model
    {
        public int ModelId { get; set; }

        // Attributes

        [Required(ErrorMessage = "Gelieve een naam in te vullen!")]
        public string Naam { get; set; }
    }
}