using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Practice5_DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class insertInventory : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Inventories",
                columns: new[] { "Inventory_Id", "Product_Id", "Stock" },
                values: new object[,]
                {
                    { 1, 10, 100 },
                    { 2, 9, 200 },
                    { 3, 8, 30 },
                    { 4, 7, 234 },
                    { 5, 6, 531 },
                    { 6, 5, 345 },
                    { 7, 4, 322 },
                    { 8, 2, 345 },
                    { 9, 3, 232 },
                    { 10, 1, 40 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Inventory_Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Inventory_Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Inventory_Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Inventory_Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Inventory_Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Inventory_Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Inventory_Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Inventory_Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Inventory_Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Inventory_Id",
                keyValue: 10);
        }
    }
}
