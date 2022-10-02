using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MVCTravelBookingISE.Controllers
{
    public class RewardsController : Controller
    {

        [Authorize]
        public IActionResult Index()
        {
            return View();
        }
    }
}
