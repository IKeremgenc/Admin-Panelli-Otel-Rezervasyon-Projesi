using Microsoft.EntityFrameworkCore.Migrations;

namespace HotelProject.DataAccsesLayer.Migrations
{
    public partial class mig3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Cinsiyet",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Countrey",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cinsiyet",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Countrey",
                table: "AspNetUsers");
        }
    }
}
