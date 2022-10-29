using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MVCTravelBookingISE.Data;
using MVCTravelBookingISE.Data.Services;
using MVCTravelBookingISE.Models;

namespace MVCTravelBookingISE.Controllers
{
    public class FlightRulesModelsController : Controller
    {
      
        private readonly IFlightRulesService _service;

        public FlightRulesModelsController(IFlightRulesService service)
        {
            _service = service;
        }

        // GET: FlightRulesModels
        public async Task<IActionResult> Index()
        {
            var data = await _service.GetAllAsync();
            return View(data);

        }

        // GET: FlightRulesModels/Details/5
        public async Task<IActionResult> Details(int id)
        {
            var FlightRulesDetails = await _service.GetFlightRulesByIdAsync(id);

            if (FlightRulesDetails == null)
            {
                return View("Empty");
            }


            return View(FlightRulesDetails);
        }
        

        // GET: FlightRulesModels/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: FlightRulesModels/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("FlightRules_Id,Flight_Descrip,Flight_Name")] FlightRulesModel flightRulesModel)
        {
            if (ModelState.IsValid)
            {
                await _service.AddSync(flightRulesModel);


                return RedirectToAction(nameof(Index));
            }
            return View(flightRulesModel);
        }

        // GET: FlightRulesModels/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            var FlightRulesDetails = await _service.GetFlightRulesByIdAsync(id);

            if (FlightRulesDetails == null) return View("NotFound");

            var response = new FlightRulesModel()
            {
                FlightRules_Id = FlightRulesDetails.FlightRules_Id,
                Flight_Name = FlightRulesDetails.Flight_Name,
                Flight_Descrip = FlightRulesDetails.Flight_Descrip
              

            };
            return View(response);
        }

        // POST: FlightRulesModels/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("FlightRules_Id,Flight_Descrip,Flight_Name")] FlightRulesModel flightRulesModel)
        {
            if (id != flightRulesModel.FlightRules_Id) return View("Not found");

            if (!ModelState.IsValid)
            {
                return View(flightRulesModel);
            }

            await _service.UpdateFlightAsync(flightRulesModel);
            return RedirectToAction(nameof(Index));
        }

        // GET: FlightRulesModels/Delete/5
      
    }
}
