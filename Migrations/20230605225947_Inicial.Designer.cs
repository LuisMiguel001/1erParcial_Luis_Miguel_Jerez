﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using _1erParcial_Luis_Miguel_Jerez.DAL;

#nullable disable

namespace _1erParcial_Luis_Miguel_Jerez.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20230605225947_Inicial")]
    partial class Inicial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.5");

            modelBuilder.Entity("_1erParcial_Luis_Miguel_Jerez.Models.Ingresos", b =>
                {
                    b.Property<int>("IngresosId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Concepto")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Monto")
                        .HasColumnType("TEXT");

                    b.HasKey("IngresosId");

                    b.ToTable("Ingresos");
                });
#pragma warning restore 612, 618
        }
    }
}
