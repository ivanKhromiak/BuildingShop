using Microsoft.EntityFrameworkCore.Migrations;

namespace BuildingShop.Persistence.Identity.Migrations
{
    public partial class UserSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6206a4f1-7ca1-4928-89b4-5d2112074e56", "f5ebc373-e948-47b0-b04d-f0deb787e9f4", "Manager", "MANAGER" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "1", 0, "2c1b1b62-85d7-450a-8083-17a1f726b936", "ivan@gmail.com", true, false, null, "IVAN@NONCE.FAKE", "IVAN", "AQAAAAEAACcQAAAAEIA8258046E4u5NV8DJOE74fnvuHNKjJrh4nlIJ8reqKjQq0LT97xgOXFLOx02KzTg==", null, false, "", false, "Ivan" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "1", "6206a4f1-7ca1-4928-89b4-5d2112074e56" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "1", "6206a4f1-7ca1-4928-89b4-5d2112074e56" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6206a4f1-7ca1-4928-89b4-5d2112074e56");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1");
        }
    }
}
