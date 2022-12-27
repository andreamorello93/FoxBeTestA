using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FoxBeTestA.DAL.Migrations
{
    public partial class basepriceandpercentage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ExtraPercentageFromBasePrice",
                table: "RoomTypes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<decimal>(
                name: "BaseRoomPrice",
                table: "Accomodations",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ExtraPercentageFromBasePrice",
                table: "RoomTypes");

            migrationBuilder.DropColumn(
                name: "BaseRoomPrice",
                table: "Accomodations");
        }
    }
}
