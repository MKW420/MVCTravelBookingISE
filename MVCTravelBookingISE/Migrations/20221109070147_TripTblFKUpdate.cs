using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVCTravelBookingISE.Migrations
{
    public partial class TripTblFKUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BookingFlight_Id",
                table: "TripManagement");

            migrationBuilder.DropColumn(
                name: "BookingTransport_Id",
                table: "TripManagement");

            migrationBuilder.DropColumn(
                name: "Booking_Id",
                table: "TripManagement");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BookingFlight_Id",
                table: "TripManagement",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BookingTransport_Id",
                table: "TripManagement",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Booking_Id",
                table: "TripManagement",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
