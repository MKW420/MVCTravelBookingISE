using Microsoft.AspNetCore.Mvc;
using MVCTravelBookingISE.Data.Reservations;

namespace MVCTravelBookingISE.Data.ViewComponents
{
    public class BookingReservedCartSummary: ViewComponent
    {
        private readonly BookingReserved _bookingReserved;

        public BookingReservedCartSummary(BookingReserved bookingReserved)
        {
          _bookingReserved = bookingReserved;
        }

        public IViewComponentResult Invoke()
        {
            var items = _bookingReserved.GetBookingAccoItem();
            return View(items.Count);
        }
    }
}
    