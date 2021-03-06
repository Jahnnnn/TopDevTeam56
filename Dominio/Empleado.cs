using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dominio
{
    public class Empleado : Persona
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        public float Sueldo_Bruto { get; set; }

        [Required]
        public int IdDirectivo { get; set; } 

        [Required]
        public int IdEmpresa { get; set; }

        [ForeignKey("IdDirectivo")]
        public virtual Directivo Directivo { get; set; }

        [ForeignKey("IdEmpresa")]
        public virtual Empresa Empresa { get; set; }
    }
}