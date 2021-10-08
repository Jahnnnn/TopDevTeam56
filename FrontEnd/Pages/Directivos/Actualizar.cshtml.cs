using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using Dominio;
using Persistencia.Repositorios;

namespace FrontEnd.Pages.Directivos
{
    public class ActualizarModel : PageModel
    {
        private readonly IRepositorioDirectivo _repositorioDirectivo;
        private readonly IRepositorioEmpresa _repositorioEmpresa;

        public IEnumerable<Empresa> listadoEmpresas { get; set; }

        [BindProperty]
        public Directivo Directivo { get; set; }

        public int directivoActualizado { get; set; }

        public ActualizarModel(IRepositorioDirectivo repositorioDirectivo, IRepositorioEmpresa repositorioEmpresa)
        {
            _repositorioDirectivo = repositorioDirectivo;
            _repositorioEmpresa = repositorioEmpresa;
        }

        public void OnGet(int Id)
        {
            directivoActualizado = -1;
            Directivo = _repositorioDirectivo.ObtenerPorId(Id);
            listadoEmpresas = _repositorioEmpresa.Obtener();
        }

        public IActionResult OnPost() 
        {
            Directivo = _repositorioDirectivo.Actualizar(Directivo);
            listadoEmpresas = _repositorioEmpresa.Obtener();

            if(Directivo != null)
            {
                directivoActualizado = 1;
            }
            else {

                directivoActualizado = 0;
            }
            
            return Page();
        }
    }
}
