using Microsoft.EntityFrameworkCore.Migrations;

namespace CitySelection.WebApi.Migrations
{
    public partial class FixRelationshipTypo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cities_Countries_ClimateId",
                table: "Cities");

            migrationBuilder.DropIndex(
                name: "IX_Climates_CityId",
                table: "Climates");

            migrationBuilder.DropIndex(
                name: "IX_Cities_ClimateId",
                table: "Cities");

            migrationBuilder.DropColumn(
                name: "ClimateId",
                table: "Cities");

            migrationBuilder.CreateIndex(
                name: "IX_Climates_CityId",
                table: "Climates",
                column: "CityId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Climates_CityId",
                table: "Climates");

            migrationBuilder.AddColumn<int>(
                name: "ClimateId",
                table: "Cities",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Climates_CityId",
                table: "Climates",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Cities_ClimateId",
                table: "Cities",
                column: "ClimateId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cities_Countries_ClimateId",
                table: "Cities",
                column: "ClimateId",
                principalTable: "Countries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
