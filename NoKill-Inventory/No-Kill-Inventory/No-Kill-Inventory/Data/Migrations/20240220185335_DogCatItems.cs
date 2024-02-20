using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace No_Kill_Inventory.Migrations
{
    /// <inheritdoc />
    public partial class DogCatItems : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CatItems",
                columns: table => new
                {
                    ItemID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Wet = table.Column<bool>(type: "INTEGER", nullable: false),
                    Adult = table.Column<bool>(type: "INTEGER", nullable: false),
                    Kitty = table.Column<bool>(type: "INTEGER", nullable: false),
                    Special = table.Column<string>(type: "TEXT", nullable: true),
                    Weight = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CatItems", x => x.ItemID);
                });

            migrationBuilder.CreateTable(
                name: "DogItems",
                columns: table => new
                {
                    ItemID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Wet = table.Column<bool>(type: "INTEGER", nullable: false),
                    Puppy = table.Column<bool>(type: "INTEGER", nullable: false),
                    WgtCtrl = table.Column<bool>(type: "INTEGER", nullable: false),
                    GrainFree = table.Column<bool>(type: "INTEGER", nullable: false),
                    SmBites = table.Column<bool>(type: "INTEGER", nullable: false),
                    Special = table.Column<string>(type: "TEXT", nullable: true),
                    Weight = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DogItems", x => x.ItemID);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12554843e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f4d13749-b218-4f00-968c-85f68f16ef49", "AQAAAAIAAYagAAAAEPu/Vd45DRRsb25MdOvFkrJVZ7u51BMCFNqTAd3khWqTIPuBKw9+GSlSlXz1wyrH6g==", "64708746-a16c-4ee2-af0f-3e76dbb572b9" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CatItems");

            migrationBuilder.DropTable(
                name: "DogItems");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12554843e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fc4fc6a4-0a42-46b4-a7e7-e16adcb1435b", "AQAAAAIAAYagAAAAEH8E2rK/PbRK8uznBTsTxLpchnquer29rQFdtQOFewDqxrbfMmNOydb2/be7vDIrTg==", "d5d64753-2e7c-411a-b2a9-bf53e1d7063c" });
        }
    }
}
