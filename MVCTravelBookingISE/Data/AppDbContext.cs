﻿using Microsoft.EntityFrameworkCore;
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
            //one to many reltionship between travellers and bookings

            modelBuilder.Entity<TravellerBooking>().HasKey(tb => new { tb.Traveller_Id, tb.Booking_Id });

            modelBuilder.Entity<TravellerBooking>()
                .HasOne(tb => tb.traveller)
                .WithMany( t => t.TravellerBookings)
                .HasForeignKey(tb => tb.Traveller_Id);

            modelBuilder.Entity<TravellerBooking>()
               .HasOne(tb => tb.Bookings)
               .WithMany(b => b.TravellerBookings)
               .HasForeignKey(tb => tb.Booking_Id)
               .OnDelete(DeleteBehavior.Cascade)
               .IsRequired();

            //reltionship between the flight rules and table flights
            modelBuilder.Entity<FlightModel>().HasKey(f => new { f.Flight_Rules_Id });

            modelBuilder.Entity<FlightModel>()
                .HasOne(f => f.FlightRule)
                .WithMany(fr => fr.Flights)
                .HasForeignKey(f => f.Flight_Id)
                .OnDelete(DeleteBehavior.Cascade)
                .IsRequired();

            //booking table has one to many reltionships with accomodation, flights,

            modelBuilder.Entity<BookingModel>().HasKey(a => new { a.Transport_Id,a.Acco_Id,a.Flight_Id});


            modelBuilder.Entity<BookingModel>()
                .HasOne(a => a.Accomodation)
                .WithMany(b => b.Bookings)
                .HasForeignKey(a => a.Acco_Id)
                .OnDelete(DeleteBehavior.Cascade)
                .IsRequired();


            modelBuilder.Entity<BookingModel>()
               .HasOne(f => f.Flight)
               .WithMany(b => b.Bookings)
               .HasForeignKey(x => x.Flight_Id)
               .OnDelete(DeleteBehavior.Cascade)
               .IsRequired();

            modelBuilder.Entity<BookingModel>()
                 .HasOne(t => t.Transport)
                 .WithMany(b => b.Bookings)
                 .HasForeignKey(x => x.Transport_Id)
                 .OnDelete(DeleteBehavior.Cascade)
                 .IsRequired();


            // reinforcing the decimal property

            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<AccomodationModel>()
                .Property(x => x.Acco_Distance)
                .HasColumnType("decimal(10,2)");

            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<AccomodationModel>()
                .Property(x => x.Acco_Price)
                .HasColumnType("decimal(10,2)");


            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<FlightModel>()
                .Property(x => x.Flight_Price)
                .HasColumnType("decimal(10,2)");

            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<TravellerBooking>()
                .Property(x => x.Booking_TotalPrice)
                .HasColumnType("decimal(10,2)");


        }


        public DbSet<BookingModel> Bookings { get; set; }
        public DbSet<FlightModel> Flights { get; set; }
        public DbSet<FlightRulesModel> FlightRules { get; set; }
        public DbSet<AccomodationModel> Accomodations { get; set; }
        public DbSet<TravellerModel> Travellers { get; set; }
        public DbSet<TransportModel> Transports { get; set; }
        public DbSet<TravellerBooking> TravellerBookings { get; set; }
        

    }
}
