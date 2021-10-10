using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using Dominio;
using Persistencia.Repositorios;

namespace FrontEnd.Pages.Clientes
{
    public class ListadoModel : PageModel
    {
        private readonly IRepositorioCliente _repositorioCliente;
        private readonly IRepositorioEmpresa _repositorioEmpresa;

        public IEnumerable<Cliente> listadoClientes { get; set; }
        public IEnumerable<Empresa> listadoEmpresas { get; set; }

        [BindProperty]
        public Cliente Cliente { get; set; }

        public int estadoCliente { get; set; }

        public ListadoModel(IRepositorioCliente repositorioCliente, IRepositorioEmpresa repositorioEmpresa)
        {
            _repositorioCliente = repositorioCliente;
            _repositorioEmpresa = repositorioEmpresa;
        }

        public void OnGet()
        {
            estadoCliente = -1;
            listadoClientes = _repositorioCliente.Obtener();
            listadoEmpresas = _repositorioEmpresa.Obtener();
        }

        public IActionResult OnPost() 
        {
            Cliente = _repositorioCliente.Crear(Cliente);
            listadoClientes = _repositorioCliente.Obtener();
            listadoEmpresas = _repositorioEmpresa.Obtener();

            if(Cliente != null)
            {
                estadoCliente = 1;
            }
            else {

                estadoCliente = 0;
            }
            
            return Page();
        }

        public IActionResult OnGetEliminarCliente(int id)
        {
            bool clienteEliminado = _repositorioCliente.Eliminar(id);
            listadoClientes = _repositorioCliente.Obtener();
            listadoEmpresas = _repositorioEmpresa.Obtener();

            if(clienteEliminado)
            {
                estadoCliente = 3;
            }
            else
            {
                estadoCliente = 2;
            }
            
            return Page();
        }
    }
}
