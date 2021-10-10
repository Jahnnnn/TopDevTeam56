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
        public Empresa Empresa {get; set;}

        public DetalleModel(IRepositorioEmpresa repositorioEmpresa){
            _repoEmpresa = repositorioEmpresa;
        }
        public void OnGet(int Id){
            Empresa = _repoEmpresa.ObtenerPorId(Id);
        }
        
    }
}
