using Project_WebApps_R0901534_ASP.Models;
using System.ComponentModel.DataAnnotations;

namespace Project_WebApps_R0901534_ASP.ViewModels
{
    public class CreateCircuitViewModel
    {
        public int CircuitId { get; set; }
        [Required(ErrorMessage = "Gelieve een naam in te vullen!"), MaxLength(30, ErrorMessage = "Naam circuit mag maar 30 karakters lang zijn!")]
        public string Naam { get; set; }
        public string Afbeelding { get; set; }
        public FileModel FileModel { get; set; }
    }
}