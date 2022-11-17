using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using MVCTravelBookingISE.Data.Base;
using MVCTravelBookingISE.Models;

namespace MVCTravelBookingISE.Data.Services
{
    public class TransportService:EntityBaseRepository<TransportModel>,ITransportService
    {
        private readonly AppDbContext _context;
        public TransportService(AppDbContext context) : base(context)
        {
            _context = context;
        }

        [AllowAnonymous]
        public async Task<TransportModel> GetTransportByIdAsync(int id)
        {
            var TransportInfo = await _context.Transport.FirstOrDefaultAsync(n => n.Transport_Id == id);

            return TransportInfo;

        }

        

    }
}
