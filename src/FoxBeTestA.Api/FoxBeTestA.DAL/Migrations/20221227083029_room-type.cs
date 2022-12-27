using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FoxBeTestA.DAL.Migrations
{
    public partial class roomtype : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RoomTypes_Accomodations_AccomodationId",
                table: "RoomTypes");

            migrationBuilder.AlterColumn<int>(
                name: "AccomodationId",
                table: "RoomTypes",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_RoomTypes_Accomodations_AccomodationId",
                table: "RoomTypes",
                column: "AccomodationId",
                principalTable: "Accomodations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RoomTypes_Accomodations_AccomodationId",
                table: "RoomTypes");

            migrationBuilder.AlterColumn<int>(
                name: "AccomodationId",
                table: "RoomTypes",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_RoomTypes_Accomodations_AccomodationId",
                table: "RoomTypes",
                column: "AccomodationId",
                principalTable: "Accomodations",
                principalColumn: "Id");
        }
    }
}
