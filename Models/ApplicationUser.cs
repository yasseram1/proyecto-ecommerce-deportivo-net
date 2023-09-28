using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
namespace proyecto_ecommerce_deportivo_net.Models {
    public class ApplicationUser : IdentityUser {

        [Required] // Esto asegura que el campo no puede ser null
        public string Nombres { get; set; }

        [Required] // Esto asegura que el campo no puede ser null
        public string Apellidos { get; set; }

        [Required] // Esto asegura que el campo no puede ser null
        public string Dni { get; set; }
    }
}