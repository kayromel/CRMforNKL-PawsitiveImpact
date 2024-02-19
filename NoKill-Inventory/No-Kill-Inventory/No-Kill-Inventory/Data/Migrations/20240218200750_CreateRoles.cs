using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace No_Kill_Inventory.Migrations
{
    /// <inheritdoc />
    public partial class CreateRoles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d407a6c9-0899-42b1-8a00-6269d34e44af");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "5892205e-d5a7-4bed-8424-b36569197dfc", "bb1463d7-2eb8-49c6-85ec-3c26ddf1cb8d" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5892205e-d5a7-4bed-8424-b36569197dfc");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bb1463d7-2eb8-49c6-85ec-3c26ddf1cb8d");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "c7b013f0-5201-4317-abd8-c211f91b7330", "2", "User", "User" },
                    { "fab4fac1-c546-41de-aebc-a14da6895711", "1", "Admin", "Admin" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "b74ddd14-6340-4840-95c2-db12554843e5", 0, "fc4fc6a4-0a42-46b4-a7e7-e16adcb1435b", "adminuser", true, true, null, "ADMINUSER", "ADMINUSER", "AQAAAAIAAYagAAAAEH8E2rK/PbRK8uznBTsTxLpchnquer29rQFdtQOFewDqxrbfMmNOydb2/be7vDIrTg==", null, false, "d5d64753-2e7c-411a-b2a9-bf53e1d7063c", false, "adminuser" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "fab4fac1-c546-41de-aebc-a14da6895711", "b74ddd14-6340-4840-95c2-db12554843e5" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c7b013f0-5201-4317-abd8-c211f91b7330");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "fab4fac1-c546-41de-aebc-a14da6895711", "b74ddd14-6340-4840-95c2-db12554843e5" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fab4fac1-c546-41de-aebc-a14da6895711");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12554843e5");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "5892205e-d5a7-4bed-8424-b36569197dfc", "6f138323-a226-47a3-b034-98efe3ee9f8a", "Admin", "ADMIN" },
                    { "d407a6c9-0899-42b1-8a00-6269d34e44af", "644bd3a5-302c-4a5a-803f-0d1e27122df2", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "bb1463d7-2eb8-49c6-85ec-3c26ddf1cb8d", 0, "57cf737a-d918-4e2c-9430-891fa5d60c5b", "adminuser", true, true, null, "ADMINUSER", "ADMINUSER", "AQAAAAIAAYagAAAAEAw0UXmDu7MQUapRRFOEHcgsv0oHL7GwLgxTIWwuQigwaj0I/BwjF+pa5MLnHN7ySw==", null, false, "567ffb8f-a070-4d5e-8a07-b6ec1ecce821", false, "adminuser" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "5892205e-d5a7-4bed-8424-b36569197dfc", "bb1463d7-2eb8-49c6-85ec-3c26ddf1cb8d" });
        }
    }
}
