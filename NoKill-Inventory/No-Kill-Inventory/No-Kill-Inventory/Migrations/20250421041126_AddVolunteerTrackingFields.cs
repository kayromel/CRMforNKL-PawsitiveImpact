using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NoKillInventory.Migrations
{
    /// <inheritdoc />
    public partial class AddVolunteerTrackingFields : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CheckInTime",
                table: "Volunteers",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "TotalHours",
                table: "Volunteers",
                type: "REAL",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12554843e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d3a209d8-2c65-4dbf-92b4-7ac0e377cc14", "AQAAAAIAAYagAAAAEHY7rt6p5bhDP+kMG6mOfHBcDNWgmy4m1jekDkhVqNK+7pk6Zgw8+6i2k7oecP3YLA==", "7a75a99b-f815-445c-b291-2579f4df2440" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CheckInTime",
                table: "Volunteers");

            migrationBuilder.DropColumn(
                name: "TotalHours",
                table: "Volunteers");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12554843e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4bd8c36f-c4bb-4ef1-8d40-be1902effd54", "AQAAAAIAAYagAAAAEIqbCi+s51YBfEq8GFoSxfQqRafA1fXtE0nsM4D0gzqRykzmqJ8YZHC2toB2TyWpNg==", "26005b3d-2f6b-4cf8-8d6e-212c4c537357" });
        }
    }
}
