using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVCTravelBookingISE.Migrations
{
    public partial class TripTblFKUpdated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TripManagement_AccomodationBookingItem_Id",
                table: "TripManagement");

            migrationBuilder.DropForeignKey(
                name: "FK_TripManagement_FlightBookingItem_BookingId",
                table: "TripManagement");

            migrationBuilder.DropForeignKey(
                name: "FK_TripManagement_TransportBookingItem_BookingId",
                table: "TripManagement");

            migrationBuilder.DropIndex(
                name: "IX_TripManagement_Id",
                table: "TripManagement");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "TripManagement",
                newName: "Booking_Id");

            migrationBuilder.RenameColumn(
                name: "BookingId",
                table: "TripManagement",
                newName: "BookingTransportId");

            migrationBuilder.RenameColumn(
                name: "BookingAcco_Id",
                table: "TripManagement",
                newName: "BookingFlightId");

            migrationBuilder.RenameIndex(
                name: "IX_TripManagement_BookingId",
                table: "TripManagement",
                newName: "IX_TripManagement_BookingTransportId");

            migrationBuilder.AddColumn<int>(
                name: "BookingAccoId",
                table: "TripManagement",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_TripManagement_BookingAccoId",
                table: "TripManagement",
                column: "BookingAccoId");

            migrationBuilder.CreateIndex(
                name: "IX_TripManagement_BookingFlightId",
                table: "TripManagement",
                column: "BookingFlightId");

            migrationBuilder.AddForeignKey(
                name: "FK_TripManagement_AccomodationBookingItem_BookingAccoId",
                table: "TripManagement",
                column: "BookingAccoId",
                principalTable: "AccomodationBookingItem",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TripManagement_FlightBookingItem_BookingFlightId",
                table: "TripManagement",
                column: "BookingFlightId",
                principalTable: "FlightBookingItem",
                principalColumn: "BookingId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TripManagement_TransportBookingItem_BookingTransportId",
                table: "TripManagement",
                column: "BookingTransportId",
                principalTable: "TransportBookingItem",
                principalColumn: "BookingId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TripManagement_AccomodationBookingItem_BookingAccoId",
                table: "TripManagement");

            migrationBuilder.DropForeignKey(
                name: "FK_TripManagement_FlightBookingItem_BookingFlightId",
                table: "TripManagement");

            migrationBuilder.DropForeignKey(
                name: "FK_TripManagement_TransportBookingItem_BookingTransportId",
                table: "TripManagement");

            migrationBuilder.DropIndex(
                name: "IX_TripManagement_BookingAccoId",
                table: "TripManagement");

            migrationBuilder.DropIndex(
                name: "IX_TripManagement_BookingFlightId",
                table: "TripManagement");

            migrationBuilder.DropColumn(
                name: "BookingAccoId",
                table: "TripManagement");

            migrationBuilder.RenameColumn(
                name: "Booking_Id",
                table: "TripManagement",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "BookingTransportId",
                table: "TripManagement",
                newName: "BookingId");

            migrationBuilder.RenameColumn(
                name: "BookingFlightId",
                table: "TripManagement",
                newName: "BookingAcco_Id");

            migrationBuilder.RenameIndex(
                name: "IX_TripManagement_BookingTransportId",
                table: "TripManagement",
                newName: "IX_TripManagement_BookingId");

            migrationBuilder.CreateIndex(
                name: "IX_TripManagement_Id",
                table: "TripManagement",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TripManagement_AccomodationBookingItem_Id",
                table: "TripManagement",
                column: "Id",
                principalTable: "AccomodationBookingItem",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TripManagement_FlightBookingItem_BookingId",
                table: "TripManagement",
                column: "BookingId",
                principalTable: "FlightBookingItem",
                principalColumn: "BookingId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TripManagement_TransportBookingItem_BookingId",
                table: "TripManagement",
                column: "BookingId",
                principalTable: "TransportBookingItem",
                principalColumn: "BookingId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
