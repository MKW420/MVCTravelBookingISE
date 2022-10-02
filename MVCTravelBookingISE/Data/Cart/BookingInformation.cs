using Microsoft.EntityFrameworkCore;
using MVCTravelBookingISE.Models;

namespace MVCTravelBookingISE.Data.Cart
{
    public class BookingInformation
    {
        public AppDbContext _context { get; set; }

        public int Booking_Id { get; set; }

        public List<BookingModel> BookingItems { get; set; }

        public List<AccomodationModel> Accomodations { get; set; }
        public BookingInformation(AppDbContext context)
        {
            _context = context;
        }

        public void AddItemToBooking(AccomodationModel accomodation, FlightModel flight)
        {
            var bookingCartItem = _context.Booking.FirstOrDefault(n => n.Accomodation.Acco_Id == accomodation.Acco_Id && n.Flight.Flight_Id == flight.Flight_Id);

            if (bookingCartItem == null)
            {
                bookingCartItem = new BookingModel()
                {
                    Booking_Id = Booking_Id,
                    Accomodation = accomodation,
                    Flight = flight,


                };
                _context.Booking.Add(bookingCartItem);

            }
            else
            {

            }
            _context.SaveChanges();
        }
        public List<BookingModel> GetAccomodationBookingItem()
        {
            return BookingItems ?? (BookingItems = _context.Booking.Where(n => n.Booking_Id == Booking_Id).Include(n => n.Flight).ToList());

        }


        //public decimal GetBookingTotal()
        //{
        //    var total = _context.Booking.Where(n => n.Booking_Id == Booking_Id).Select(n => n.Accomodation.Acco_Price + n.Flight.Flight_Price);

        //}

        //    public void RemoveBooking(AccomodationModel accomodation,BookingModel booking)
        //    {
        //        var bookingCartItem = _context.Booking.FirstOrDefault(n => n.Accomodation.Acco_Id == accomodation.Acco_Id && n.Flight.Flight_Id == flight.Flight_Id);

        //        if (bookingCartItem == null)
        //        {
        //            bookingCartItem = new BookingModel()
        //            {
        //                Booking_Id = Booking_Id,
        //                Accomodation = accomodation,
        //                Flight = flight,


        //            };
        //            _context.Booking.Add(bookingCartItem);

        //        }
        //        else
        //        {

        //        }
        //        _context.SaveChanges();
        //    }

        //}
    }
}
