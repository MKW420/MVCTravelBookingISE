using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MVCTravelBookingISE.Data.FlightAPI;
using MVCTravelBookingISE.Models;
using static MVCTravelBookingISE.Data.FlightAPI.TravelAPIs.FlightsAvailable;

namespace MVCTravelBookingISE.Controllers
{
    public class APIController : Controller
    {
      
        //public async Task<IActionResult> Index([FromServices] TravelAPIs api, [FromQuery] string cityCode, [FromQuery] int? year)
        //{
        //    if (!string.IsNullOrEmpty(cityCode)
        //    && year is int intYear)
        //    {
        //        await api.ConnectOAuth();
        //        var results = await api.GetBusiestTravelPeriodsOfYear(cityCode, intYear);
        //        ViewBag.Results = results;
        //    }
        //    return View();
        //}
        [AllowAnonymous]
        public async Task<IActionResult> Index([FromQuery]string OriginLocationCode,[FromQuery] string DestinationLocationCode, [FromQuery] string DepartureDate, [FromQuery] string ReturnDate,[FromQuery] string Adults,[FromServices] TravelAPIs api )
        {
           // FlightsInfo flightInformation1 = flightInformation;
           
            await api.ConnectOAuth();

            if (!string.IsNullOrEmpty(OriginLocationCode))
            {
                var results = await api.SearchFlights(OriginLocationCode, DestinationLocationCode, DepartureDate, ReturnDate, Adults);

                ViewBag.Results = results;
            }
          

            return View();
        }

    }
}
