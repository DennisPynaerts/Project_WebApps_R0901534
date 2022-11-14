using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Project_WebApps_R0901534_ASP.Models
{
    public class Model
    {
        public int ModelId { get; set; }

        // Attributes

        [Required(ErrorMessage = "Gelieve een naam in te vullen!"), MaxLength(30, ErrorMessage = "Modelnaam mag maar 30 karakters lang zijn!")]
        public string Naam { get; set; }
        public virtual ICollection<Merk> Merken { get; set; }
    }
}