using System;
using System.ComponentModel.DataAnnotations;

namespace Dominio
{
    public abstract class Persona
    {
        [Required]
        public string Nombre { get; set; }

        [Required]
        public DateTime Fecha_Nacimiento { get; set; } 
    }
}