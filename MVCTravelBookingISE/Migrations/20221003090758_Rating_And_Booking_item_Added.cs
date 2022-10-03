using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVCTravelBookingISE.Migrations
{
    public partial class Rating_And_Booking_item_Added : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Booking_Accomodation_Acco_Id",
                table: "Booking");

            migrationBuilder.DropForeignKey(
                name: "FK_Booking_Flight_Flight_Id",
                table: "Booking");

            migrationBuilder.DropForeignKey(
                name: "FK_Booking_Transport_Transport_Id",
                table: "Booking");

            migrationBuilder.DropForeignKey(
                name: "FK_RewardsModel_Traveller_Traveller_Id",
                table: "RewardsModel");

            migrationBuilder.DropTable(
                name: "TravellerBooking");

            migrationBuilder.DropTable(
                name: "Traveller");

            migrationBuilder.DropIndex(
                name: "IX_RewardsModel_Traveller_Id",
                table: "RewardsModel");

            migrationBuilder.DropIndex(
                name: "IX_Booking_Acco_Id",
                table: "Booking");

            migrationBuilder.DropIndex(
                name: "IX_Booking_Flight_Id",
                table: "Booking");

            migrationBuilder.DropIndex(
                name: "IX_Booking_Transport_Id",
                table: "Booking");

            migrationBuilder.DropColumn(
                name: "Traveller_Id",
                table: "RewardsModel");

            migrationBuilder.DropColumn(
                name: "Acco_Id",
                table: "Booking");

            migrationBuilder.DropColumn(
                name: "Flight_Id",
                table: "Booking");

            migrationBuilder.DropColumn(
                name: "Transport_Id",
                table: "Booking");

            migrationBuilder.RenameColumn(
                name: "Booking_date",
                table: "Booking",
                newName: "Booking_Startdate");

            migrationBuilder.RenameColumn(
                name: "Booking_TotalPrice",
                table: "Booking",
                newName: "TotalPrice");

            migrationBuilder.RenameColumn(
                name: "Booking_Name",
                table: "Booking",
                newName: "UserId");

            migrationBuilder.AddColumn<string>(
                name: "Transport_Status",
                table: "Transport",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "RewardsModel",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "AccomodationModelAcco_Id",
                table: "Booking",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Booking_Enddate",
                table: "Booking",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "TransportModelTransport_Id",
                table: "Booking",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Acco_availability",
                table: "Accomodation",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "bookingItems",
                columns: table => new
                {
                    Item_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Booking_Id = table.Column<int>(type: "int", nullable: false),
                    Flight_Id = table.Column<int>(type: "int", nullable: false),
                    Acco_Id = table.Column<int>(type: "int", nullable: false),
                    Transport_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_bookingItems", x => x.Item_Id);
                    table.ForeignKey(
                        name: "FK_bookingItems_Accomodation_Acco_Id",
                        column: x => x.Acco_Id,
                        principalTable: "Accomodation",
                        principalColumn: "Acco_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_bookingItems_Booking_Booking_Id",
                        column: x => x.Booking_Id,
                        principalTable: "Booking",
                        principalColumn: "Booking_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_bookingItems_Flight_Flight_Id",
                        column: x => x.Flight_Id,
                        principalTable: "Flight",
                        principalColumn: "Flight_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_bookingItems_Transport_Transport_Id",
                        column: x => x.Transport_Id,
                        principalTable: "Transport",
                        principalColumn: "Transport_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "rating",
                columns: table => new
                {
                    RatingsId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    rating = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Booking_Id = table.Column<int>(type: "int", nullable: false),
                    TimeStamp = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RatingComment = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AccomodationModelAcco_Id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_rating", x => x.RatingsId);
                    table.ForeignKey(
                        name: "FK_rating_Accomodation_AccomodationModelAcco_Id",
                        column: x => x.AccomodationModelAcco_Id,
                        principalTable: "Accomodation",
                        principalColumn: "Acco_Id");
                    table.ForeignKey(
                        name: "FK_rating_Booking_Booking_Id",
                        column: x => x.Booking_Id,
                        principalTable: "Booking",
                        principalColumn: "Booking_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Booking_AccomodationModelAcco_Id",
                table: "Booking",
                column: "AccomodationModelAcco_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Booking_TransportModelTransport_Id",
                table: "Booking",
                column: "TransportModelTransport_Id");

            migrationBuilder.CreateIndex(
                name: "IX_bookingItems_Acco_Id",
                table: "bookingItems",
                column: "Acco_Id");

            migrationBuilder.CreateIndex(
                name: "IX_bookingItems_Booking_Id",
                table: "bookingItems",
                column: "Booking_Id");

            migrationBuilder.CreateIndex(
                name: "IX_bookingItems_Flight_Id",
                table: "bookingItems",
                column: "Flight_Id");

            migrationBuilder.CreateIndex(
                name: "IX_bookingItems_Transport_Id",
                table: "bookingItems",
                column: "Transport_Id");

            migrationBuilder.CreateIndex(
                name: "IX_rating_AccomodationModelAcco_Id",
                table: "rating",
                column: "AccomodationModelAcco_Id");

            migrationBuilder.CreateIndex(
                name: "IX_rating_Booking_Id",
                table: "rating",
                column: "Booking_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Booking_Accomodation_AccomodationModelAcco_Id",
                table: "Booking",
                column: "AccomodationModelAcco_Id",
                principalTable: "Accomodation",
                principalColumn: "Acco_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Booking_Transport_TransportModelTransport_Id",
                table: "Booking",
                column: "TransportModelTransport_Id",
                principalTable: "Transport",
                principalColumn: "Transport_Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Booking_Accomodation_AccomodationModelAcco_Id",
                table: "Booking");

            migrationBuilder.DropForeignKey(
                name: "FK_Booking_Transport_TransportModelTransport_Id",
                table: "Booking");

            migrationBuilder.DropTable(
                name: "bookingItems");

            migrationBuilder.DropTable(
                name: "rating");

            migrationBuilder.DropIndex(
                name: "IX_Booking_AccomodationModelAcco_Id",
                table: "Booking");

            migrationBuilder.DropIndex(
                name: "IX_Booking_TransportModelTransport_Id",
                table: "Booking");

            migrationBuilder.DropColumn(
                name: "Transport_Status",
                table: "Transport");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "RewardsModel");

            migrationBuilder.DropColumn(
                name: "AccomodationModelAcco_Id",
                table: "Booking");

            migrationBuilder.DropColumn(
                name: "Booking_Enddate",
                table: "Booking");

            migrationBuilder.DropColumn(
                name: "TransportModelTransport_Id",
                table: "Booking");

            migrationBuilder.DropColumn(
                name: "Acco_availability",
                table: "Accomodation");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Booking",
                newName: "Booking_Name");

            migrationBuilder.RenameColumn(
                name: "TotalPrice",
                table: "Booking",
                newName: "Booking_TotalPrice");

            migrationBuilder.RenameColumn(
                name: "Booking_Startdate",
                table: "Booking",
                newName: "Booking_date");

            migrationBuilder.AddColumn<int>(
                name: "Traveller_Id",
                table: "RewardsModel",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Acco_Id",
                table: "Booking",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Flight_Id",
                table: "Booking",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Transport_Id",
                table: "Booking",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Traveller",
                columns: table => new
                {
                    Traveller_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date_Of_Birth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    First_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Last_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ratings = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Traveller", x => x.Traveller_Id);
                });

            migrationBuilder.CreateTable(
                name: "TravellerBooking",
                columns: table => new
                {
                    Traveller_Id = table.Column<int>(type: "int", nullable: false),
                    Booking_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TravellerBooking", x => new { x.Traveller_Id, x.Booking_Id });
                    table.ForeignKey(
                        name: "FK_TravellerBooking_Booking_Booking_Id",
                        column: x => x.Booking_Id,
                        principalTable: "Booking",
                        principalColumn: "Booking_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TravellerBooking_Traveller_Traveller_Id",
                        column: x => x.Traveller_Id,
                        principalTable: "Traveller",
                        principalColumn: "Traveller_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_RewardsModel_Traveller_Id",
                table: "RewardsModel",
                column: "Traveller_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Booking_Acco_Id",
                table: "Booking",
                column: "Acco_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Booking_Flight_Id",
                table: "Booking",
                column: "Flight_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Booking_Transport_Id",
                table: "Booking",
                column: "Transport_Id");

            migrationBuilder.CreateIndex(
                name: "IX_TravellerBooking_Booking_Id",
                table: "TravellerBooking",
                column: "Booking_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Booking_Accomodation_Acco_Id",
                table: "Booking",
                column: "Acco_Id",
                principalTable: "Accomodation",
                principalColumn: "Acco_Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Booking_Flight_Flight_Id",
                table: "Booking",
                column: "Flight_Id",
                principalTable: "Flight",
                principalColumn: "Flight_Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Booking_Transport_Transport_Id",
                table: "Booking",
                column: "Transport_Id",
                principalTable: "Transport",
                principalColumn: "Transport_Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RewardsModel_Traveller_Traveller_Id",
                table: "RewardsModel",
                column: "Traveller_Id",
                principalTable: "Traveller",
                principalColumn: "Traveller_Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
