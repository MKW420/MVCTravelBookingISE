using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVCTravelBookingISE.Migrations
{
    public partial class UpdateDbOne : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_bookingAccoItems_Accomodation_Acco_Id",
                table: "bookingAccoItems");

            migrationBuilder.DropForeignKey(
                name: "FK_rating_Accomodation_AccomodationModelAcco_Id",
                table: "rating");

            migrationBuilder.DropForeignKey(
                name: "FK_rating_Booking_Booking_Id",
                table: "rating");

            migrationBuilder.DropTable(
                name: "Booking");

            migrationBuilder.DropTable(
                name: "ReservedItems");

            migrationBuilder.DropTable(
                name: "RewardsModel");

            migrationBuilder.DropPrimaryKey(
                name: "PK_rating",
                table: "rating");

            migrationBuilder.DropPrimaryKey(
                name: "PK_bookingAccoItems",
                table: "bookingAccoItems");

            migrationBuilder.DropColumn(
                name: "Qauntity",
                table: "bookingAccoItems");

            migrationBuilder.RenameTable(
                name: "rating",
                newName: "Rating");

            migrationBuilder.RenameTable(
                name: "bookingAccoItems",
                newName: "BookingAccoItem");

            migrationBuilder.RenameColumn(
                name: "Booking_Id",
                table: "Rating",
                newName: "TripId");

            migrationBuilder.RenameColumn(
                name: "RatingsId",
                table: "Rating",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_rating_AccomodationModelAcco_Id",
                table: "Rating",
                newName: "IX_Rating_AccomodationModelAcco_Id");

            migrationBuilder.RenameIndex(
                name: "IX_rating_Booking_Id",
                table: "Rating",
                newName: "IX_Rating_TripId");

            migrationBuilder.RenameColumn(
                name: "BookingCartId",
                table: "BookingAccoItem",
                newName: "SessionId");

            migrationBuilder.RenameIndex(
                name: "IX_bookingAccoItems_Acco_Id",
                table: "BookingAccoItem",
                newName: "IX_BookingAccoItem_Acco_Id");

            migrationBuilder.AlterColumn<bool>(
                name: "Transport_FuelCard",
                table: "Transport",
                type: "bit",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<bool>(
                name: "Acco_availability",
                table: "Accomodation",
                type: "bit",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Rating",
                table: "Rating",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BookingAccoItem",
                table: "BookingAccoItem",
                column: "Id");

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

            migrationBuilder.CreateTable(
                name: "TransportBookingItem",
                columns: table => new
                {
                    BookingId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Transport_Id = table.Column<int>(type: "int", nullable: false),
                    SessionId = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransportBookingItem", x => x.BookingId);
                    table.ForeignKey(
                        name: "FK_TransportBookingItem_Transport_Transport_Id",
                        column: x => x.Transport_Id,
                        principalTable: "Transport",
                        principalColumn: "Transport_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TripManagement",
                columns: table => new
                {
                    TripId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Acco_Id = table.Column<int>(type: "int", nullable: false),
                    Transport_Id = table.Column<int>(type: "int", nullable: false),
                    Flight_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TripManagement", x => x.TripId);
                    table.ForeignKey(
                        name: "FK_TripManagement_Accomodation_Acco_Id",
                        column: x => x.Acco_Id,
                        principalTable: "Accomodation",
                        principalColumn: "Acco_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TripManagement_Flight_Flight_Id",
                        column: x => x.Flight_Id,
                        principalTable: "Flight",
                        principalColumn: "Flight_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TripManagement_Transport_Transport_Id",
                        column: x => x.Transport_Id,
                        principalTable: "Transport",
                        principalColumn: "Transport_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FlightBookingItem_Flight_Id",
                table: "FlightBookingItem",
                column: "Flight_Id");

            migrationBuilder.CreateIndex(
                name: "IX_TransportBookingItem_Transport_Id",
                table: "TransportBookingItem",
                column: "Transport_Id");

            migrationBuilder.CreateIndex(
                name: "IX_TripManagement_Acco_Id",
                table: "TripManagement",
                column: "Acco_Id");

            migrationBuilder.CreateIndex(
                name: "IX_TripManagement_Flight_Id",
                table: "TripManagement",
                column: "Flight_Id");

            migrationBuilder.CreateIndex(
                name: "IX_TripManagement_Transport_Id",
                table: "TripManagement",
                column: "Transport_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BookingAccoItem_Accomodation_Acco_Id",
                table: "BookingAccoItem",
                column: "Acco_Id",
                principalTable: "Accomodation",
                principalColumn: "Acco_Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Rating_Accomodation_AccomodationModelAcco_Id",
                table: "Rating",
                column: "AccomodationModelAcco_Id",
                principalTable: "Accomodation",
                principalColumn: "Acco_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Rating_TripManagement_TripId",
                table: "Rating",
                column: "TripId",
                principalTable: "TripManagement",
                principalColumn: "TripId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookingAccoItem_Accomodation_Acco_Id",
                table: "BookingAccoItem");

            migrationBuilder.DropForeignKey(
                name: "FK_Rating_Accomodation_AccomodationModelAcco_Id",
                table: "Rating");

            migrationBuilder.DropForeignKey(
                name: "FK_Rating_TripManagement_TripId",
                table: "Rating");

            migrationBuilder.DropTable(
                name: "FlightBookingItem");

            migrationBuilder.DropTable(
                name: "TransportBookingItem");

            migrationBuilder.DropTable(
                name: "TripManagement");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Rating",
                table: "Rating");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BookingAccoItem",
                table: "BookingAccoItem");

            migrationBuilder.RenameTable(
                name: "Rating",
                newName: "rating");

            migrationBuilder.RenameTable(
                name: "BookingAccoItem",
                newName: "bookingAccoItems");

            migrationBuilder.RenameColumn(
                name: "TripId",
                table: "rating",
                newName: "Booking_Id");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "rating",
                newName: "RatingsId");

            migrationBuilder.RenameIndex(
                name: "IX_Rating_AccomodationModelAcco_Id",
                table: "rating",
                newName: "IX_rating_AccomodationModelAcco_Id");

            migrationBuilder.RenameIndex(
                name: "IX_Rating_TripId",
                table: "rating",
                newName: "IX_rating_Booking_Id");

            migrationBuilder.RenameColumn(
                name: "SessionId",
                table: "bookingAccoItems",
                newName: "BookingCartId");

            migrationBuilder.RenameIndex(
                name: "IX_BookingAccoItem_Acco_Id",
                table: "bookingAccoItems",
                newName: "IX_bookingAccoItems_Acco_Id");

            migrationBuilder.AlterColumn<string>(
                name: "Transport_FuelCard",
                table: "Transport",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<string>(
                name: "Acco_availability",
                table: "Accomodation",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AddColumn<int>(
                name: "Qauntity",
                table: "bookingAccoItems",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_rating",
                table: "rating",
                column: "RatingsId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_bookingAccoItems",
                table: "bookingAccoItems",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Booking",
                columns: table => new
                {
                    Booking_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Booking_Approved = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Booking_Enddate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Booking_Startdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Booking", x => x.Booking_Id);
                });

            migrationBuilder.CreateTable(
                name: "ReservedItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccomodationAcco_Id = table.Column<int>(type: "int", nullable: false),
                    Qauntity = table.Column<int>(type: "int", nullable: false),
                    ReservedBooking_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReservedItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ReservedItems_Accomodation_AccomodationAcco_Id",
                        column: x => x.AccomodationAcco_Id,
                        principalTable: "Accomodation",
                        principalColumn: "Acco_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RewardsModel",
                columns: table => new
                {
                    Rewards_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExpiryRewardsDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Rewards_Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rewards_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rewards_Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RewardsModel", x => x.Rewards_Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ReservedItems_AccomodationAcco_Id",
                table: "ReservedItems",
                column: "AccomodationAcco_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_bookingAccoItems_Accomodation_Acco_Id",
                table: "bookingAccoItems",
                column: "Acco_Id",
                principalTable: "Accomodation",
                principalColumn: "Acco_Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_rating_Accomodation_AccomodationModelAcco_Id",
                table: "rating",
                column: "AccomodationModelAcco_Id",
                principalTable: "Accomodation",
                principalColumn: "Acco_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_rating_Booking_Booking_Id",
                table: "rating",
                column: "Booking_Id",
                principalTable: "Booking",
                principalColumn: "Booking_Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
