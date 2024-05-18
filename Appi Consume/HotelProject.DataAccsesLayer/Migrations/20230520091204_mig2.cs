using Microsoft.EntityFrameworkCore.Migrations;

namespace HotelProject.DataAccsesLayer.Migrations
{
    public partial class mig2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "WorkDepartman",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "WorkLocationid",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "WorkLocations",
                columns: table => new
                {
                    WorkLocationid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WorkLocationName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WorkLocationCity = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkLocations", x => x.WorkLocationid);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_WorkLocationid",
                table: "AspNetUsers",
                column: "WorkLocationid");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_WorkLocations_WorkLocationid",
                table: "AspNetUsers",
                column: "WorkLocationid",
                principalTable: "WorkLocations",
                principalColumn: "WorkLocationid",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_WorkLocations_WorkLocationid",
                table: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "WorkLocations");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_WorkLocationid",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "WorkDepartman",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "WorkLocationid",
                table: "AspNetUsers");
        }
    }
}
