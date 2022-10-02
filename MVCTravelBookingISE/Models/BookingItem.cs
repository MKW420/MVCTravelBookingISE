using MessagePack;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using MVCTravelBookingISE.Data.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCTravelBookingISE.Models
{
    public class BookingItem
    {

        [System.ComponentModel.DataAnnotations.Key]
        public int Id { get; set; }

        public int Amount { get; set; }

    }
   
}
