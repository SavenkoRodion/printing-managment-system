using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PMS_Api.Migrations
{
    /// <inheritdoc />
    public partial class changeClientModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Clients",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateOfCreation",
                table: "Clients",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Clients",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Uuid",
                keyValue: new Guid("599a628a-a3ea-40d9-9494-0ff27debf95d"),
                columns: new[] { "Address", "DateOfCreation", "Email" },
                values: new object[] { "Address B", new DateTime(2024, 11, 26, 18, 35, 4, 49, DateTimeKind.Local).AddTicks(1110), "client2@test.com" });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Uuid",
                keyValue: new Guid("71e2244b-3f26-4344-a9d6-93a00b8fd83f"),
                columns: new[] { "Address", "DateOfCreation", "Email" },
                values: new object[] { "Address A", new DateTime(2024, 11, 26, 18, 35, 4, 49, DateTimeKind.Local).AddTicks(1071), "client1@test.pl" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateOfCreation",
                value: new DateTime(2024, 11, 26, 18, 35, 4, 49, DateTimeKind.Local).AddTicks(1127));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateOfCreation",
                value: new DateTime(2024, 11, 26, 18, 35, 4, 49, DateTimeKind.Local).AddTicks(1129));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateOfCreation",
                value: new DateTime(2024, 11, 26, 18, 35, 4, 49, DateTimeKind.Local).AddTicks(1131));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateModified",
                value: new DateTime(2024, 11, 26, 18, 35, 4, 49, DateTimeKind.Local).AddTicks(1148));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateModified",
                value: new DateTime(2024, 11, 26, 18, 35, 4, 49, DateTimeKind.Local).AddTicks(1151));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateModified",
                value: new DateTime(2024, 11, 26, 18, 35, 4, 49, DateTimeKind.Local).AddTicks(1153));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateModified",
                value: new DateTime(2024, 11, 26, 18, 35, 4, 49, DateTimeKind.Local).AddTicks(1155));

            migrationBuilder.UpdateData(
                table: "Templates",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateModified",
                value: new DateTime(2024, 11, 26, 18, 35, 4, 49, DateTimeKind.Local).AddTicks(1170));

            migrationBuilder.UpdateData(
                table: "Templates",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateModified",
                value: new DateTime(2024, 11, 26, 18, 35, 4, 49, DateTimeKind.Local).AddTicks(1173));

            migrationBuilder.UpdateData(
                table: "Templates",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateModified",
                value: new DateTime(2024, 11, 26, 18, 35, 4, 49, DateTimeKind.Local).AddTicks(1175));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address",
                table: "Clients");

            migrationBuilder.DropColumn(
                name: "DateOfCreation",
                table: "Clients");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Clients");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateOfCreation",
                value: new DateTime(2024, 11, 11, 16, 8, 25, 337, DateTimeKind.Local).AddTicks(6133));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateOfCreation",
                value: new DateTime(2024, 11, 11, 16, 8, 25, 337, DateTimeKind.Local).AddTicks(6181));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateOfCreation",
                value: new DateTime(2024, 11, 11, 16, 8, 25, 337, DateTimeKind.Local).AddTicks(6183));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateModified",
                value: new DateTime(2024, 11, 11, 16, 8, 25, 337, DateTimeKind.Local).AddTicks(6213));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateModified",
                value: new DateTime(2024, 11, 11, 16, 8, 25, 337, DateTimeKind.Local).AddTicks(6218));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateModified",
                value: new DateTime(2024, 11, 11, 16, 8, 25, 337, DateTimeKind.Local).AddTicks(6221));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateModified",
                value: new DateTime(2024, 11, 11, 16, 8, 25, 337, DateTimeKind.Local).AddTicks(6224));

            migrationBuilder.UpdateData(
                table: "Templates",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateModified",
                value: new DateTime(2024, 11, 11, 16, 8, 25, 337, DateTimeKind.Local).AddTicks(6257));

            migrationBuilder.UpdateData(
                table: "Templates",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateModified",
                value: new DateTime(2024, 11, 11, 16, 8, 25, 337, DateTimeKind.Local).AddTicks(6261));

            migrationBuilder.UpdateData(
                table: "Templates",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateModified",
                value: new DateTime(2024, 11, 11, 16, 8, 25, 337, DateTimeKind.Local).AddTicks(6264));
        }
    }
}
