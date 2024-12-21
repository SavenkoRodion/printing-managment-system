using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PMS_Api.Migrations
{
    /// <inheritdoc />
    public partial class renameProductsIntoProjectType : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Projects_Products_ProductId",
                table: "Projects");

            migrationBuilder.DropForeignKey(
                name: "FK_Templates_Products_ProductId",
                table: "Templates");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.RenameColumn(
                name: "ProductId",
                table: "Templates",
                newName: "ProjectTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_Templates_ProductId",
                table: "Templates",
                newName: "IX_Templates_ProjectTypeId");

            migrationBuilder.RenameColumn(
                name: "ProductId",
                table: "Projects",
                newName: "ProjectTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_Projects_ProductId",
                table: "Projects",
                newName: "IX_Projects_ProjectTypeId");

            migrationBuilder.CreateTable(
                name: "ProjectTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfCreation = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectTypes", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Uuid",
                keyValue: new Guid("599a628a-a3ea-40d9-9494-0ff27debf95d"),
                column: "DateOfCreation",
                value: new DateTime(2024, 12, 14, 14, 39, 14, 554, DateTimeKind.Local).AddTicks(6206));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Uuid",
                keyValue: new Guid("71e2244b-3f26-4344-a9d6-93a00b8fd83f"),
                column: "DateOfCreation",
                value: new DateTime(2024, 12, 14, 14, 39, 14, 554, DateTimeKind.Local).AddTicks(6168));

            migrationBuilder.InsertData(
                table: "ProjectTypes",
                columns: new[] { "Id", "DateOfCreation", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 12, 14, 14, 39, 14, 554, DateTimeKind.Local).AddTicks(6226), "ProjectType 1" },
                    { 2, new DateTime(2024, 12, 14, 14, 39, 14, 554, DateTimeKind.Local).AddTicks(6229), "ProjectType 2" },
                    { 3, new DateTime(2024, 12, 14, 14, 39, 14, 554, DateTimeKind.Local).AddTicks(6231), "ProjectType 3" }
                });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateModified",
                value: new DateTime(2024, 12, 14, 14, 39, 14, 554, DateTimeKind.Local).AddTicks(6247));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateModified",
                value: new DateTime(2024, 12, 14, 14, 39, 14, 554, DateTimeKind.Local).AddTicks(6250));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateModified",
                value: new DateTime(2024, 12, 14, 14, 39, 14, 554, DateTimeKind.Local).AddTicks(6252));

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateModified",
                value: new DateTime(2024, 12, 14, 14, 39, 14, 554, DateTimeKind.Local).AddTicks(6254));

            migrationBuilder.UpdateData(
                table: "Templates",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateModified",
                value: new DateTime(2024, 12, 14, 14, 39, 14, 554, DateTimeKind.Local).AddTicks(6271));

            migrationBuilder.UpdateData(
                table: "Templates",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateModified",
                value: new DateTime(2024, 12, 14, 14, 39, 14, 554, DateTimeKind.Local).AddTicks(6274));

            migrationBuilder.UpdateData(
                table: "Templates",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateModified",
                value: new DateTime(2024, 12, 14, 14, 39, 14, 554, DateTimeKind.Local).AddTicks(6277));

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_ProjectTypes_ProjectTypeId",
                table: "Projects",
                column: "ProjectTypeId",
                principalTable: "ProjectTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Templates_ProjectTypes_ProjectTypeId",
                table: "Templates",
                column: "ProjectTypeId",
                principalTable: "ProjectTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Projects_ProjectTypes_ProjectTypeId",
                table: "Projects");

            migrationBuilder.DropForeignKey(
                name: "FK_Templates_ProjectTypes_ProjectTypeId",
                table: "Templates");

            migrationBuilder.DropTable(
                name: "ProjectTypes");

            migrationBuilder.RenameColumn(
                name: "ProjectTypeId",
                table: "Templates",
                newName: "ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_Templates_ProjectTypeId",
                table: "Templates",
                newName: "IX_Templates_ProductId");

            migrationBuilder.RenameColumn(
                name: "ProjectTypeId",
                table: "Projects",
                newName: "ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_Projects_ProjectTypeId",
                table: "Projects",
                newName: "IX_Projects_ProductId");

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateOfCreation = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Uuid",
                keyValue: new Guid("599a628a-a3ea-40d9-9494-0ff27debf95d"),
                column: "DateOfCreation",
                value: new DateTime(2024, 11, 26, 18, 35, 4, 49, DateTimeKind.Local).AddTicks(1110));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Uuid",
                keyValue: new Guid("71e2244b-3f26-4344-a9d6-93a00b8fd83f"),
                column: "DateOfCreation",
                value: new DateTime(2024, 11, 26, 18, 35, 4, 49, DateTimeKind.Local).AddTicks(1071));

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "DateOfCreation", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 11, 26, 18, 35, 4, 49, DateTimeKind.Local).AddTicks(1127), "Product 1" },
                    { 2, new DateTime(2024, 11, 26, 18, 35, 4, 49, DateTimeKind.Local).AddTicks(1129), "Product 2" },
                    { 3, new DateTime(2024, 11, 26, 18, 35, 4, 49, DateTimeKind.Local).AddTicks(1131), "Product 3" }
                });

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

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_Products_ProductId",
                table: "Projects",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Templates_Products_ProductId",
                table: "Templates",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
