using System;
using Dominio;
using System.Collections.Generic;
using Persistencia;
using Persistencia.Repositorios;

namespace Consola
{
    class Program
    {
        private static IRepositorioEmpresa repositorioEmpresa = new RepositorioEmpresa(new AplicacionContext());
        
        static void Main(string[] args)
        {
            //CRUD Entidad Empresa

            //crearEmpresa();
            //actualizarEmpresa();
            //obtenerEmpresa();
            //obtenerEmpresas();
            //eliminarEmpresa();
        }

        static void crearEmpresa() {

            Empresa empresa = new Empresa(){
                Nombre = "Maderas J&G  S.A.S",
                NIT = "3652365285"
            };

            Empresa empresaCreada = repositorioEmpresa.Crear(empresa);

            if(empresaCreada != null){
                Console.WriteLine("Empresa creada correctamente");
            }
            else {
                Console.WriteLine("No se pudo crear la empresa");
            }
        }

        static void actualizarEmpresa() {

            Empresa empresa = new Empresa(){
                Id = 5,
                Nombre = "Pinturax Colombia S.A.S",
                NIT = "75236523212"
            };

            Empresa empresaActualizada = repositorioEmpresa.Actualizar(empresa);

            if(empresaActualizada != null){
                Console.WriteLine("Empresa actualizada correctamente");
            }
            else {
                Console.WriteLine("No se pudo actualizar la empresa");
            }
        }

        static void obtenerEmpresa() {

            Empresa empresaEncontrada = repositorioEmpresa.ObtenerPorId(5);

            if(empresaEncontrada != null){
                Console.WriteLine($"Empresa {empresaEncontrada.Nombre} encontrada");
            }
            else {
                Console.WriteLine("No se pudo encontrar la empresa");
            }

        }

        static void obtenerEmpresas() {

            IEnumerable<Empresa> empresasEncontradas = repositorioEmpresa.Obtener();

            foreach (var empresa in empresasEncontradas)
            {
                Console.WriteLine($"{empresa.Nombre} - {empresa.NIT}");
            }
        }

        static void eliminarEmpresa() {

            bool empresaEliminada = repositorioEmpresa.Eliminar(7);

            if(empresaEliminada) {

                Console.WriteLine("Empresa eliminada correctamente");

            }
            else {

                Console.WriteLine("No se pudo eliminar la empresa");

            }
        }
    }
}
