using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class SeedCustomers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Customer",
                columns: new[] { "Id", "DOB", "First_name", "Gender", "Last_name" },
                values: new object[] { 1, new DateTime(1980, 8, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "John", "Male", "Munroe" });

            migrationBuilder.InsertData(
                table: "Customer",
                columns: new[] { "Id", "DOB", "First_name", "Gender", "Last_name" },
                values: new object[] { 2, new DateTime(1990, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Danica", "Female", "Blake" });

            migrationBuilder.InsertData(
                table: "Customer",
                columns: new[] { "Id", "DOB", "First_name", "Gender", "Last_name" },
                values: new object[] { 3, new DateTime(1998, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Monica", "Female", "Sandy" });

            migrationBuilder.InsertData(
                table: "Customer",
                columns: new[] { "Id", "DOB", "First_name", "Gender", "Last_name" },
                values: new object[] { 4, new DateTime(1970, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Colm", "Male", "Blair" });

            migrationBuilder.InsertData(
                table: "Customer",
                columns: new[] { "Id", "DOB", "First_name", "Gender", "Last_name" },
                values: new object[] { 5, new DateTime(1984, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Declan", "Male", "Rowley" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
