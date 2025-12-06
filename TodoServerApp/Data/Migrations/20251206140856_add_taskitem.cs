using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TodoServerApp.Migrations
{
    /// <inheritdoc />
    public partial class add_taskitem : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TaskItem",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(type: "TEXT", nullable: true),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: true),
                    FinishDate = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaskItem", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "TaskItem",
                columns: new[] { "Id", "CreatedDate", "Description", "FinishDate", "Title" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 12, 6, 19, 8, 55, 790, DateTimeKind.Local).AddTicks(1301), "Описание задачи 1", null, "Задача 1" },
                    { 2, new DateTime(2025, 12, 6, 19, 8, 55, 802, DateTimeKind.Local).AddTicks(4725), "Описание задачи 2", null, "Задача 2" },
                    { 3, new DateTime(2025, 12, 6, 19, 8, 55, 802, DateTimeKind.Local).AddTicks(4748), "Описание задачи 3", null, "Задача 3" },
                    { 4, new DateTime(2025, 12, 6, 19, 8, 55, 802, DateTimeKind.Local).AddTicks(4751), "Описание задачи 4", null, "Задача 4" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TaskItem");
        }
    }
}
