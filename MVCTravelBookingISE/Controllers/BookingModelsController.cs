using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Cryptography.Xml;
using System.Threading.Tasks;
using Autofac.Core;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;
using MVCTravelBookingISE.Data;
using MVCTravelBookingISE.Data.Reservations;
using MVCTravelBookingISE.Data.Services;
using MVCTravelBookingISE.Data.ViewModels;
using MVCTravelBookingISE.Models;
using Newtonsoft.Json.Linq;

namespace MVCTravelBookingISE.Controllers
{

    public class BookingModelsController : Controller
    {


        private readonly IAccomodationService _accomodationService;

        private readonly IFlightService _flightService;

      private readonly ITransportService _transportService;

        // private readonly IBookingService _bookingService;

        private readonly BookingReserved _bookingReserved;


        public BookingModelsController(IAccomodationService accomodationService, IFlightService  flightService , ITransportService transportService, BookingReserved bookingReserved)
        {

            _accomodationService = accomodationService;
            _flightService = flightService;
            _transportService = transportService;
            _bookingReserved = bookingReserved;
            //_bookingService = bookingService;

        }

        public IActionResult BookingCart()
        {

            var items = _bookingReserved.GetBookingAccoItem();

           // var TransItems = _bookingReserved.GetTransportBookingItems();

            var FlightItems = _bookingReserved.GetFlightBookingItems();


            _bookingReserved.AccoItems = items;
            //_bookingReserved.TransportItems = TransItems;
            _bookingReserved.FlightBookingItems = FlightItems;

            var rep = new BookingVModel()
            {
                bookingReserved = _bookingReserved,
                BookingTotalPrice = _bookingReserved.GetBookingTotal()
            };

            return View(rep);
        }
        public async Task<RedirectToActionResult> AddItemToBookingCart(int id)
        {
            var item = await _accomodationService.GetByIdAsync(id);
            
            if (item != null)
            {
                _bookingReserved.AddItemToBooking(item);
            }

            return RedirectToAction(nameof(BookingCart));

        }
        public async Task<RedirectToActionResult> AddFlightItemToBookingCart(int id)
        {
            var item = await _flightService.GetFlightsByIdAsync(id);

            if (item != null)
            {

                _bookingReserved.AddFlightItemToBooking(item);
            }

            return RedirectToAction(nameof(BookingCart));

        }

        [AllowAnonymous]
        public async Task<RedirectToActionResult> AddTransportItemToBookingCart(int id)
        {
            var item = await _transportService.GetTransportByIdAsync(id);

            if (item != null)
            {

                _bookingReserved.AddTransportItemToBooking(item);
            }

            return RedirectToAction(nameof(BookingCart));

        }
        public async Task<IActionResult> RemoveItemFromCart(int id)
        {
            var item = await _accomodationService.GetByIdAsync(id);

            if (item != null)
            {
                _bookingReserved.RemoveItemFromBooking(item);
            }

            return Redirect(nameof(BookingCart));


        }
    }



}

 

