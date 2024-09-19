using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Practice5_DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class DataInsertInventory1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Inventories",
                keyColumn: "Inventory_Id",
                keyValue: 1,
                column: "Product_Id",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Inventories",
                keyColumn: "Inventory_Id",
                keyValue: 2,
                column: "Product_Id",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Inventories",
                keyColumn: "Inventory_Id",
                keyValue: 3,
                column: "Product_Id",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Inventories",
                keyColumn: "Inventory_Id",
                keyValue: 4,
                column: "Product_Id",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Inventories",
                keyColumn: "Inventory_Id",
                keyValue: 5,
                column: "Product_Id",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Inventories",
                keyColumn: "Inventory_Id",
                keyValue: 6,
                column: "Product_Id",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Inventories",
                keyColumn: "Inventory_Id",
                keyValue: 7,
                column: "Product_Id",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Inventories",
                keyColumn: "Inventory_Id",
                keyValue: 8,
                column: "Product_Id",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Inventories",
                keyColumn: "Inventory_Id",
                keyValue: 9,
                column: "Product_Id",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Inventories",
                keyColumn: "Inventory_Id",
                keyValue: 10,
                column: "Product_Id",
                value: 10);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Inventories",
                keyColumn: "Inventory_Id",
                keyValue: 1,
                column: "Product_Id",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Inventories",
                keyColumn: "Inventory_Id",
                keyValue: 2,
                column: "Product_Id",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Inventories",
                keyColumn: "Inventory_Id",
                keyValue: 3,
                column: "Product_Id",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Inventories",
                keyColumn: "Inventory_Id",
                keyValue: 4,
                column: "Product_Id",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Inventories",
                keyColumn: "Inventory_Id",
                keyValue: 5,
                column: "Product_Id",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Inventories",
                keyColumn: "Inventory_Id",
                keyValue: 6,
                column: "Product_Id",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Inventories",
                keyColumn: "Inventory_Id",
                keyValue: 7,
                column: "Product_Id",
                value: 4);

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

            migrationBuilder.UpdateData(
                table: "Inventories",
                keyColumn: "Inventory_Id",
                keyValue: 10,
                column: "Product_Id",
                value: 1);
        }
    }
}
