using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVCTravelBookingISE.Migrations
{
    public partial class UpdateIDOnBooking : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_bookingAccoItems_Booking_Booking_Id",
                table: "bookingAccoItems");

            migrationBuilder.DropIndex(
                name: "IX_bookingAccoItems_Booking_Id",
                table: "bookingAccoItems");

            migrationBuilder.DropColumn(
                name: "Booking_Id",
                table: "bookingAccoItems");

            migrationBuilder.AddColumn<int>(
                name: "Item_Id",
                table: "Booking",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Booking_Item_Id",
                table: "Booking",
                column: "Item_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Booking_bookingAccoItems_Item_Id",
                table: "Booking",
                column: "Item_Id",
                principalTable: "bookingAccoItems",
                principalColumn: "Item_Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Booking_bookingAccoItems_Item_Id",
                table: "Booking");

            migrationBuilder.DropIndex(
                name: "IX_Booking_Item_Id",
                table: "Booking");

            migrationBuilder.DropColumn(
                name: "Item_Id",
                table: "Booking");

            migrationBuilder.AddColumn<int>(
                name: "Booking_Id",
                table: "bookingAccoItems",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_bookingAccoItems_Booking_Id",
                table: "bookingAccoItems",
                column: "Booking_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_bookingAccoItems_Booking_Booking_Id",
                table: "bookingAccoItems",
                column: "Booking_Id",
                principalTable: "Booking",
                principalColumn: "Booking_Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
