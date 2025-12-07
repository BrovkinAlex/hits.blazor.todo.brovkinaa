using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TodoServerApp.Migrations
{
    /// <inheritdoc />
    public partial class AddRest : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "TaskItem",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 7, 14, 9, 58, 84, DateTimeKind.Local).AddTicks(8220));

            migrationBuilder.UpdateData(
                table: "TaskItem",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 7, 14, 9, 58, 96, DateTimeKind.Local).AddTicks(7359));

            migrationBuilder.UpdateData(
                table: "TaskItem",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 7, 14, 9, 58, 96, DateTimeKind.Local).AddTicks(7376));

            migrationBuilder.UpdateData(
                table: "TaskItem",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 7, 14, 9, 58, 96, DateTimeKind.Local).AddTicks(7379));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "TaskItem",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 6, 19, 8, 55, 790, DateTimeKind.Local).AddTicks(1301));

            migrationBuilder.UpdateData(
                table: "TaskItem",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 6, 19, 8, 55, 802, DateTimeKind.Local).AddTicks(4725));

            migrationBuilder.UpdateData(
                table: "TaskItem",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 6, 19, 8, 55, 802, DateTimeKind.Local).AddTicks(4748));

            migrationBuilder.UpdateData(
                table: "TaskItem",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2025, 12, 6, 19, 8, 55, 802, DateTimeKind.Local).AddTicks(4751));
        }
    }
}
