using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NoKillInventory.Migrations
{
    /// <inheritdoc />
    public partial class UpdateVolunteerTrackingToMinutes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TotalHours",
                table: "Volunteers",
                newName: "TotalMinutes");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12554843e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fc8b04f3-07a0-48c1-8926-0e43125b1626", "AQAAAAIAAYagAAAAEAsKBT9H4CSMqkx3haBdp3bcxv6896TaqZ0BEkd9OTCRFhH5c/tcSFqzwOfrEJoiSw==", "bc0d1491-5bb3-412d-a1d5-321d670fe8f5" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TotalMinutes",
                table: "Volunteers",
                newName: "TotalHours");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12554843e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d3a209d8-2c65-4dbf-92b4-7ac0e377cc14", "AQAAAAIAAYagAAAAEHY7rt6p5bhDP+kMG6mOfHBcDNWgmy4m1jekDkhVqNK+7pk6Zgw8+6i2k7oecP3YLA==", "7a75a99b-f815-445c-b291-2579f4df2440" });
        }
    }
}
