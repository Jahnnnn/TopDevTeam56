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

namespace FrontEnd.Pages.Directivos
{
    [Authorize]
    public class ListadoModel : PageModel
    {
        private readonly IRepositorioDirectivo _repositorioDirectivo;
        private readonly IRepositorioEmpresa _repositorioEmpresa;

        public IEnumerable<Directivo> listadoDirectivos { get; set; }
        public IEnumerable<Empresa> listadoEmpresas { get; set; }

        [BindProperty]
        public Directivo Directivo { get; set; }

        public int estadoDirectivo { get; set; }

        public ListadoModel(IRepositorioDirectivo repositorioDirectivo, IRepositorioEmpresa repositorioEmpresa)
        {
            _repositorioDirectivo = repositorioDirectivo;
            _repositorioEmpresa = repositorioEmpresa;
        }

        public void OnGet()
        {
            estadoDirectivo = -1;
            listadoDirectivos = _repositorioDirectivo.Obtener();
            listadoEmpresas = _repositorioEmpresa.Obtener();
        }

        public IActionResult OnPost() 
        {
            Directivo = _repositorioDirectivo.Crear(Directivo);
            listadoDirectivos = _repositorioDirectivo.Obtener();
            listadoEmpresas = _repositorioEmpresa.Obtener();

            if(Directivo != null)
            {
                estadoDirectivo = 1;
            }
            else {

                estadoDirectivo = 0;
            }
            
            return Page();
        }

        public IActionResult OnGetEliminarDirectivo(int id)
        {
            bool directivoEliminado = _repositorioDirectivo.Eliminar(id);
            listadoDirectivos = _repositorioDirectivo.Obtener();
            listadoEmpresas = _repositorioEmpresa.Obtener();

            if(directivoEliminado)
            {
                estadoDirectivo = 3;
            }
            else
            {
                estadoDirectivo = 2;
            }
            
            return Page();
        }
    }
}
