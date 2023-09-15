﻿// <auto-generated />
using System;
using GoNavals.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GoNavals.Domain.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("GoNavals.Domain.Ciudad", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PaisId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PaisId");

                    b.ToTable("Ciudad");
                });

            modelBuilder.Entity("GoNavals.Domain.Color", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Color");
                });

            modelBuilder.Entity("GoNavals.Domain.Comandancia", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<long>("Celular")
                        .HasColumnType("bigint");

                    b.Property<int>("CiudadId")
                        .HasColumnType("int");

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Direccion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("Telefono1")
                        .HasColumnType("bigint");

                    b.Property<long>("Telefono2")
                        .HasColumnType("bigint");

                    b.Property<int>("ZonaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CiudadId");

                    b.HasIndex("ZonaId");

                    b.ToTable("Comandancia");
                });

            modelBuilder.Entity("GoNavals.Domain.Comandante", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Apellidos")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RangoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RangoId");

                    b.ToTable("Comandante");
                });

            modelBuilder.Entity("GoNavals.Domain.ComandanteComandancia", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ComandanciaId")
                        .HasColumnType("int");

                    b.Property<int>("ComandanteId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ComandanciaId");

                    b.HasIndex("ComandanteId");

                    b.ToTable("ComandanteComandancia");
                });

            modelBuilder.Entity("GoNavals.Domain.Constructora", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Celular")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Direccion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PaisId")
                        .HasColumnType("int");

                    b.Property<string>("RNC")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefono1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefono2")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("PaisId");

                    b.ToTable("Constructora");
                });

            modelBuilder.Entity("GoNavals.Domain.Curso", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Origen")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TipoCurso")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Curso");
                });

            modelBuilder.Entity("GoNavals.Domain.Embarcacion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Embarcacion");
                });

            modelBuilder.Entity("GoNavals.Domain.Ocupacion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Ocupacion");
                });

            modelBuilder.Entity("GoNavals.Domain.Pais", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Pais");
                });

            modelBuilder.Entity("GoNavals.Domain.Propietario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Apellidos")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cedula_Pasaporte")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("Celular")
                        .HasColumnType("bigint");

                    b.Property<string>("Direccion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PaisId")
                        .HasColumnType("int");

                    b.Property<long>("Telefono")
                        .HasColumnType("bigint");

                    b.Property<int>("Zip")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PaisId");

                    b.ToTable("Propietario");
                });

            modelBuilder.Entity("GoNavals.Domain.Puerto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<long>("Celular")
                        .HasColumnType("bigint");

                    b.Property<int>("CiudadId")
                        .HasColumnType("int");

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Direccion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("Telefono1")
                        .HasColumnType("bigint");

                    b.Property<long>("Telefono2")
                        .HasColumnType("bigint");

                    b.Property<int>("ZonaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CiudadId");

                    b.HasIndex("ZonaId");

                    b.ToTable("Puerto");
                });

            modelBuilder.Entity("GoNavals.Domain.Rango", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Rango");
                });

            modelBuilder.Entity("GoNavals.Domain.TipoUso", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TipoUso");
                });

            modelBuilder.Entity("GoNavals.Domain.Zona", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Zona");
                });

            modelBuilder.Entity("GoNavals.Domain.Ciudad", b =>
                {
                    b.HasOne("GoNavals.Domain.Pais", "Pais")
                        .WithMany("Ciudades")
                        .HasForeignKey("PaisId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pais");
                });

            modelBuilder.Entity("GoNavals.Domain.Comandancia", b =>
                {
                    b.HasOne("GoNavals.Domain.Ciudad", "Ciudad")
                        .WithMany()
                        .HasForeignKey("CiudadId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GoNavals.Domain.Zona", "Zona")
                        .WithMany("Comandancias")
                        .HasForeignKey("ZonaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ciudad");

                    b.Navigation("Zona");
                });

            modelBuilder.Entity("GoNavals.Domain.Comandante", b =>
                {
                    b.HasOne("GoNavals.Domain.Rango", "Rango")
                        .WithMany("Comandante")
                        .HasForeignKey("RangoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Rango");
                });

            modelBuilder.Entity("GoNavals.Domain.ComandanteComandancia", b =>
                {
                    b.HasOne("GoNavals.Domain.Comandancia", "Comandancia")
                        .WithMany("ComandanteComandancias")
                        .HasForeignKey("ComandanciaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GoNavals.Domain.Comandante", "Comandante")
                        .WithMany("ComandanteComandancias")
                        .HasForeignKey("ComandanteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Comandancia");

                    b.Navigation("Comandante");
                });

            modelBuilder.Entity("GoNavals.Domain.Constructora", b =>
                {
                    b.HasOne("GoNavals.Domain.Pais", "Pais")
                        .WithMany()
                        .HasForeignKey("PaisId");

                    b.Navigation("Pais");
                });

            modelBuilder.Entity("GoNavals.Domain.Propietario", b =>
                {
                    b.HasOne("GoNavals.Domain.Pais", "Pais")
                        .WithMany()
                        .HasForeignKey("PaisId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pais");
                });

            modelBuilder.Entity("GoNavals.Domain.Puerto", b =>
                {
                    b.HasOne("GoNavals.Domain.Ciudad", "Ciudad")
                        .WithMany()
                        .HasForeignKey("CiudadId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GoNavals.Domain.Zona", "Zona")
                        .WithMany("Puertos")
                        .HasForeignKey("ZonaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ciudad");

                    b.Navigation("Zona");
                });

            modelBuilder.Entity("GoNavals.Domain.Comandancia", b =>
                {
                    b.Navigation("ComandanteComandancias");
                });

            modelBuilder.Entity("GoNavals.Domain.Comandante", b =>
                {
                    b.Navigation("ComandanteComandancias");
                });

            modelBuilder.Entity("GoNavals.Domain.Pais", b =>
                {
                    b.Navigation("Ciudades");
                });

            modelBuilder.Entity("GoNavals.Domain.Rango", b =>
                {
                    b.Navigation("Comandante");
                });

            modelBuilder.Entity("GoNavals.Domain.Zona", b =>
                {
                    b.Navigation("Comandancias");

                    b.Navigation("Puertos");
                });
#pragma warning restore 612, 618
        }
    }
}
