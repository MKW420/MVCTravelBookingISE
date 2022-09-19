using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MVCTravelBookingISE.Areas.Identity.Data;
using MVCTravelBookingISE.Models;

namespace MVCTravelBookingISE.Data
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) 
            : base(options)
        {

        }

        //for the many to many reltionships between the tables
       protected override void OnModelCreating(ModelBuilder modelBuilder)
       {
            //one to many reltionship between travellers and bookings

            modelBuilder.Entity<TravellerBooking>().HasKey(tb => new { tb.Traveller_Id, tb.Booking_Id });

            modelBuilder.Entity<TravellerBooking>()
                .HasOne(tb => tb.Traveller)
                .WithMany( t => t.TravellerBookings)
                .HasForeignKey(tb => tb.Traveller_Id)
                .OnDelete(DeleteBehavior.Cascade)
               .IsRequired();

            modelBuilder.Entity<TravellerBooking>()
               .HasOne(tb => tb.Booking)
               .WithMany(b => b.TravellerBookings)
               .HasForeignKey(tb => tb.Booking_Id)
               .OnDelete(DeleteBehavior.Cascade)
               .IsRequired();

            base.OnModelCreating(modelBuilder);

            //reltionship between the flight rules and table flights
          //  modelBuilder.Entity<FlightModel>().HasKey(f => new { f.Flight_Rules_Id });

          //  modelBuilder.Entity<FlightModel>()
          //      .HasOne(f => f.FlightRule)
       //         .WithMany(fr => fr.Flights)
         //       .HasForeignKey(f => f.Flight_Id)
          //      .OnDelete(DeleteBehavior.Cascade)
         //       .IsRequired();

            //booking table has one to many reltionships with accomodation, flights,

          // modelBuilder.Entity<BookingModel>().HasKey(x => new { x.Acco_Id,x.Flight_Id,x.Transport_Id});

            

           // modelBuilder.Entity<BookingModel>()
             //   .HasOne(x => x.Accomodation)
              /// .HasForeignKey(a => a.Acco_Id)
               // .OnDelete(DeleteBehavior.Cascade)
               // .IsRequired();


            //modelBuilder.Entity<BookingModel>()
              // .HasOne(x => x.Flight)
              // .WithMany(b => b.Bookings)
              // .HasForeignKey(f => f.Flight_Id)
              // .OnDelete(DeleteBehavior.Cascade)
              // .IsRequired();

           // modelBuilder.Entity<BookingModel>()
             //    .HasOne(x => x.Transport)
              //   .WithMany(b => b.Bookings)
               //  .HasForeignKey(t => t.Transport_Id)
               //  .OnDelete(DeleteBehavior.Cascade)
               //  .IsRequired();


            // reinforcing the decimal property

           // base.OnModelCreating(modelBuilder);
       //     modelBuilder.Entity<AccomodationModel>()
        //        .Property(x => x.Acco_Distance)
         //       .HasColumnType("decimal(10,2)");

         //   base.OnModelCreating(modelBuilder);
       //     modelBuilder.Entity<AccomodationModel>()
        //        .Property(x => x.Acco_Price)
         //       .HasColumnType("decimal(10,2)");

//
      //      base.OnModelCreating(modelBuilder);
       //     modelBuilder.Entity<FlightModel>()
         ///       .Property(x => x.Flight_Price)
          //      .HasColumnType("decimal(10,2)");
//
           // base.OnModelCreating(modelBuilder);
           // modelBuilder.Entity<BookingModel>()
               // .Property(x => x.Booking_TotalPrice)
              //  .HasColumnType("decimal(10,2)");


        }


        public DbSet<BookingModel> Booking { get; set; }
        public DbSet<FlightModel> Flight { get; set; }
        public DbSet<FlightRulesModel> FlightRule { get; set; }
        public DbSet<AccomodationModel> Accomodation { get; set; }
        public DbSet<TravellerModel> Traveller { get; set; }
        public DbSet<TransportModel> Transport { get; set; }
        public DbSet<TravellerBooking> TravellerBooking { get; set; }
        

    }
}
