using Microsoft.EntityFrameworkCore.Migrations;

namespace Back_End.Migrations
{
    public partial class stops : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "address",
                table: "Stop");

            migrationBuilder.DropColumn(
                name: "latitude",
                table: "Stop");

            migrationBuilder.DropColumn(
                name: "longitude",
                table: "Stop");

            migrationBuilder.DropColumn(
                name: "stopName",
                table: "Stop");

            migrationBuilder.AddColumn<double>(
                name: "lat",
                table: "Stop",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "lon",
                table: "Stop",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "name",
                table: "Stop",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "stopId",
                table: "Stop",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "lat",
                table: "Stop");

            migrationBuilder.DropColumn(
                name: "lon",
                table: "Stop");

            migrationBuilder.DropColumn(
                name: "name",
                table: "Stop");

            migrationBuilder.DropColumn(
                name: "stopId",
                table: "Stop");

            migrationBuilder.AddColumn<string>(
                name: "address",
                table: "Stop",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "latitude",
                table: "Stop",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "longitude",
                table: "Stop",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "stopName",
                table: "Stop",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
