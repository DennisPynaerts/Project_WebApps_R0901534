using Microsoft.AspNetCore.Mvc.Rendering;
using Project_WebApps_R0901534_ASP.Areas.Identity;
using Project_WebApps_R0901534_ASP.Models;
using System.Collections.Generic;

namespace Project_WebApps_R0901534_ASP.ViewModels
{
    public class LaptimeListViewModel
    {
        public List<Laptime> Laptimes { get; set; }
        public Circuit Circuit { get; set; }
        //public List<GebruikerAuto> GebruikerAutos { get; set; }
        public Gebruiker Gebruiker { get; set; }
        public GebruikerAuto GebruikerAuto { get; set; }
        public string Rondetijd { get; set; }
        public int GebruikerAutoId { get; set; }
        public List<SelectListItem> GebruikerAutos { get; set; }
        public int CircuitId { get; set; }
        public string Merknaam { get; set; }
        public string Modelnaam { get; set; }
        public int PI { get; set; }

    }
}