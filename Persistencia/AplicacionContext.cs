using System;
using Microsoft.EntityFrameworkCore;
using Dominio;

namespace Persistencia
{
    public class AplicacionContext : DbContext
    {
        public DbSet<Empresa> Empresa { get; set; }
        public DbSet<Empleado> Empleado { get; set; }
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Directivo> Directivo { get; set; }
        
        private const string cadenaConexion = @"Data Source=localhost\sqlexpress; Initial Catalog = Empresa; Integrated Security = True";
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(cadenaConexion);
            }
        }

    }
}