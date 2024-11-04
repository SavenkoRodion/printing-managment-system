using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PMS_Api.Migrations
{
    /// <inheritdoc />
    public partial class test : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Uuid",
                keyValue: new Guid("4442089a-a3c9-44ee-b857-d04bd9bb17c7"));

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Uuid",
                keyValue: new Guid("e4c6f04b-5c25-4827-a5c1-412ecf3845fc"));

            migrationBuilder.InsertData(
                table: "Admins",
                columns: new[] { "Uuid", "CreatedAt", "Email", "Name", "Password" },
                values: new object[,]
                {
                    { new Guid("40abfad9-6365-43c1-a7a6-66c933fb0018"), new DateOnly(2024, 11, 4), "admin@test.com", "Administrator", "1234" },
                    { new Guid("6b9957e6-6465-4cc4-a481-b699bbbe331e"), new DateOnly(2024, 8, 18), "testemail@test.com", "Admin", "1234" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Uuid",
                keyValue: new Guid("40abfad9-6365-43c1-a7a6-66c933fb0018"));

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Uuid",
                keyValue: new Guid("6b9957e6-6465-4cc4-a481-b699bbbe331e"));

            migrationBuilder.InsertData(
                table: "Admins",
                columns: new[] { "Uuid", "CreatedAt", "Email", "Name", "Password" },
                values: new object[,]
                {
                    { new Guid("4442089a-a3c9-44ee-b857-d04bd9bb17c7"), new DateOnly(2024, 8, 18), "testemail@test.com", "Admin", "1234" },
                    { new Guid("e4c6f04b-5c25-4827-a5c1-412ecf3845fc"), new DateOnly(2024, 8, 18), "admin@test.com", "Administrator", "1234" }
                });
        }
    }
}
