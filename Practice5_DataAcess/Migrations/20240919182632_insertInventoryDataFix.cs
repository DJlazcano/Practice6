using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Practice5_DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class insertInventoryDataFix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Inventories",
                keyColumn: "Inventory_Id",
                keyValue: 1);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Inventories",
                columns: new[] { "Inventory_Id", "Product_Id", "Stock" },
                values: new object[] { 1, 10, 100 });
        }
    }
}
