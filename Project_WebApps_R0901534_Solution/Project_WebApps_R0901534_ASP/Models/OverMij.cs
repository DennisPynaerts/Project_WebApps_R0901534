using System.ComponentModel.DataAnnotations;

namespace Project_WebApps_R0901534_ASP.Models
{
    public class OverMij
    {
        public int OverMijId { get; set; }

        [Required(ErrorMessage = "Titel moet ingevuld worden!"), MaxLength(40, ErrorMessage = "Titel mag max. 40 karakters hebben!")]
        public string TitelPersInfo { get; set; }

        public string TekstPersInfo { get; set; }

        [Required(ErrorMessage = "Titel moet ingevuld worden!"), MaxLength(40, ErrorMessage = "Titel mag max. 40 karakters hebben!")]
        public string TitelAppInfo { get; set; }

        public string TekstAppInfo { get; set; }
        public string Afbeelding1 { get; set; }
        public string Afbeelding2 { get; set; }
    }
}