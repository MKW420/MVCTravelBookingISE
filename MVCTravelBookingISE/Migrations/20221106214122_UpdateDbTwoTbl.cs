using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVCTravelBookingISE.Migrations
{
    public partial class UpdateDbTwoTbl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookingAccoItem_Accomodation_Acco_Id",
                table: "BookingAccoItem");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BookingAccoItem",
                table: "BookingAccoItem");

            migrationBuilder.RenameTable(
                name: "BookingAccoItem",
                newName: "AccomodationBookingItem");

            migrationBuilder.RenameIndex(
                name: "IX_BookingAccoItem_Acco_Id",
                table: "AccomodationBookingItem",
                newName: "IX_AccomodationBookingItem_Acco_Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AccomodationBookingItem",
                table: "AccomodationBookingItem",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AccomodationBookingItem_Accomodation_Acco_Id",
                table: "AccomodationBookingItem",
                column: "Acco_Id",
                principalTable: "Accomodation",
                principalColumn: "Acco_Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AccomodationBookingItem_Accomodation_Acco_Id",
                table: "AccomodationBookingItem");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AccomodationBookingItem",
                table: "AccomodationBookingItem");

            migrationBuilder.RenameTable(
                name: "AccomodationBookingItem",
                newName: "BookingAccoItem");

            migrationBuilder.RenameIndex(
                name: "IX_AccomodationBookingItem_Acco_Id",
                table: "BookingAccoItem",
                newName: "IX_BookingAccoItem_Acco_Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BookingAccoItem",
                table: "BookingAccoItem",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BookingAccoItem_Accomodation_Acco_Id",
                table: "BookingAccoItem",
                column: "Acco_Id",
                principalTable: "Accomodation",
                principalColumn: "Acco_Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
