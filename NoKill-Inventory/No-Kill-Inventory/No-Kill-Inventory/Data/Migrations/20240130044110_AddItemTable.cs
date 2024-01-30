using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace No_Kill_Inventory.Migrations
{
    /// <inheritdoc />
    public partial class AddItemTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    itemID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Brand = table.Column<string>(type: "TEXT", nullable: false),
                    Animal = table.Column<string>(type: "TEXT", nullable: false),
                    Prescription = table.Column<bool>(type: "INTEGER", nullable: false),
                    PrescriptionDesc = table.Column<string>(type: "TEXT", nullable: true),
                    DryWet = table.Column<string>(type: "TEXT", nullable: false),
                    Age = table.Column<string>(type: "TEXT", nullable: false),
                    GrainFree = table.Column<bool>(type: "INTEGER", nullable: false),
                    WeightCtrl = table.Column<bool>(type: "INTEGER", nullable: false),
                    SmallBites = table.Column<bool>(type: "INTEGER", nullable: false),
                    Junk = table.Column<bool>(type: "INTEGER", nullable: false),
                    Qty = table.Column<int>(type: "INTEGER", nullable: false),
                    FoodWeight = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.itemID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Items");
        }
    }
}
