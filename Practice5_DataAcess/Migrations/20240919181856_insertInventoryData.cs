using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Practice5_DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class insertInventoryData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Inventories_Product_Id",
                table: "Inventories");

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

            migrationBuilder.CreateIndex(
                name: "IX_Inventories_Product_Id",
                table: "Inventories",
                column: "Product_Id",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Inventories_Product_Id",
                table: "Inventories");

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

            migrationBuilder.CreateIndex(
                name: "IX_Inventories_Product_Id",
                table: "Inventories",
                column: "Product_Id");
        }
    }
}
