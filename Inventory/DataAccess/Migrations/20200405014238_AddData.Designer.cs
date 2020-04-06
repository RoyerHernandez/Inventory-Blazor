﻿// <auto-generated />
using System;
using DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DataAccess.Migrations
{
    [DbContext(typeof(InventaryContext))]
    [Migration("20200405014238_AddData")]
    partial class AddData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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
                            categoryId = "JS",
                            categoryName = "Juguetes Sexuales"
                        },
                        new
                        {
                            categoryId = "LI",
                            categoryName = "Lubricantes Intimos"
                        },
                        new
                        {
                            categoryId = "RE",
                            categoryName = "Retardantes"
                        },
                        new
                        {
                            categoryId = "RI",
                            categoryName = "Ropa Intiva"
                        },
                        new
                        {
                            categoryId = "AS",
                            categoryName = "Accesorios Sexuales"
                        });
                });

            modelBuilder.Entity("Entities.InOutEntity", b =>
                {
                    b.Property<string>("inOutsID")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<DateTime>("InOutDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Quality")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("storageId")
                        .IsRequired()
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
                            categoryId = "JS",
                            productDesciption = "",
                            productName = "Consoladores",
                            totalQuantity = 0m
                        },
                        new
                        {
                            productId = "RPT-5465879",
                            categoryId = "RE",
                            productDesciption = "",
                            productName = "Aceite retardante",
                            totalQuantity = 0m
                        });
                });

            modelBuilder.Entity("Entities.StorageEntity", b =>
                {
                    b.Property<string>("storageId")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<decimal>("partialQuantity")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("productId")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("storageName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("warehouseId")
                        .IsRequired()
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
                            warehouseId = "829e67ba-995a-4dc7-b3ba-36840e6971ae",
                            warehouseAddress = "Calle 8 con 23",
                            warehouseName = "Bodega Central"
                        },
                        new
                        {
                            warehouseId = "ec1b76a7-c04f-45e5-aff2-4d8793c115f3",
                            warehouseAddress = "Calle norte con occidente",
                            warehouseName = "Bodega Norte"
                        });
                });

            modelBuilder.Entity("Entities.InOutEntity", b =>
                {
                    b.HasOne("Entities.StorageEntity", "Storage")
                        .WithMany("InOuts")
                        .HasForeignKey("storageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
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
                        .HasForeignKey("productId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.WarehouseEntity", "warehouse")
                        .WithMany()
                        .HasForeignKey("warehouseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
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
