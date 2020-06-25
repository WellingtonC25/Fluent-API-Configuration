using Elit.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Elite.Data.Configurations
{
    public class TipoLavadoConfiguration : IEntityTypeConfiguration<TipoLavado>
    {
        public void Configure(EntityTypeBuilder<TipoLavado> builder)
        {
            builder.Property<int>("Codigo")
                .ValueGeneratedOnAdd()
                .HasColumnType("int")
                .HasAnnotation("SqlServer : ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            builder.HasKey("Codigo");

            builder.Property<string>("Descripcion")
                .HasColumnType("nvarchar(100)");

            builder.Property<double>("Precio")
                .HasColumnType("float");
        }
    }
}
