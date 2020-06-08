using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BuildingShop.Persistence.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StarDate",
                table: "Orders");

            migrationBuilder.AddColumn<DateTime>(
                name: "StartDate",
                table: "Orders",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Сухі суміші");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Грунтовки");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "Фарби");

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[] { 4, "Блоки будівельні" });

            migrationBuilder.UpdateData(
                table: "Deliveries",
                keyColumn: "Id",
                keyValue: 100,
                column: "Amount",
                value: 50);

            migrationBuilder.InsertData(
                table: "Deliveries",
                columns: new[] { "Id", "Amount", "Date", "ProductId" },
                values: new object[] { 101, 60, new DateTime(2020, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.UpdateData(
                table: "ProductAmountTrackers",
                keyColumn: "Id",
                keyValue: 1,
                column: "Amount",
                value: 60);

            migrationBuilder.UpdateData(
                table: "ProductAmountTrackers",
                keyColumn: "Id",
                keyValue: 2,
                column: "Amount",
                value: 50);

            migrationBuilder.UpdateData(
                table: "ProductAmountTrackers",
                keyColumn: "Id",
                keyValue: 3,
                column: "Amount",
                value: 30);

            migrationBuilder.UpdateData(
                table: "ProductAmountTrackers",
                keyColumn: "Id",
                keyValue: 4,
                column: "Amount",
                value: 14);

            migrationBuilder.UpdateData(
                table: "ProductAmountTrackers",
                keyColumn: "Id",
                keyValue: 6,
                column: "Amount",
                value: 50);

            migrationBuilder.UpdateData(
                table: "ProductAmountTrackers",
                keyColumn: "Id",
                keyValue: 7,
                column: "Amount",
                value: 38);

            migrationBuilder.InsertData(
                table: "ProductAmountTrackers",
                columns: new[] { "Id", "Amount", "Date", "ProductId" },
                values: new object[,]
                {
                    { 8, 23, new DateTime(2020, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 9, 9, new DateTime(2020, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 10, 60, new DateTime(2020, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 11, 35, new DateTime(2020, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Amount", "Image", "Name", "Price", "Сharacteristics" },
                values: new object[] { 40, "https://cdn.27.ua/799/7b/62/1276770_2.jpeg", "Цемент IFCEM ПЦ II/БК-400 25 кг", 76.20m, "{\"Бренд\":\"IFCEM\",\"Вага\":\"25 кг\",\"Тип\":\"шлакопортландцемент\",\"Марка\":\"М-400\",\"Країна-виробник\":\"Україна\"}" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Amount", "CategoryId", "Image", "Name", "Price", "Сharacteristics" },
                values: new object[] { 50, 1, "https://cdn.27.ua/799/fd/48/326984_1.jpeg", "Цемент Dyckerhoff ПЦ II/А-Ш 500 25 кг", 85m, "{\"Бренд\":\"Dyckerhoff\",\"Вага\":\"25 кг\",\"Тип\":\"портландцемент\",\"Марка\":\"М-500\",\"Країна-виробник\":\"Україна\"}" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Amount", "CategoryId", "Image", "Name", "Price", "Сharacteristics" },
                values: new object[] { 35, 1, "https://cdn.27.ua/799/fd/3b/326971_2.jpeg", "Цемент ПЦII/БК 400 25 кг", 71m, "{\"Вага\":\"25 кг\",\"Тип\":\"портландцемент\",\"Марка\":\"М-400\",\"Країна-виробник\":\"Україна\"}" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Amount", "CategoryId", "Image", "Name", "Price", "Сharacteristics" },
                values: new object[,]
                {
                    { 10, 32, 3, "https://cdn.27.ua/799/68/49/26697_3.jpeg", "Фарба Sniezka Ultra Biel білий 10 л 14 кг", 262.70m, "{\"Бренд\":\"Sniezka\",\"Призначення\":\"для стін, для стелі\",\"Тип\":\"акрилова, водоемульсійна\",\"Відтінок\":\"білий\",\"Країна-виробник\":\"Україна\"}" },
                    { 4, 33, 1, "https://cdn.27.ua/799/b8/f0/1292528_2.jpeg", "Цемент білий OYAK 25 кг", 215m, "{\"Бренд\":\"OYAK\",\"Вага\":\"25 кг\",\"Тип\":\"білий\",\"Марка\":\"М-600\",\"Країна-виробник\":\"Туреччина\"}" },
                    { 9, 30, 3, "https://cdn.27.ua/799/4c/32/543794_3.jpeg", "Фарба Dufa Wandfarbe D1a білий 10 л 14 кг", 305.50m, "{\"Бренд\":\"Dufa\",\"Призначення\":\"штукатурка, ДСП, ДВП, МДФ, цегла, шпалери, гіпсокартон\",\"Тип\":\"акрилова, водоемульсійна\",\"Відтінок\":\"білий\",\"Країна-виробник\":\"Україна\"}" },
                    { 7, 21, 2, "https://cdn.27.ua/799/2c/dd/1125597_1.jpeg", "Ґрунтовка глибокопроникна Farbex силіконова 2 л", 99.60m, "{\"Бренд\":\"Farbex\",\"Призначення\":\"для внутрішніх робіт\",\"Основа\":\"силікон\",\"Колір\":\"прозорий\",\"Країна-виробник\":\"Україна\"}" },
                    { 8, 20, 2, "https://cdn.27.ua/799/cb/ce/314318_1.jpeg", "Ґрунтовка водовідштовхувальна Eskaro Aquastop Facade концентрат 1:10 1 л", 183.20m, "{\"Бренд\":\"Eskaro\",\"Основа\":\"акрилова\",\"Тип\":\"водовідштовхувальна\",\"Колір\":\"білий\",\"Країна-виробник\":\"Україна\"}" },
                    { 12, 60, 3, "https://cdn.27.ua/799/47/9b/411547_4.jpeg", "Фарба Triora TR-33 matt білий 10 л", 910.50m, "{\"Бренд\":\"Triora\",\"Призначення\":\"для стін, для стелі\",\"Тип\":\"латексна, водоемульсійна\",\"Відтінок\":\"білий\",\"Країна-виробник\":\"Україна\"}" },
                    { 11, 50, 3, "https://cdn.27.ua/799/f8/0c/522252_3.jpeg", "Фарба Dufa Mattlatex D100 білий 10 л 14 кг", 617.60m, "{\"Бренд\":\"Dufa\",\"Призначення\":\"для стін, для стелі\",\"Тип\":\"латексна, водоемульсійна\",\"Відтінок\":\"білий\",\"Країна-виробник\":\"Україна\"}" },
                    { 5, 23, 2, "https://cdn.27.ua/799/65/c4/550340_1.jpeg", "Ґрунт Farbex 1:4 глибокого проникнення SuperBase 1 л", 53.64m, "{\"Бренд\":\"Farbex\",\"Країна-виробник\":\"Україна\"}" },
                    { 6, 46, 2, "https://cdn.27.ua/799/47/bb/411579_4.jpeg", "Ґрунтовка фунгіцидна TR-25 bio 1 л", 50.28m, "{\"Бренд\":\"Triora\",\"Тип\":\"фунгіцидна\",\"Колір\":\"прозорий\",\"Основа\":\"акрилова\",\"Країна-виробник\":\"Україна\"}" }
                });

            migrationBuilder.UpdateData(
                table: "Purchases",
                keyColumn: "Id",
                keyValue: 100,
                column: "Amount",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Purchases",
                keyColumn: "Id",
                keyValue: 101,
                column: "Amount",
                value: 16);

            migrationBuilder.UpdateData(
                table: "Purchases",
                keyColumn: "Id",
                keyValue: 102,
                column: "Amount",
                value: 14);

            migrationBuilder.UpdateData(
                table: "Purchases",
                keyColumn: "Id",
                keyValue: 103,
                column: "Amount",
                value: 12);

            migrationBuilder.InsertData(
                table: "Purchases",
                columns: new[] { "Id", "Amount", "Date", "ProductId" },
                values: new object[,]
                {
                    { 107, 25, new DateTime(2020, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 105, 14, new DateTime(2020, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 104, 15, new DateTime(2020, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 106, 9, new DateTime(2020, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Amount", "CategoryId", "Image", "Name", "Price", "Сharacteristics" },
                values: new object[,]
                {
                    { 13, 52, 4, "https://cdn.27.ua/799/d6/34/1168948_2.jpeg", "Газобетонний блок BauGut 600x200x300 мм D-500", 61.30m, "{\"Бренд\":\"BauGut\",\"Призначення\":\"стіновий\",\"Марка міцності\":\"D-500\",\"Морозостійкість\":\"F-35\",\"Країна-виробник\":\"Україна\"}" },
                    { 14, 100, 4, "https://cdn.27.ua/799/7c/c7/31943_2.jpeg", "Блок бетонний Фратеко 500х200х200 мм", 25.50m, "{\"Бренд\":\"Фратеко\",\"Водопоглинання\":\"9%\",\"Пустотність\":\"30%\",\"Морозостійкість\":\"50\",\"Країна-виробник\":\"Україна\"}" },
                    { 15, 115, 4, "https://cdn.27.ua/799/87/d3/1279955_2.jpeg", "Блок бетонний М-50", 30m, "{\"Вид\":\"блок бетонний\",\"Призначення\":\"стіновий\",\"Торцева грань\":\"гладка\",\"Країна виробник\":\"Україна\",\"Вага\":\"11,5 кг\"}" },
                    { 16, 75, 4, "https://cdn.27.ua/799/87/f4/1279988_2.jpeg", "Блок керамічний ЗБК 45", 48m, "{\"Бренд\":\"3БК\",\"Призначення\":\"стіновий\",\"Вид\":\"блок керамічний 35\",\"Торцева грань\":\"паз-гребінь\",\"Країна-виробник\":\"Україна\"}" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Deliveries",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "ProductAmountTrackers",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "ProductAmountTrackers",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "ProductAmountTrackers",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "ProductAmountTrackers",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Purchases",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Purchases",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Purchases",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Purchases",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DropColumn(
                name: "StartDate",
                table: "Orders");

            migrationBuilder.AddColumn<DateTime>(
                name: "StarDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Ручні інструменти");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Електротовари");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "Ліхтарі");

            migrationBuilder.UpdateData(
                table: "Deliveries",
                keyColumn: "Id",
                keyValue: 100,
                column: "Amount",
                value: 30);

            migrationBuilder.UpdateData(
                table: "ProductAmountTrackers",
                keyColumn: "Id",
                keyValue: 1,
                column: "Amount",
                value: 25);

            migrationBuilder.UpdateData(
                table: "ProductAmountTrackers",
                keyColumn: "Id",
                keyValue: 2,
                column: "Amount",
                value: 15);

            migrationBuilder.UpdateData(
                table: "ProductAmountTrackers",
                keyColumn: "Id",
                keyValue: 3,
                column: "Amount",
                value: 9);

            migrationBuilder.UpdateData(
                table: "ProductAmountTrackers",
                keyColumn: "Id",
                keyValue: 4,
                column: "Amount",
                value: 5);

            migrationBuilder.UpdateData(
                table: "ProductAmountTrackers",
                keyColumn: "Id",
                keyValue: 6,
                column: "Amount",
                value: 30);

            migrationBuilder.UpdateData(
                table: "ProductAmountTrackers",
                keyColumn: "Id",
                keyValue: 7,
                column: "Amount",
                value: 28);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Amount", "Image", "Name", "Price", "Сharacteristics" },
                values: new object[] { 20, null, "Молоток", 50m, "{\"Вага\":\"50 грам\",\"Матеріал\":\"Метал\",\"Призначення\":\"Слюсарний\"}" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Amount", "CategoryId", "Image", "Name", "Price", "Сharacteristics" },
                values: new object[] { 40, 2, null, "Діодна лампа", 25.99m, "{\"Потужність\":\"10 Ватт\",\"Довжина\":\"40 см\",\"Цоколь\":\"E27\"}" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Amount", "CategoryId", "Image", "Name", "Price", "Сharacteristics" },
                values: new object[] { 28, 3, null, "Ліхтар BRAVIS LL-92", 119m, "{\"Потужність\":\"3 Вт\",\"Кількість світлодіодів\":\"1\",\"Яскравість\":\"240 люмен\",\"Матеріал\":\"Сплав алюмінію\"}" });

            migrationBuilder.UpdateData(
                table: "Purchases",
                keyColumn: "Id",
                keyValue: 100,
                column: "Amount",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Purchases",
                keyColumn: "Id",
                keyValue: 101,
                column: "Amount",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Purchases",
                keyColumn: "Id",
                keyValue: 102,
                column: "Amount",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Purchases",
                keyColumn: "Id",
                keyValue: 103,
                column: "Amount",
                value: 2);
        }
    }
}
