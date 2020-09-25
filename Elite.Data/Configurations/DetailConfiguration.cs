using Elit.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Elite.Data.Configurations
{
    public class DetailConfiguration : IEntityTypeConfiguration<Detail>
    {
        public void Configure(EntityTypeBuilder<Detail> builder)
        {
            builder.Property<int>("Codigo")
                .ValueGeneratedOnAdd()
                .HasColumnType("int")
                .HasAnnotation("SqlServer: ValuesGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            builder.HasKey("Codigo");

            builder.Property<Guid>("MasterId")
                .HasColumnType("uniqueidentifier");

            builder.Property<string>("Placa")
                .HasColumnType("nvarchar(7)");

            builder.Property<string>("Marca")
                .HasColumnType("nvarchar(100)");

            builder.Property<string>("Modelo")
                .HasColumnType("nvarchar(100)");

            builder.Property<string>("TVDescripcion")
                .HasColumnType("nvarchar(100)");

            builder.Property<string>("Lavado")
                .HasColumnType("nvarchar(100)");

            builder.Property<double>("Precio")
                .HasColumnType("float");

            builder.Property<double>("SubTotal")
                .HasColumnType("float");

            builder.Property<double>("ITBIS")
                .HasColumnType("float");

            builder.Property<double>("Total")
                .HasColumnType("float");

            builder.HasOne(p => p.Master)
            .WithMany(p => p.Details)
            .HasForeignKey(p => p.MasterId)
            .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
