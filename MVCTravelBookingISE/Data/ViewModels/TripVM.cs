using MVCTravelBookingISE.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCTravelBookingISE.Data.ViewModels
{
    public class TripVM
    {
        public int Id { get; set; }


        public string UserId { get; set; }
        

        public DateOnly StartDate { get; set; }

        public DateOnly EndDate { get; set; }

        //Reltionships
        public int Acco_Id { get; set; }

        public int Transport_Id { get; set; }
      
        public int Flight_Id { get; set; }
    
        

    }
}
