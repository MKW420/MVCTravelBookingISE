using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVCTravelBookingISE.Migrations
{
    public partial class FixColDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Rating");

            migrationBuilder.AddColumn<decimal>(
                name: "Transport_Price",
                table: "Transport",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Transport_Price",
                table: "Transport");

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Rating",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
