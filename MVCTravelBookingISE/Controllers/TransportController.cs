using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MVCTravelBookingISE.Data.Services;

namespace MVCTravelBookingISE.Controllers
{
    public class TransportController : Controller
    {
        private readonly ITransportService _service;

        public TransportController(ITransportService service)
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

    }
}
