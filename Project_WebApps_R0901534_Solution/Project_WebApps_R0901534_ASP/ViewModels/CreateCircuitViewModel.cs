using System.ComponentModel.DataAnnotations;

namespace Project_WebApps_R0901534_ASP.ViewModels
{
    public class CreateCircuitViewModel
    {
        public int CircuitId { get; set; }
        [Required]
        public string Naam { get; set; }
        [Required]
        public string Afbeelding { get; set; }
    }
}