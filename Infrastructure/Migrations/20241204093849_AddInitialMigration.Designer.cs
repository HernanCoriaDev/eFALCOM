﻿// <auto-generated />
using System;
using Infrastructure.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Infrastructure.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20241204093849_AddInitialMigration")]
    partial class AddInitialMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Domain.Entities.DepositoEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CapacidadOcupada")
                        .HasColumnType("int");

                    b.Property<int>("CapacidadTotal")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Deposito");
                });

            modelBuilder.Entity("Domain.Entities.PalletEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CodigoProducto")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaIngreso")
                        .HasColumnType("datetime2");

                    b.Property<int>("UbicacionId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UbicacionId");

                    b.ToTable("Pallet");
                });

            modelBuilder.Entity("Domain.Entities.StockMovimientoEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CodigoProducto")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaMovimiento")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("PalletId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("TipoMovimiento")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UbicacionId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UbicacionId");

                    b.ToTable("StockMovimiento");
                });

            modelBuilder.Entity("Domain.Entities.UbicacionEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Columna")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("DepositoEntityId")
                        .HasColumnType("int");

                    b.Property<string>("Fila")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Ocupada")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("DepositoEntityId");

                    b.ToTable("Ubicacion");
                });

            modelBuilder.Entity("Domain.Entities.PalletEntity", b =>
                {
                    b.HasOne("Domain.Entities.UbicacionEntity", "Ubicacion")
                        .WithMany()
                        .HasForeignKey("UbicacionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ubicacion");
                });

            modelBuilder.Entity("Domain.Entities.StockMovimientoEntity", b =>
                {
                    b.HasOne("Domain.Entities.UbicacionEntity", "Ubicacion")
                        .WithMany()
                        .HasForeignKey("UbicacionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ubicacion");
                });

            modelBuilder.Entity("Domain.Entities.UbicacionEntity", b =>
                {
                    b.HasOne("Domain.Entities.DepositoEntity", null)
                        .WithMany("Ubicaciones")
                        .HasForeignKey("DepositoEntityId");
                });

            modelBuilder.Entity("Domain.Entities.DepositoEntity", b =>
                {
                    b.Navigation("Ubicaciones");
                });
#pragma warning restore 612, 618
        }
    }
}