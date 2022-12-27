using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FoxBeTestA.DAL.Migrations
{
    public partial class uniqueindexroomtype : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_DescriptionAndAccomodationId_Unique",
                table: "RoomTypes",
                columns: new[] { "Description", "AccomodationId" },
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_DescriptionAndAccomodationId_Unique",
                table: "RoomTypes");
        }
    }
}
