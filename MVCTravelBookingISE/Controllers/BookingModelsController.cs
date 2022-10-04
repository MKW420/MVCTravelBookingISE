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
using MVCTravelBookingISE.Data.Reservations;
using MVCTravelBookingISE.Data.Services;
using MVCTravelBookingISE.Data.ViewModels;
using MVCTravelBookingISE.Models;

namespace MVCTravelBookingISE.Controllers
{
    public class BookingModelsController : Controller
    {

        private readonly IAccomodationService _accomodationService;
        private readonly IFlightService _flightService;
        private readonly ITransportService _transportService;

        private readonly BookingReserved _bookingReserved;


        public BookingModelsController(IAccomodationService accomodationService, IFlightService flightService, ITransportService transportService, BookingReserved bookingReserved)
        {
            _accomodationService = accomodationService;
            _flightService = flightService;
            _transportService = transportService;
            _bookingReserved = bookingReserved;
        }

        public IActionResult Reservation()
        {
            var items = _bookingReserved.GetBookingItems();
            _bookingReserved.bookingitems = items;
            var response = new BookingVModel()
            {
                BookingReserved = _bookingReserved,
                BookingTotalPrice = _bookingReserved.GetBookingTotal()

            };

            return (View(response));
        }

        public async Task<RedirectToActionResult> AddItemToBooking(int id)
        {
            var Accoitem = await _accomodationService.GetAccomodationByIdAsync(id);
            var flightitem = await _flightService.GetFlightsByIdAsync(id);
            var Transportitem = await _transportService.GetTransportByIdAsync(id);

            if (Accoitem != null || flightitem != null || Transportitem == null)
            {
                _bookingReserved.AddItemToBooking(Accoitem, flightitem, Transportitem);
            }

            return RedirectToAction(nameof(Reservation));
        }
    }


}
 

