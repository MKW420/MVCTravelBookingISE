using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVCTravelBookingISE.Migrations
{
    public partial class FuelCardTb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FuelCard",
                columns: table => new
                {
                    Card_Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CurrentBalance = table.Column<double>(type: "float", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FuelCard", x => x.Card_Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FuelCard");
        }
    }
}
