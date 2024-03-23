using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TodoList.DAL.Migrations
{
    /// <inheritdoc />
    public partial class addValidations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Todos_Name",
                table: "Todos");

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 1,
                column: "DeadLine",
                value: new DateTime(2024, 3, 24, 0, 21, 44, 447, DateTimeKind.Local).AddTicks(7634));

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 2,
                column: "DeadLine",
                value: new DateTime(2024, 3, 25, 0, 21, 44, 447, DateTimeKind.Local).AddTicks(7702));

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 3,
                column: "DeadLine",
                value: new DateTime(2024, 3, 26, 0, 21, 44, 447, DateTimeKind.Local).AddTicks(7706));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 1,
                column: "DeadLine",
                value: new DateTime(2024, 3, 23, 11, 56, 57, 586, DateTimeKind.Local).AddTicks(4695));

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 2,
                column: "DeadLine",
                value: new DateTime(2024, 3, 24, 11, 56, 57, 586, DateTimeKind.Local).AddTicks(4744));

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 3,
                column: "DeadLine",
                value: new DateTime(2024, 3, 25, 11, 56, 57, 586, DateTimeKind.Local).AddTicks(4748));

            migrationBuilder.CreateIndex(
                name: "IX_Todos_Name",
                table: "Todos",
                column: "Name",
                unique: true);
        }
    }
}
