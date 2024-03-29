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
    [Migration("20221106214122_UpdateDbTwoTbl")]
    partial class UpdateDbTwoTbl
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

                    b.Property<bool>("Acco_availability")
                        .HasColumnType("bit");

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

                    b.Property<string>("SessionId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("Acco_Id");

                    b.ToTable("AccomodationBookingItem");
                });

            modelBuilder.Entity("MVCTravelBookingISE.Models.FlightBookingItem", b =>
                {
                    b.Property<int>("BookingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BookingId"), 1L, 1);

                    b.Property<int>("Flight_Id")
                        .HasColumnType("int");

                    b.Property<string>("SessionId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BookingId");

                    b.HasIndex("Flight_Id");

                    b.ToTable("FlightBookingItem");
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

            modelBuilder.Entity("MVCTravelBookingISE.Models.Rating", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("AccomodationModelAcco_Id")
                        .HasColumnType("int");

                    b.Property<string>("RatingComment")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("TimeStamp")
                        .HasColumnType("datetime2");

                    b.Property<int>("TripId")
                        .HasColumnType("int");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("rating")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AccomodationModelAcco_Id");

                    b.HasIndex("TripId");

                    b.ToTable("Rating");
                });

            modelBuilder.Entity("MVCTravelBookingISE.Models.TransportBookingItem", b =>
                {
                    b.Property<int>("BookingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BookingId"), 1L, 1);

                    b.Property<string>("SessionId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Transport_Id")
                        .HasColumnType("int");

                    b.HasKey("BookingId");

                    b.HasIndex("Transport_Id");

                    b.ToTable("TransportBookingItem");
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

                    b.Property<bool>("Transport_FuelCard")
                        .HasColumnType("bit");

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

            modelBuilder.Entity("MVCTravelBookingISE.Models.TripManagementModel", b =>
                {
                    b.Property<int>("TripId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TripId"), 1L, 1);

                    b.Property<int>("Acco_Id")
                        .HasColumnType("int");

                    b.Property<int>("Flight_Id")
                        .HasColumnType("int");

                    b.Property<int>("Transport_Id")
                        .HasColumnType("int");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TripId");

                    b.HasIndex("Acco_Id");

                    b.HasIndex("Flight_Id");

                    b.HasIndex("Transport_Id");

                    b.ToTable("TripManagement");
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

            modelBuilder.Entity("MVCTravelBookingISE.Models.FlightBookingItem", b =>
                {
                    b.HasOne("MVCTravelBookingISE.Models.FlightModel", "Flight")
                        .WithMany("Bookingitem")
                        .HasForeignKey("Flight_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Flight");
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

                    b.HasOne("MVCTravelBookingISE.Models.TripManagementModel", "tripManagement")
                        .WithMany()
                        .HasForeignKey("TripId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("tripManagement");
                });

            modelBuilder.Entity("MVCTravelBookingISE.Models.TransportBookingItem", b =>
                {
                    b.HasOne("MVCTravelBookingISE.Models.TransportModel", "transport")
                        .WithMany("Bookingitem")
                        .HasForeignKey("Transport_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("transport");
                });

            modelBuilder.Entity("MVCTravelBookingISE.Models.TripManagementModel", b =>
                {
                    b.HasOne("MVCTravelBookingISE.Models.AccomodationModel", "Accomodation")
                        .WithMany()
                        .HasForeignKey("Acco_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MVCTravelBookingISE.Models.FlightModel", "flight")
                        .WithMany("TripManagements")
                        .HasForeignKey("Flight_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MVCTravelBookingISE.Models.TransportModel", "transport")
                        .WithMany("TripManagements")
                        .HasForeignKey("Transport_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Accomodation");

                    b.Navigation("flight");

                    b.Navigation("transport");
                });

            modelBuilder.Entity("MVCTravelBookingISE.Models.AccomodationModel", b =>
                {
                    b.Navigation("Bookingitem");

                    b.Navigation("Ratings");
                });

            modelBuilder.Entity("MVCTravelBookingISE.Models.FlightModel", b =>
                {
                    b.Navigation("Bookingitem");

                    b.Navigation("TripManagements");
                });

            modelBuilder.Entity("MVCTravelBookingISE.Models.FlightRulesModel", b =>
                {
                    b.Navigation("Flights");
                });

            modelBuilder.Entity("MVCTravelBookingISE.Models.TransportModel", b =>
                {
                    b.Navigation("Bookingitem");

                    b.Navigation("TripManagements");
                });
#pragma warning restore 612, 618
        }
    }
}
