using Autofac.Core;
using Microsoft.AspNetCore.Mvc;
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

        public async Task DeleteAsync(int id)
        {
            //get the acco

            var result = await _context.Accomodation.FirstOrDefaultAsync(n => n.Acco_Id == id);
            _context.Accomodation.Remove(result);

            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<AccomodationModel>> GetAllAsync()
        {
            var results = await _context.Accomodation.ToListAsync();
            return results;
        }

        public async Task <AccomodationModel> GetByIdAsync(int id)
        {
          var result = await _context.Accomodation.FirstOrDefaultAsync(n => n.Acco_Id == id);
            return result;
            
        }

        public async Task<AccomodationModel> UpdateAsync(int id, AccomodationModel newAccomodation)
        {
            _context.Update(newAccomodation);
            await _context.SaveChangesAsync();
            return newAccomodation;
        }

        
    }
}
