using Elit.Model;
using Elite.Data.Configurations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;

namespace Elite.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
           : base(options)
        {

        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Empleado> Empleados { get; set; }
        public DbSet<Marca> Marcas { get; set; }
        public DbSet<Modelo> Modelos { get; set; }
        public DbSet<Master> Masters { get; set; }
        public DbSet<Detail> Details { get; set; }
        public DbSet<TipoLavado> Lavados { get; set; }
        public DbSet<TipoVehiculo> TipoVehiculos { get; set; }
        public DbSet<Vehiculo> Vehiculos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ClienteConfiguration());
            modelBuilder.ApplyConfiguration(new DetailConfiguration());
            modelBuilder.ApplyConfiguration(new EmpleadoConfiguration());
            modelBuilder.ApplyConfiguration(new MarcaConfiguration());
            modelBuilder.ApplyConfiguration(new MasterConfiguration());
            modelBuilder.ApplyConfiguration(new ModeloConfiguration());
            modelBuilder.ApplyConfiguration(new TipoDeVehiculoConfiguration());
            modelBuilder.ApplyConfiguration(new TipoLavadoConfiguration());
            modelBuilder.ApplyConfiguration(new VehiculoConfiguration());

            #region Relaciones de Marca
             modelBuilder.Entity<Marca>()
             .HasMany(p => p.Modelos)
             .WithOne(p => p.Marca)
             .OnDelete(DeleteBehavior.Cascade);
            #endregion

            #region Relaciones de Master 

            modelBuilder.Entity<Master>()
           .HasOne(c => c.Cliente)
           .WithOne(e => e.Master)
           .HasForeignKey<Master>(b => b.ClienteId)
           .OnDelete(DeleteBehavior.Cascade) ;

            modelBuilder.Entity<Master>()
           .HasOne(c => c.Empleado)
           .WithOne(e => e.Master)
           .HasForeignKey<Master>(b => b.EmpleadoId)
            .OnDelete(DeleteBehavior.Cascade);
            #endregion

            #region Relaciones de Vehiculos

             modelBuilder.Entity<Vehiculo>()
             .HasOne(p => p.Marca)
             .WithMany(p => p.Vehiculos)
             .OnDelete(DeleteBehavior.Cascade);

             modelBuilder.Entity<Vehiculo>()
               .HasOne(p => p.TipoVehiculo)
               .WithMany(p => p.Vehiculos)
               .OnDelete(DeleteBehavior.Cascade);

            #endregion

            #region Relaciones de Detalles

            modelBuilder.Entity<Detail>()
            .HasOne(p => p.Master)
            .WithMany(p => p.Details)
            .OnDelete(DeleteBehavior.Cascade);

            #endregion
        }
    }
}
