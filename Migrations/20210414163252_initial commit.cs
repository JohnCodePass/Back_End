using Microsoft.EntityFrameworkCore.Migrations;

namespace Back_End.Migrations
{
    public partial class initialcommit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Paths",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    route = table.Column<int>(nullable: false),
                    typeOfRoute = table.Column<string>(nullable: true),
                    typeOfDay = table.Column<string>(nullable: true),
                    direction = table.Column<string>(nullable: true),
                    stops = table.Column<string>(nullable: true),
                    trips = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Paths", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Routes",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    number = table.Column<int>(nullable: false),
                    type = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Routes", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    username = table.Column<string>(nullable: true),
                    password = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.id);
                });

            migrationBuilder.InsertData(
                table: "Paths",
                columns: new[] { "id", "direction", "route", "stops", "trips", "typeOfDay", "typeOfRoute" },
                values: new object[] { 1, "North", 42, "['stop 1']", "[['9:55am']]", "Weekday", "BRT-Express" });

            migrationBuilder.InsertData(
                table: "Routes",
                columns: new[] { "id", "number", "type" },
                values: new object[] { 1, 40, "BART EXPRESS" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "id", "password", "username" },
                values: new object[] { 1, "password", "huegogh" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Paths");

            migrationBuilder.DropTable(
                name: "Routes");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
