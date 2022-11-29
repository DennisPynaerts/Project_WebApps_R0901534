using Project_WebApps_R0901534_ASP.Models;
using System.ComponentModel.DataAnnotations;

namespace Project_WebApps_R0901534_ASP.ViewModels
{
    public class UpdateOverMijViewModel
    {
        public int OverMijId { get; set; }
        [Required(ErrorMessage = "Titel moet ingevuld worden!"), MaxLength(40, ErrorMessage = "Titel mag max. 40 karakters hebben!")]
        public string TitelPersInfo { get; set; }

        [Required]
        public string TekstPersInfo { get; set; }

        [Required(ErrorMessage = "Titel moet ingevuld worden!"), MaxLength(40, ErrorMessage = "Titel mag max. 40 karakters hebben!")]
        public string TitelAppInfo { get; set; }

        [Required]
        public string TekstAppInfo { get; set; }
        public string Afbeelding1 { get; set; }
        public string Afbeelding2 { get; set; }
        public FileModel FileModel { get; set; }
    }
}