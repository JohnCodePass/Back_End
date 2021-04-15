using Microsoft.EntityFrameworkCore.Migrations;

namespace Back_End.Migrations
{
    public partial class fares : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "email",
                table: "Users",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Fares",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    riderType = table.Column<string>(nullable: true),
                    routeType = table.Column<string>(nullable: true),
                    type = table.Column<string>(nullable: true),
                    price = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fares", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Favorate",
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
                    table.PrimaryKey("PK_Favorate", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "RiderAlert",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    date = table.Column<string>(nullable: true),
                    title = table.Column<string>(nullable: true),
                    content = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RiderAlert", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Stop",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    stopName = table.Column<string>(nullable: true),
                    address = table.Column<string>(nullable: true),
                    latitude = table.Column<string>(nullable: true),
                    longitude = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stop", x => x.id);
                });

            migrationBuilder.InsertData(
                table: "Fares",
                columns: new[] { "id", "price", "riderType", "routeType", "type" },
                values: new object[] { 1, "$1.50", "Full-test", "Local-test", "1-Ride" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "id",
                keyValue: 1,
                column: "email",
                value: "email");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Fares");

            migrationBuilder.DropTable(
                name: "Favorate");

            migrationBuilder.DropTable(
                name: "RiderAlert");

            migrationBuilder.DropTable(
                name: "Stop");

            migrationBuilder.DropColumn(
                name: "email",
                table: "Users");
        }
    }
}
