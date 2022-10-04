using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVCTravelBookingISE.Models;

namespace MVCTravelBookingISE.Data.Reservations
{
    public class BookingReserved
    {

        public List<BookingItem> bookingitems { get; set; }


        public int item_Id { get; set; }
        public AppDbContext _context { get; set; }

        public BookingReserved(AppDbContext context)
        {
            _context = context;
        }

        public static BookingReserved GetBooking(IServiceProvider services)
        {
            ISession session = services.GetRequiredService < IHttpContextAccessor>()?.HttpContext.Session;
            var context = services.GetService<AppDbContext>();

            int cartId = session.GetInt32("ItemId") ?? 0; Guid.NewGuid();
            session.SetInt32("cartId", cartId);

            return new BookingReserved(context) { item_Id = cartId };



        }
      
        public void AddItemToBooking(AccomodationModel accomodation, FlightModel flight, TransportModel transport)
        {
            var bookingAccoItem = _context.bookingItems.FirstOrDefault(n => n.Accomodation.Acco_Id == accomodation.Acco_Id && n.Item_Id == item_Id);
            var bookingFlightItem = _context.bookingItems.FirstOrDefault(n => n.Flight.Flight_Id == flight.Flight_Id && n.Item_Id == item_Id);
            var bookingTransportItem = _context.bookingItems.FirstOrDefault(n => n.Transport.Transport_Id == transport.Transport_Id && n.Item_Id == item_Id);
           
            if (bookingAccoItem == null)
            {
                bookingAccoItem = new BookingItem()
                {

                    Accomodation = accomodation,
                   
                    Amount = 1
                };

                _context.bookingItems.Add(bookingAccoItem);
            }
            else
            {
                bookingAccoItem.Amount++;

            }
            if (bookingFlightItem == null)
            {
                bookingFlightItem = new BookingItem()
                {

                    Flight = flight,

                    Amount = 1
                };

                _context.bookingItems.Add(bookingAccoItem);
            }
            else
            {
                bookingFlightItem.Amount++;

            }
             if (bookingTransportItem == null)
            {
                bookingTransportItem = new BookingItem()
                {

                    Transport = transport,
                   
                    Amount = 1
                };

                _context.bookingItems.Add(bookingTransportItem);
            }
            else
            {
                bookingTransportItem.Amount++;

            }
            _context.SaveChanges();
        }

        public void RemoveItemFromBooking(AccomodationModel accomodation, FlightModel flight, TransportModel transport)
        {
            var bookingItem = _context.bookingItems.FirstOrDefault(n => n.Accomodation.Acco_Id == accomodation.Acco_Id || n.Transport.Transport_Id == transport.Transport_Id || n.Flight.Flight_Id == flight.Flight_Id && n.Item_Id == item_Id);

            if (bookingItem != null)
            {

                if (bookingItem.Amount > 1)
                {
                    bookingItem.Amount--;
                }
                else
                {
                    _context.bookingItems.Remove(bookingItem);
                }



            }
            _context.SaveChanges();
        }


        // GET: BookingModels/Details/5

        public List<BookingItem> GetBookingItems()
        {
            return bookingitems ?? (bookingitems = _context.bookingItems.Where(n => n.Item_Id == item_Id).Include(n => n.Accomodation).ToList());
            //return bookingitems ?? (bookingitems = _context.bookingItems.Where(n => n.Booking_Id == Booking_Id).Include(n => n.Transport).ToList());
            // return bookingitems ?? (bookingitems = _context.bookingItems.Where(n => n.Booking_Id == Booking_Id).Include(n => n.Flight).ToList());

        }
        public decimal GetBookingTotal() => _context.bookingItems.Where(n => n.Item_Id == item_Id).Select(n => n.Accomodation.Acco_Price * n.Amount).Sum();

       
    }
}

