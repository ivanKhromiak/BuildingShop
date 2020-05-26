using Microsoft.EntityFrameworkCore.Migrations;

namespace BuildingShop.Persistence.Migrations
{
    public partial class AddСharacteristics : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Products",
                type: "decimal(12, 2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(12, 6)");

            migrationBuilder.AddColumn<string>(
                name: "Сharacteristics",
                table: "Products",
                maxLength: 4000,
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Ручні інструменту");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Електротовари");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Name", "Сharacteristics" },
                values: new object[] { "Молоток", "{\"Вага\":\"50 грам\",\"Матеріал\":\"Метал\",\"Призначення\":\"Слюсарний\"}" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Name", "Сharacteristics" },
                values: new object[] { "Діодна лампа", "{\"Потужність\":\"10 Ватт\",\"Довжина\":\"40 см\",\"Цоколь\":\"E27\"}" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Сharacteristics",
                table: "Products");

            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Products",
                type: "decimal(12, 6)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(12, 2)");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Instruments");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Light bulbs");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Hammer");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Diode lamp");
        }
    }
}
