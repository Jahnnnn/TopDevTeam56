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
    public class ActualizarModel : PageModel
    {
        private readonly IRepositorioCliente _repositorioCliente;
        private readonly IRepositorioEmpresa _repositorioEmpresa;

        public IEnumerable<Empresa> listadoEmpresas { get; set; }

        [BindProperty]
        public Cliente Cliente { get; set; }

        public int clienteActualizado { get; set; }

        public ActualizarModel(IRepositorioCliente repositorioCliente, IRepositorioEmpresa repositorioEmpresa)
        {
            _repositorioCliente = repositorioCliente;
            _repositorioEmpresa = repositorioEmpresa;
        }

        public void OnGet(int Id)
        {
            clienteActualizado = -1; 
            Cliente = _repositorioCliente.ObtenerPorId(Id);
            listadoEmpresas = _repositorioEmpresa.Obtener();
        }

        public IActionResult OnPost() 
        {
            Cliente = _repositorioCliente.Actualizar(Cliente);
            listadoEmpresas = _repositorioEmpresa.Obtener();

            if(Cliente != null)
            {
                clienteActualizado = 1;
            }
            else {

                clienteActualizado = 0;
            }
            
            return Page();
        }
    } 
}
