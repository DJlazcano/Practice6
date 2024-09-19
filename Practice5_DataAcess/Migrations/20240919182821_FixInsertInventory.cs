using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Practice5_DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class FixInsertInventory : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Inventories",
                keyColumn: "Inventory_Id",
                keyValue: 8,
                column: "Product_Id",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Inventories",
                keyColumn: "Inventory_Id",
                keyValue: 9,
                column: "Product_Id",
                value: 3);

            migrationBuilder.InsertData(
                table: "Inventories",
                columns: new[] { "Inventory_Id", "Product_Id", "Stock" },
                values: new object[] { 1, 10, 100 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Inventory_Id",
                keyValue: 1);

            migrationBuilder.UpdateData(
                table: "Inventories",
                keyColumn: "Inventory_Id",
                keyValue: 8,
                column: "Product_Id",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Inventories",
                keyColumn: "Inventory_Id",
                keyValue: 9,
                column: "Product_Id",
                value: 2);
        }
    }
}
