﻿// <auto-generated />
using System;
using MVCTravelBookingISE.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MVCTravelBookingISE.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20221028092656_FuelCardTb")]
    partial class FuelCardTb
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("MVCTravelBookingISE.Models.AccomodationModel", b =>
                {
                    b.Property<int>("Acco_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Acco_Id"), 1L, 1);

                    b.Property<int>("Acco_Bathrooms")
                        .HasColumnType("int");

                    b.Property<string>("Acco_Destination")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<decimal>("Acco_Distance")
                        .HasColumnType("decimal(10,2)");

                    b.Property<string>("Acco_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Acco_Price")
                        .HasColumnType("decimal(10,2)");

                    b.Property<int>("Acco_Rate")
                        .HasColumnType("int");

                    b.Property<int>("Acco_Rooms")
                        .HasColumnType("int");

                    b.Property<string>("Acco_Rules")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Acco_Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.Property<string>("Acco_availability")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Acco_picture")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Acco_Id");

                    b.ToTable("Accomodation");
                });

            modelBuilder.Entity("MVCTravelBookingISE.Models.BookingAccoItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Acco_Id")
                        .HasColumnType("int");

                    b.Property<string>("BookingCartId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Qauntity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Acco_Id");

                    b.ToTable("bookingAccoItems");
                });

            modelBuilder.Entity("MVCTravelBookingISE.Models.BookingModel", b =>
                {
                    b.Property<int>("Booking_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Booking_Id"), 1L, 1);

                    b.Property<string>("Booking_Approved")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Booking_Enddate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Booking_Startdate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Booking_Id");

                    b.ToTable("Booking");
                });

            modelBuilder.Entity("MVCTravelBookingISE.Models.FlightModel", b =>
                {
                    b.Property<int>("Flight_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Flight_Id"), 1L, 1);

                    b.Property<int>("FlightRules_Id")
                        .HasColumnType("int");

                    b.Property<string>("Flight_Class")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.Property<DateTime>("Flight_Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Flight_Departure")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Flight_Destination")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Flight_Price")
                        .HasColumnType("decimal(10,2)");

                    b.HasKey("Flight_Id");

                    b.HasIndex("FlightRules_Id");

                    b.ToTable("Flight");
                });

            modelBuilder.Entity("MVCTravelBookingISE.Models.FlightRulesModel", b =>
                {
                    b.Property<int>("FlightRules_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FlightRules_Id"), 1L, 1);

                    b.Property<string>("Flight_Descrip")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Flight_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("FlightRules_Id");

                    b.ToTable("FlightRule");
                });

            modelBuilder.Entity("MVCTravelBookingISE.Models.FuelCardModel", b =>
                {
                    b.Property<string>("Card_Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<double>("CurrentBalance")
                        .HasColumnType("float");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Card_Id");

                    b.ToTable("FuelCard");
                });

            modelBuilder.Entity("MVCTravelBookingISE.Models.Rating", b =>
                {
                    b.Property<int>("RatingsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RatingsId"), 1L, 1);

                    b.Property<int?>("AccomodationModelAcco_Id")
                        .HasColumnType("int");

                    b.Property<int>("Booking_Id")
                        .HasColumnType("int");

                    b.Property<string>("RatingComment")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("TimeStamp")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("rating")
                        .HasColumnType("int");

                    b.HasKey("RatingsId");

                    b.HasIndex("AccomodationModelAcco_Id");

                    b.HasIndex("Booking_Id");

                    b.ToTable("rating");
                });

            modelBuilder.Entity("MVCTravelBookingISE.Models.ReservedItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("AccomodationAcco_Id")
                        .HasColumnType("int");

                    b.Property<int>("Qauntity")
                        .HasColumnType("int");

                    b.Property<int>("ReservedBooking_Id")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AccomodationAcco_Id");

                    b.ToTable("ReservedItems");
                });

            modelBuilder.Entity("MVCTravelBookingISE.Models.RewardsModel", b =>
                {
                    b.Property<int>("Rewards_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Rewards_Id"), 1L, 1);

                    b.Property<DateTime>("ExpiryRewardsDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Rewards_Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Rewards_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Rewards_Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Rewards_Id");

                    b.ToTable("RewardsModel");
                });

            modelBuilder.Entity("MVCTravelBookingISE.Models.TransportModel", b =>
                {
                    b.Property<int>("Transport_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Transport_Id"), 1L, 1);

                    b.Property<string>("Destination_point")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pick_Up_Point")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Transport_Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Transport_Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.Property<int>("Transport_ratings")
                        .HasColumnType("int");

                    b.HasKey("Transport_Id");

                    b.ToTable("Transport");
                });

            modelBuilder.Entity("MVCTravelBookingISE.Models.BookingAccoItem", b =>
                {
                    b.HasOne("MVCTravelBookingISE.Models.AccomodationModel", "Accomodation")
                        .WithMany("Bookingitem")
                        .HasForeignKey("Acco_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Accomodation");
                });

            modelBuilder.Entity("MVCTravelBookingISE.Models.FlightModel", b =>
                {
                    b.HasOne("MVCTravelBookingISE.Models.FlightRulesModel", "FlightRule")
                        .WithMany("Flights")
                        .HasForeignKey("FlightRules_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("FlightRule");
                });

            modelBuilder.Entity("MVCTravelBookingISE.Models.Rating", b =>
                {
                    b.HasOne("MVCTravelBookingISE.Models.AccomodationModel", null)
                        .WithMany("Ratings")
                        .HasForeignKey("AccomodationModelAcco_Id");

                    b.HasOne("MVCTravelBookingISE.Models.BookingModel", "Booking")
                        .WithMany("Ratings")
                        .HasForeignKey("Booking_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Booking");
                });

            modelBuilder.Entity("MVCTravelBookingISE.Models.ReservedItem", b =>
                {
                    b.HasOne("MVCTravelBookingISE.Models.AccomodationModel", "Accomodation")
                        .WithMany()
                        .HasForeignKey("AccomodationAcco_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Accomodation");
                });

            modelBuilder.Entity("MVCTravelBookingISE.Models.AccomodationModel", b =>
                {
                    b.Navigation("Bookingitem");

                    b.Navigation("Ratings");
                });

            modelBuilder.Entity("MVCTravelBookingISE.Models.BookingModel", b =>
                {
                    b.Navigation("Ratings");
                });

            modelBuilder.Entity("MVCTravelBookingISE.Models.FlightRulesModel", b =>
                {
                    b.Navigation("Flights");
                });
#pragma warning restore 612, 618
        }
    }
}
