using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class AddData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Warehouses",
                keyColumn: "warehouseId",
                keyValue: "06fc3c63-1183-4010-b38e-8f45475bdff3");

            migrationBuilder.DeleteData(
                table: "Warehouses",
                keyColumn: "warehouseId",
                keyValue: "81ef69b8-e745-49ee-8b86-c59c5daafdb3");

            migrationBuilder.InsertData(
                table: "Warehouses",
                columns: new[] { "warehouseId", "WarehouseEntitywarehouseId", "warehouseAddress", "warehouseName" },
                values: new object[] { "18728ead-d82b-4294-ba1b-482833b7c0f6", null, "Calle 8 con 23", "Bodega Central" });

            migrationBuilder.InsertData(
                table: "Warehouses",
                columns: new[] { "warehouseId", "WarehouseEntitywarehouseId", "warehouseAddress", "warehouseName" },
                values: new object[] { "68382069-8c66-4c5d-8be0-5ed907dcf749", null, "Calle norte con occidente", "Bodega Norte" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Warehouses",
                keyColumn: "warehouseId",
                keyValue: "18728ead-d82b-4294-ba1b-482833b7c0f6");

            migrationBuilder.DeleteData(
                table: "Warehouses",
                keyColumn: "warehouseId",
                keyValue: "68382069-8c66-4c5d-8be0-5ed907dcf749");

            migrationBuilder.InsertData(
                table: "Warehouses",
                columns: new[] { "warehouseId", "WarehouseEntitywarehouseId", "warehouseAddress", "warehouseName" },
                values: new object[] { "06fc3c63-1183-4010-b38e-8f45475bdff3", null, "Calle 8 con 23", "Bodega Central" });

            migrationBuilder.InsertData(
                table: "Warehouses",
                columns: new[] { "warehouseId", "WarehouseEntitywarehouseId", "warehouseAddress", "warehouseName" },
                values: new object[] { "81ef69b8-e745-49ee-8b86-c59c5daafdb3", null, "Calle norte con occidente", "Bodega Norte" });
        }
    }
}
