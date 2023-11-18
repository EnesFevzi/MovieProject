using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MovieProject.DataAccess.Migrations
{
    public partial class initial2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CreatedDate", "Name" },
                values: new object[] { 1, new DateTime(2023, 11, 15, 19, 17, 15, 168, DateTimeKind.Local).AddTicks(7802), "Komedi" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CreatedDate", "Name" },
                values: new object[] { 2, new DateTime(2023, 11, 15, 19, 17, 15, 168, DateTimeKind.Local).AddTicks(7814), "Bilim Kurgu" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CreatedDate", "Name" },
                values: new object[] { 3, new DateTime(2023, 11, 15, 19, 17, 15, 168, DateTimeKind.Local).AddTicks(7815), "Gerilim" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3);
        }
    }
}
