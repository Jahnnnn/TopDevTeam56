using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dominio
{
    public class Directivo : Persona
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        public float Sueldo_Bruto { get; set; }

        [Required]
        public int Categoria { get; set; }

        [Required]
        public int IdEmpresa { get; set; }

        [ForeignKey("IdEmpresa")]
        public virtual Empresa Empresa { get; set; }

        public virtual ICollection<Empleado> Empleados { get; set; }
    }
}