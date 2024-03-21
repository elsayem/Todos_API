using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TodoList.DAL.Migrations
{
    /// <inheritdoc />
    public partial class secondOne : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Todos",
                columns: new[] { "Id", "DeadLine", "Name", "description" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 3, 22, 16, 51, 23, 907, DateTimeKind.Local).AddTicks(3924), "Models", "Models for Every Entity" },
                    { 2, new DateTime(2024, 3, 23, 16, 51, 23, 907, DateTimeKind.Local).AddTicks(3976), "Views", "Views for Every Controller" },
                    { 3, new DateTime(2024, 3, 24, 16, 51, 23, 907, DateTimeKind.Local).AddTicks(3980), "Validations", "Validate User input" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
