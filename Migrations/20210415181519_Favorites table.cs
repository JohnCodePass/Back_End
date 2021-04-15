using Microsoft.EntityFrameworkCore.Migrations;

namespace Back_End.Migrations
{
    public partial class Favoritestable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Favorate");

            migrationBuilder.CreateTable(
                name: "Favorites",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    username = table.Column<string>(nullable: true),
                    destinationName = table.Column<string>(nullable: true),
                    destinationAddress = table.Column<string>(nullable: true),
                    savedStop = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Favorites", x => x.id);
                });

            migrationBuilder.InsertData(
                table: "Favorites",
                columns: new[] { "id", "destinationAddress", "destinationName", "savedStop", "username" },
                values: new object[] { 1, "E Weber Ave, Stockton, CA 95202", "DTC Depart", "Pacific & Ben Holt", "huegogh" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Favorites");

            migrationBuilder.CreateTable(
                name: "Favorate",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    destinationAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    destinationName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    savedStop = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    username = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Favorate", x => x.id);
                });
        }
    }
}
