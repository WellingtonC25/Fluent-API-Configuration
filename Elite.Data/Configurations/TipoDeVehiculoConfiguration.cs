using Elit.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Elite.Data.Configurations
{
    public class TipoDeVehiculoConfiguration : IEntityTypeConfiguration<TipoVehiculo>
    {
        public void Configure(EntityTypeBuilder<TipoVehiculo> builder)
        {
            builder.Property<int>("Codigo")
                .ValueGeneratedOnAdd()
                .HasColumnType("int")
                .HasAnnotation("SqlServer: ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            builder.HasKey("Codigo");

            builder.Property<string>("Descripcion")
                .HasColumnType("nvarchar(100)");
        }
    }
}
