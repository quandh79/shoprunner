using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace server.Migrations
{
    public partial class ok : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("078269d8-1a12-4592-b92e-7ff1a876a5f2"),
                column: "ConcurrencyStamp",
                value: "ea019cbe-76ab-4b68-8554-132bac471eba");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("6d9186ba-2cd6-4b6c-b729-4e605de1019f"),
                column: "ConcurrencyStamp",
                value: "8c22e436-f5a8-47a3-81d5-a22bc5d60147");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4557893f-1f56-4b6f-bb3b-caefd62c8c49"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "080a8d11-47df-4d6b-a584-8b84a531bc40", "AQAAAAEAACcQAAAAEDGXDI1WwaIuCheWIRjmKrfyb28ASkdP7YxR6lxuVn9lXTF8FQCflwQ5r6ScoirXsg==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("078269d8-1a12-4592-b92e-7ff1a876a5f2"),
                column: "ConcurrencyStamp",
                value: "89511aa0-0d3b-4e24-9aba-a0c70cfbe474");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("6d9186ba-2cd6-4b6c-b729-4e605de1019f"),
                column: "ConcurrencyStamp",
                value: "f0b1080f-c7e4-4fae-a63e-627bd5a9ad16");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4557893f-1f56-4b6f-bb3b-caefd62c8c49"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d7ead9f2-febc-42d1-9f3c-777176097cad", "AQAAAAEAACcQAAAAEOW/aD5q0QuxQtotTbCo6Ohdb5a+AZeOU2umSuGaZEKkVVo3CwTujz4oIyi8CK6ElA==" });
        }
    }
}
