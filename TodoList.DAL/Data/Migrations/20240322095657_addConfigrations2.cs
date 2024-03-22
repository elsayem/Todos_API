using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TodoList.DAL.Migrations
{
    /// <inheritdoc />
    public partial class addConfigrations2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Todos",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Todos",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DeadLine",
                table: "Todos",
                type: "datetime2",
                nullable: false,
                defaultValueSql: "DATEADD(hour, 2, GETDATE())",
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Todos_Name",
                table: "Todos");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Todos",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Todos",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DeadLine",
                table: "Todos",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValueSql: "DATEADD(hour, 2, GETDATE())");

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
    }
}
