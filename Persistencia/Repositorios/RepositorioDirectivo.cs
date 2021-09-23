using System;
using System.Linq;
using Dominio;
using Persistencia;
using System.Collections.Generic;

namespace Persistencia.Repositorios
{
    public class RepositorioDirectivo : IRepositorioDirectivo
    {
        private readonly AplicacionContext _appContext;

        public RepositorioDirectivo(AplicacionContext appContext) {

            _appContext = appContext;

        }

        public Directivo Crear(Directivo directivo) {

            try {

                var nuevoDirectivo = _appContext.Directivo.Add(directivo);
                _appContext.SaveChanges();
                
                return nuevoDirectivo.Entity;

            }
            catch(Exception e){

                return null;

            }

        }

        public Directivo Actualizar(Directivo directivo) {

            try {

                var directivoEncontrado = _appContext.Directivo.FirstOrDefault(p => p.Id == directivo.Id);

                if(directivoEncontrado != null) {

                    directivoEncontrado.Nombre = directivo.Nombre;
                    directivoEncontrado.Fecha_Nacimiento = directivo.Fecha_Nacimiento;
                    directivoEncontrado.Sueldo_Bruto = directivo.Sueldo_Bruto;
                    directivoEncontrado.Categoria = directivo.Categoria;
                    directivoEncontrado.IdEmpresa = directivo.IdEmpresa;
                    _appContext.SaveChanges();

                }

                return directivoEncontrado;
                
            }
            catch(Exception e) {

                return null;

            }

        }

        public IEnumerable<Directivo> Obtener() {

            try {

                return _appContext.Directivo;

            }
            catch(Exception e) {

                return null;
            }

        }

        public IEnumerable<Directivo> ObtenerPorIdEmpresa(int id) {

            try {

                return _appContext.Directivo.Where(p => p.IdEmpresa == id);

            }
            catch(Exception e) {

                return null;
            }

        }

        public Directivo ObtenerPorId(int id) {

            try {

                return _appContext.Directivo.FirstOrDefault(p => p.Id == id);

            }
            catch(Exception e) {

                return null;

            }

        }

        public bool Eliminar(int id) {

            try {

                var directivoEncontrado = _appContext.Directivo.FirstOrDefault(p => p.Id == id);

                if(directivoEncontrado != null) {

                    _appContext.Directivo.Remove(directivoEncontrado);
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