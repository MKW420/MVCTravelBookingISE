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
            modelBuilder.Entity<Booking_Flight>().HasKey(am => new
            {
                am.BookingId,
                am.FlightId

            });

           // modelBuilder.Entity<Booking_Flight>().HasOne(m => m.Booking).WithMany(am => am.Bookings_Flights).HasForeignKeey(m => m.BookingId);
           // base.OnModelCreating(modelBuilder);
        }

        public DbSet<BookingModel> Bookings { get; set; }
        public DbSet<FlightModel> Flights { get; set; }
        public DbSet<FlightRulesModel> FlightRules { get; set; }
        public DbSet<AccomodationModel> Accomodations { get; set; }
        public DbSet<TravellerModel> Travellers { get; set; }
        public DbSet<TransportModel> transports { get; set; }
        public DbSet<Booking_Flight> Bookings_Flights { get; set; }

    }
}
