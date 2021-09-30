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
        private static IRepositorioDirectivo repositorioDirectivo = new RepositorioDirectivo(new AplicacionContext());
        private static IRepositorioEmpleado repositorioEmpleado = new RepositorioEmpleado(new AplicacionContext());
        
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

            //CRUD Entidad Directivo

            //crearDirectivo();
            //actualizarDirectivo();
            //obtenerDirectivo();
            //obtenerDirectivos();
            //obtenerDirectivosPorEmpresa();
            //eliminarDirectivo();

            //CRUD Entidad Empleado
            //crearEmpleado();
            //actualizarEmpleado();
            //obtenerEmpleado();
            //obtenerEmpleados();
            //obtenerEmpleadosPorEmpresa();
            //obtenerEmpleadosPorDirectivo();
            //eliminarEmpleado();

        }

        static void crearEmpresa() {

            Empresa empresa = new Empresa(){
                Nombre = "Carpintería Robledo S.A.",
                NIT = "985632563252"
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

            bool empresaEliminada = repositorioEmpresa.Eliminar(3);

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

            Cliente clienteEncontrado = repositorioCliente.ObtenerPorId(5);

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

        static void crearDirectivo() {

            Directivo directivo = new Directivo(){
                Nombre = "David José Manrique Perez",
                Fecha_Nacimiento = new DateTime(1992,7,11),
                Sueldo_Bruto = 2500000,
                Categoria = 2,
                IdEmpresa = 4
            };

            Directivo directivoCreado = repositorioDirectivo.Crear(directivo);

            if(directivoCreado != null){
                Console.WriteLine("Directivo creado correctamente");
            }
            else {
                Console.WriteLine("No se pudo crear el directivo");
            }

        }

        static void actualizarDirectivo() {

            Directivo directivo = new Directivo(){
                Id = 1,
                Nombre = "Manuel Alejandro Llanes Gómez",
                Fecha_Nacimiento = new DateTime(1995,11,8),
                Sueldo_Bruto = 2800000,
                Categoria = 1,
                IdEmpresa = 3
            };

            Directivo directivoActualizado = repositorioDirectivo.Actualizar(directivo);

            if(directivoActualizado != null){
                Console.WriteLine("Directivo actualizado correctamente");
            }
            else {
                Console.WriteLine("No se pudo actualizar el directivo");
            }

        }

        static void obtenerDirectivo() {

            Directivo directivoEncontrado = repositorioDirectivo.ObtenerPorId(2);

            if(directivoEncontrado != null){
                Console.WriteLine($"Directivo {directivoEncontrado.Nombre} encontrado");
            }
            else {
                Console.WriteLine("No se pudo encontrar el directivo");
            }
        }

        static void obtenerDirectivos() {

            IEnumerable<Directivo> directivosEncontrados = repositorioDirectivo.Obtener();

            foreach (var directivo in directivosEncontrados)
            {
                Console.WriteLine($"{directivo.Id} - {directivo.Nombre} - {directivo.Fecha_Nacimiento} - {directivo.Sueldo_Bruto} - {directivo.Categoria} - {directivo.IdEmpresa}");
            }
        }

        static void obtenerDirectivosPorEmpresa() {

            IEnumerable<Directivo> directivosEncontrados = repositorioDirectivo.ObtenerPorIdEmpresa(1);

            foreach (var directivo in directivosEncontrados)
            {
                Console.WriteLine($"{directivo.Id} - {directivo.Nombre} - {directivo.Fecha_Nacimiento} - {directivo.Sueldo_Bruto} - {directivo.Categoria} - {directivo.IdEmpresa}");
            }

        }

        static void eliminarDirectivo() {

            bool directivoEliminado = repositorioDirectivo.Eliminar(4);

            if(directivoEliminado) {

                Console.WriteLine("Directivo eliminado correctamente");

            }
            else {

                Console.WriteLine("No se pudo eliminar el directivo");

            }

        }

        static void crearEmpleado() {

            Empleado empleado = new Empleado(){
                Nombre = "Daniela Gómez Alvarez",
                Fecha_Nacimiento = new DateTime(1991,10,18),
                Sueldo_Bruto = 1800000,
                IdDirectivo = 4,
                IdEmpresa = 1
            };

            Empleado empleadoCreado = repositorioEmpleado.Crear(empleado);

            if(empleadoCreado != null){
                Console.WriteLine("Empleado creado correctamente");
            }
            else {
                Console.WriteLine("No se pudo crear el empleado");
            }
        }

        static void actualizarEmpleado() {

            Empleado empleado = new Empleado(){
                Id = 1,
                Nombre = "David Alejandro Alvarez Gómez",
                Fecha_Nacimiento = new DateTime(1996,8,5),
                Sueldo_Bruto = 1900000,
                IdDirectivo = 1,
                IdEmpresa = 3
            };

            Empleado empleadoActualizado = repositorioEmpleado.Actualizar(empleado);

            if(empleadoActualizado != null){
                Console.WriteLine("Empleado actualizado correctamente");
            }
            else {
                Console.WriteLine("No se pudo actualizar el empleado");
            }
        }

        static void obtenerEmpleado() {

            Empleado empleadoEncontrado = repositorioEmpleado.ObtenerPorId(2);

            if(empleadoEncontrado != null){
                Console.WriteLine($"Empleado {empleadoEncontrado.Nombre} encontrado");
            }
            else {
                Console.WriteLine("No se pudo encontrar el empleado");
            }
        }

        static void obtenerEmpleados() {

            IEnumerable<Empleado> empleadosEncontrados = repositorioEmpleado.Obtener();

            foreach (var empleado in empleadosEncontrados)
            {
                Console.WriteLine($"{empleado.Id} - {empleado.Nombre} - {empleado.Fecha_Nacimiento} - {empleado.Sueldo_Bruto} - {empleado.IdDirectivo} - {empleado.IdEmpresa}");
            }
        }

        static void obtenerEmpleadosPorEmpresa() {

            IEnumerable<Empleado> empleadosEncontrados = repositorioEmpleado.ObtenerPorIdEmpresa(1);

            foreach (var empleado in empleadosEncontrados)
            {
                Console.WriteLine($"{empleado.Id} - {empleado.Nombre} - {empleado.Fecha_Nacimiento} - {empleado.Sueldo_Bruto} - {empleado.IdDirectivo} - {empleado.IdEmpresa}");
            }
        }

        static void obtenerEmpleadosPorDirectivo() {

            IEnumerable<Empleado> empleadosEncontrados = repositorioEmpleado.ObtenerPorIdDirectivo(4);

            foreach (var empleado in empleadosEncontrados)
            {
                Console.WriteLine($"{empleado.Id} - {empleado.Nombre} - {empleado.Fecha_Nacimiento} - {empleado.Sueldo_Bruto} - {empleado.IdDirectivo} - {empleado.IdEmpresa}");
            }
        }

        static void eliminarEmpleado() {

            bool empleadoEliminado = repositorioEmpleado.Eliminar(5);

            if(empleadoEliminado) {

                Console.WriteLine("Empleado eliminado correctamente");

            }
            else {

                Console.WriteLine("No se pudo eliminar el empleado");

            }
        }
    }
}
