using Microsoft.EntityFrameworkCore;
using MVCTravelBookingISE.Data.Base;
using MVCTravelBookingISE.Models;

namespace MVCTravelBookingISE.Data.Services
{
    public class TransportService : EntityBaseRepository<TransportModel>,ITransportService
    {
        private readonly AppDbContext _context;
        public TransportService(AppDbContext context) : base(context)
        {
            _context = context;
        }


        public async Task AddNewTransport(TransportModel transport)
        {
            var newTransport = new TransportModel()
            {
                Destination_point = transport.Destination_point,
                Pick_Up_Point = transport.Pick_Up_Point,
                Transport_Status = transport.Transport_Status,
                Transport_ratings = transport.Transport_ratings,
                Transport_Type= transport.Transport_Type,
                
               

            };
            await _context.Transport.AddAsync(newTransport);
            await _context.SaveChangesAsync();

        
        }

        public async Task<TransportModel> GetTransportByIdAsync(int id)
        {
            var TransportInfo = await _context.Transport.FirstOrDefaultAsync(n => n.Transport_Id == id);

            return TransportInfo;

        }

        public async Task UpdateTransportAsync(TransportModel data)
        {
            var dbTransport = await _context.Transport.FirstOrDefaultAsync(n => n.Transport_Id == data.Transport_Id);
            if (dbTransport != null)
            {

                dbTransport.Transport_Id = data.Transport_Id;
                dbTransport.Transport_Status = data.Transport_Status;
                dbTransport.Transport_ratings = data.Transport_ratings;
                dbTransport.Pick_Up_Point = data.Pick_Up_Point;
                dbTransport.Transport_Type = data.Transport_Type;
                dbTransport.Destination_point = data.Destination_point;
 
            }

            //Removing existing Accomodation

           
            // _context.Booking.RemoveRange(existingAccomodationDb);
            await _context.SaveChangesAsync();


        }
    

    }
}

