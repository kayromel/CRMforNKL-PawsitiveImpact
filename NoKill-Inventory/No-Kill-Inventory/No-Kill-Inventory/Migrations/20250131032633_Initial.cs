using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NoKillInventory.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12554843e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f318a940-3616-4bce-99f1-92a513c3fe48", "AQAAAAIAAYagAAAAEK6yKym4eFtbcNTzrk7Gy61BxXdfixkSz5KE+iwysAUWBD1ZXsgGJVP1LxMh6ANyEA==", "f8cfe669-1e7a-470f-91e4-ae3676119d0c" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12554843e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3c81c7f1-14f4-43b7-b173-2f8ba4732b45", "AQAAAAIAAYagAAAAEHnwn6S61R6grDslytR6urmFIrgWOvTkVGvstTH1GDfAuRhKYOxEc0LBpQey0klcrA==", "b7f23999-2429-439c-b6a0-64f2500e6b38" });
        }
    }
}
