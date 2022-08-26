using System.ComponentModel.DataAnnotations;

namespace MVCTravelBookingISE.Models
{
    public class AccomodationModel
    {
        [Key]
        public int Acco_ID { get; set; }
        public string Acco_Name { get; set; }
        public string Acco_Destination { get; set; }
        public int Acco_Rooms { get; set; }
        public int Acco_Bathrooms { get; set; }
        public decimal Acco_Distance { get; set; }
        public int Acco_Rate { get; set; }
        public char Acco_Type { get; set; }
        public decimal Acco_Price { get; set; }






    }
}
