using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NoKillInventory.Migrations
{
    /// <inheritdoc />
    public partial class AddItemsReceivingToRecipient : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ItemsReceiving",
                table: "Recipients",
                type: "TEXT",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12554843e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8644c639-9814-4cf9-865d-2ef41ae37253", "AQAAAAIAAYagAAAAEPjA6ejSgcZ+gdMdggpE2iDsibD9hW2AM5gIF+quHzJZJCEiSd19fE93BS96Repjdg==", "42bd4c33-e8c9-48fd-ab42-4082a7c79477" });

            migrationBuilder.UpdateData(
                table: "Recipients",
                keyColumn: "Id",
                keyValue: 1,
                column: "ItemsReceiving",
                value: null);

            migrationBuilder.UpdateData(
                table: "Recipients",
                keyColumn: "Id",
                keyValue: 2,
                column: "ItemsReceiving",
                value: null);

            migrationBuilder.UpdateData(
                table: "Recipients",
                keyColumn: "Id",
                keyValue: 3,
                column: "ItemsReceiving",
                value: null);

            migrationBuilder.UpdateData(
                table: "Recipients",
                keyColumn: "Id",
                keyValue: 4,
                column: "ItemsReceiving",
                value: null);

            migrationBuilder.UpdateData(
                table: "Recipients",
                keyColumn: "Id",
                keyValue: 5,
                column: "ItemsReceiving",
                value: null);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ItemsReceiving",
                table: "Recipients");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12554843e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f318a940-3616-4bce-99f1-92a513c3fe48", "AQAAAAIAAYagAAAAEK6yKym4eFtbcNTzrk7Gy61BxXdfixkSz5KE+iwysAUWBD1ZXsgGJVP1LxMh6ANyEA==", "f8cfe669-1e7a-470f-91e4-ae3676119d0c" });
        }
    }
}
