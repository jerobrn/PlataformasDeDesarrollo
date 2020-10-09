﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Parcial;

namespace Parcial.Migrations
{
    [DbContext(typeof(DBCon))]
    [Migration("20201008205027_inicial")]
    partial class inicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8");

            modelBuilder.Entity("Parcial.Detalle", b =>
                {
                    b.Property<int>("IDDetalle")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("TEXT");

                    b.Property<int?>("RecursoIDRecurso")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Tiempo")
                        .HasColumnType("TEXT");

                    b.HasKey("IDDetalle");

                    b.HasIndex("RecursoIDRecurso");

                    b.ToTable("Detalle");
                });

            modelBuilder.Entity("Parcial.Recurso", b =>
                {
                    b.Property<int>("IDRecurso")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nombre")
                        .HasColumnType("TEXT");

                    b.Property<int?>("UsuarioIDUser")
                        .HasColumnType("INTEGER");

                    b.HasKey("IDRecurso");

                    b.HasIndex("UsuarioIDUser");

                    b.ToTable("Recurso");
                });

            modelBuilder.Entity("Parcial.Tarea", b =>
                {
                    b.Property<int>("IDTarea")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Estimacion")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Responsable")
                        .HasColumnType("TEXT");

                    b.Property<bool>("String")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Titulo")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Vencimiento")
                        .HasColumnType("TEXT");

                    b.HasKey("IDTarea");

                    b.ToTable("Tarea");
                });

            modelBuilder.Entity("Parcial.Usuario", b =>
                {
                    b.Property<int>("IDUser")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Clave")
                        .HasColumnType("TEXT");

                    b.Property<string>("User")
                        .HasColumnType("TEXT");

                    b.HasKey("IDUser");

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("Parcial.Detalle", b =>
                {
                    b.HasOne("Parcial.Recurso", "Recurso")
                        .WithMany()
                        .HasForeignKey("RecursoIDRecurso");
                });

            modelBuilder.Entity("Parcial.Recurso", b =>
                {
                    b.HasOne("Parcial.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioIDUser");
                });
#pragma warning restore 612, 618
        }
    }
}
