using Dominio;
using System.Collections.Generic;

namespace Persistencia.Repositorios
{
    public interface IRepositorioCliente
    {
        Cliente Crear(Cliente cliente);

        Cliente Actualizar(Cliente cliente);

        IEnumerable<Cliente> Obtener();

        IEnumerable<Cliente> ObtenerPorIdEmpresa(int id);

        Cliente ObtenerPorId(int id);

        bool Eliminar(int id);
    }
}