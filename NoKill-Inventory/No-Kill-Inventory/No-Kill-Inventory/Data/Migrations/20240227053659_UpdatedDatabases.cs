using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace No_Kill_Inventory.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedDatabases : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GrainFree",
                table: "DogItems");

            migrationBuilder.DropColumn(
                name: "Puppy",
                table: "DogItems");

            migrationBuilder.DropColumn(
                name: "SmBites",
                table: "DogItems");

            migrationBuilder.DropColumn(
                name: "Special",
                table: "DogItems");

            migrationBuilder.DropColumn(
                name: "Wet",
                table: "DogItems");

            migrationBuilder.DropColumn(
                name: "WgtCtrl",
                table: "DogItems");

            migrationBuilder.DropColumn(
                name: "Adult",
                table: "CatItems");

            migrationBuilder.DropColumn(
                name: "Kitty",
                table: "CatItems");

            migrationBuilder.DropColumn(
                name: "Special",
                table: "CatItems");

            migrationBuilder.DropColumn(
                name: "Wet",
                table: "CatItems");

            migrationBuilder.AddColumn<string>(
                name: "Type",
                table: "DogItems",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Type",
                table: "CatItems",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "OtherItems",
                columns: table => new
                {
                    ItemID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Animal = table.Column<string>(type: "TEXT", nullable: false),
                    Desc = table.Column<string>(type: "TEXT", nullable: false),
                    Weight = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OtherItems", x => x.ItemID);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12554843e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5644d6d9-862c-4aac-9f49-403d63d56fcd", "AQAAAAIAAYagAAAAEAuSLGd98m3qT4ErF9D3lAOOy3FlPj1GKevfZqdvadHG8lYt/smyMwuXMHu8KUoVfg==", "632097d3-704e-4b2d-9e85-1a5ba5b5dd9b" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12554843e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f4d13749-b218-4f00-968c-85f68f16ef49", "AQAAAAIAAYagAAAAEPu/Vd45DRRsb25MdOvFkrJVZ7u51BMCFNqTAd3khWqTIPuBKw9+GSlSlXz1wyrH6g==", "64708746-a16c-4ee2-af0f-3e76dbb572b9" });
        }
    }
}
