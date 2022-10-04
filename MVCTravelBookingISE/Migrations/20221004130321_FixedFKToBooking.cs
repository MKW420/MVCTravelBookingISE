using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVCTravelBookingISE.Migrations
{
    public partial class FixedFKToBooking : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Booking_bookingItems_Item_Id",
                table: "Booking");

            migrationBuilder.DropIndex(
                name: "IX_Booking_Item_Id",
                table: "Booking");

            migrationBuilder.DropColumn(
                name: "Item_Id",
                table: "Booking");

            migrationBuilder.DropColumn(
                name: "TotalPrice",
                table: "Booking");

            migrationBuilder.AddColumn<int>(
                name: "Booking_Id",
                table: "bookingItems",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "bookingItems",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Booking",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_bookingItems_Booking_Id",
                table: "bookingItems",
                column: "Booking_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_bookingItems_Booking_Booking_Id",
                table: "bookingItems",
                column: "Booking_Id",
                principalTable: "Booking",
                principalColumn: "Booking_Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_bookingItems_Booking_Booking_Id",
                table: "bookingItems");

            migrationBuilder.DropIndex(
                name: "IX_bookingItems_Booking_Id",
                table: "bookingItems");

            migrationBuilder.DropColumn(
                name: "Booking_Id",
                table: "bookingItems");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "bookingItems");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Booking");

            migrationBuilder.AddColumn<int>(
                name: "Item_Id",
                table: "Booking",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<decimal>(
                name: "TotalPrice",
                table: "Booking",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.CreateIndex(
                name: "IX_Booking_Item_Id",
                table: "Booking",
                column: "Item_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Booking_bookingItems_Item_Id",
                table: "Booking",
                column: "Item_Id",
                principalTable: "bookingItems",
                principalColumn: "Item_Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
