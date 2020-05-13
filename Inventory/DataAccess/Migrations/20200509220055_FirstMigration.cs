using System;
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
                name: "Clients",
                columns: table => new
                {
                    clientId = table.Column<int>(maxLength: 12, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    clientName = table.Column<string>(maxLength: 50, nullable: false),
                    clientLastName = table.Column<string>(maxLength: 50, nullable: false),
                    clientAddres = table.Column<string>(nullable: false),
                    numberPhone = table.Column<int>(maxLength: 10, nullable: false),
                    eMail = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.clientId);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    orderId = table.Column<string>(nullable: false),
                    clientId = table.Column<int>(maxLength: 12, nullable: false),
                    clientFullname = table.Column<string>(maxLength: 150, nullable: true),
                    productName = table.Column<string>(nullable: true),
                    unitPrice = table.Column<decimal>(nullable: false),
                    totalPrice = table.Column<decimal>(nullable: false),
                    IsAdd = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.orderId);
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
                    totalQuantity = table.Column<int>(nullable: false),
                    unitPrice = table.Column<decimal>(nullable: false),
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
                    partialQuantity = table.Column<int>(nullable: false),
                    LastUpdate = table.Column<DateTime>(nullable: false),
                    warehouseId = table.Column<string>(nullable: true),
                    productId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Storages", x => x.storageId);
                    table.ForeignKey(
                        name: "FK_Storages_Products_productId",
                        column: x => x.productId,
                        principalTable: "Products",
                        principalColumn: "productId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Storages_Warehouses_warehouseId",
                        column: x => x.warehouseId,
                        principalTable: "Warehouses",
                        principalColumn: "warehouseId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "InOuts",
                columns: table => new
                {
                    inOutsID = table.Column<string>(maxLength: 100, nullable: false),
                    InOutDate = table.Column<DateTime>(nullable: false),
                    Quality = table.Column<int>(nullable: false),
                    IsInput = table.Column<bool>(nullable: false),
                    storageId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InOuts", x => x.inOutsID);
                    table.ForeignKey(
                        name: "FK_InOuts_Storages_storageId",
                        column: x => x.storageId,
                        principalTable: "Storages",
                        principalColumn: "storageId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "categoryId", "categoryName" },
                values: new object[,]
                {
                    { "MD", "Medicamentos" },
                    { "JB", "Jabones" },
                    { "BT", "Boticario" },
                    { "PB", "Productos Bucales" },
                    { "AS", "Aseo Personal" }
                });

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "clientId", "clientAddres", "clientLastName", "clientName", "eMail", "numberPhone" },
                values: new object[,]
                {
                    { 1024466070, "Cra 77 h # 65 j 86 sur", "Chaparro", "Jeimi Paola", "jeichap@hotmail.com", 7797467 },
                    { 80142463, "Cra 77 h # 65 j 86 sur", "Hernandez M", "Royer A", "jeichap@hotmail.com", 7797467 }
                });

            migrationBuilder.InsertData(
                table: "Warehouses",
                columns: new[] { "warehouseId", "WarehouseEntitywarehouseId", "warehouseAddress", "warehouseName" },
                values: new object[,]
                {
                    { "af32d94e-692b-499e-a667-a765a9cf1e85", null, "Calle 8 con 23", "Bodega Central" },
                    { "263f1ec5-0759-43fb-82cb-a187385e7cb3", null, "Calle norte con occidente", "Bodega Norte" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "productId", "WarehouseEntitywarehouseId", "categoryId", "productDesciption", "productName", "totalQuantity", "unitPrice" },
                values: new object[] { "ASJ-98745", null, "MD", "", "Medicamento", 0, 0m });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "productId", "WarehouseEntitywarehouseId", "categoryId", "productDesciption", "productName", "totalQuantity", "unitPrice" },
                values: new object[] { "RPT-5465879", null, "BT", "", "Boticario", 0, 0m });

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
                name: "Clients");

            migrationBuilder.DropTable(
                name: "InOuts");

            migrationBuilder.DropTable(
                name: "Orders");

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
