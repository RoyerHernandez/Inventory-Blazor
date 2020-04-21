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
                keyValue: "a06c9ac9-a688-4462-a153-ddadcbb61a02");

            migrationBuilder.DeleteData(
                table: "Warehouses",
                keyColumn: "warehouseId",
                keyValue: "e8de31b2-2ac3-40d1-9fdd-7a5657756a9a");

            migrationBuilder.InsertData(
                table: "Warehouses",
                columns: new[] { "warehouseId", "WarehouseEntitywarehouseId", "warehouseAddress", "warehouseName" },
                values: new object[] { "19593181-8eab-4b12-b114-8fc27d767d92", null, "Calle 8 con 23", "Bodega Central" });

            migrationBuilder.InsertData(
                table: "Warehouses",
                columns: new[] { "warehouseId", "WarehouseEntitywarehouseId", "warehouseAddress", "warehouseName" },
                values: new object[] { "2377ce66-e97f-4193-b289-37b72bc58c5f", null, "Calle norte con occidente", "Bodega Sur" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Warehouses",
                keyColumn: "warehouseId",
                keyValue: "19593181-8eab-4b12-b114-8fc27d767d92");

            migrationBuilder.DeleteData(
                table: "Warehouses",
                keyColumn: "warehouseId",
                keyValue: "2377ce66-e97f-4193-b289-37b72bc58c5f");

            migrationBuilder.InsertData(
                table: "Warehouses",
                columns: new[] { "warehouseId", "WarehouseEntitywarehouseId", "warehouseAddress", "warehouseName" },
                values: new object[] { "e8de31b2-2ac3-40d1-9fdd-7a5657756a9a", null, "Calle 8 con 23", "Bodega Central" });

            migrationBuilder.InsertData(
                table: "Warehouses",
                columns: new[] { "warehouseId", "WarehouseEntitywarehouseId", "warehouseAddress", "warehouseName" },
                values: new object[] { "a06c9ac9-a688-4462-a153-ddadcbb61a02", null, "Calle norte con occidente", "Bodega Sur" });
        }
    }
}
