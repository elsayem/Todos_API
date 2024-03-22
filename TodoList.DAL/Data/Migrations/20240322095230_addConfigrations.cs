using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TodoList.DAL.Migrations
{
    /// <inheritdoc />
    public partial class addConfigrations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "description",
                table: "Todos",
                newName: "Description");

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 1,
                column: "DeadLine",
                value: new DateTime(2024, 3, 23, 11, 52, 28, 131, DateTimeKind.Local).AddTicks(3234));

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 2,
                column: "DeadLine",
                value: new DateTime(2024, 3, 24, 11, 52, 28, 131, DateTimeKind.Local).AddTicks(3283));

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 3,
                column: "DeadLine",
                value: new DateTime(2024, 3, 25, 11, 52, 28, 131, DateTimeKind.Local).AddTicks(3287));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Todos",
                newName: "description");

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 1,
                column: "DeadLine",
                value: new DateTime(2024, 3, 22, 16, 51, 23, 907, DateTimeKind.Local).AddTicks(3924));

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 2,
                column: "DeadLine",
                value: new DateTime(2024, 3, 23, 16, 51, 23, 907, DateTimeKind.Local).AddTicks(3976));

            migrationBuilder.UpdateData(
                table: "Todos",
                keyColumn: "Id",
                keyValue: 3,
                column: "DeadLine",
                value: new DateTime(2024, 3, 24, 16, 51, 23, 907, DateTimeKind.Local).AddTicks(3980));
        }
    }
}
