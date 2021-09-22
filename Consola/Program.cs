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
        private static IRepositorioCliente repositorioCliente = new RepositorioCliente(new AplicacionContext());
        
        static void Main(string[] args)
        {
            //CRUD Entidad Empresa

            //crearEmpresa();
            //actualizarEmpresa();
            //obtenerEmpresa();
            //obtenerEmpresas();
            //eliminarEmpresa();

            //CRUD Entidad Cliente

            //crearCliente();
            //actualizarCliente();
            //obtenerCliente();
            //obtenerClientes();
            //obtenerClientesPorEmpresa();
            //eliminarCliente();

        }

        static void crearEmpresa() {

            Empresa empresa = new Empresa(){
                Nombre = "Metalicas Alvarado S.A.",
                NIT = "96856325236"
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

            bool empresaEliminada = repositorioEmpresa.Eliminar(1);

            if(empresaEliminada) {

                Console.WriteLine("Empresa eliminada correctamente");

            }
            else {

                Console.WriteLine("No se pudo eliminar la empresa");

            }
        }

        static void crearCliente() {

            Cliente cliente = new Cliente(){
                Nombre = "Daniela Alejandra Gómez Rodríguez",
                Fecha_Nacimiento = new DateTime(1989,8,15),
                Telefono = "3185296665",
                IdEmpresa = 3
            };

            Cliente clienteCreado = repositorioCliente.Crear(cliente);

            if(clienteCreado != null){
                Console.WriteLine("Cliente creado correctamente");
            }
            else {
                Console.WriteLine("No se pudo crear el cliente");
            }
        }

        static void actualizarCliente() {

            Cliente cliente = new Cliente(){
                Id = 5,
                Nombre = "Daniela Alejandra Gómez Rodríguez",
                Fecha_Nacimiento = new DateTime(1989,8,15),
                Telefono = "3185296665",
                IdEmpresa = 3
            };

            Cliente clienteActualizado = repositorioCliente.Actualizar(cliente);

            if(clienteActualizado != null){
                Console.WriteLine("Cliente actualizado correctamente");
            }
            else {
                Console.WriteLine("No se pudo actualizar el cliente");
            }
        }

        static void obtenerCliente() {

            Cliente clienteEncontrado = repositorioCliente.ObtenerPorId(3);

            if(clienteEncontrado != null){
                Console.WriteLine($"Cliente {clienteEncontrado.Nombre} encontrado");
            }
            else {
                Console.WriteLine("No se pudo encontrar el cliente");
            }

        }

        static void obtenerClientes() {

            IEnumerable<Cliente> clientesEncontrados = repositorioCliente.Obtener();

            foreach (var cliente in clientesEncontrados)
            {
                Console.WriteLine($"{cliente.Id} - {cliente.Nombre} - {cliente.Fecha_Nacimiento} - {cliente.Telefono} - {cliente.IdEmpresa}");
            }

        }

        static void obtenerClientesPorEmpresa() {

            IEnumerable<Cliente> clientesEncontrados = repositorioCliente.ObtenerPorIdEmpresa(3);

            foreach (var cliente in clientesEncontrados)
            {
                Console.WriteLine($"{cliente.Id} - {cliente.Nombre} - {cliente.Fecha_Nacimiento} - {cliente.Telefono} - {cliente.IdEmpresa}");
            }

        }

        static void eliminarCliente() {

            bool clienteEliminado = repositorioCliente.Eliminar(7);

            if(clienteEliminado) {

                Console.WriteLine("Cliente eliminado correctamente");

            }
            else {

                Console.WriteLine("No se pudo eliminar el cliente");

            }
        }
    }
}
