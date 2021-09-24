using Dominio;
using System.Collections.Generic;

namespace Persistencia.Repositorios
{
    public interface IRepositorioEmpleado
    {
        Empleado Crear(Empleado empleado);

        Empleado Actualizar(Empleado empleado);

        IEnumerable<Empleado> Obtener();

        IEnumerable<Empleado> ObtenerPorIdEmpresa(int id);

        IEnumerable<Empleado> ObtenerPorIdDirectivo(int id);

        Empleado ObtenerPorId(int id);

        bool Eliminar(int id);
    }
}