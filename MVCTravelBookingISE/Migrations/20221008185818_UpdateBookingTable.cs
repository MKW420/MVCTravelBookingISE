using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVCTravelBookingISE.Migrations
{
    public partial class UpdateBookingTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "bookingItems");

            migrationBuilder.CreateTable(
                name: "bookingAccoItems",
                columns: table => new
                {
                    Item_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Qauntity = table.Column<int>(type: "int", nullable: false),
                    Acco_Id = table.Column<int>(type: "int", nullable: false),
                    Booking_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_bookingAccoItems", x => x.Item_Id);
                    table.ForeignKey(
                        name: "FK_bookingAccoItems_Accomodation_Acco_Id",
                        column: x => x.Acco_Id,
                        principalTable: "Accomodation",
                        principalColumn: "Acco_Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_bookingAccoItems_Booking_Booking_Id",
                        column: x => x.Booking_Id,
                        principalTable: "Booking",
                        principalColumn: "Booking_Id",
                        onDelete: ReferentialAction.Cascade);
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

            migrationBuilder.CreateIndex(
                name: "IX_bookingAccoItems_Acco_Id",
                table: "bookingAccoItems",
                column: "Acco_Id");

            migrationBuilder.CreateIndex(
                name: "IX_bookingAccoItems_Booking_Id",
                table: "bookingAccoItems",
                column: "Booking_Id");

            migrationBuilder.CreateIndex(
                name: "IX_ReservedItems_AccomodationAcco_Id",
                table: "ReservedItems",
                column: "AccomodationAcco_Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "bookingAccoItems");

            migrationBuilder.DropTable(
                name: "ReservedItems");

            migrationBuilder.CreateTable(
                name: "bookingItems",
                columns: table => new
                {
                    Item_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Acco_Id = table.Column<int>(type: "int", nullable: false),
                    Booking_Id = table.Column<int>(type: "int", nullable: false),
                    Flight_Id = table.Column<int>(type: "int", nullable: false),
                    Transport_Id = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
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
        }
    }
}
