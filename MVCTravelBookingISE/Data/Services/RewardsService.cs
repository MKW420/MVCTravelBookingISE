using MVCTravelBookingISE.Data.Base;
using MVCTravelBookingISE.Models;

namespace MVCTravelBookingISE.Data.Services
{
    public class RewardsService :EntityBaseRepository<RewardsModel>,IRewardsService
    {
      //  private readonly AppDbContext _context;

        public RewardsService(AppDbContext context) : base(context) { }
    }
}
