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
                keyValue: "7cb8e915-5704-41ad-8e4e-090cb95246aa");

            migrationBuilder.DeleteData(
                table: "Warehouses",
                keyColumn: "warehouseId",
                keyValue: "cf9d55a2-c52b-46e8-82f4-691602f046d5");

            migrationBuilder.InsertData(
                table: "Warehouses",
                columns: new[] { "warehouseId", "WarehouseEntitywarehouseId", "warehouseAddress", "warehouseName" },
                values: new object[] { "2c632cf4-02c5-4c8d-b275-a05aeff287f9", null, "Calle 8 con 23", "Bodega Central" });

            migrationBuilder.InsertData(
                table: "Warehouses",
                columns: new[] { "warehouseId", "WarehouseEntitywarehouseId", "warehouseAddress", "warehouseName" },
                values: new object[] { "6fdc47ae-d0db-4cad-849d-ef8a00b81e66", null, "Calle norte con occidente", "Bodega Sur" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Warehouses",
                keyColumn: "warehouseId",
                keyValue: "2c632cf4-02c5-4c8d-b275-a05aeff287f9");

            migrationBuilder.DeleteData(
                table: "Warehouses",
                keyColumn: "warehouseId",
                keyValue: "6fdc47ae-d0db-4cad-849d-ef8a00b81e66");

            migrationBuilder.InsertData(
                table: "Warehouses",
                columns: new[] { "warehouseId", "WarehouseEntitywarehouseId", "warehouseAddress", "warehouseName" },
                values: new object[] { "cf9d55a2-c52b-46e8-82f4-691602f046d5", null, "Calle 8 con 23", "Bodega Central" });

            migrationBuilder.InsertData(
                table: "Warehouses",
                columns: new[] { "warehouseId", "WarehouseEntitywarehouseId", "warehouseAddress", "warehouseName" },
                values: new object[] { "7cb8e915-5704-41ad-8e4e-090cb95246aa", null, "Calle norte con occidente", "Bodega Sur" });
        }
    }
}
