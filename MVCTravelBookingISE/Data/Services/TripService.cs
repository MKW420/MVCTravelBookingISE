using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MVCTravelBookingISE.Areas.Identity.Data;
using MVCTravelBookingISE.Data.Base;
using MVCTravelBookingISE.Data.ViewModels;
using MVCTravelBookingISE.Models;


namespace MVCTravelBookingISE.Data.Services
{
    public class TripService: EntityBaseRepository<TripManagementModel>, ITripService
    {

        private readonly AppDbContext _context;
        private readonly AuthDbContext _authContext; 

      

        
        public TripService(AppDbContext context): base(context)
        {
            _context = context;
          //  _authContext = Authcontext;
            //Need to be able to retrieve user
        }

    
        public async Task AddNewTripAsync(TripVM data)
        {

            var newTrip = new TripManagementModel()
            {
                BookingAccoId = data.Acco_Id,
                BookingTransportId = data.Transport_Id,
                BookingFlightId = data.Flight_Id,
                

            };

            await _context.TripManagement.AddAsync(newTrip);
            await _context.SaveChangesAsync(); 


            //Add Trip
        }
        public async Task<TripManagementModel> GetTripByIdAsync( int id)
        {
            
            var TripDetails = _context.TripManagement
                    .Include(a => a.bookedAccoItem)
                    .Include(t => t.bookedtransportItem)
                    .Include(f => f.bookedflightItem)
                    .FirstOrDefaultAsync(n => n.TripId == id);

            return await TripDetails;
        
        }
        //get trip by user method
    
    }
}
