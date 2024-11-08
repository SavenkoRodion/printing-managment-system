using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PMS_Api.Migrations
{
    /// <inheritdoc />
    public partial class AddingTestData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Admins",
                columns: table => new
                {
                    Uuid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateOnly>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admins", x => x.Uuid);
                });

            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    Uuid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.Uuid);
                });

            migrationBuilder.CreateTable(
                name: "Parameters",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parameters", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfCreation = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Projects",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClientId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Format = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LiczbaStron = table.Column<int>(type: "int", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AdminId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projects", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Projects_Admins_AdminId",
                        column: x => x.AdminId,
                        principalTable: "Admins",
                        principalColumn: "Uuid",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Projects_Clients_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Clients",
                        principalColumn: "Uuid",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Projects_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Templates",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClientId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Format = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LiczbaStron = table.Column<int>(type: "int", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AdminId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Templates", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Templates_Admins_AdminId",
                        column: x => x.AdminId,
                        principalTable: "Admins",
                        principalColumn: "Uuid",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Templates_Clients_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Clients",
                        principalColumn: "Uuid",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Templates_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Admins",
                columns: new[] { "Uuid", "CreatedAt", "Email", "Name", "Password" },
                values: new object[,]
                {
                    { new Guid("6b9957e6-6465-4cc4-a481-b699bbbe331e"), new DateOnly(2024, 7, 4), "admin@test.com", "Administrator", "1234" },
                    { new Guid("a86e8efd-ebf7-43a4-950c-3398d232de1b"), new DateOnly(2024, 11, 4), "testemail@test.com", "Admin", "1234" }
                });

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "Uuid", "Name" },
                values: new object[,]
                {
                    { new Guid("599a628a-a3ea-40d9-9494-0ff27debf95d"), "Client B" },
                    { new Guid("71e2244b-3f26-4344-a9d6-93a00b8fd83f"), "Client A" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "DateOfCreation", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 11, 8, 19, 41, 32, 464, DateTimeKind.Local).AddTicks(4899), "Product 1" },
                    { 2, new DateTime(2024, 11, 8, 19, 41, 32, 464, DateTimeKind.Local).AddTicks(4936), "Product 2" }
                });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Id", "AdminId", "ClientId", "DateModified", "Format", "LiczbaStron", "Name", "ProductId" },
                values: new object[,]
                {
                    { 1, new Guid("a86e8efd-ebf7-43a4-950c-3398d232de1b"), new Guid("71e2244b-3f26-4344-a9d6-93a00b8fd83f"), new DateTime(2024, 11, 8, 19, 41, 32, 464, DateTimeKind.Local).AddTicks(4955), "A4", 100, "Project 1", 1 },
                    { 2, new Guid("6b9957e6-6465-4cc4-a481-b699bbbe331e"), new Guid("599a628a-a3ea-40d9-9494-0ff27debf95d"), new DateTime(2024, 11, 8, 19, 41, 32, 464, DateTimeKind.Local).AddTicks(4959), "A3", 200, "Project 2", 2 }
                });

            migrationBuilder.InsertData(
                table: "Templates",
                columns: new[] { "Id", "AdminId", "ClientId", "DateModified", "Format", "LiczbaStron", "Name", "ProductId" },
                values: new object[,]
                {
                    { 1, new Guid("a86e8efd-ebf7-43a4-950c-3398d232de1b"), new Guid("71e2244b-3f26-4344-a9d6-93a00b8fd83f"), new DateTime(2024, 11, 8, 19, 41, 32, 464, DateTimeKind.Local).AddTicks(4974), "A4", 100, "Template 1", 1 },
                    { 2, new Guid("6b9957e6-6465-4cc4-a481-b699bbbe331e"), new Guid("599a628a-a3ea-40d9-9494-0ff27debf95d"), new DateTime(2024, 11, 8, 19, 41, 32, 464, DateTimeKind.Local).AddTicks(4978), "A3", 200, "Template 2", 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Projects_AdminId",
                table: "Projects",
                column: "AdminId");

            migrationBuilder.CreateIndex(
                name: "IX_Projects_ClientId",
                table: "Projects",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_Projects_ProductId",
                table: "Projects",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Templates_AdminId",
                table: "Templates",
                column: "AdminId");

            migrationBuilder.CreateIndex(
                name: "IX_Templates_ClientId",
                table: "Templates",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_Templates_ProductId",
                table: "Templates",
                column: "ProductId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Parameters");

            migrationBuilder.DropTable(
                name: "Projects");

            migrationBuilder.DropTable(
                name: "Templates");

            migrationBuilder.DropTable(
                name: "Admins");

            migrationBuilder.DropTable(
                name: "Clients");

            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
