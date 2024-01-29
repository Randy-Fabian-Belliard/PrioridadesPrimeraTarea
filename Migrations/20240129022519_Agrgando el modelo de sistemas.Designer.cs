﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PrioridadesPrimeraTarea.DAL;

#nullable disable

namespace PrioridadesPrimeraTarea.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20240129022519_Agrgando el modelo de sistemas")]
    partial class Agrgandoelmodelodesistemas
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.1");

            modelBuilder.Entity("PrioridadesPrimeraTarea.Models.Clientes", b =>
                {
                    b.Property<int>("ClienteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Celular")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nombres")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Rnc")
                        .HasColumnType("TEXT");

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("ClienteId");

                    b.ToTable("clientes");
                });

            modelBuilder.Entity("PrioridadesPrimeraTarea.Models.Prioridades", b =>
                {
                    b.Property<int>("PrioridadId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("DiasCompromiso")
                        .HasColumnType("INTEGER");

                    b.HasKey("PrioridadId");

                    b.ToTable("Prioridades");
                });

            modelBuilder.Entity("PrioridadesPrimeraTarea.Models.Sistemas", b =>
                {
                    b.Property<int>("SistemaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("SistemaId");

                    b.ToTable("Sistemas");
                });

            modelBuilder.Entity("PrioridadesPrimeraTarea.Models.Tickets", b =>
                {
                    b.Property<int>("TicketId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("ClienteId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("TEXT");

                    b.Property<int>("PrioridadId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("SistemaId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("Sistemas")
                        .HasColumnType("INTEGER");

                    b.Property<string>("SolicitadoPor")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Sunto")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("TicketId");

                    b.HasIndex("ClienteId");

                    b.HasIndex("PrioridadId");

                    b.HasIndex("Sistemas");

                    b.ToTable("Tickets");
                });

            modelBuilder.Entity("PrioridadesPrimeraTarea.Models.Tickets", b =>
                {
                    b.HasOne("PrioridadesPrimeraTarea.Models.Clientes", null)
                        .WithMany("Tickets")
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PrioridadesPrimeraTarea.Models.Prioridades", null)
                        .WithMany("Tickets")
                        .HasForeignKey("PrioridadId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PrioridadesPrimeraTarea.Models.Sistemas", null)
                        .WithMany("Tickets")
                        .HasForeignKey("Sistemas");
                });

            modelBuilder.Entity("PrioridadesPrimeraTarea.Models.Clientes", b =>
                {
                    b.Navigation("Tickets");
                });

            modelBuilder.Entity("PrioridadesPrimeraTarea.Models.Prioridades", b =>
                {
                    b.Navigation("Tickets");
                });

            modelBuilder.Entity("PrioridadesPrimeraTarea.Models.Sistemas", b =>
                {
                    b.Navigation("Tickets");
                });
#pragma warning restore 612, 618
        }
    }
}
