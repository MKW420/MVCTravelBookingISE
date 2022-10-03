using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MVCTravelBookingISE.Data;
using MVCTravelBookingISE.Data.Services;
using MVCTravelBookingISE.Models;

namespace MVCTravelBookingISE.Controllers
{
    public class BookingModelsController : Controller
    {
        private readonly IAccomodationService _accomodationService;
        private readonly IFlightService _flightService;
        private readonly ITransportService _transportService;
        private List<BookingItem> items { get; set; }
        private readonly BookingItem _items;

        public int Item_Id { get; set; }
        public AppDbContext _context { get; set; }

        public BookingModelsController(AppDbContext context, IAccomodationService accomodationService, IFlightService flightService, ITransportService transportService, List<BookingItem> items, BookingItem item)
        {
            _context = context;
            _accomodationService = accomodationService;
            _flightService = flightService;
            _transportService = transportService;
           
            _items = item;
        }
        public void AddItemToBooking(AccomodationModel accomodation , FlightModel flight, TransportModel transport)
        {
            var bookingItem = _context.bookingItems.FirstOrDefault(n => n.Accomodation.Acco_Id == accomodation.Acco_Id || n.Transport.Transport_Id == transport.Transport_Id || n.Flight.Flight_Id == flight.Flight_Id && n.Item_Id == Item_Id);

            if(bookingItem == null)
            {
                bookingItem = new BookingItem()
                {
                    Item_Id = Item_Id,
                    Accomodation = accomodation,
                    Flight = flight,
                    Transport = transport,
                    Amount = 1
                };

                _context.bookingItems.Add(bookingItem);
            }
            else
            {
                bookingItem.Amount++;

            }
            _context.SaveChanges();
        }

        public void RemoveItemFromBooking(AccomodationModel accomodation, FlightModel flight, TransportModel transport)
        {
            var bookingItem = _context.bookingItems.FirstOrDefault(n => n.Accomodation.Acco_Id == accomodation.Acco_Id || n.Transport.Transport_Id == transport.Transport_Id || n.Flight.Flight_Id == flight.Flight_Id && n.Item_Id == Item_Id);

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


        // GET: BookingModels
        [AllowAnonymous]
        public async Task<IActionResult> Index()
        {
            

            return View();
        }

        // GET: BookingModels/Details/5

        public List<BookingItem> GetBookingItems()
        {
            return items ?? (items = _context.bookingItems.Where(n => n.Item_Id == Item_Id).Include(n => n.Accomodation).ToList());


        }
        public decimal GetBookingTotal => _context.bookingItems.Where(n => n.Item_Id == Item_Id).Select(n => n.Accomodation.Acco_Price * n.Amount).Sum();




    }
 }

