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

   

        // private readonly IBookingService _bookingService;

        private readonly BookingReserved _bookingReserved;

        public BookingModelsController(IAccomodationService accomodationService, BookingReserved bookingReserved)
        {

            _accomodationService = accomodationService;
          
            _bookingReserved = bookingReserved;
            //_bookingService = bookingService;

        }
        [AllowAnonymous]
        public IActionResult SuccessPage()
        {
            return View();
        }
        [AllowAnonymous]
        public IActionResult BookingCart()
        {

            var items = _bookingReserved.GetBookingAccoItem();

         


            _bookingReserved.AccoItems = items;
          

            var rep = new BookingVModel()
            {
                bookingReserved = _bookingReserved,
                BookingTotalPrice = _bookingReserved.GetBookingTotal()
            };

            return View(rep);
        }

        [AllowAnonymous]
        public async Task<RedirectToActionResult> AddItemToBookingCart(int id)
        {
            var item = await _accomodationService.GetAccomodationByIdAsync(id);
            
            if (item != null)
            {
                _bookingReserved.AddItemToBooking(item);
            }

            return RedirectToAction(nameof(BookingCart));

        }
       
        [AllowAnonymous]
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

 

