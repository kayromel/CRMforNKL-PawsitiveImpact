using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace No_Kill_Inventory.Migrations
{
    /// <inheritdoc />
    public partial class Lengths : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12554843e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2ab830ef-168b-4b06-8e81-32e994b6c940", "AQAAAAIAAYagAAAAEIaOXzntZdCK5dGWUtXeYu5gOU8fFfJs86/HlR5WNP/EOk431crSJRdyQuESnVIdPA==", "f22202e5-051d-4382-bc53-7b440341e006" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12554843e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b83bd6ff-d0f6-4bc1-8174-a0d677488ca0", "AQAAAAIAAYagAAAAEDkeBrjsTK3Zi+7EID4KQHJW+s/j02Km3OwmzmoNwG7Mq8UySVIwC07F2jFF9Aeo4Q==", "487e0faf-3bb3-4b60-85d3-d3af35a9bed4" });
        }
    }
}
