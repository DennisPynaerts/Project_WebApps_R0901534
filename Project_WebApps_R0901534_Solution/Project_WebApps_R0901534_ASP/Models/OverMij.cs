using Project_WebApps_R0901534_ASP.Areas.Identity;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Project_WebApps_R0901534_ASP.Models
{
    public class OverMij
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

        [Required]
        public string Afbeelding1 { get; set; }

        [Required]
        public string Afbeelding2 { get; set; }
        public virtual ICollection<Gebruiker> Gebruikers { get; set; }
    }
}