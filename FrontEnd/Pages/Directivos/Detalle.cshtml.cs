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

namespace FrontEnd.Pages.Directivos
{
    [Authorize]
    public class DetalleModel : PageModel
    {
        private readonly IRepositorioDirectivo _repositorioDirectivo;
        private readonly IRepositorioEmpresa _repositorioEmpresa;
        private readonly IRepositorioEmpleado _repositorioEmpleado;

        public IEnumerable<Empleado> listadoEmpleados { get; set; }

        public Directivo Directivo { get; set; }
        public Empresa Empresa { get; set; }

        public DetalleModel(IRepositorioDirectivo repositorioDirectivo, IRepositorioEmpresa repositorioEmpresa, IRepositorioEmpleado repositorioEmpleado)
        {
            _repositorioDirectivo = repositorioDirectivo;
            _repositorioEmpresa = repositorioEmpresa;
            _repositorioEmpleado = repositorioEmpleado;
        }

        public void OnGet(int Id)
        {
            Directivo = _repositorioDirectivo.ObtenerPorId(Id);
            Empresa = _repositorioEmpresa.ObtenerPorId(Directivo.IdEmpresa);
            listadoEmpleados = _repositorioEmpleado.ObtenerPorIdDirectivo(Id);
        }
    }
}
