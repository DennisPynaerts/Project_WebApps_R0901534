using Microsoft.AspNetCore.Mvc.Rendering;

namespace Project_WebApps_R0901534_ASP.ViewModels
{
    public class RollenBeheerViewModel
    {
        public SelectList Gebruikers { get; set; }
        public SelectList Rollen { get; set; }
        public string Id { get; set; }
        public string RolId { get; set; }
    }
}
