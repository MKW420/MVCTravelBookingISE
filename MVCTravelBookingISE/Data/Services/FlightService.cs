using Microsoft.EntityFrameworkCore;
using MVCTravelBookingISE.Data.Base;
using MVCTravelBookingISE.Models;

namespace MVCTravelBookingISE.Data.Services
{
    public class FlightService : EntityBaseRepository<FlightModel>, IFlightService
    {


        private readonly AppDbContext _context;

        public FlightService(AppDbContext context) : base(context)
        {
            _context = context;
        }
        public async Task<FlightModel> GetFlightsByIdAsync(int id)
        {
            var FlightsDetails = await _context.Flight.FirstOrDefaultAsync(n => n.Flight_Id == id);

            return FlightsDetails;

        }
        public async Task UpdateFlightAsync(FlightModel data)
        {
            var dbFlight = await _context.Flight.FirstOrDefaultAsync(n => n.Flight_Id == data.Flight_Id);
            if (dbFlight != null)
            {

                dbFlight.Flight_Id = data.Flight_Id;
                dbFlight.Flight_Departure = data.Flight_Departure;
                dbFlight.Flight_Destination = data.Flight_Destination;
                dbFlight.Flight_Date = data.Flight_Date;
                dbFlight.Flight_Class = data.Flight_Class;
                dbFlight.Flight_Price = data.Flight_Price;

                await _context.SaveChangesAsync();



            }

            //Removing existing Accomodation


           

        }
    }
}
