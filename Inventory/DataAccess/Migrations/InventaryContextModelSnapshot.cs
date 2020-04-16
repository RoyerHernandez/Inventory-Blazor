﻿// <auto-generated />
using System;
using DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DataAccess.Migrations
{
    [DbContext(typeof(InventaryContext))]
    partial class InventaryContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Entities.CategoryEntity", b =>
                {
                    b.Property<string>("categoryId")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("categoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("categoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            categoryId = "MD",
                            categoryName = "Medicamentos"
                        },
                        new
                        {
                            categoryId = "JB",
                            categoryName = "Jabones"
                        },
                        new
                        {
                            categoryId = "BT",
                            categoryName = "Boticario"
                        },
                        new
                        {
                            categoryId = "PB",
                            categoryName = "Productos Bucales"
                        },
                        new
                        {
                            categoryId = "AS",
                            categoryName = "Aseo Personal"
                        });
                });

            modelBuilder.Entity("Entities.InOutEntity", b =>
                {
                    b.Property<string>("inOutsID")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<DateTime>("InOutDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsInput")
                        .HasColumnType("bit");

                    b.Property<int>("Quality")
                        .HasColumnType("int");

                    b.Property<string>("storageId")
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("inOutsID");

                    b.HasIndex("storageId");

                    b.ToTable("InOuts");
                });

            modelBuilder.Entity("Entities.ProductEntity", b =>
                {
                    b.Property<string>("productId")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("WarehouseEntitywarehouseId")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("categoryId")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("productDesciption")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("productName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("totalQuantity")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("productId");

                    b.HasIndex("WarehouseEntitywarehouseId");

                    b.HasIndex("categoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            productId = "ASJ-98745",
                            categoryId = "MD",
                            productDesciption = "",
                            productName = "Medicamento",
                            totalQuantity = 0m
                        },
                        new
                        {
                            productId = "RPT-5465879",
                            categoryId = "BT",
                            productDesciption = "",
                            productName = "Boticario",
                            totalQuantity = 0m
                        });
                });

            modelBuilder.Entity("Entities.StorageEntity", b =>
                {
                    b.Property<string>("storageId")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<DateTime>("LastUpdate")
                        .HasColumnType("datetime2");

                    b.Property<int>("partialQuantity")
                        .HasColumnType("int");

                    b.Property<string>("productId")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("warehouseId")
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("storageId");

                    b.HasIndex("productId");

                    b.HasIndex("warehouseId");

                    b.ToTable("Storages");
                });

            modelBuilder.Entity("Entities.WarehouseEntity", b =>
                {
                    b.Property<string>("warehouseId")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("WarehouseEntitywarehouseId")
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("warehouseAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("warehouseName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("warehouseId");

                    b.HasIndex("WarehouseEntitywarehouseId");

                    b.ToTable("Warehouses");

                    b.HasData(
                        new
                        {
                            warehouseId = "b91dd517-698e-4d4e-a1a3-1d08ad20b49f",
                            warehouseAddress = "Calle 8 con 23",
                            warehouseName = "Bodega Central"
                        },
                        new
                        {
                            warehouseId = "58a3d9f7-372b-4571-8b85-f8af5f9683be",
                            warehouseAddress = "Calle norte con occidente",
                            warehouseName = "Bodega Norte"
                        });
                });

            modelBuilder.Entity("Entities.InOutEntity", b =>
                {
                    b.HasOne("Entities.StorageEntity", "Storage")
                        .WithMany("InOuts")
                        .HasForeignKey("storageId");
                });

            modelBuilder.Entity("Entities.ProductEntity", b =>
                {
                    b.HasOne("Entities.WarehouseEntity", null)
                        .WithMany("Products")
                        .HasForeignKey("WarehouseEntitywarehouseId");

                    b.HasOne("Entities.CategoryEntity", "Category")
                        .WithMany("Products")
                        .HasForeignKey("categoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Entities.StorageEntity", b =>
                {
                    b.HasOne("Entities.ProductEntity", "Product")
                        .WithMany("Storages")
                        .HasForeignKey("productId");

                    b.HasOne("Entities.WarehouseEntity", "warehouse")
                        .WithMany()
                        .HasForeignKey("warehouseId");
                });

            modelBuilder.Entity("Entities.WarehouseEntity", b =>
                {
                    b.HasOne("Entities.WarehouseEntity", null)
                        .WithMany("Warehouses")
                        .HasForeignKey("WarehouseEntitywarehouseId");
                });
#pragma warning restore 612, 618
        }
    }
}
