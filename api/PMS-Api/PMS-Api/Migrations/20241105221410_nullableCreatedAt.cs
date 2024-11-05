using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PMS_Api.Migrations
{
    /// <inheritdoc />
    public partial class nullableCreatedAt : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateOnly>(
                name: "CreatedAt",
                table: "Admins",
                type: "date",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Admins",
                keyColumn: "Uuid",
                keyValue: new Guid("a86e8efd-ebf7-43a4-950c-3398d232de1b"),
                column: "CreatedAt",
                value: new DateOnly(2024, 11, 4));

            migrationBuilder.InsertData(
                table: "Admins",
                columns: new[] { "Uuid", "CreatedAt", "Email", "Name", "Password" },
                values: new object[] { new Guid("6b9957e6-6465-4cc4-a481-b699bbbe331e"), new DateOnly(2024, 7, 4), "admin@test.com", "Administrator", "1234" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Uuid",
                keyValue: new Guid("6b9957e6-6465-4cc4-a481-b699bbbe331e"));

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Admins");
        }
    }
}
