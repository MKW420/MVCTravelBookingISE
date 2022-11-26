using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVCTravelBookingISE.Migrations
{
    public partial class FlightsTableReadded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "flights",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Airline = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Flight_Destination = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Flight_Departure = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Flight_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    seats = table.Column<int>(type: "int", nullable: false),
                    Flight_Class = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    Flight_Price = table.Column<decimal>(type: "decimal(10,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_flights", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "flights");
        }
    }
}
