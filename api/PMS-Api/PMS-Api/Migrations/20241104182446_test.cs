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
            migrationBuilder.DropPrimaryKey(
                name: "PK_Admins",
                table: "Admins");

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Id",
                keyColumnType: "int",
                keyValue: 2);

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Admins");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Admins",
                table: "Admins",
                column: "Uuid");

            migrationBuilder.InsertData(
                table: "Admins",
                columns: new[] { "Uuid", "Email", "Name", "Password", "createdAt" },
                values: new object[,]
                {
                    { new Guid("6162e909-a5ca-40b9-a4fe-e9bac2607891"), "testemail@test.com", "Admin", "1234", "18.08.2024" },
                    { new Guid("ed2e192a-2e42-471f-af8f-41c9c09ddf29"), "admin@test.com", "Administrator", "1234", "04.11.2024" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Admins",
                table: "Admins");

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Uuid",
                keyValue: new Guid("6162e909-a5ca-40b9-a4fe-e9bac2607891"));

            migrationBuilder.DeleteData(
                table: "Admins",
                keyColumn: "Uuid",
                keyValue: new Guid("ed2e192a-2e42-471f-af8f-41c9c09ddf29"));

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Admins",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Admins",
                table: "Admins",
                column: "Id");

            migrationBuilder.InsertData(
                table: "Admins",
                columns: new[] { "Id", "Email", "Name", "Password", "Uuid", "createdAt" },
                values: new object[,]
                {
                    { 1, "testemail@test.com", "Admin", "1234", new Guid("b6938ebb-b2b2-4d4e-a346-47dfe45316b3"), "18.08.2024" },
                    { 2, "admin@test.com", "Administrator", "1234", new Guid("b35cad50-1d90-4bd1-bc61-886279633dbb"), "04.11.2024" }
                });
        }
    }
}
