using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVCTravelBookingISE.Migrations
{
    public partial class TripTblUpdated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TripManagement_Accomodation_Acco_Id",
                table: "TripManagement");

            migrationBuilder.DropForeignKey(
                name: "FK_TripManagement_Flight_Flight_Id",
                table: "TripManagement");

            migrationBuilder.DropForeignKey(
                name: "FK_TripManagement_Transport_Transport_Id",
                table: "TripManagement");

            migrationBuilder.DropIndex(
                name: "IX_TripManagement_Flight_Id",
                table: "TripManagement");

            migrationBuilder.RenameColumn(
                name: "Transport_Id",
                table: "TripManagement",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "Flight_Id",
                table: "TripManagement",
                newName: "BookingTransport_Id");

            migrationBuilder.RenameColumn(
                name: "Acco_Id",
                table: "TripManagement",
                newName: "BookingId");

            migrationBuilder.RenameIndex(
                name: "IX_TripManagement_Transport_Id",
                table: "TripManagement",
                newName: "IX_TripManagement_Id");

            migrationBuilder.RenameIndex(
                name: "IX_TripManagement_Acco_Id",
                table: "TripManagement",
                newName: "IX_TripManagement_BookingId");

            migrationBuilder.AddColumn<int>(
                name: "BookingAcco_Id",
                table: "TripManagement",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BookingFlight_Id",
                table: "TripManagement",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "BookingAcco_Id",
                table: "TripManagement");

            migrationBuilder.DropColumn(
                name: "BookingFlight_Id",
                table: "TripManagement");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "TripManagement",
                newName: "Transport_Id");

            migrationBuilder.RenameColumn(
                name: "BookingTransport_Id",
                table: "TripManagement",
                newName: "Flight_Id");

            migrationBuilder.RenameColumn(
                name: "BookingId",
                table: "TripManagement",
                newName: "Acco_Id");

            migrationBuilder.RenameIndex(
                name: "IX_TripManagement_Id",
                table: "TripManagement",
                newName: "IX_TripManagement_Transport_Id");

            migrationBuilder.RenameIndex(
                name: "IX_TripManagement_BookingId",
                table: "TripManagement",
                newName: "IX_TripManagement_Acco_Id");

            migrationBuilder.CreateIndex(
                name: "IX_TripManagement_Flight_Id",
                table: "TripManagement",
                column: "Flight_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TripManagement_Accomodation_Acco_Id",
                table: "TripManagement",
                column: "Acco_Id",
                principalTable: "Accomodation",
                principalColumn: "Acco_Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TripManagement_Flight_Flight_Id",
                table: "TripManagement",
                column: "Flight_Id",
                principalTable: "Flight",
                principalColumn: "Flight_Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TripManagement_Transport_Transport_Id",
                table: "TripManagement",
                column: "Transport_Id",
                principalTable: "Transport",
                principalColumn: "Transport_Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
