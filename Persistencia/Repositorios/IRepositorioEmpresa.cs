using Dominio;
using System.Collections.Generic;

namespace Persistencia.Repositorios
{
    public interface IRepositorioEmpresa
    {
        Empresa Crear(Empresa empresa);

        Empresa Actualizar(Empresa empresa);

        IEnumerable<Empresa> Obtener();

        Empresa ObtenerPorId(int id);

        bool Eliminar(int id);
    }
}