using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVCTravelBookingISE.Migrations
{
    public partial class AddCardOptionToTrans : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FuelCard");

            migrationBuilder.AddColumn<string>(
                name: "Transport_FuelCard",
                table: "Transport",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Transport_FuelCard",
                table: "Transport");

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
    }
}
