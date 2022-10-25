using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVCTravelBookingISE.Migrations
{
    public partial class RemoveBookingFKandAddCol : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.RenameColumn(
                name: "Item_Id",
                table: "bookingAccoItems",
                newName: "Id");

            migrationBuilder.AddColumn<string>(
                name: "BookingCartId",
                table: "bookingAccoItems",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BookingCartId",
                table: "bookingAccoItems");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "bookingAccoItems",
                newName: "Item_Id");

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
    }
}
