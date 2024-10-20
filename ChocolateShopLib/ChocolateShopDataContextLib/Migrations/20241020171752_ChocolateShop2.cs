using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ChocolateShopDataContextLib.Migrations
{
    /// <inheritdoc />
    public partial class ChocolateShop2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterTable(
                name: "Shops",
                oldComment: "Shop managed on the website");

            migrationBuilder.AddColumn<int>(
                name: "ShopId",
                table: "Customers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ShopId",
                table: "Chocolates",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Customers_ShopId",
                table: "Customers",
                column: "ShopId");

            migrationBuilder.CreateIndex(
                name: "IX_Chocolates_ShopId",
                table: "Chocolates",
                column: "ShopId");

            migrationBuilder.AddForeignKey(
                name: "FK_Chocolates_Shops_ShopId",
                table: "Chocolates",
                column: "ShopId",
                principalTable: "Shops",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_Shops_ShopId",
                table: "Customers",
                column: "ShopId",
                principalTable: "Shops",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Chocolates_Shops_ShopId",
                table: "Chocolates");

            migrationBuilder.DropForeignKey(
                name: "FK_Customers_Shops_ShopId",
                table: "Customers");

            migrationBuilder.DropIndex(
                name: "IX_Customers_ShopId",
                table: "Customers");

            migrationBuilder.DropIndex(
                name: "IX_Chocolates_ShopId",
                table: "Chocolates");

            migrationBuilder.DropColumn(
                name: "ShopId",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "ShopId",
                table: "Chocolates");

            migrationBuilder.AlterTable(
                name: "Shops",
                comment: "Shop managed on the website");
        }
    }
}
