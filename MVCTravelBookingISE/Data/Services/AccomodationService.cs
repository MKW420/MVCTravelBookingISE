using Autofac.Core;
using Microsoft.EntityFrameworkCore;
using MVCTravelBookingISE.Models;

namespace MVCTravelBookingISE.Data.Services
{
    public class AccomodationService : IAccomodationService
    {

       private readonly AppDbContext _context;

        public AccomodationService(AppDbContext context)
        {
            _context = context;
        }
        public async Task AddAsync(AccomodationModel accomodationModel)
        { 
           await _context.Accomodation.AddAsync(accomodationModel); ;
           await _context.SaveChangesAsync();
        }

        public async void Delete(int id)
        {
            var dataItem = await _context.Remove(id)
        }

        public async Task< IEnumerable<AccomodationModel>> GetAlAsync()
        {
            var results = await _context.Accomodation.ToListAsync();
            return results;
        }

        public async Task <AccomodationModel> GetByIdAsync(int id)
        {
          var result = await _context.Accomodation.FirstOrDefaultAsync(n => n.Acco_Id == id);
            return result;
            
        }

        public AccomodationModel Update(int id, AccomodationModel newAccomodation)
        {
            throw new NotImplementedException();
        }
    }
}
