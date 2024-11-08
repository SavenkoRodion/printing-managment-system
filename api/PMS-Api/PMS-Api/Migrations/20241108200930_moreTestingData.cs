using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PMS_Api.Migrations
{
    /// <inheritdoc />
    public partial class moreTestingData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateOfCreation",
                value: new DateTime(2024, 11, 8, 21, 9, 29, 882, DateTimeKind.Local).AddTicks(8783));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateOfCreation",
                value: new DateTime(2024, 11, 8, 21, 9, 29, 882, DateTimeKind.Local).AddTicks(8826));

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "DateOfCreation", "Name" },
                values: new object[] { 3, new DateTime(2024, 11, 8, 21, 9, 29, 882, DateTimeKind.Local).AddTicks(8828), "Product 3" });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateModified",
                value: new DateTime(2024, 11, 8, 21, 9, 29, 882, DateTimeKind.Local).AddTicks(8844));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateModified",
                value: new DateTime(2024, 11, 8, 21, 9, 29, 882, DateTimeKind.Local).AddTicks(8848));

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Id", "AdminId", "ClientId", "DateModified", "Format", "LiczbaStron", "Name", "ProductId" },
                values: new object[] { 4, new Guid("6b9957e6-6465-4cc4-a481-b699bbbe331e"), new Guid("71e2244b-3f26-4344-a9d6-93a00b8fd83f"), new DateTime(2024, 11, 8, 21, 9, 29, 882, DateTimeKind.Local).AddTicks(8852), "A6", 400, "Project 4", 1 });

            migrationBuilder.UpdateData(
                table: "Templates",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateModified",
                value: new DateTime(2024, 11, 8, 21, 9, 29, 882, DateTimeKind.Local).AddTicks(8868));

            migrationBuilder.UpdateData(
                table: "Templates",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateModified",
                value: new DateTime(2024, 11, 8, 21, 9, 29, 882, DateTimeKind.Local).AddTicks(8872));

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Id", "AdminId", "ClientId", "DateModified", "Format", "LiczbaStron", "Name", "ProductId" },
                values: new object[] { 3, new Guid("a86e8efd-ebf7-43a4-950c-3398d232de1b"), new Guid("71e2244b-3f26-4344-a9d6-93a00b8fd83f"), new DateTime(2024, 11, 8, 21, 9, 29, 882, DateTimeKind.Local).AddTicks(8850), "A5", 300, "Project 3", 3 });

            migrationBuilder.InsertData(
                table: "Templates",
                columns: new[] { "Id", "AdminId", "ClientId", "DateModified", "Format", "LiczbaStron", "Name", "ProductId" },
                values: new object[] { 3, new Guid("a86e8efd-ebf7-43a4-950c-3398d232de1b"), new Guid("599a628a-a3ea-40d9-9494-0ff27debf95d"), new DateTime(2024, 11, 8, 21, 9, 29, 882, DateTimeKind.Local).AddTicks(8874), "A5", 300, "Template 3", 3 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Templates",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateOfCreation",
                value: new DateTime(2024, 11, 8, 19, 50, 54, 214, DateTimeKind.Local).AddTicks(5479));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateOfCreation",
                value: new DateTime(2024, 11, 8, 19, 50, 54, 214, DateTimeKind.Local).AddTicks(5533));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateModified",
                value: new DateTime(2024, 11, 8, 19, 50, 54, 214, DateTimeKind.Local).AddTicks(5573));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateModified",
                value: new DateTime(2024, 11, 8, 19, 50, 54, 214, DateTimeKind.Local).AddTicks(5639));

            migrationBuilder.UpdateData(
                table: "Templates",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateModified",
                value: new DateTime(2024, 11, 8, 19, 50, 54, 214, DateTimeKind.Local).AddTicks(5679));

            migrationBuilder.UpdateData(
                table: "Templates",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateModified",
                value: new DateTime(2024, 11, 8, 19, 50, 54, 214, DateTimeKind.Local).AddTicks(5684));
        }
    }
}
