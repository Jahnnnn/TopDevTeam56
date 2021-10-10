using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Dominio;
using Persistencia.Repositorios;


namespace FrontEnd.Pages.Empresas
{
    public class DetalleModel : PageModel
    {
        private readonly IRepositorioEmpresa _repoEmpresa;
        private readonly IRepositorioDirectivo _repoDirectivo;
        private readonly IRepositorioEmpleado _repoEmpleado;
        private readonly IRepositorioCliente _repoCliente;

        public IEnumerable<Directivo> listadoDirectivos {get; set;}
        public IEnumerable<Empleado> listadoEmpleados {get; set;}
        public IEnumerable<Cliente> listadoClientes {get;set;}
        public Empresa Empresa {get; set;}

        public DetalleModel(IRepositorioEmpresa repositorioEmpresa, IRepositorioDirectivo repositorioDirectivo, IRepositorioEmpleado repositorioEmpleado, IRepositorioCliente repositorioCliente){
            _repoEmpresa = repositorioEmpresa;
            _repoDirectivo = repositorioDirectivo;
            _repoEmpleado = repositorioEmpleado;
            _repoCliente = repositorioCliente;
        }
        public void OnGet(int Id){
            Empresa = _repoEmpresa.ObtenerPorId(Id);
            listadoDirectivos = _repoDirectivo.ObtenerPorIdEmpresa(Id);
            listadoEmpleados = _repoEmpleado.ObtenerPorIdEmpresa(Id);
            listadoClientes = _repoCliente.ObtenerPorIdEmpresa(Id);

        }
        
    }
}
