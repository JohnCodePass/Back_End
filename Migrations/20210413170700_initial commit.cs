using Microsoft.EntityFrameworkCore.Migrations;

namespace Back_End.Migrations
{
    public partial class initialcommit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PathTable",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    routeNumber = table.Column<int>(nullable: false),
                    typeOfDay = table.Column<string>(nullable: true),
                    direction = table.Column<string>(nullable: true),
                    stopNames = table.Column<string>(nullable: true),
                    tripTimes = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PathTable", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "RouteTable",
                columns: table => new
                {
                    number = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    type = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RouteTable", x => x.number);
                });

            migrationBuilder.CreateTable(
                name: "UserInfoTable",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    username = table.Column<string>(nullable: true),
                    password = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserInfoTable", x => x.id);
                });

            migrationBuilder.InsertData(
                table: "PathTable",
                columns: new[] { "id", "direction", "routeNumber", "stopNames", "tripTimes", "typeOfDay" },
                values: new object[] { 1, "North", 40, null, "['9:55am']", "weekday" });

            migrationBuilder.InsertData(
                table: "RouteTable",
                columns: new[] { "number", "type" },
                values: new object[] { 40, "BART EXPRESS" });

            migrationBuilder.InsertData(
                table: "UserInfoTable",
                columns: new[] { "id", "password", "username" },
                values: new object[] { 1, "password", "huegogh" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PathTable");

            migrationBuilder.DropTable(
                name: "RouteTable");

            migrationBuilder.DropTable(
                name: "UserInfoTable");
        }
    }
}
