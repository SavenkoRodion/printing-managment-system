using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PMS_Api.Migrations
{
    /// <inheritdoc />
    public partial class test2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Uuid",
                keyValue: new Guid("40abfad9-6365-43c1-a7a6-66c933fb0018"));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Uuid",
                keyValue: new Guid("6b9957e6-6465-4cc4-a481-b699bbbe331e"),
                columns: new[] { "CreatedAt", "Email", "Name" },
                values: new object[] { new DateOnly(2024, 7, 4), "admin@test.com", "Administrator" });

            migrationBuilder.InsertData(
                table: "Admins",
                columns: new[] { "Uuid", "CreatedAt", "Email", "Name", "Password" },
                values: new object[] { new Guid("a86e8efd-ebf7-43a4-950c-3398d232de1b"), new DateOnly(2024, 11, 4), "testemail@test.com", "Admin", "1234" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Uuid",
                keyValue: new Guid("a86e8efd-ebf7-43a4-950c-3398d232de1b"));

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Uuid",
                keyValue: new Guid("6b9957e6-6465-4cc4-a481-b699bbbe331e"),
                columns: new[] { "CreatedAt", "Email", "Name" },
                values: new object[] { new DateOnly(2024, 8, 18), "testemail@test.com", "Admin" });

            migrationBuilder.InsertData(
                table: "Admins",
                columns: new[] { "Uuid", "CreatedAt", "Email", "Name", "Password" },
                values: new object[] { new Guid("40abfad9-6365-43c1-a7a6-66c933fb0018"), new DateOnly(2024, 11, 4), "admin@test.com", "Administrator", "1234" });
        }
    }
}
