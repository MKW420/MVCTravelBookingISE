using Microsoft.EntityFrameworkCore;
using MVCTravelBookingISE.Models;

namespace MVCTravelBookingISE.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {

        }

        //for the many to many reltionships between the tables
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
          //  modelBuilder.Entity<BookingModel>().HasKey(am => new
          //  {
           //     am.Flight_Id,
             //   am.Traveller_Id,
            //    am.Acco_Id


           // });

           // modelBuilder.Entity<BookingModel>().HasOne(m => m.Travellers).WithMany(am => am.Bookings).HasForeignKey(m => m.Traveller_Id);
           // base.OnModelCreating(modelBuilder);
          //  modelBuilder.Entity<BookingModel>().HasOne(m => m.Flights).WithMany(am => am.).HasForeignKey(m => m.Flights_Id);
         //  base.OnModelCreating(modelBuilder);
        }

        public DbSet<BookingModel> Bookings { get; set; }
        public DbSet<FlightModel> Flights { get; set; }
        public DbSet<FlightRulesModel> FlightRules { get; set; }
        public DbSet<AccomodationModel> Accomodations { get; set; }
        public DbSet<TravellerModel> Travellers { get; set; }
        public DbSet<TransportModel> transports { get; set; }
        

    }
}
