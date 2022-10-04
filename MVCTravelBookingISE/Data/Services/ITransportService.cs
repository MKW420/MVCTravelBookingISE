using MVCTravelBookingISE.Data.Base;
using MVCTravelBookingISE.Models;

namespace MVCTravelBookingISE.Data.Services
{
    public interface ITransportService:IEntityBaseRepository<TransportModel>
    {


        Task AddNewTransport(TransportModel transport);
       
        Task<TransportModel> GetTransportByIdAsync(int id);

        Task UpdateAccomodationAsync(TransportModel data);
    }
}
