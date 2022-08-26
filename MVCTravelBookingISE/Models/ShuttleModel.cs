
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCTravelBookingISE.Models
{
    public class ShuttleModel
    {
        [Key]
        [ForeignKey("TransportModel")]
        public int Transport_Id { get; set; }
        public int Rate_Driver { get; set; }


        //Reltionships
        public List<TransportModel> Transports { get; set; }
    }
}
