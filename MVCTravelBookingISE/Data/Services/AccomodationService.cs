using Autofac.Core;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVCTravelBookingISE.Data.Base;
using MVCTravelBookingISE.Models;

namespace MVCTravelBookingISE.Data.Services
{
    public class AccomodationService : EntityBaseRepository<AccomodationModel>,IAccomodationService
=======
    public class AccomodationService : EntityBaseRepository<AccomodationModel>,IAccomodationService
>>>>>>> 4769a3a (pushchanges)
    {

       private readonly AppDbContext _context;

        public AccomodationService(AppDbContext context) : base(context) { }
        
        
    }
}
