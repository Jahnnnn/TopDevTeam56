using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using Dominio;
using Persistencia.Repositorios;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.Logging;

namespace FrontEnd.Pages.Empleados
{
    [Authorize]
    public class DetalleModel : PageModel
    {
        private readonly IRepositorioEmpleado _repositorioEmpleado;
        private readonly IRepositorioEmpresa _repositorioEmpresa;
        private readonly IRepositorioDirectivo _repositorioDirectivo;

        public Empleado Empleado { get; set; }
        public Empresa Empresa { get; set; }
        public Directivo Directivo { get; set; }

        public DetalleModel(IRepositorioEmpleado repositorioEmpleado, IRepositorioEmpresa repositorioEmpresa, IRepositorioDirectivo repositorioDirectivo)
        {
            _repositorioEmpleado = repositorioEmpleado;
            _repositorioEmpresa = repositorioEmpresa;
            _repositorioDirectivo = repositorioDirectivo;
        }

        public void OnGet(int Id)
        {
            Empleado = _repositorioEmpleado.ObtenerPorId(Id);
            Empresa = _repositorioEmpresa.ObtenerPorId(Empleado.IdEmpresa);
            Directivo = _repositorioDirectivo.ObtenerPorId(Empleado.IdDirectivo);
        }
    }
}
