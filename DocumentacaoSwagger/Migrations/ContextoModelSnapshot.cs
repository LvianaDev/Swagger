﻿// <auto-generated />
using DocumentacaoSwagger.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DocumentacaoSwagger.Migrations
{
    [DbContext(typeof(Contexto))]
    partial class ContextoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.13")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DocumentacaoSwagger.Models.Aviao", b =>
                {
                    b.Property<int>("AviaoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NomeAviao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NomeProdutor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("QtdPassageiros")
                        .HasColumnType("int");

                    b.HasKey("AviaoId");

                    b.ToTable("Avioes");
                });
#pragma warning restore 612, 618
        }
    }
}