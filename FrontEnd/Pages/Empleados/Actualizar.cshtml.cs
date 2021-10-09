using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using Dominio;
using Persistencia.Repositorios;

namespace FrontEnd.Pages.Empleados
{
    public class ActualizarModel : PageModel
    {
        private readonly IRepositorioEmpleado _repositorioEmpleado;
        private readonly IRepositorioEmpresa _repositorioEmpresa;
        private readonly IRepositorioDirectivo _repositorioDirectivo;

        public IEnumerable<Empresa> listadoEmpresas { get; set; }
        public IEnumerable<Directivo> listadoDirectivos { get; set; }

        [BindProperty]
        public Empleado Empleado { get; set; }

        public int empleadoActualizado { get; set;}

        public ActualizarModel(IRepositorioEmpleado repositorioEmpleado, IRepositorioEmpresa repositorioEmpresa, IRepositorioDirectivo repositorioDirectivo){
            
            _repositorioEmpleado = repositorioEmpleado;
            _repositorioEmpresa = repositorioEmpresa;
            _repositorioDirectivo = repositorioDirectivo;

        }

        public void OnGet(int Id)
        {
            empleadoActualizado = -1;
            Empleado = _repositorioEmpleado.ObtenerPorId(Id);
            listadoEmpresas = _repositorioEmpresa.Obtener();
            listadoDirectivos = _repositorioDirectivo.Obtener();
        }

        public IActionResult OnPost() 
        {
            Empleado = _repositorioEmpleado.Actualizar(Empleado);
            listadoEmpresas = _repositorioEmpresa.Obtener();
            listadoDirectivos = _repositorioDirectivo.Obtener();

            if(Empleado != null)
            {
                empleadoActualizado = 1;
            }
            else {

                empleadoActualizado = 0;
            }
            
            return Page();
        }
    }
}
