using Microsoft.EntityFrameworkCore;
using MVCTravelBookingISE.Data.Base;
using MVCTravelBookingISE.Models;

namespace MVCTravelBookingISE.Data.Services
{
    public class FlightRulesService : EntityBaseRepository<FlightRulesModel>, IFlightRulesService
    {

        private readonly AppDbContext _context;
        public FlightRulesService(AppDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task AddNewFlightRule(FlightRulesModel data)
        {
            var newRules = new FlightRulesModel()
            {
               FlightRules_Id =  data.FlightRules_Id,
               Flight_Descrip = data.Flight_Descrip,
               Flight_Name = data.Flight_Name,  
               

            };
            await _context.FlightRule.AddAsync(newRules);
            await _context.SaveChangesAsync();

        }

        public async Task<FlightRulesModel> GetFlightRulesByIdAsync(int id)
        {
            var RulesDetails = await _context.FlightRule.FirstOrDefaultAsync(n => n.FlightRules_Id == id);

            return RulesDetails;
        }

        public Task UpdateFlightAsync(FlightRulesModel data)
        {
            throw new NotImplementedException();
        }
    }
}
