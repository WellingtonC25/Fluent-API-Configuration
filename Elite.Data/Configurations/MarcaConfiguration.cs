using Elit.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Elite.Data.Configurations
{
    public class MarcaConfiguration : IEntityTypeConfiguration<Marca>

    {
        public void Configure(EntityTypeBuilder<Marca> builder)
        {
            builder.Property<int>("Id")
                .ValueGeneratedOnAdd()
                .HasColumnType("int")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            builder.HasKey("Id");

            builder.Property<string>("Descripcion")
                .HasColumnType("nvarchar(100)");
        }
    }
}
