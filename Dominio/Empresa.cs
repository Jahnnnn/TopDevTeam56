using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Dominio
{
    public class Empresa
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        public string Nombre { get; set; }

        [Required]
        public string NIT { get; set; }

        public virtual ICollection<Empleado> Empleados { get; set; }

        public virtual ICollection<Directivo> Directivos { get; set; }

        public virtual ICollection<Cliente> Clientes { get; set; }

    }
}