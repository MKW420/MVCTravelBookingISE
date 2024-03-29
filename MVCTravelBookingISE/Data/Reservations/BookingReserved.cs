﻿
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVCTravelBookingISE.Models;

namespace MVCTravelBookingISE.Data.Reservations
{
    public class BookingReserved
    {

        public string SessionId { get; set; }
        public AppDbContext _context { get; set; }
        public List<BookingAccoItem> AccoItems { get; set; }
        public List<TransportBookingItem> TransportItems { get; set; }


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

            return new BookingReserved(context) { SessionId = cartId };

        }


        public void AddItemToBooking(AccomodationModel accomodation)
        {
            var bookingAccoItem = _context.AccomodationBookingItem.FirstOrDefault(n => n.Accomodation.Acco_Id == accomodation.Acco_Id && n.SessionId == SessionId);
            //var bookingFlightItem = _context.bookingItems.FirstOrDefault(n => n.Flight.Flight_Id == flight.Flight_Id && n.Item_Id == ItemId);
            //var bookingTransportItem = _context.bookingItems.FirstOrDefault(n => n.Transport.Transport_Id == transport.Transport_Id && n.Item_Id == ItemId);

            if (bookingAccoItem == null)
            {
                bookingAccoItem = new BookingAccoItem()
                {
                    Accomodation = accomodation,
                    SessionId = SessionId
              
                };

                _context.AccomodationBookingItem.Add(bookingAccoItem);
            }
          
            _context.SaveChanges();

        }
        [AllowAnonymous]
        public void AddTransportItemToBooking(TransportModel transport)
        {
            var bookingTransItem = _context.transportBookingItems.FirstOrDefault(n => n.transport.Transport_Id == transport.Transport_Id && n.SessionId == SessionId);

            if (bookingTransItem == null)
            {
                bookingTransItem = new TransportBookingItem()
                {
                    transport = transport,
                    SessionId = SessionId

                };

                _context.transportBookingItems.Add(bookingTransItem);
            }

            _context.SaveChanges();

        }
        [AllowAnonymous]
        public List<TransportBookingItem> GetTransportBookingItems()
        {
            return TransportItems ?? (TransportItems = _context.transportBookingItems.Where(n => n.SessionId == SessionId).Include(n => n.transport).ToList());

        }
        public void RemoveItemFromBooking(AccomodationModel accomodation)
        {
            var bookingItem = _context.AccomodationBookingItem.FirstOrDefault(n => n.Accomodation.Acco_Id == accomodation.Acco_Id && n.SessionId == SessionId);
            if (bookingItem != null)
            {
                
                    _context.AccomodationBookingItem.Remove(bookingItem);
                
            }
            _context.SaveChanges();
        }


        // GET: BookingModels/Details/5
        [AllowAnonymous]
        public List<BookingAccoItem> GetBookingAccoItem()
        {

            return AccoItems ?? (AccoItems = _context.AccomodationBookingItem.Where(n => n.SessionId == SessionId).Include(n => n.Accomodation).ToList());

        }

      
        public decimal GetBookingTotal() => _context.AccomodationBookingItem.Where(n => n.SessionId == SessionId).Select(n => n.Accomodation.Acco_Price).Sum();
      //  public decimal GetBookingTotal() => _context.TransportBookingItem.Where(n => n.SessionId == SessionId).Select(n => n.transport.Transport_Price).Sum();

    }
}

