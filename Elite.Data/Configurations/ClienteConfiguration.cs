using Elit.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Elite.Data.Configurations
{
    public class ClienteConfiguration : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.Property<int>("Id")
                  .ValueGeneratedOnAdd()
                  .HasColumnType("int")
                  .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            builder.HasKey("Id");

            builder.Property<string>("Nombre")
                .HasColumnType("nvarchar(30)");

            builder.Property<string>("Apellidos")
                .HasColumnType("nvarchar(50)");

            builder.Property<string>("Cedula")
                .HasColumnType("nvarchar(11)");

            builder.Property<string>("Direccion")
                .HasColumnType("nvarchar(100)");

            builder.Property<string>("Contacto")
                .HasColumnType("nvarchar(10)");

            builder.Property<string>("Correo")
                .HasColumnType("nvarchar(100)");
        }
    }
}
