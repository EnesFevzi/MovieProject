using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MovieProject.DataAccess.Migrations
{
    public partial class initial3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Actors",
                columns: new[] { "ActorId", "CreatedDate", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 11, 15, 19, 31, 48, 439, DateTimeKind.Local).AddTicks(9196), "Morgan Freeman" },
                    { 2, new DateTime(2023, 11, 15, 19, 31, 48, 439, DateTimeKind.Local).AddTicks(9205), "Tom Holland" },
                    { 3, new DateTime(2023, 11, 15, 19, 31, 48, 439, DateTimeKind.Local).AddTicks(9206), "Cillian Murphy" }
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 15, 19, 31, 48, 439, DateTimeKind.Local).AddTicks(9325));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 15, 19, 31, 48, 439, DateTimeKind.Local).AddTicks(9327));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 15, 19, 31, 48, 439, DateTimeKind.Local).AddTicks(9327));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 15, 19, 17, 15, 168, DateTimeKind.Local).AddTicks(7802));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 15, 19, 17, 15, 168, DateTimeKind.Local).AddTicks(7814));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 11, 15, 19, 17, 15, 168, DateTimeKind.Local).AddTicks(7815));
        }
    }
}
