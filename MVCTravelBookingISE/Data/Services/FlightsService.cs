using Microsoft.EntityFrameworkCore;
using MVCTravelBookingISE.Data.Base;
using MVCTravelBookingISE.Models;

namespace MVCTravelBookingISE.Data.Services
{
    public class FlightsService : EntityBaseRepository<Flights>, IFlightsService
    {

        private readonly AppDbContext _context;

        public FlightsService(AppDbContext context) : base(context)
        {
            _context = context;
        }
        public async Task<Flights> GetFlightsByIdAsync(int id)
        {
            var FlightsDetails = await _context.flights.FirstOrDefaultAsync(n => n.Id == id);

            return FlightsDetails;

        }
        public async Task UpdateFlightAsync(Flights data)
        {
            var dbFlight = await _context.flights.FirstOrDefaultAsync(n => n.Id == data.Id);


            if (dbFlight != null)
            {

                dbFlight.Id = data.Id;
                dbFlight.Flight_Departure = data.Flight_Departure;
                dbFlight.Flight_Destination = data.Flight_Destination;
                dbFlight.Airline = data.Airline;
                dbFlight.Flight_Date = data.Flight_Date;
                dbFlight.Flight_Class = data.Flight_Class;
                dbFlight.seats = data.seats;
                dbFlight.Flight_Price = data.Flight_Price;

                await _context.SaveChangesAsync();



            }
        }
    }
}
