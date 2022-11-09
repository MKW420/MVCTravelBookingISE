using System;
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
using MVCTravelBookingISE.Models;

namespace MVCTravelBookingISE.Controllers
{
    public class TransportModelsController : Controller
    {
        private readonly ITransportService _service;
     
        public TransportModelsController( ITransportService service)
        {
           
            _service = service;
        }


        // GET: TransportModels
        [AllowAnonymous]
        public async Task<IActionResult> Index()
        {
            var allTranpsorts = await _service.GetAllAsync();
            return View(allTranpsorts);
        }

        // GET: TransportModels/Details/5
        [AllowAnonymous]
        public async Task<IActionResult> Details(int id)
        {
            var transportDetail = await _service.GetTransportByIdAsync(id);
            return View(transportDetail);
        }

        // GET: TransportModels/Create
        public IActionResult Create()
        {
            return View();
        }
        public async Task<IActionResult> Edit(int id)
        {
            var TransInfo = await _service.GetTransportByIdAsync(id);

            if (TransInfo == null) return View("NotFound");

            var response = new TransportModel()
            {
               Transport_Id = TransInfo.Transport_Id,
               Transport_ratings = TransInfo.Transport_ratings,
               Transport_Status = TransInfo.Transport_Status,
               Transport_Type = TransInfo.Transport_Type,


            };
            return View(response);
        }

        [HttpPost]

        // GET: AccomodationModels/Edit/5
        public async Task<IActionResult> Edit(int id, TransportModel transport)
        {

            if (id != transport.Transport_Id) return View("Not found");

            if (!ModelState.IsValid)
            {
                return View(transport);
            }

            await _service.UpdateTransportAsync(transport);
            return RedirectToAction(nameof(Index));
        }
        // POST: TransportModels/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        

        // GET: TransportModels/Edit/5
        public async Task<IActionResult> UpdateRating(int id)
        {
            var transportDetials = await _service.GetTransportByIdAsync(id);
            if (transportDetials == null) return View("Not found");

            var response = new TransportModel()
            {
                Transport_Id = transportDetials.Transport_Id,
                Destination_point = transportDetials.Destination_point,
                Pick_Up_Point = transportDetials.Pick_Up_Point,
                Transport_ratings = transportDetials.Transport_ratings,
                Transport_Status = transportDetials.Transport_Status,
                Transport_Type = transportDetials.Transport_Type
            };

            
            return View(response);
        }

        // POST: TransportModels/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> UpdateRating(int id, [Bind("Transport_Id,Pick_Up_Point,Delivery_point,Transport_Type")] TransportModel transportModel)
        {
           

            if (!ModelState.IsValid)
            {
                return View(transportModel);
            }
            await _service.UpdateAsync(id,transportModel);
            return View(transportModel);
        }

        // GET: TransportModels/Delete/5
       
        // POST: TransportModels/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
       
        public async Task<IActionResult> Filter(string searchPick, string DesSearch)
        {
            var allTransport = await _service.GetAllAsync();

            if (searchPick != null && DesSearch != null)
            {
                var filterResult = allTransport.Where(n => n.Pick_Up_Point.Equals(searchPick) && n.Destination_point.Equals(DesSearch));
                return View("Index", filterResult);

            }
            return View("Index", allTransport);
        }
        public async Task<IActionResult> FilterShuttle()
        {
            var allTransport = await _service.GetAllAsync();

            if (allTransport!= null)
            {
                var filterResult = allTransport.Where(n => n.Transport_Type.Equals('S'));
                return View("Index", filterResult);

            }
            return View("Index", allTransport);
        }
        public async Task<IActionResult> FilterRental()
        {
            var allTransport = await _service.GetAllAsync();

            if (allTransport != null)
            {
                var filterResult = allTransport.Where(n => n.Transport_Type.Equals('R'));
                return View("Index", filterResult);

            }
            return View("Index", allTransport);
        }
    
        
    }
}
