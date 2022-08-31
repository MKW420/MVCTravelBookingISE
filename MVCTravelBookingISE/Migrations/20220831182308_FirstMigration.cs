using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVCTravelBookingISE.Migrations
{
    public partial class FirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bookings",
                columns: table => new
                {
                    Booking_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Booking_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Booking_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Flight_Id = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Acco_Id = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Traveller_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bookings", x => x.Booking_Id);
                });

            migrationBuilder.CreateTable(
                name: "transports",
                columns: table => new
                {
                    Transport_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Pick_Up_Point = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Destination_point = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Transport_Type = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    Transport_ratings = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_transports", x => x.Transport_Id);
                });

            migrationBuilder.CreateTable(
                name: "Accomodations",
                columns: table => new
                {
                    Acco_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Acco_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Acco_Destination = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Acco_Rooms = table.Column<int>(type: "int", nullable: false),
                    Acco_Bathrooms = table.Column<int>(type: "int", nullable: false),
                    Acco_Distance = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    Acco_Rate = table.Column<int>(type: "int", nullable: false),
                    Acco_Type = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    Acco_Price = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    BookingModelBooking_Id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accomodations", x => x.Acco_Id);
                    table.ForeignKey(
                        name: "FK_Accomodations_Bookings_BookingModelBooking_Id",
                        column: x => x.BookingModelBooking_Id,
                        principalTable: "Bookings",
                        principalColumn: "Booking_Id");
                });

            migrationBuilder.CreateTable(
                name: "Flights",
                columns: table => new
                {
                    Flight_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Flight_Destination = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Flight_Departure = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Flight_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Flight_Class = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    Flight_Price = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    Flight_Rules_Id = table.Column<int>(type: "int", nullable: false),
                    BookingModelBooking_Id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Flights", x => x.Flight_Id);
                    table.ForeignKey(
                        name: "FK_Flights_Bookings_BookingModelBooking_Id",
                        column: x => x.BookingModelBooking_Id,
                        principalTable: "Bookings",
                        principalColumn: "Booking_Id");
                });

            migrationBuilder.CreateTable(
                name: "Travellers",
                columns: table => new
                {
                    Traveller_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    First_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Last_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date_Of_Birth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Ratings = table.Column<int>(type: "int", nullable: false),
                    BookingModelBooking_Id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Travellers", x => x.Traveller_Id);
                    table.ForeignKey(
                        name: "FK_Travellers_Bookings_BookingModelBooking_Id",
                        column: x => x.BookingModelBooking_Id,
                        principalTable: "Bookings",
                        principalColumn: "Booking_Id");
                });

            migrationBuilder.CreateTable(
                name: "FlightRules",
                columns: table => new
                {
                    FlightRules_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Flight_Descrip = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Flight_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FlightModelFlight_Id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FlightRules", x => x.FlightRules_Id);
                    table.ForeignKey(
                        name: "FK_FlightRules_Flights_FlightModelFlight_Id",
                        column: x => x.FlightModelFlight_Id,
                        principalTable: "Flights",
                        principalColumn: "Flight_Id");
                });

            migrationBuilder.CreateTable(
                name: "TravellerBookings",
                columns: table => new
                {
                    Traveller_Id = table.Column<int>(type: "int", nullable: false),
                    Booking_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TravellerBookings", x => new { x.Traveller_Id, x.Booking_Id });
                    table.ForeignKey(
                        name: "FK_TravellerBookings_Bookings_Booking_Id",
                        column: x => x.Booking_Id,
                        principalTable: "Bookings",
                        principalColumn: "Booking_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TravellerBookings_Travellers_Traveller_Id",
                        column: x => x.Traveller_Id,
                        principalTable: "Travellers",
                        principalColumn: "Traveller_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Accomodations_BookingModelBooking_Id",
                table: "Accomodations",
                column: "BookingModelBooking_Id");

            migrationBuilder.CreateIndex(
                name: "IX_FlightRules_FlightModelFlight_Id",
                table: "FlightRules",
                column: "FlightModelFlight_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Flights_BookingModelBooking_Id",
                table: "Flights",
                column: "BookingModelBooking_Id");

            migrationBuilder.CreateIndex(
                name: "IX_TravellerBookings_Booking_Id",
                table: "TravellerBookings",
                column: "Booking_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Travellers_BookingModelBooking_Id",
                table: "Travellers",
                column: "BookingModelBooking_Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Accomodations");

            migrationBuilder.DropTable(
                name: "FlightRules");

            migrationBuilder.DropTable(
                name: "transports");

            migrationBuilder.DropTable(
                name: "TravellerBookings");

            migrationBuilder.DropTable(
                name: "Flights");

            migrationBuilder.DropTable(
                name: "Travellers");

            migrationBuilder.DropTable(
                name: "Bookings");
        }
    }
}
