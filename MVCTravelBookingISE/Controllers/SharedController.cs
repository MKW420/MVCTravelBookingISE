using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVCTravelBookingISE.Models;

namespace MVCTravelBookingISE.Controllers
{
    public class SharedController : Controller
    {
        [AllowAnonymous]
        public IActionResult Index()
        {
            return View();
        }

        
      
    }
}
