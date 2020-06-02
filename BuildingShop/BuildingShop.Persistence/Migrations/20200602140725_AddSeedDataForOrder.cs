using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BuildingShop.Persistence.Migrations
{
    public partial class AddSeedDataForOrder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Ручні інструменти");

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[] { 3, "Ліхтарі" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Amount", "CategoryId", "Image", "Name", "Price", "Сharacteristics" },
                values: new object[] { 3, 28, 3, null, "Ліхтар BRAVIS LL-92", 119m, "{\"Потужність\":\"3 Вт\",\"Кількість світлодіодів\":\"1\",\"Яскравість\":\"240 люмен\",\"Матеріал\":\"Сплав алюмінію\"}" });

            migrationBuilder.InsertData(
                table: "Deliveries",
                columns: new[] { "Id", "Amount", "Date", "OrderId", "ProductId" },
                values: new object[] { 100, 30, new DateTime(2020, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3 });

            migrationBuilder.InsertData(
                table: "ProductAmountTrackers",
                columns: new[] { "Id", "Amount", "Date", "ProductId" },
                values: new object[,]
                {
                    { 1, 25, new DateTime(2020, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 2, 15, new DateTime(2020, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 3, 9, new DateTime(2020, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 4, 5, new DateTime(2020, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 5, 0, new DateTime(2020, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 6, 30, new DateTime(2020, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 7, 28, new DateTime(2020, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 }
                });

            migrationBuilder.InsertData(
                table: "Purchases",
                columns: new[] { "Id", "Amount", "Date", "OrderId", "ProductId" },
                values: new object[,]
                {
                    { 100, 6, new DateTime(2020, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3 },
                    { 101, 4, new DateTime(2020, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3 },
                    { 102, 5, new DateTime(2020, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3 },
                    { 103, 2, new DateTime(2020, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 3 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Deliveries",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "ProductAmountTrackers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ProductAmountTrackers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ProductAmountTrackers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ProductAmountTrackers",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ProductAmountTrackers",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ProductAmountTrackers",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ProductAmountTrackers",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Purchases",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Purchases",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Purchases",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Purchases",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Ручні інструменту");
        }
    }
}
