using System;
using System.Linq;
using Dominio;
using Persistencia;
using System.Collections.Generic;

namespace Persistencia.Repositorios
{
    public class RepositorioEmpresa : IRepositorioEmpresa
    {
        private readonly AplicacionContext _appContext;

        public RepositorioEmpresa(AplicacionContext appContext) {

            _appContext = appContext;

        }

        public Empresa Crear(Empresa empresa) {

            try {

                var nuevaEmpresa = _appContext.Empresa.Add(empresa);
                _appContext.SaveChanges();
                
                return nuevaEmpresa.Entity;

            }
            catch(Exception e){

                return null;

            }
            
        }

        public Empresa Actualizar(Empresa empresa) {

            try {

                var empresaEncontrada = _appContext.Empresa.FirstOrDefault(p => p.Id == empresa.Id);

                if(empresaEncontrada != null) {

                    empresaEncontrada.Nombre = empresa.Nombre;
                    empresaEncontrada.NIT = empresa.NIT;
                    _appContext.SaveChanges();

                }

                return empresaEncontrada;
                
            }
            catch(Exception e) {

                return null;

            }

        }

        public IEnumerable<Empresa> Obtener() {

            try {

                return _appContext.Empresa;

            }
            catch(Exception e) {

                return null;
            }


        }

        public Empresa ObtenerPorId(int id) {

            try {

                return _appContext.Empresa.FirstOrDefault(p => p.Id == id);

            }
            catch(Exception e) {

                return null;

            }

        }

        public bool Eliminar(int id) {

            try {

                var empresaEncontrada = _appContext.Empresa.FirstOrDefault(p => p.Id == id);

                if(empresaEncontrada != null) {

                    _appContext.Empresa.Remove(empresaEncontrada);
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