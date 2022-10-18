using MessagePack;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using MVCTravelBookingISE.Data.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCTravelBookingISE.Models
{
    public class BookingAccoItem
    {

        [System.ComponentModel.DataAnnotations.Key]
        public int Item_Id { get; set; }
        public int Qauntity{ get; set; }

        //Foreign key of Accomodation_ID
        public int Acco_Id { get; set; }
        [ForeignKey("Acco_Id")]
        public AccomodationModel Accomodation { get; set; }

        //foreign key 

        public List<BookingModel> booking{ get; set; }

    }

}
