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
    public class ListadoModel : PageModel
    {
        private readonly IRepositorioEmpleado _repositorioEmpleado;
        private readonly IRepositorioEmpresa _repositorioEmpresa;
        private readonly IRepositorioDirectivo _repositorioDirectivo;

        public IEnumerable<Empleado> listadoEmpleados { get; set; }
        public IEnumerable<Empresa> listadoEmpresas { get; set; }
        public IEnumerable<Directivo> listadoDirectivos { get; set; }

        [BindProperty]
        public Empleado Empleado { get; set; }

        public int empleadoCreado { get; set;}

        public ListadoModel(IRepositorioEmpleado repositorioEmpleado, IRepositorioEmpresa repositorioEmpresa, IRepositorioDirectivo repositorioDirectivo) {

            _repositorioEmpleado = repositorioEmpleado;
            _repositorioEmpresa = repositorioEmpresa;
            _repositorioDirectivo = repositorioDirectivo;

        }

        public void OnGet()
        {
            empleadoCreado = 2;
            listadoEmpleados = _repositorioEmpleado.Obtener();
            listadoEmpresas = _repositorioEmpresa.Obtener();
            listadoDirectivos = _repositorioDirectivo.Obtener();
        }

        public IActionResult OnPost() 
        {
            Empleado = _repositorioEmpleado.Crear(Empleado);
            listadoEmpleados = _repositorioEmpleado.Obtener();
            listadoEmpresas = _repositorioEmpresa.Obtener();
            listadoDirectivos = _repositorioDirectivo.Obtener();

            if(Empleado != null)
            {
                empleadoCreado = 1;
            }
            else {

                empleadoCreado = 0;
            }
            
            return Page();
        }
    }
}
