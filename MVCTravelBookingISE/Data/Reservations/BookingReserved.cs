
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVCTravelBookingISE.Models;

namespace MVCTravelBookingISE.Data.Reservations
{
    public class BookingReserved
    {

        public string BookingCartId { get; set; }
        public AppDbContext _context { get; set; }
        public List<BookingAccoItem> Items { get; set; }

        public BookingReserved(AppDbContext context)
        {
            _context = context;
        }

        public static BookingReserved GetBookingCart(IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;

            var context = services.GetService<AppDbContext>();

            string cartId = session.GetString("CartId") ??  Guid.NewGuid().ToString();
            session.SetString("CartId", cartId);

            return new BookingReserved(context) { BookingCartId = cartId };

        }
    
      
    //    public void AddItemToBooking(AccomodationModel accomodation)
    //    {
    //        var bookingAccoItem = _context.bookingAccoItems.FirstOrDefault(n => n.Accomodation.Acco_Id == accomodation.Acco_Id && n.BookingCartId == BookingCartId);
    //        //var bookingFlightItem = _context.bookingItems.FirstOrDefault(n => n.Flight.Flight_Id == flight.Flight_Id && n.Item_Id == ItemId);
    //        //var bookingTransportItem = _context.bookingItems.FirstOrDefault(n => n.Transport.Transport_Id == transport.Transport_Id && n.Item_Id == ItemId);
           
    //        if (bookingAccoItem == null)
    //        {
    //            bookingAccoItem = new BookingAccoItem()
    //            {
    //                BookingCartId = BookingCartId,
    //               Accomodation = accomodation,
    //               Qauntity = 1
                  
    //            };

    //            _context.bookingAccoItems.Add(bookingAccoItem);
    //        }
    //        else
    //        {
    //            bookingAccoItem.Qauntity++;

    //        }
    //        _context.SaveChanges();
          
    //    }

    //    public void RemoveItemFromBooking(AccomodationModel accomodation)
    //    {
    //        var bookingItem = _context.bookingAccoItems.FirstOrDefault(n => n.Accomodation.Acco_Id == accomodation.Acco_Id && n.BookingCartId == BookingCartId);
    //        if (bookingItem != null)
    //        {

    //            if (bookingItem.Qauntity > 1)
    //            {
    //                bookingItem.Qauntity--;
    //            }
    //            else
    //            {
    //                _context.bookingAccoItems.Remove(bookingItem);
    //            }



    //        }
    //        _context.SaveChanges();
    //    }


    //    // GET: BookingModels/Details/5

    //    public List<BookingAccoItem> GetBookingAccoItem()
    //    {
          
    //        return Items ?? (Items = _context.bookingAccoItems.Where(n => n.BookingCartId == BookingCartId).Include(n => n.Accomodation).ToList());

    //    }
    //    public decimal GetBookingTotal() => _context.bookingAccoItems.Where(n => n.BookingCartId == BookingCartId).Select(n => n.Accomodation.Acco_Price * n.Qauntity).Sum();

       
    }
}

