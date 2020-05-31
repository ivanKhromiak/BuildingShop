using Microsoft.EntityFrameworkCore.Migrations;

namespace BuildingShop.Persistence.Migrations
{
    public partial class ProductIdForAmountTracker : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProductId",
                table: "ProductAmountTrackers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_ProductAmountTrackers_ProductId",
                table: "ProductAmountTrackers",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductAmountTrackers_Products_ProductId",
                table: "ProductAmountTrackers",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductAmountTrackers_Products_ProductId",
                table: "ProductAmountTrackers");

            migrationBuilder.DropIndex(
                name: "IX_ProductAmountTrackers_ProductId",
                table: "ProductAmountTrackers");

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "ProductAmountTrackers");
        }
    }
}
