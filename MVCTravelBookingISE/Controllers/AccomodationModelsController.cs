using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Autofac.Core;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MVCTravelBookingISE.Data;
using MVCTravelBookingISE.Data.Services;
using MVCTravelBookingISE.Models;

namespace MVCTravelBookingISE.Controllers
{
    public class AccomodationModelsController : Controller
    {
       
        private readonly IAccomodationService _service;
        public AccomodationModelsController(  IAccomodationService service)
        {
            
            _service = service;
        }

        // GET: AccomodationModels
        public async Task <IActionResult> Index()
        {
            var data =  await _service.GetAllAsync();
            return View(data);
        }

        // GET: AccomodationModels/Details/5
        public async Task<IActionResult> Details(int id)
        {
            var accomodationDetails = _service.GetByIdAsync(id);

            if (accomodationDetails == null)
            {
                return View("Empty");
            }

          
            return View(accomodationDetails);
        }

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
        public async Task<IActionResult> Create([Bind("Acco_Id,Acco_Name,Acco_Destination,Acco_Rooms,Acco_Bathrooms,Acco_Distance,Acco_Rate,Acco_Type,Acco_Price")] AccomodationModel accomodationModel)
        {
            if (ModelState.IsValid)
            {
               await  _service.AddSync(accomodationModel);
              
                return RedirectToAction(nameof(Index));
            }
            return View(accomodationModel);
        }

        // GET: AccomodationModels/Edit/5
        public async Task<IActionResult> Edit(int id) { 
             
            var accomodationModel = await _service.GetByIdAsync(id);
            if(accomodationModel == null)
            {
                return View("Not found");
            }
            return View(accomodationModel);

        }

        // POST: AccomodationModels/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Acco_Id,Acco_Name,Acco_Destination,Acco_Rooms,Acco_Bathrooms,Acco_Distance,Acco_Rate,Acco_Type,Acco_Price")] AccomodationModel accomodationModel)
        {
            if (id != accomodationModel.Acco_Id)
            {
                return NotFound();
            }

            if (!ModelState.IsValid)
            {
                return View(accomodationModel);

             }
            await _service.UpdateAsync(id, accomodationModel);
            return RedirectToAction(nameof(Index));
            
        
        }

        // GET: AccomodationModels/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            var accomodationModel = await _service.GetByIdAsync(id);
            if (accomodationModel == null)
            {
                return View("Not found");
            }
            return View(accomodationModel);
        }

        // POST: AccomodationModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var accomodationDetails = await _service.GetByIdAsync(id);
            if (accomodationDetails == null )
            {
                return View("Not found");
            }
            await _service.DeleteAsync(id);
            
            return RedirectToAction(nameof(Index));
        }

        //private async Task<bool> AccomodationmodelexistsAsync(int id)
        //{
        //    var result = await _service.GetByIdAsync(id);
        //    if (result == null)
        //    {
        //        return false;
        //    }
        //    else
        //    {
        //        if (results.acco_id == id)
        //        {
        //            return true;
        //        }

        //        await _service.

        //    }

        //}
    }
}
