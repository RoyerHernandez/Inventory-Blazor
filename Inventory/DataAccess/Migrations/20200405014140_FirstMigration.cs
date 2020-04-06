﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class FirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    categoryId = table.Column<string>(maxLength: 100, nullable: false),
                    categoryName = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.categoryId);
                });

            migrationBuilder.CreateTable(
                name: "Warehouses",
                columns: table => new
                {
                    warehouseId = table.Column<string>(maxLength: 100, nullable: false),
                    warehouseName = table.Column<string>(nullable: false),
                    warehouseAddress = table.Column<string>(nullable: true),
                    WarehouseEntitywarehouseId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Warehouses", x => x.warehouseId);
                    table.ForeignKey(
                        name: "FK_Warehouses_Warehouses_WarehouseEntitywarehouseId",
                        column: x => x.WarehouseEntitywarehouseId,
                        principalTable: "Warehouses",
                        principalColumn: "warehouseId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    productId = table.Column<string>(maxLength: 100, nullable: false),
                    productName = table.Column<string>(nullable: false),
                    productDesciption = table.Column<string>(nullable: true),
                    totalQuantity = table.Column<decimal>(nullable: false),
                    categoryId = table.Column<string>(nullable: false),
                    WarehouseEntitywarehouseId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.productId);
                    table.ForeignKey(
                        name: "FK_Products_Warehouses_WarehouseEntitywarehouseId",
                        column: x => x.WarehouseEntitywarehouseId,
                        principalTable: "Warehouses",
                        principalColumn: "warehouseId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Products_Categories_categoryId",
                        column: x => x.categoryId,
                        principalTable: "Categories",
                        principalColumn: "categoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Storages",
                columns: table => new
                {
                    storageId = table.Column<string>(maxLength: 100, nullable: false),
                    storageName = table.Column<string>(nullable: false),
                    partialQuantity = table.Column<decimal>(nullable: false),
                    warehouseId = table.Column<string>(nullable: false),
                    productId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Storages", x => x.storageId);
                    table.ForeignKey(
                        name: "FK_Storages_Products_productId",
                        column: x => x.productId,
                        principalTable: "Products",
                        principalColumn: "productId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Storages_Warehouses_warehouseId",
                        column: x => x.warehouseId,
                        principalTable: "Warehouses",
                        principalColumn: "warehouseId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "InOuts",
                columns: table => new
                {
                    inOutsID = table.Column<string>(maxLength: 100, nullable: false),
                    InOutDate = table.Column<DateTime>(nullable: false),
                    Quality = table.Column<string>(nullable: true),
                    storageId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InOuts", x => x.inOutsID);
                    table.ForeignKey(
                        name: "FK_InOuts_Storages_storageId",
                        column: x => x.storageId,
                        principalTable: "Storages",
                        principalColumn: "storageId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "categoryId", "categoryName" },
                values: new object[,]
                {
                    { "JS", "Juguetes Sexuales" },
                    { "LI", "Lubricantes Intimos" },
                    { "RE", "Retardantes" },
                    { "RI", "Ropa Intiva" },
                    { "AS", "Accesorios Sexuales" }
                });

            migrationBuilder.InsertData(
                table: "Warehouses",
                columns: new[] { "warehouseId", "WarehouseEntitywarehouseId", "warehouseAddress", "warehouseName" },
                values: new object[,]
                {
                    { "5c72a10c-bbd7-4676-8c8e-3e49718f8992", null, "Calle 8 con 23", "Bodega Central" },
                    { "6ef3f770-ee8e-464e-a654-424dead10c77", null, "Calle norte con occidente", "Bodega Norte" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "productId", "WarehouseEntitywarehouseId", "categoryId", "productDesciption", "productName", "totalQuantity" },
                values: new object[] { "ASJ-98745", null, "JS", "", "Consoladores", 0m });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "productId", "WarehouseEntitywarehouseId", "categoryId", "productDesciption", "productName", "totalQuantity" },
                values: new object[] { "RPT-5465879", null, "RE", "", "Aceite retardante", 0m });

            migrationBuilder.CreateIndex(
                name: "IX_InOuts_storageId",
                table: "InOuts",
                column: "storageId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_WarehouseEntitywarehouseId",
                table: "Products",
                column: "WarehouseEntitywarehouseId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_categoryId",
                table: "Products",
                column: "categoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Storages_productId",
                table: "Storages",
                column: "productId");

            migrationBuilder.CreateIndex(
                name: "IX_Storages_warehouseId",
                table: "Storages",
                column: "warehouseId");

            migrationBuilder.CreateIndex(
                name: "IX_Warehouses_WarehouseEntitywarehouseId",
                table: "Warehouses",
                column: "WarehouseEntitywarehouseId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "InOuts");

            migrationBuilder.DropTable(
                name: "Storages");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Warehouses");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
