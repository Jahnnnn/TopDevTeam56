using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Dominio;
using Persistencia.Repositorios;

namespace FrontEnd.Pages
{
    public class ListadoEmpleadosModel : PageModel
    {
        private readonly IRepositorioEmpleado _repositorioEmpleado;
        public IEnumerable<Empleado> listadoEmpleados { get; set; }

        public ListadoEmpleadosModel(IRepositorioEmpleado repositorioEmpleado) {

            _repositorioEmpleado = repositorioEmpleado;

        }

        public void OnGet()
        {
            listadoEmpleados = _repositorioEmpleado.Obtener();
        }
    }
}
