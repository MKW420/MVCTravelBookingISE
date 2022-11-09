using MVCTravelBookingISE.Data.Base;
using MVCTravelBookingISE.Models;


namespace MVCTravelBookingISE.Data.Services
{
    public interface IAccomodationService:IEntityBaseRepository<AccomodationModel>
    {
      Task<AccomodationModel>GetAccomodationByIdAsync(int id);

      // // Task<Accomodation> AddNewAccomodationAsync(NewAccomdation data);
      //  Task AddNewAccomodation(AccomodationModel data);
        //Task UpdateAccomodationAsync(AccomodationModel data);
    
    }

   
}
