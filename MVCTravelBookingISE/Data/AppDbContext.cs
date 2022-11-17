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


       

        public DbSet<AccomodationModel> Accomodation { get; set; }
      
         public DbSet<TransportBookingItem> transportBookingItems { get; set; }
        public DbSet<TransportModel> Transport { get; set; }
        public DbSet<BookingAccoItem> AccomodationBookingItem { get; set; }

        public DbSet<TripManagementModel> TripManagement { get; set; }
    }
}
