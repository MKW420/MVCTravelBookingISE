using Microsoft.EntityFrameworkCore;
using MVCTravelBookingISE.Models;

namespace MVCTravelBookingISE.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) 
            : base(options)
        {

        }

        //for the many to many reltionships between the tables
       protected override void OnModelCreating(ModelBuilder modelBuilder)
       {
            //many to many reltionship between travellers and bookings

            modelBuilder.Entity<TravellerBooking>().HasKey(tb => new { tb.Traveller_Id, tb.Booking_Id });

            modelBuilder.Entity<TravellerBooking>()
                .HasOne(tb => tb.Travellers)
                .WithMany( t => t.TravellerBookings)
                .HasForeignKey(tb => tb.Traveller_Id);

            modelBuilder.Entity<TravellerBooking>()
               .HasOne(tb => tb.Bookings)
               .WithMany(b => b.TravellerBookings)
               .HasForeignKey(tb => tb.Booking_Id);

            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<AccomodationModel>()
                .Property(p => p.Acco_Distance)
                .HasColumnType("decimal(10,2");

            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<AccomodationModel>()
                .Property(p => p.Acco_Price)
                .HasColumnType("decimal(10,2");


            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<FlightModel>()
                .Property(p => p.Flight_Price)
                .HasColumnType("decimal(10,2");



        }

        // modelBuilder.Entity<BookingModel>().HasOne(m => m.Travellers).WithMany(am => am.Bookings).HasForeignKey(m => m.Traveller_Id);
        // base.OnModelCreating(modelBuilder);
        //  modelBuilder.Entity<BookingModel>().HasOne(m => m.Flights).WithMany(am => am.).HasForeignKey(m => m.Flights_Id);
        //  base.OnModelCreating(modelBuilder);
        //  }

        public DbSet<BookingModel> Bookings { get; set; }
        public DbSet<FlightModel> Flights { get; set; }
        public DbSet<FlightRulesModel> FlightRules { get; set; }
        public DbSet<AccomodationModel> Accomodations { get; set; }
        public DbSet<TravellerModel> Travellers { get; set; }
        public DbSet<TransportModel> transports { get; set; }
        public DbSet<TravellerBooking> TravellerBookings { get; set; }
        

    }
}
