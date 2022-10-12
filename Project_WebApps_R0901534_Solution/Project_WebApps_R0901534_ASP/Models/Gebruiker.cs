﻿using System.ComponentModel.DataAnnotations;

namespace Project_WebApps_R0901534_ASP.Models
{
    public class Gebruiker
    {
        // Primary Key

        public int GebruikerId { get; set; }

        // Attributes

        [Required(ErrorMessage = "Gelieve een nickname in te vullen!")]
        public string Nickname { get; set; }

        [Required(ErrorMessage = "Gelieve een emailadres in te vullen!"), MaxLength(40, ErrorMessage = "Het maximum toegelaten karakters is 40!")]
        public string Emailadres { get; set; }

        public bool IsAdmin { get; set; }

        [Required(ErrorMessage = "Gelieve een wachtwoord in te vullen!")]
        public string Wachtwoord { get; set; }
    }
}