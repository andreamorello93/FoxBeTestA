using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FoxBeTestA.DAL.Migrations
{
    public partial class uniqueindexpricelist : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_PriceList_RoomTypeId",
                table: "PriceList");

            migrationBuilder.CreateIndex(
                name: "IX_RoomTypeIdAndDate_Unique",
                table: "PriceList",
                columns: new[] { "RoomTypeId", "Date" },
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_RoomTypeIdAndDate_Unique",
                table: "PriceList");

            migrationBuilder.CreateIndex(
                name: "IX_PriceList_RoomTypeId",
                table: "PriceList",
                column: "RoomTypeId");
        }
    }
}
