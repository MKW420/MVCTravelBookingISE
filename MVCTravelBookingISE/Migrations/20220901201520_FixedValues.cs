using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVCTravelBookingISE.Migrations
{
    public partial class FixedValues : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Accomodations_Bookings_BookingModelBooking_Id",
                table: "Accomodations");

            migrationBuilder.DropForeignKey(
                name: "FK_FlightRules_Flights_FlightModelFlight_Id",
                table: "FlightRules");

            migrationBuilder.DropForeignKey(
                name: "FK_Flights_Bookings_BookingModelBooking_Id",
                table: "Flights");

            migrationBuilder.DropForeignKey(
                name: "FK_Travellers_Bookings_BookingModelBooking_Id",
                table: "Travellers");

            migrationBuilder.DropIndex(
                name: "IX_Travellers_BookingModelBooking_Id",
                table: "Travellers");

            migrationBuilder.DropIndex(
                name: "IX_Flights_BookingModelBooking_Id",
                table: "Flights");

            migrationBuilder.DropIndex(
                name: "IX_FlightRules_FlightModelFlight_Id",
                table: "FlightRules");

            migrationBuilder.DropIndex(
                name: "IX_Accomodations_BookingModelBooking_Id",
                table: "Accomodations");

            migrationBuilder.DropColumn(
                name: "BookingModelBooking_Id",
                table: "Travellers");

            migrationBuilder.DropColumn(
                name: "BookingModelBooking_Id",
                table: "Flights");

            migrationBuilder.DropColumn(
                name: "FlightModelFlight_Id",
                table: "FlightRules");

            migrationBuilder.DropColumn(
                name: "BookingModelBooking_Id",
                table: "Accomodations");

            migrationBuilder.AddColumn<string>(
                name: "Booking_approved",
                table: "TravellerBookings",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<decimal>(
                name: "Total_price",
                table: "TravellerBookings",
                type: "decimal(10,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "FlightRules_Id",
                table: "Flights",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "Flight_Id",
                table: "Bookings",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "Acco_Id",
                table: "Bookings",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateIndex(
                name: "IX_Flights_FlightRules_Id",
                table: "Flights",
                column: "FlightRules_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_Acco_Id",
                table: "Bookings",
                column: "Acco_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_Flight_Id",
                table: "Bookings",
                column: "Flight_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_Traveller_Id",
                table: "Bookings",
                column: "Traveller_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Bookings_Accomodations_Acco_Id",
                table: "Bookings",
                column: "Acco_Id",
                principalTable: "Accomodations",
                principalColumn: "Acco_Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Bookings_Flights_Flight_Id",
                table: "Bookings",
                column: "Flight_Id",
                principalTable: "Flights",
                principalColumn: "Flight_Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Bookings_Travellers_Traveller_Id",
                table: "Bookings",
                column: "Traveller_Id",
                principalTable: "Travellers",
                principalColumn: "Traveller_Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Flights_FlightRules_FlightRules_Id",
                table: "Flights",
                column: "FlightRules_Id",
                principalTable: "FlightRules",
                principalColumn: "FlightRules_Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bookings_Accomodations_Acco_Id",
                table: "Bookings");

            migrationBuilder.DropForeignKey(
                name: "FK_Bookings_Flights_Flight_Id",
                table: "Bookings");

            migrationBuilder.DropForeignKey(
                name: "FK_Bookings_Travellers_Traveller_Id",
                table: "Bookings");

            migrationBuilder.DropForeignKey(
                name: "FK_Flights_FlightRules_FlightRules_Id",
                table: "Flights");

            migrationBuilder.DropIndex(
                name: "IX_Flights_FlightRules_Id",
                table: "Flights");

            migrationBuilder.DropIndex(
                name: "IX_Bookings_Acco_Id",
                table: "Bookings");

            migrationBuilder.DropIndex(
                name: "IX_Bookings_Flight_Id",
                table: "Bookings");

            migrationBuilder.DropIndex(
                name: "IX_Bookings_Traveller_Id",
                table: "Bookings");

            migrationBuilder.DropColumn(
                name: "Booking_approved",
                table: "TravellerBookings");

            migrationBuilder.DropColumn(
                name: "Total_price",
                table: "TravellerBookings");

            migrationBuilder.DropColumn(
                name: "FlightRules_Id",
                table: "Flights");

            migrationBuilder.AddColumn<int>(
                name: "BookingModelBooking_Id",
                table: "Travellers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BookingModelBooking_Id",
                table: "Flights",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FlightModelFlight_Id",
                table: "FlightRules",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Flight_Id",
                table: "Bookings",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Acco_Id",
                table: "Bookings",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "BookingModelBooking_Id",
                table: "Accomodations",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Travellers_BookingModelBooking_Id",
                table: "Travellers",
                column: "BookingModelBooking_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Flights_BookingModelBooking_Id",
                table: "Flights",
                column: "BookingModelBooking_Id");

            migrationBuilder.CreateIndex(
                name: "IX_FlightRules_FlightModelFlight_Id",
                table: "FlightRules",
                column: "FlightModelFlight_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Accomodations_BookingModelBooking_Id",
                table: "Accomodations",
                column: "BookingModelBooking_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Accomodations_Bookings_BookingModelBooking_Id",
                table: "Accomodations",
                column: "BookingModelBooking_Id",
                principalTable: "Bookings",
                principalColumn: "Booking_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_FlightRules_Flights_FlightModelFlight_Id",
                table: "FlightRules",
                column: "FlightModelFlight_Id",
                principalTable: "Flights",
                principalColumn: "Flight_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Flights_Bookings_BookingModelBooking_Id",
                table: "Flights",
                column: "BookingModelBooking_Id",
                principalTable: "Bookings",
                principalColumn: "Booking_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Travellers_Bookings_BookingModelBooking_Id",
                table: "Travellers",
                column: "BookingModelBooking_Id",
                principalTable: "Bookings",
                principalColumn: "Booking_Id");
        }
    }
}
