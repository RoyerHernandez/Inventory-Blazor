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
                keyValue: "2fefa5e8-e06d-4287-9ad5-91df4e37bc2d");

            migrationBuilder.DeleteData(
                table: "Warehouses",
                keyColumn: "warehouseId",
                keyValue: "33e856c1-15a8-4259-aa35-f42c95d59bce");

            migrationBuilder.InsertData(
                table: "Warehouses",
                columns: new[] { "warehouseId", "WarehouseEntitywarehouseId", "warehouseAddress", "warehouseName" },
                values: new object[] { "cb6b5614-9758-4b83-8963-0985e64c4f75", null, "Calle 8 con 23", "Bodega Central" });

            migrationBuilder.InsertData(
                table: "Warehouses",
                columns: new[] { "warehouseId", "WarehouseEntitywarehouseId", "warehouseAddress", "warehouseName" },
                values: new object[] { "c511dccf-f030-4cc0-861e-da280302cf0e", null, "Calle norte con occidente", "Bodega Norte" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Warehouses",
                keyColumn: "warehouseId",
                keyValue: "c511dccf-f030-4cc0-861e-da280302cf0e");

            migrationBuilder.DeleteData(
                table: "Warehouses",
                keyColumn: "warehouseId",
                keyValue: "cb6b5614-9758-4b83-8963-0985e64c4f75");

            migrationBuilder.InsertData(
                table: "Warehouses",
                columns: new[] { "warehouseId", "WarehouseEntitywarehouseId", "warehouseAddress", "warehouseName" },
                values: new object[] { "33e856c1-15a8-4259-aa35-f42c95d59bce", null, "Calle 8 con 23", "Bodega Central" });

            migrationBuilder.InsertData(
                table: "Warehouses",
                columns: new[] { "warehouseId", "WarehouseEntitywarehouseId", "warehouseAddress", "warehouseName" },
                values: new object[] { "2fefa5e8-e06d-4287-9ad5-91df4e37bc2d", null, "Calle norte con occidente", "Bodega Norte" });
        }
    }
}
