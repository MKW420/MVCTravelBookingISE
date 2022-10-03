using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVCTravelBookingISE.Migrations
{
    public partial class Remove_FK_OnBooking : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Booking_Accomodation_AccomodationModelAcco_Id",
                table: "Booking");

            migrationBuilder.DropForeignKey(
                name: "FK_Booking_FlightRule_FlightRulesModelFlightRules_Id",
                table: "Booking");

            migrationBuilder.DropForeignKey(
                name: "FK_Booking_Transport_TransportModelTransport_Id",
                table: "Booking");

            migrationBuilder.DropIndex(
                name: "IX_Booking_AccomodationModelAcco_Id",
                table: "Booking");

            migrationBuilder.DropIndex(
                name: "IX_Booking_FlightRulesModelFlightRules_Id",
                table: "Booking");

            migrationBuilder.DropIndex(
                name: "IX_Booking_TransportModelTransport_Id",
                table: "Booking");

            migrationBuilder.DropColumn(
                name: "AccomodationModelAcco_Id",
                table: "Booking");

            migrationBuilder.DropColumn(
                name: "FlightRulesModelFlightRules_Id",
                table: "Booking");

            migrationBuilder.DropColumn(
                name: "TransportModelTransport_Id",
                table: "Booking");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AccomodationModelAcco_Id",
                table: "Booking",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FlightRulesModelFlightRules_Id",
                table: "Booking",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TransportModelTransport_Id",
                table: "Booking",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Booking_AccomodationModelAcco_Id",
                table: "Booking",
                column: "AccomodationModelAcco_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Booking_FlightRulesModelFlightRules_Id",
                table: "Booking",
                column: "FlightRulesModelFlightRules_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Booking_TransportModelTransport_Id",
                table: "Booking",
                column: "TransportModelTransport_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Booking_Accomodation_AccomodationModelAcco_Id",
                table: "Booking",
                column: "AccomodationModelAcco_Id",
                principalTable: "Accomodation",
                principalColumn: "Acco_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Booking_FlightRule_FlightRulesModelFlightRules_Id",
                table: "Booking",
                column: "FlightRulesModelFlightRules_Id",
                principalTable: "FlightRule",
                principalColumn: "FlightRules_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Booking_Transport_TransportModelTransport_Id",
                table: "Booking",
                column: "TransportModelTransport_Id",
                principalTable: "Transport",
                principalColumn: "Transport_Id");
        }
    }
}
