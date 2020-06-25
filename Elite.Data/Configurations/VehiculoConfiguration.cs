using Elit.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Elite.Data.Configurations
{
    public class VehiculoConfiguration : IEntityTypeConfiguration<Vehiculo>
    {
        public void Configure(EntityTypeBuilder<Vehiculo> builder)
        {
            builder.Property<string>("Placa")
               .HasColumnType("nvarchar(7)");

            builder.HasKey("Placa");

            builder.Property<string>("DescripcionMarca")
                .HasColumnType("nvarchar(100)");

            builder.Property<string>("DescripcionModelo")
                .HasColumnType("nvarchar(100)");

            builder.Property<string>("DescripcionVehiculo")
                .HasColumnType("nvarchar(50)");
        }
    }
}
