using Elit.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Elite.Data.Configurations
{
    public class MasterConfiguration : IEntityTypeConfiguration<Master>
    {
        public void Configure(EntityTypeBuilder<Master> builder)
        {
            builder.Property<Guid>("Codigo")
                .ValueGeneratedOnAdd()
                .HasColumnType("uniqueidentifier");

            builder.HasKey("Codigo");

            builder.Property<DateTime>("Fecha")
                .HasColumnType("date");

            builder.Property<string>("NombreCliente")
                .HasColumnType("nvarchar(30)");

            builder.Property<string>("NombreEmpleado")
                .HasColumnType("nvarchar(30)");

            builder.HasOne(x => x.Cliente).WithOne(m => m.Master)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(x => x.Empleado).WithOne(m => m.Master)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
