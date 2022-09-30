using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OilPriceAPI.Migrations
{
    public partial class ChangeTableName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Course",
                table: "Course");

            migrationBuilder.RenameTable(
                name: "Course",
                newName: "FuelPrice");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FuelPrice",
                table: "FuelPrice",
                column: "OilPriceId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_FuelPrice",
                table: "FuelPrice");

            migrationBuilder.RenameTable(
                name: "FuelPrice",
                newName: "Course");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Course",
                table: "Course",
                column: "OilPriceId");
        }
    }
}
