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
    public class DetalleModel : PageModel
    {
        private readonly IRepositorioDirectivo _repositorioDirectivo;
        private readonly IRepositorioEmpresa _repositorioEmpresa;

        public Directivo Directivo { get; set; }
        public Empresa Empresa { get; set; }

        public DetalleModel(IRepositorioDirectivo repositorioDirectivo, IRepositorioEmpresa repositorioEmpresa)
        {
            _repositorioDirectivo = repositorioDirectivo;
            _repositorioEmpresa = repositorioEmpresa;
        }

        public void OnGet(int Id)
        {
            Directivo = _repositorioDirectivo.ObtenerPorId(Id);
            Empresa = _repositorioEmpresa.ObtenerPorId(Directivo.IdEmpresa);
        }
    }
}
