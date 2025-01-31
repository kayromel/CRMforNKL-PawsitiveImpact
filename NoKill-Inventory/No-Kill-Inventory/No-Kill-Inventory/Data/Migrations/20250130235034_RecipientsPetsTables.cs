using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace No_Kill_Inventory.Migrations
{
    /// <inheritdoc />
    public partial class RecipientsPetsTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Recipients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FirstName = table.Column<string>(type: "TEXT", nullable: false),
                    LastName = table.Column<string>(type: "TEXT", nullable: false),
                    PhoneNumber = table.Column<string>(type: "TEXT", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recipients", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Pets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Type = table.Column<int>(type: "INTEGER", nullable: false),
                    FoodType = table.Column<string>(type: "TEXT", nullable: false),
                    FoodAmount = table.Column<int>(type: "INTEGER", nullable: false),
                    RecipientId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pets_Recipients_RecipientId",
                        column: x => x.RecipientId,
                        principalTable: "Recipients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12554843e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "deac9c1b-222c-499f-b02b-7d34179f98fb", "AQAAAAIAAYagAAAAEMJJ6YDFmNJh9bZsr0RNplTyng7lw3hpwVcrjo9MVVDSrJBPSuIZlDGgblHirQaEVQ==", "650d9a14-2b3f-4772-ae9f-3ee3eb0abb11" });

            migrationBuilder.InsertData(
                table: "Recipients",
                columns: new[] { "Id", "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[,]
                {
                    { 1, "billy@gmail.com", "Billy", "Madison", "555-555-5555" },
                    { 2, "sarahc@gmail.com", "Sarah", "Connor", "444-123-9876" },
                    { 3, "johndoe@example.com", "John", "Doe", "333-456-7890" },
                    { 4, "janesmith@hotmail.com", "Jane", "Smith", "222-654-3210" },
                    { 5, "mscott@dundermifflin.com", "Michael", "Scott", "111-777-8888" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Pets_RecipientId",
                table: "Pets",
                column: "RecipientId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pets");

            migrationBuilder.DropTable(
                name: "Recipients");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b74ddd14-6340-4840-95c2-db12554843e5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2ab830ef-168b-4b06-8e81-32e994b6c940", "AQAAAAIAAYagAAAAEIaOXzntZdCK5dGWUtXeYu5gOU8fFfJs86/HlR5WNP/EOk431crSJRdyQuESnVIdPA==", "f22202e5-051d-4382-bc53-7b440341e006" });
        }
    }
}
