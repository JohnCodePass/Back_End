using Microsoft.EntityFrameworkCore.Migrations;

namespace Back_End.Migrations
{
    public partial class initialcommit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Path",
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
                    table.PrimaryKey("PK_Path", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Route",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    number = table.Column<int>(nullable: false),
                    type = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Route", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "UserInfo",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    username = table.Column<string>(nullable: true),
                    password = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserInfo", x => x.id);
                });

            migrationBuilder.InsertData(
                table: "Path",
                columns: new[] { "id", "direction", "routeNumber", "stopNames", "tripTimes", "typeOfDay" },
                values: new object[] { 1, "North", 40, null, "['9:55am']", "weekday" });

            migrationBuilder.InsertData(
                table: "Route",
                columns: new[] { "id", "number", "type" },
                values: new object[] { 1, 40, "BART EXPRESS" });

            migrationBuilder.InsertData(
                table: "UserInfo",
                columns: new[] { "id", "password", "username" },
                values: new object[] { 1, "password", "huegogh" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Path");

            migrationBuilder.DropTable(
                name: "Route");

            migrationBuilder.DropTable(
                name: "UserInfo");
        }
    }
}
