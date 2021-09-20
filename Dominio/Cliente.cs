using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dominio
{
    public class Cliente : Persona
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]   
        public string Telefono { get; set; }

        [Required]
        public int IdEmpresa { get; set; }

        [ForeignKey("IdEmpresa")]
        public virtual Empresa Empresa { get; set; }
    }
}