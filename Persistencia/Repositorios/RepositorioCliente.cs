using System;
using System.Linq;
using Dominio;
using Persistencia;
using System.Collections.Generic;

namespace Persistencia.Repositorios
{
    public class RepositorioCliente : IRepositorioCliente
    {
        private readonly AplicacionContext _appContext;

        public RepositorioCliente(AplicacionContext appContext) {

            _appContext = appContext;

        }

        public Cliente Crear(Cliente cliente) {

            try {

                var nuevoCliente = _appContext.Cliente.Add(cliente);
                _appContext.SaveChanges();
                
                return nuevoCliente.Entity;

            }
            catch(Exception e){

                return null;

            }

        }

        public Cliente Actualizar(Cliente cliente) {

            try {

                var clienteEncontrado = _appContext.Cliente.FirstOrDefault(p => p.Id == cliente.Id);

                if(clienteEncontrado != null) {

                    clienteEncontrado.Nombre = cliente.Nombre;
                    clienteEncontrado.Fecha_Nacimiento = cliente.Fecha_Nacimiento;
                    clienteEncontrado.Telefono = cliente.Telefono;
                    clienteEncontrado.IdEmpresa = cliente.IdEmpresa;
                    _appContext.SaveChanges();

                }

                return clienteEncontrado;
                
            }
            catch(Exception e) {

                return null;

            }

        }

        public IEnumerable<Cliente> Obtener() {

            try {

                return _appContext.Cliente;

            }
            catch(Exception e) {

                return null;
            }

        }

        public IEnumerable<Cliente> ObtenerPorIdEmpresa(int id) {

            try {

                return _appContext.Cliente.Where(p => p.IdEmpresa == id);

            }
            catch(Exception e) {

                return null;
            }

        }

        public Cliente ObtenerPorId(int id) {

            try {

                return _appContext.Cliente.FirstOrDefault(p => p.Id == id);

            }
            catch(Exception e) {

                return null;

            }

        }

        public bool Eliminar(int id) {

            try {

                var clienteEncontrado = _appContext.Cliente.FirstOrDefault(p => p.Id == id);

                if(clienteEncontrado != null) {

                    _appContext.Cliente.Remove(clienteEncontrado);
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