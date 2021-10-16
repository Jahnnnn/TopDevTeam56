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


namespace FrontEnd.Pages.Clientes
{
    [Authorize]
    public class DetalleModel : PageModel
    {
        private readonly IRepositorioCliente _repositorioCliente;
        private readonly IRepositorioEmpresa _repositorioEmpresa;

        public Cliente Cliente { get; set; }
        public Empresa Empresa { get; set; }

        public DetalleModel(IRepositorioCliente repositorioCliente, IRepositorioEmpresa repositorioEmpresa)
        {
            _repositorioCliente = repositorioCliente;
            _repositorioEmpresa = repositorioEmpresa;
        }

        public void OnGet(int Id)
        {
            Cliente = _repositorioCliente.ObtenerPorId(Id);
            Empresa = _repositorioEmpresa.ObtenerPorId(Cliente.IdEmpresa);
        }
    }
}
