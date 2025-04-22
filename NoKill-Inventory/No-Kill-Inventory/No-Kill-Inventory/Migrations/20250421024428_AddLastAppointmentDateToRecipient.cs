using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NoKillInventory.Migrations
{
    /// <inheritdoc />
    public partial class AddLastAppointmentDateToRecipient : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "LastAppointmentDate",
                table: "Recipients",
                type: "TEXT",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12554843e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4bd8c36f-c4bb-4ef1-8d40-be1902effd54", "AQAAAAIAAYagAAAAEIqbCi+s51YBfEq8GFoSxfQqRafA1fXtE0nsM4D0gzqRykzmqJ8YZHC2toB2TyWpNg==", "26005b3d-2f6b-4cf8-8d6e-212c4c537357" });

            migrationBuilder.UpdateData(
                table: "Recipients",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastAppointmentDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "Recipients",
                keyColumn: "Id",
                keyValue: 2,
                column: "LastAppointmentDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "Recipients",
                keyColumn: "Id",
                keyValue: 3,
                column: "LastAppointmentDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "Recipients",
                keyColumn: "Id",
                keyValue: 4,
                column: "LastAppointmentDate",
                value: null);

            migrationBuilder.UpdateData(
                table: "Recipients",
                keyColumn: "Id",
                keyValue: 5,
                column: "LastAppointmentDate",
                value: null);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LastAppointmentDate",
                table: "Recipients");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12554843e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8644c639-9814-4cf9-865d-2ef41ae37253", "AQAAAAIAAYagAAAAEPjA6ejSgcZ+gdMdggpE2iDsibD9hW2AM5gIF+quHzJZJCEiSd19fE93BS96Repjdg==", "42bd4c33-e8c9-48fd-ab42-4082a7c79477" });
        }
    }
}
