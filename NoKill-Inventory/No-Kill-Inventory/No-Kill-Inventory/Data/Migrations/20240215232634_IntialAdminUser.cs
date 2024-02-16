using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace No_Kill_Inventory.Migrations
{
    /// <inheritdoc />
    public partial class IntialAdminUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "c87f125f-55dc-49e9-9e82-30e4e5811951", 0, "", "adminuser", true, true, null, "ADMINUSER", "ADMINUSER", "AQAAAAIAAYagAAAAEC2nlncqTRsANLkvUS2tV1A7S41bZTLJRZwTHC12KCSlgeLTJdO/Xwa20WjvoVDkcA==", null, false, "b60868c5-0270-41e2-a7ef-2d37c3e64150", false, "adminuser" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c87f125f-55dc-49e9-9e82-30e4e5811951");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "1", 0, "", "adminuser", true, true, null, "ADMINUSER", "ADMINUSER", "AQAAAAIAAYagAAAAEBMjwrFhHQ7ZZCBzummLo3E+lqwtsgTdwvhe5z0tajAa7KLCJQ/ULfoN9iR++1vhZQ==", null, false, "", false, "adminuser" });
        }
    }
}
