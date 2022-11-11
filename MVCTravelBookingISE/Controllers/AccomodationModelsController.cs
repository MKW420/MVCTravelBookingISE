﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Autofac.Core;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MVCTravelBookingISE.Data;
using MVCTravelBookingISE.Data.Services;
using MVCTravelBookingISE.Data.ViewModels;
using MVCTravelBookingISE.Models;

namespace MVCTravelBookingISE.Controllers
{
    [AllowAnonymous]
    public class AccomodationModelsController : Controller
    {

        private readonly IAccomodationService _service;
      //  private readonly ILogger<AccomodationModelsController> _logger;
        public AccomodationModelsController( IAccomodationService service)
        {
           // _logger = logger;
            _service = service;
        }

        // GET: AccomodationModels
        [AllowAnonymous]
        public async Task<IActionResult> Index()
        {

            var model = new AccomodationVM()
            {
                IsBlogActive = false
            };

            var data = await _service.GetAllAsync();

            return View(data);
        }
        [AllowAnonymous]
        public async Task<IActionResult> Filter(string searchstring)
        {
            var allAccomodation = await _service.GetAllAsync();

            if (!string.IsNullOrEmpty(searchstring))
            {
                var filterResult = allAccomodation.Where(n => n.Acco_Destination.Contains(searchstring) || n.Acco_Destination.Contains(searchstring)).ToList();
                return View("Index", filterResult);

            }
            return View("Index", allAccomodation);
        }
        [AllowAnonymous]
        public async Task<IActionResult> FilterResort()
        {
            var allAccomodation = await _service.GetAllAsync();

            if (allAccomodation != null)
            {
                var filterResult = allAccomodation.Where(n => n.Acco_Name.Equals("Resort") || n.Acco_Type.Equals("resort")).ToList();
                return View("Index", filterResult);

            }
            return View("Index", allAccomodation);
        }
        [AllowAnonymous]
        public async Task<IActionResult> FilterHotel()
        {
            var allAccomodation = await _service.GetAllAsync();

            if (allAccomodation != null)
            {
                var filterResult = allAccomodation.Where(n => n.Acco_Name.Equals("Hotel") || n.Acco_Type.Equals("hotel")).ToList();
                return View("Index", filterResult);

            }
            return View("Index", allAccomodation);
        }
        [AllowAnonymous]
        public async Task<IActionResult> FilterVilla()
        {
            var allAccomodation = await _service.GetAllAsync();

            if (allAccomodation != null)
            {
                var filterResult = allAccomodation.Where(n => n.Acco_Name.Equals("Villa") || n.Acco_Type.Equals("villa")).ToList();
                return View("Index", filterResult);

            }
            return View("Index", allAccomodation);
        }
        [AllowAnonymous]
        public async Task<IActionResult> FilterApartment()
        {
            var allAccomodation = await _service.GetAllAsync();

            if (allAccomodation != null)
            {
                var filterResult = allAccomodation.Where(n => n.Acco_Name.Equals("Apartment") || n.Acco_Type.Equals("apartment")).ToList();
                return View("Index", filterResult);

            }
            return View("Index", allAccomodation);
        }
        [AllowAnonymous]
        public async Task<IActionResult> PricesEqaulToOneThousand()
        {
            var allAccomodation = await _service.GetAllAsync();

            if(allAccomodation != null)
            {
                var filterResult = allAccomodation.Where(n => n.Acco_Price > 1500 || n.Acco_Price > 1500).ToList();
                return View("Index", filterResult);

            }
            return View("Index", allAccomodation);
        }
        // GET: Acco
        // GET: AccomodationModels/Details/5
        // [AllowAnonymous]
        [AllowAnonymous]
        public async Task<IActionResult> Details(int id)
        {

            var accomodationDetails = await _service.GetAccomodationByIdAsync(id);

            return View(accomodationDetails);

           
        }
        [AllowAnonymous]

        // GET: AccomodationModels/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: AccomodationModels/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [AllowAnonymous]
        public async Task<IActionResult> Create([Bind("Acco_Id,Acco_Name,Acco_Destination,Acco_Rooms,Acco_Bathrooms,Acco_Distance,Acco_Rate,Acco_Type,Acco_Price")] AccomodationModel accomodationModel)
        {
            if (ModelState.IsValid)
            {
                await _service.AddSync(accomodationModel);
                return RedirectToAction(nameof(Index));
            }
            return View(accomodationModel);
        }

        [HttpGet]
           [AllowAnonymous]


        public async Task<IActionResult> Edit(int id)
        {
             var accoInformation = await _service.GetAccomodationByIdAsync(id);
            if (accoInformation == null) return View("NotFound");
            return View(accoInformation);
        }
        // POST: AccomodationModels/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Edit(int id, [Bind("Acco_Id,Acco_Name,Acco_Destination,Acco_Rooms,Acco_Bathrooms,Acco_Distance,Acco_Rate,Acco_Type,Acco_Price")] AccomodationModel accomodation)
        {

            if (!ModelState.IsValid)
            {
                return View(accomodation);

            }
            await _service.UpdateAsync(id, accomodation);
            return RedirectToAction(nameof(Index));


        }

        //GET: 

        [HttpPost]

        [AllowAnonymous]

        // GET: AccomodationModels/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            var accomodationDetails = await _service.GetByIdAsync(id);
            if (accomodationDetails == null)
            {
                return View("Not found");
            }
            return View(accomodationDetails);
        }

        // POST: AccomodationModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [AllowAnonymous]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var accomodationDetails = await _service.GetByIdAsync(id);
            if (accomodationDetails == null)
            {
                return View("Not found");
            }
            await _service.DeleteAsync(id);

            return RedirectToAction(nameof(Index));
        }

      
       




    }
}

//}

