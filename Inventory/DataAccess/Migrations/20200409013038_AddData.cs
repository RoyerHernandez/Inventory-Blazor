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
                keyValue: "948741e3-e7f2-4fe1-9c7f-6b18d0b9f14f");

            migrationBuilder.DeleteData(
                table: "Warehouses",
                keyColumn: "warehouseId",
                keyValue: "e8de297e-dbdf-4afb-b65e-f3ce7f55e426");

            migrationBuilder.InsertData(
                table: "Warehouses",
                columns: new[] { "warehouseId", "WarehouseEntitywarehouseId", "warehouseAddress", "warehouseName" },
                values: new object[] { "5b70e2c4-fac0-4cf5-92d9-ecc73231e8b1", null, "Calle 8 con 23", "Bodega Central" });

            migrationBuilder.InsertData(
                table: "Warehouses",
                columns: new[] { "warehouseId", "WarehouseEntitywarehouseId", "warehouseAddress", "warehouseName" },
                values: new object[] { "ecbb9edf-fa46-4935-80a5-b53fad2dc131", null, "Calle norte con occidente", "Bodega Norte" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Warehouses",
                keyColumn: "warehouseId",
                keyValue: "5b70e2c4-fac0-4cf5-92d9-ecc73231e8b1");

            migrationBuilder.DeleteData(
                table: "Warehouses",
                keyColumn: "warehouseId",
                keyValue: "ecbb9edf-fa46-4935-80a5-b53fad2dc131");

            migrationBuilder.InsertData(
                table: "Warehouses",
                columns: new[] { "warehouseId", "WarehouseEntitywarehouseId", "warehouseAddress", "warehouseName" },
                values: new object[] { "948741e3-e7f2-4fe1-9c7f-6b18d0b9f14f", null, "Calle 8 con 23", "Bodega Central" });

            migrationBuilder.InsertData(
                table: "Warehouses",
                columns: new[] { "warehouseId", "WarehouseEntitywarehouseId", "warehouseAddress", "warehouseName" },
                values: new object[] { "e8de297e-dbdf-4afb-b65e-f3ce7f55e426", null, "Calle norte con occidente", "Bodega Norte" });
        }
    }
}
