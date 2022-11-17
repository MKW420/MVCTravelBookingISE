using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVCTravelBookingISE.Migrations
{
    public partial class RemovedFlight : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TransportBookingItem_Transport_Transport_Id",
                table: "TransportBookingItem");

            migrationBuilder.DropForeignKey(
                name: "FK_TripManagement_FlightBookingItem_BookingFlightId",
                table: "TripManagement");

            migrationBuilder.DropForeignKey(
                name: "FK_TripManagement_TransportBookingItem_BookingTransportId",
                table: "TripManagement");

            migrationBuilder.DropTable(
                name: "FlightBookingItem");

            migrationBuilder.DropTable(
                name: "Rating");

            migrationBuilder.DropTable(
                name: "Flight");

            migrationBuilder.DropTable(
                name: "FlightRule");

            migrationBuilder.DropIndex(
                name: "IX_TripManagement_BookingFlightId",
                table: "TripManagement");

            migrationBuilder.DropIndex(
                name: "IX_TripManagement_BookingTransportId",
                table: "TripManagement");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TransportBookingItem",
                table: "TransportBookingItem");

            migrationBuilder.DropColumn(
                name: "BookingFlightId",
                table: "TripManagement");

            migrationBuilder.DropColumn(
                name: "BookingTransportId",
                table: "TripManagement");

            migrationBuilder.RenameTable(
                name: "TransportBookingItem",
                newName: "transportBookingItems");

            migrationBuilder.RenameIndex(
                name: "IX_TransportBookingItem_Transport_Id",
                table: "transportBookingItems",
                newName: "IX_transportBookingItems_Transport_Id");

            migrationBuilder.AddColumn<int>(
                name: "TransportBookingItemBookingId",
                table: "TripManagement",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_transportBookingItems",
                table: "transportBookingItems",
                column: "BookingId");

            migrationBuilder.CreateIndex(
                name: "IX_TripManagement_TransportBookingItemBookingId",
                table: "TripManagement",
                column: "TransportBookingItemBookingId");

            migrationBuilder.AddForeignKey(
                name: "FK_transportBookingItems_Transport_Transport_Id",
                table: "transportBookingItems",
                column: "Transport_Id",
                principalTable: "Transport",
                principalColumn: "Transport_Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TripManagement_transportBookingItems_TransportBookingItemBookingId",
                table: "TripManagement",
                column: "TransportBookingItemBookingId",
                principalTable: "transportBookingItems",
                principalColumn: "BookingId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_transportBookingItems_Transport_Transport_Id",
                table: "transportBookingItems");

            migrationBuilder.DropForeignKey(
                name: "FK_TripManagement_transportBookingItems_TransportBookingItemBookingId",
                table: "TripManagement");

            migrationBuilder.DropIndex(
                name: "IX_TripManagement_TransportBookingItemBookingId",
                table: "TripManagement");

            migrationBuilder.DropPrimaryKey(
                name: "PK_transportBookingItems",
                table: "transportBookingItems");

            migrationBuilder.DropColumn(
                name: "TransportBookingItemBookingId",
                table: "TripManagement");

            migrationBuilder.RenameTable(
                name: "transportBookingItems",
                newName: "TransportBookingItem");

            migrationBuilder.RenameIndex(
                name: "IX_transportBookingItems_Transport_Id",
                table: "TransportBookingItem",
                newName: "IX_TransportBookingItem_Transport_Id");

            migrationBuilder.AddColumn<int>(
                name: "BookingFlightId",
                table: "TripManagement",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BookingTransportId",
                table: "TripManagement",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_TransportBookingItem",
                table: "TransportBookingItem",
                column: "BookingId");

            migrationBuilder.CreateTable(
                name: "FlightRule",
                columns: table => new
                {
                    FlightRules_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Flight_Descrip = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Flight_Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FlightRule", x => x.FlightRules_Id);
                });

            migrationBuilder.CreateTable(
                name: "Rating",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TripId = table.Column<int>(type: "int", nullable: false),
                    AccomodationModelAcco_Id = table.Column<int>(type: "int", nullable: true),
                    RatingComment = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TimeStamp = table.Column<DateTime>(type: "datetime2", nullable: false),
                    rating = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rating", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Rating_Accomodation_AccomodationModelAcco_Id",
                        column: x => x.AccomodationModelAcco_Id,
                        principalTable: "Accomodation",
                        principalColumn: "Acco_Id");
                    table.ForeignKey(
                        name: "FK_Rating_TripManagement_TripId",
                        column: x => x.TripId,
                        principalTable: "TripManagement",
                        principalColumn: "TripId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Flight",
                columns: table => new
                {
                    Flight_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FlightRules_Id = table.Column<int>(type: "int", nullable: false),
                    Flight_Class = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    Flight_Departure = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Flight_Destination = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Flight_Price = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    FromDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ToDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Flight", x => x.Flight_Id);
                    table.ForeignKey(
                        name: "FK_Flight_FlightRule_FlightRules_Id",
                        column: x => x.FlightRules_Id,
                        principalTable: "FlightRule",
                        principalColumn: "FlightRules_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FlightBookingItem",
                columns: table => new
                {
                    BookingId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Flight_Id = table.Column<int>(type: "int", nullable: false),
                    SessionId = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FlightBookingItem", x => x.BookingId);
                    table.ForeignKey(
                        name: "FK_FlightBookingItem_Flight_Flight_Id",
                        column: x => x.Flight_Id,
                        principalTable: "Flight",
                        principalColumn: "Flight_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TripManagement_BookingFlightId",
                table: "TripManagement",
                column: "BookingFlightId");

            migrationBuilder.CreateIndex(
                name: "IX_TripManagement_BookingTransportId",
                table: "TripManagement",
                column: "BookingTransportId");

            migrationBuilder.CreateIndex(
                name: "IX_Flight_FlightRules_Id",
                table: "Flight",
                column: "FlightRules_Id");

            migrationBuilder.CreateIndex(
                name: "IX_FlightBookingItem_Flight_Id",
                table: "FlightBookingItem",
                column: "Flight_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Rating_AccomodationModelAcco_Id",
                table: "Rating",
                column: "AccomodationModelAcco_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Rating_TripId",
                table: "Rating",
                column: "TripId");

            migrationBuilder.AddForeignKey(
                name: "FK_TransportBookingItem_Transport_Transport_Id",
                table: "TransportBookingItem",
                column: "Transport_Id",
                principalTable: "Transport",
                principalColumn: "Transport_Id",
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
    }
}
