using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PMS_Api.Migrations
{
    /// <inheritdoc />
    public partial class changeProjectTemplateModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateOfCreation",
                value: new DateTime(2024, 11, 8, 21, 9, 29, 882, DateTimeKind.Local).AddTicks(8828));

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

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateModified",
                value: new DateTime(2024, 11, 8, 21, 9, 29, 882, DateTimeKind.Local).AddTicks(8850));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateModified",
                value: new DateTime(2024, 11, 8, 21, 9, 29, 882, DateTimeKind.Local).AddTicks(8852));

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

            migrationBuilder.UpdateData(
                table: "Templates",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateModified",
                value: new DateTime(2024, 11, 8, 21, 9, 29, 882, DateTimeKind.Local).AddTicks(8874));
        }
    }
}
