﻿// <auto-generated />
using System;
using EVega.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EVega.Migrations
{
    [DbContext(typeof(EVegaContext))]
    partial class EVegaContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.29")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("EVega.Models.Carrera", b =>
                {
                    b.Property<int>("IdCarrera")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdCarrera"), 1L, 1);

                    b.Property<string>("Campus")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NombreCarrera")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NumeroSemestre")
                        .HasColumnType("int");

                    b.HasKey("IdCarrera");

                    b.ToTable("Carrera");
                });

            modelBuilder.Entity("EVega.Models.Estudiante", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CarreraIdCarrera")
                        .HasColumnType("int");

                    b.Property<bool>("Estado")
                        .HasColumnType("bit");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdCarrera")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Nota")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.HasIndex("CarreraIdCarrera");

                    b.ToTable("Estudiante");
                });

            modelBuilder.Entity("EVega.Models.Estudiante", b =>
                {
                    b.HasOne("EVega.Models.Carrera", "Carrera")
                        .WithMany()
                        .HasForeignKey("CarreraIdCarrera")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Carrera");
                });
#pragma warning restore 612, 618
        }
    }
}
