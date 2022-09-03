using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVCTravelBookingISE.Migrations
{
    public partial class FirstMigrate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Accomodation",
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
                    Acco_Price = table.Column<decimal>(type: "decimal(10,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accomodation", x => x.Acco_Id);
                });

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
                name: "Transport",
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
                    table.PrimaryKey("PK_Transport", x => x.Transport_Id);
                });

            migrationBuilder.CreateTable(
                name: "Traveller",
                columns: table => new
                {
                    Traveller_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    First_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Last_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date_Of_Birth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Ratings = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Traveller", x => x.Traveller_Id);
                });

            migrationBuilder.CreateTable(
                name: "Flight",
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
                    FlightRules_Id = table.Column<int>(type: "int", nullable: false)
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
                name: "Booking",
                columns: table => new
                {
                    Booking_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Booking_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Booking_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Booking_Approved = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Booking_TotalPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Flight_Id = table.Column<int>(type: "int", nullable: false),
                    Acco_Id = table.Column<int>(type: "int", nullable: false),
                    Transport_Id = table.Column<int>(type: "int", nullable: false),
                    FlightRulesModelFlightRules_Id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Booking", x => x.Booking_Id);
                    table.ForeignKey(
                        name: "FK_Booking_Accomodation_Acco_Id",
                        column: x => x.Acco_Id,
                        principalTable: "Accomodation",
                        principalColumn: "Acco_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Booking_Flight_Flight_Id",
                        column: x => x.Flight_Id,
                        principalTable: "Flight",
                        principalColumn: "Flight_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Booking_FlightRule_FlightRulesModelFlightRules_Id",
                        column: x => x.FlightRulesModelFlightRules_Id,
                        principalTable: "FlightRule",
                        principalColumn: "FlightRules_Id");
                    table.ForeignKey(
                        name: "FK_Booking_Transport_Transport_Id",
                        column: x => x.Transport_Id,
                        principalTable: "Transport",
                        principalColumn: "Transport_Id",
                        onDelete: ReferentialAction.Cascade);
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
                name: "IX_Booking_Acco_Id",
                table: "Booking",
                column: "Acco_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Booking_Flight_Id",
                table: "Booking",
                column: "Flight_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Booking_FlightRulesModelFlightRules_Id",
                table: "Booking",
                column: "FlightRulesModelFlightRules_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Booking_Transport_Id",
                table: "Booking",
                column: "Transport_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Flight_FlightRules_Id",
                table: "Flight",
                column: "FlightRules_Id");

            migrationBuilder.CreateIndex(
                name: "IX_TravellerBooking_Booking_Id",
                table: "TravellerBooking",
                column: "Booking_Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TravellerBooking");

            migrationBuilder.DropTable(
                name: "Booking");

            migrationBuilder.DropTable(
                name: "Traveller");

            migrationBuilder.DropTable(
                name: "Accomodation");

            migrationBuilder.DropTable(
                name: "Flight");

            migrationBuilder.DropTable(
                name: "Transport");

            migrationBuilder.DropTable(
                name: "FlightRule");
        }
    }
}
