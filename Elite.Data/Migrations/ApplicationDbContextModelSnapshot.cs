﻿// <auto-generated />
using System;
using Elite.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Elite.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Elit.Model.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Apellidos")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Cedula")
                        .HasColumnType("nvarchar(11)");

                    b.Property<string>("Contacto")
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Correo")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Direccion")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("Id");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("Elit.Model.Detail", b =>
                {
                    b.Property<int>("Codigo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer: ValuesGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("ITBIS")
                        .HasColumnType("float");

                    b.Property<string>("Lavado")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Marca")
                        .HasColumnType("nvarchar(100)");

                    b.Property<Guid>("MasterId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Modelo")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Placa")
                        .HasColumnType("nvarchar(7)");

                    b.Property<double>("Precio")
                        .HasColumnType("float");

                    b.Property<double>("SubTotal")
                        .HasColumnType("float");

                    b.Property<string>("TVDescripcion")
                        .HasColumnType("nvarchar(100)");

                    b.Property<double>("Total")
                        .HasColumnType("float");

                    b.HasKey("Codigo");

                    b.HasIndex("MasterId");

                    b.ToTable("Details");
                });

            modelBuilder.Entity("Elit.Model.Empleado", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Apellidos")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Cedula")
                        .HasColumnType("nvarchar(11)");

                    b.Property<string>("Contacto")
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Direccion")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("Id");

                    b.ToTable("Empleados");
                });

            modelBuilder.Entity("Elit.Model.Marca", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Marcas");
                });

            modelBuilder.Entity("Elit.Model.Master", b =>
                {
                    b.Property<Guid>("Codigo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("ClienteId")
                        .HasColumnType("int");

                    b.Property<int>("EmpleadoId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("date");

                    b.Property<string>("NombreCliente")
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("NombreEmpleado")
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("Codigo");

                    b.HasIndex("ClienteId")
                        .IsUnique();

                    b.HasIndex("EmpleadoId")
                        .IsUnique();

                    b.ToTable("Masters");
                });

            modelBuilder.Entity("Elit.Model.Modelo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer: ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("MarcaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MarcaId");

                    b.ToTable("Modelos");
                });

            modelBuilder.Entity("Elit.Model.TipoLavado", b =>
                {
                    b.Property<int>("Codigo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer : ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(100)");

                    b.Property<int?>("DetailCodigo")
                        .HasColumnType("int");

                    b.Property<double>("Precio")
                        .HasColumnType("float");

                    b.HasKey("Codigo");

                    b.HasIndex("DetailCodigo");

                    b.ToTable("Lavados");
                });

            modelBuilder.Entity("Elit.Model.TipoVehiculo", b =>
                {
                    b.Property<int>("Codigo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer: ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.HasKey("Codigo");

                    b.ToTable("TipoVehiculos");
                });

            modelBuilder.Entity("Elit.Model.Vehiculo", b =>
                {
                    b.Property<string>("Placa")
                        .HasColumnType("nvarchar(7)");

                    b.Property<string>("DescripcionMarca")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("DescripcionModelo")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("DescripcionVehiculo")
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("DetailCodigo")
                        .HasColumnType("int");

                    b.Property<int>("MarcaId")
                        .HasColumnType("int");

                    b.Property<int>("TipoVehiculoId")
                        .HasColumnType("int");

                    b.HasKey("Placa");

                    b.HasIndex("DetailCodigo");

                    b.HasIndex("MarcaId");

                    b.HasIndex("TipoVehiculoId");

                    b.ToTable("Vehiculos");
                });

            modelBuilder.Entity("Elit.Model.Detail", b =>
                {
                    b.HasOne("Elit.Model.Master", "Master")
                        .WithMany("Details")
                        .HasForeignKey("MasterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Elit.Model.Master", b =>
                {
                    b.HasOne("Elit.Model.Cliente", "Cliente")
                        .WithOne("Master")
                        .HasForeignKey("Elit.Model.Master", "ClienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Elit.Model.Empleado", "Empleado")
                        .WithOne("Master")
                        .HasForeignKey("Elit.Model.Master", "EmpleadoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Elit.Model.Modelo", b =>
                {
                    b.HasOne("Elit.Model.Marca", "Marca")
                        .WithMany("Modelos")
                        .HasForeignKey("MarcaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Elit.Model.TipoLavado", b =>
                {
                    b.HasOne("Elit.Model.Detail", null)
                        .WithMany("Lavados")
                        .HasForeignKey("DetailCodigo");
                });

            modelBuilder.Entity("Elit.Model.Vehiculo", b =>
                {
                    b.HasOne("Elit.Model.Detail", null)
                        .WithMany("Vehiculos")
                        .HasForeignKey("DetailCodigo");

                    b.HasOne("Elit.Model.Marca", "Marca")
                        .WithMany("Vehiculos")
                        .HasForeignKey("MarcaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Elit.Model.TipoVehiculo", "TipoVehiculo")
                        .WithMany("Vehiculos")
                        .HasForeignKey("TipoVehiculoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
