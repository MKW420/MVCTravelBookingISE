using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MVCTravelBookingISE.Areas.Identity.Data;
using MVCTravelBookingISE.Models;

namespace MVCTravelBookingISE.Data
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)  : base(options)
        {

        }

        //for the many to many reltionships between the tables
       protected override void OnModelCreating(ModelBuilder modelBuilder)
       {
            //one to many reltionship between travellers and bookings

            

            base.OnModelCreating(modelBuilder);

           

        }


        public DbSet<BookingModel> Booking { get; set; }
        public DbSet<FlightModel> Flight { get; set; }
        public DbSet<FlightRulesModel> FlightRule { get; set; }
        public DbSet<AccomodationModel> Accomodation { get; set; }
      
        public DbSet<TransportModel> Transport { get; set; }
      
        public DbSet<MVCTravelBookingISE.Models.RewardsModel> RewardsModel { get; set; }
        
        public DbSet<Rating> rating { get; set; }

        public DbSet<BookingAccoItem> bookingAccoItems { get; set; }

        public DbSet<ReservedItem> ReservedItems { get; set; }


    }
}
