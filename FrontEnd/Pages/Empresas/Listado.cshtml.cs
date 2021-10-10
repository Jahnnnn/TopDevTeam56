using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using Dominio;
using Persistencia.Repositorios;

namespace FrontEnd.Pages.Empresas
{
    public class ListadoModel : PageModel
    {
        private readonly IRepositorioEmpresa _repoEmpresa;

        public IEnumerable<Empresa> listadoEmpresas {get;set;}

        [BindProperty]

        public Empresa Empresa {get;set;}
        public int empresaCreada {get;set;}

        public ListadoModel(IRepositorioEmpresa repoEmpresa){
            _repoEmpresa = repoEmpresa;
        }
        public void OnGet()
        {
            empresaCreada = -1;
            listadoEmpresas = _repoEmpresa.Obtener();

        }

        public IActionResult OnPost(){
            Empresa = _repoEmpresa.Crear(Empresa);

            if(Empresa != null){
                empresaCreada = 1;
            }else{
                empresaCreada = 0;
            }

            listadoEmpresas = _repoEmpresa.Obtener();
            return Page();
        }

        public IActionResult OnGetEliminarEmpresa(int id){
            bool empresaEliminada = _repoEmpresa.Eliminar(id);

            if(empresaEliminada){
                empresaCreada = 3;
            }
            else{
                empresaCreada = 2;
            }
        }
    }
}
