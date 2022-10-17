using System;
using System.ComponentModel.DataAnnotations;

namespace Project_WebApps_R0901534_ASP.ViewModels
{
    public class CreateGebruikerViewModel
    {
        public string Nickname { get; set; }
        public string Emailadres { get; set; }

        [DataType(DataType.Password)]
        public string Wachtwoord { get; set; }
    }
}