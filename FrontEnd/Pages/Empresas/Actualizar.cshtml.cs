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
    public class ActualizarModel : PageModel
    {
        private readonly IRepositorioEmpresa _repoEmpresa;

        [BindProperty]

        public Empresa Empresa {get;set;}
        public int empresaActualizada {get;set;}

        public ActualizarModel(IRepositorioEmpresa repoEmpresa){
            _repoEmpresa = repoEmpresa;
        }
        public void OnGet()
        {
            empresaActualizada = -1;
        }

        public IActionResult OnPost(){
            Empresa = _repoEmpresa.Actualizar(Empresa);

            if(Empresa != null){
                empresaActualizada = 1;
            }else{
                empresaActualizada = 0;
            }

            return Page();
        }
    }

}
