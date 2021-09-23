using Dominio;
using System.Collections.Generic;

namespace Persistencia.Repositorios
{
    public interface IRepositorioDirectivo
    {
        Directivo Crear(Directivo directivo);

        Directivo Actualizar(Directivo actualizar);

        IEnumerable<Directivo> Obtener();

        IEnumerable<Directivo> ObtenerPorIdEmpresa(int id);

        Directivo ObtenerPorId(int id);

        bool Eliminar(int id); 
    }
}