using System;
using System.Linq;
using Dominio;
using Persistencia;
using System.Collections.Generic;

namespace Persistencia.Repositorios
{
    public class RepositorioEmpleado : IRepositorioEmpleado
    {
        private readonly AplicacionContext _appContext;

        public RepositorioEmpleado(AplicacionContext appContext) {

            _appContext = appContext;

        }

        public Empleado Crear(Empleado empleado) {

            try {

                var nuevoEmpleado = _appContext.Empleado.Add(empleado);
                _appContext.SaveChanges();
                
                return nuevoEmpleado.Entity;

            }
            catch(Exception e){

                return null;

            }
        }

        public Empleado Actualizar(Empleado empleado) {

            try {

                var empleadoEncontrado = _appContext.Empleado.FirstOrDefault(p => p.Id == empleado.Id);

                if(empleadoEncontrado != null) {

                    empleadoEncontrado.Nombre = empleado.Nombre;
                    empleadoEncontrado.Fecha_Nacimiento = empleado.Fecha_Nacimiento;
                    empleadoEncontrado.Sueldo_Bruto = empleado.Sueldo_Bruto;
                    empleadoEncontrado.IdDirectivo = empleado.IdDirectivo;
                    empleadoEncontrado.IdEmpresa = empleado.IdEmpresa;
                    _appContext.SaveChanges();

                }

                return empleadoEncontrado;
                
            }
            catch(Exception e) {

                return null;

            }

        }

        public IEnumerable<Empleado> Obtener() {

            try {

                return _appContext.Empleado;

            }
            catch(Exception e) {

                return null;
            }

        }

        public IEnumerable<Empleado> ObtenerPorIdEmpresa(int id) {

            try {

                return _appContext.Empleado.Where(p => p.IdEmpresa == id);

            }
            catch(Exception e) {

                return null;
            }

        }

        public IEnumerable<Empleado> ObtenerPorIdDirectivo(int id) {

            try {

                return _appContext.Empleado.Where(p => p.IdDirectivo == id);

            }
            catch(Exception e) {

                return null;
            }

        }

        public Empleado ObtenerPorId(int id) {

            try {

                return _appContext.Empleado.FirstOrDefault(p => p.Id == id);

            }
            catch(Exception e) {

                return null;

            }

        }

        public bool Eliminar(int id) {

            try {

                var empleadoEncontrado = _appContext.Empleado.FirstOrDefault(p => p.Id == id);

                if(empleadoEncontrado != null) {

                    _appContext.Empleado.Remove(empleadoEncontrado);
                    _appContext.SaveChanges();

                    return true;

                }
                else {

                    return false;

                }

            }
            catch(Exception e) {

                return false;

            }

        }
        
    }
}