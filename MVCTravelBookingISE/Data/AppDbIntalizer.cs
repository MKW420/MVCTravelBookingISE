using Microsoft.EntityFrameworkCore.Diagnostics;
using MVCTravelBookingISE.Models;
using MVCTravelBookingISE.Areas.Identity.Data;
using ContactManager.Data;

namespace MVCTravelBookingISE.Data
{
    public class AppDbIntalizer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                context.Database.EnsureCreated();

                if (!context.Accomodation.Any())
                {

                    context.Accomodation.AddRange(new List<AccomodationModel>()
                    {
                        new AccomodationModel
                        {
                            Acco_Name = "Lagoon Beach Hotel",
                            Acco_Destination = "Milnerton, CapeTown",
                            Acco_Rooms = 1,
                            Acco_Bathrooms = 2,
                            Acco_Distance = 2,
                            Acco_Rate = 5,
                            Acco_Type = 'S',
                            Acco_Price = 1259,
                            Acco_picture= "https://images.unsplash.com/photo-1615460549969-36fa19521a4f?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=1074&q=80",
                            Acco_Rules = "Free Cancellation for 48 hours (Full Refund included) After 3 Days a partial Refund will be included (50%) After 7 Days there is no Refunds. Free Parking included, WIFI available and no smoking allowed ",
                            Acco_availability = true

                          },
                         new AccomodationModel
                        {
                            Acco_Name = "Lagoon Beach Hotel",
                            Acco_Destination = "Milnerton, CapeTown",
                            Acco_Rooms = 4,
                            Acco_Bathrooms = 3,
                            Acco_Distance = 2,
                            Acco_Rate = 0,
                            Acco_Type= 'G',
                            Acco_Price = 1659,
                            Acco_picture="https://images.unsplash.com/photo-1445019980597-93fa8acb246c?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=1174&q=80",
                             Acco_Rules = "Free Cancellation for 48 hours (Full Refund included) After 3 Days a partial Refund will be included (50%) After 7 Days there is no Refunds. Parking fee included, WIFI available and no smoking allowed ",
                              Acco_availability = true

                          },
                        new AccomodationModel
                        {
                             Acco_Name = "President Hotel",
                            Acco_Destination = "Sea Point , CapeTown",
                            Acco_Rooms = 1,
                            Acco_Bathrooms = 2,
                            Acco_Distance = 1,
                            Acco_Rate = 0,
                            Acco_Type = 'S',
                            Acco_Price = 1599,
                            Acco_picture = "https://images.unsplash.com/photo-1445019980597-93fa8acb246c?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=1174&q=80",
                             Acco_Rules = "Free Cancellation for 48 hours (Full Refund included) After 3 Days a partial Refund will be included (50%) After 7 Days there is no Refunds. Parking fee included, WIFI available and no smoking allowed ",
                              Acco_availability = true
                        },
                        new AccomodationModel
                        {
                             Acco_Name = "President Hotel",
                            Acco_Destination = "Sea Point , CapeTown",
                            Acco_Rooms = 3,
                            Acco_Bathrooms = 3,
                            Acco_Distance = 1,
                            Acco_Rate = 0,
                            Acco_Type = 'G',
                            Acco_Price = 1899,
                            Acco_picture="https://images.unsplash.com/photo-1611892440504-42a792e24d32?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=1170&q=80",
                             Acco_Rules = "Free Cancellation for 48 hours (Full Refund included) After 3 Days a partial Refund will be included (50%) After 7 Days there is no Refunds. Parking fee included, WIFI available and no smoking allowed ",
                               Acco_availability = true
                        },
                        new AccomodationModel
                        {
                            Acco_Name = "Center Range (Holiday House)",
                            Acco_Destination = "Milnerton, Capetown",
                            Acco_Rooms = 5,
                            Acco_Bathrooms = 5,
                            Acco_Distance = 1,
                            Acco_Rate = 0,
                            Acco_Type = 'G',
                            Acco_Price = 1855,
                            Acco_picture = "https://images.unsplash.com/photo-1520250497591-112f2f40a3f4?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=1170&q=80",
                             Acco_Rules = "Free Cancellation for 48 hours (Full Refund included) After 3 Days a partial Refund will be included (50%) After 7 Days there is no Refunds. Parking fee included, WIFI available and no smoking allowed ",
                              Acco_availability = true

                        },
                         new AccomodationModel
                        {
                            Acco_Name = "Life on the 3rd (Holiday House)",
                            Acco_Destination = "Melville, Johannesburg",
                            Acco_Rooms = 5,
                            Acco_Bathrooms = 4,
                            Acco_Distance = 2,
                            Acco_Rate = 0,
                            Acco_Type = 'G',
                            Acco_Price = 1699,
                            Acco_picture ="https://images.unsplash.com/photo-1512918728675-ed5a9ecdebfd?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=1170&q=80",
                             Acco_Rules = "Free Cancellation for 48 hours (Full Refund included) After 3 Days a partial Refund will be included (50%) After 7 Days there is no Refunds. Parking fee included, WIFI available and no smoking allowed ",
                             Acco_availability = true

                         },

                          new AccomodationModel
                        {
                            Acco_Name = "Sunninghill Guest Lodges (Game Park)",
                            Acco_Destination = "Sunninghill, Johannesburg",
                            Acco_Rooms = 1,
                            Acco_Bathrooms = 1,
                            Acco_Distance = 1,
                            Acco_Rate = 0,
                            Acco_Type = 'G',
                            Acco_Price = 1195,
                            Acco_picture="https://images.unsplash.com/photo-1551882547-ff40c63fe5fa?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=1170&q=80",
                             Acco_Rules = "Free Cancellation for 48 hours (Full Refund included) After 3 Days a partial Refund will be included (50%) After 7 Days there is no Refunds. Parking fee included, WIFI available and no smoking allowed ",
                              Acco_availability = true
                          },
                         new AccomodationModel
                        {
                            Acco_Name = "Sunninghill Guest Lodges (Game Park)",
                            Acco_Destination = "Sunninghill, Johannesburg",
                            Acco_Rooms = 4,
                            Acco_Bathrooms = 4,
                            Acco_Distance = 1,
                            Acco_Rate = 0,
                            Acco_Type = 'G',
                            Acco_Price = 1999,
                            Acco_picture ="https://images.unsplash.com/photo-1566073771259-6a8506099945?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=1170&q=80",
                             Acco_Rules = "Free Cancellation for 48 hours (Full Refund included) After 3 Days a partial Refund will be included (50%) After 7 Days there is no Refunds. Parking fee included, WIFI available and no smoking allowed ",
                              Acco_availability = true

                         },
                        new AccomodationModel
                        {
                            Acco_Name = "Sunninghill Guest Lodges (Game Park)",
                            Acco_Destination = "Sunninghill, Johannesburg",
                            Acco_Rooms = 2,
                            Acco_Bathrooms = 2,
                            Acco_Distance = 1,
                            Acco_Rate = 0,
                            Acco_Type = 'G',
                            Acco_Price = 1499,
                            Acco_picture = "https://images.unsplash.com/photo-1618773928121-c32242e63f39?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=1170&q=80",
                             Acco_Rules = "Free Cancellation for 48 hours (Full Refund included) After 3 Days a partial Refund will be included (50%) After 7 Days there is no Refunds. Parking fee included, WIFI available and no smoking allowed ",
                             Acco_availability = true

                        },
                        new AccomodationModel
                        {
                            Acco_Name = "Khasab Hotel",
                            Acco_Destination = "Khasab",
                            Acco_Rooms = 1,
                            Acco_Bathrooms = 1,
                            Acco_Distance = 1,
                            Acco_Rate = 0,
                            Acco_Type = 'S',
                            Acco_Price = 1299,
                            Acco_picture="https://images.unsplash.com/photo-1564501049412-61c2a3083791?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=1332&q=80",
                             Acco_Rules = "Free Cancellation for 48 hours (Full Refund included) After 3 Days a partial Refund will be included (50%) After 7 Days there is no Refunds. Free Parking included, WIFI available and smoking allowed adn complimentary Shuttle provided on arrival ",
                              Acco_availability = true

                        },
                        new AccomodationModel()
                        {
                            Acco_Name = "Rydges Sydeny Central",
                            Acco_Destination = "Sydney, Austraila",
                            Acco_Rooms = 2,
                            Acco_Bathrooms = 2,
                            Acco_Distance = 1,
                            Acco_Rate = 0,
                            Acco_Type = 'G',
                            Acco_picture ="https://images.unsplash.com/photo-1600210492486-724fe5c67fb0?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=1074&q=80",
                             Acco_Rules = "Free Cancellation for 48 hours (Full Refund included) After 3 Days a partial Refund will be included (50%) After 7 Days there is no Refunds. Free Parking included, WIFI available and no smoking allowed. Swimming pool included",
                            Acco_Price = 1299,
                             Acco_availability = true
                        },
                         new AccomodationModel()
                        {
                            Acco_Name = "Umhlanga Windsor Villa (Holiday House)",
                            Acco_Destination = "Umlhanga, Durban",
                            Acco_Rooms = 4,
                            Acco_Bathrooms = 5,
                            Acco_Distance = 2,
                            Acco_Rate = 0,
                            Acco_Type = 'G',
                            Acco_Price = 1999,
                            Acco_picture="https://images.unsplash.com/photo-1570129477492-45c003edd2be?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=1170&q=80",
                            Acco_Rules = "Free Cancellation for 48 hours (Full Refund included) After 3 Days a partial Refund will be included (50%) After 7 Days there is no Refunds. Free Parking included, WIFI available and no smoking allowed ",
                             Acco_availability = true
                         },
                          new AccomodationModel()
                        {
                            Acco_Name = "Point Waterfront Apartments (Holiday Apartment)",
                            Acco_Destination = "Durban Point Waterfront, Durban",
                            Acco_Rooms = 4,
                            Acco_Bathrooms = 4,
                            Acco_Distance = 1,
                            Acco_Rate = 0,
                            Acco_Type = 'G',
                            Acco_Price = 2599,
                            Acco_picture = "https://images.unsplash.com/photo-1580587771525-78b9dba3b914?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=1074&q=80",
                            Acco_Rules = "Free Cancellation for 48 hours (Full Refund included) After 3 Days a partial Refund will be included (50%) After 7 Days there is no Refunds. Parking fee included, WIFI available and no smoking allowed ",
                             Acco_availability = true

                          },

                    });
                    context.SaveChanges();
                }

                if (!context.Transport.Any())
                {

                    context.Transport.AddRange(new List<TransportModel>()
                        {
                            new TransportModel
                            {
                                Pick_Up_Point = "O.R Tambo Airport",
                                Destination_point = "Sunninghill, Johannesburg" ,
                                Transport_Type = 'S',
                                Transport_ratings = 0,
                                Transport_Status = "Available",
                                Transport_FuelCard = false

                            },
                            
                            new TransportModel
                            {
                                Pick_Up_Point = "Cape Town International Airport",
                                Destination_point = "Milnerton, Capetown" ,
                                Transport_Type = 'S',
                                Transport_ratings = 0,
                                Transport_Status = "Available",
                                Transport_Price = 499,
                                Transport_FuelCard = false
                            },
                            new TransportModel
                            {
                                Pick_Up_Point = "Cape Town International Airport",
                                Destination_point = "Sea Point , CapeTown" ,
                                Transport_Type = 'S',
                                Transport_ratings = 4,
                                Transport_Status = "Available",
                                Transport_Price = 599,
                                Transport_FuelCard = false
                            },
                               new TransportModel
                            {
                                Pick_Up_Point = "Cape Town International Airport",
                                Destination_point = "Bellville, CapeTown" ,
                                Transport_Type = 'S',
                                Transport_ratings = 0,
                                Transport_Status = "Available",
                                Transport_Price = 499,
                                Transport_FuelCard = false
                            },
                                new TransportModel
                            {
                                Pick_Up_Point = "Cape Town International Airport",
                                Destination_point = "Stellenbosch, CapeTown" ,
                                Transport_Type = 'S',
                                Transport_ratings = 0,
                                Transport_Status = "Available",
                                Transport_Price = 350,
                                Transport_FuelCard = false
                            },
                               new TransportModel
                            {
                                Pick_Up_Point = "Cape Town International Airport",
                                Destination_point = "" ,
                                Transport_Type = 'C',
                                Transport_ratings = 0,
                                Transport_Status = "Available",
                                Transport_Price = 1599,
                                Transport_FuelCard = true
                            },
                             new TransportModel
                            {
                                Pick_Up_Point = "Port Elizabeth International Airport",
                                Destination_point = " " ,
                                Transport_Type = 'C',
                                Transport_ratings = 0,
                                Transport_Status = "Available",
                                Transport_Price = 1599,
                                Transport_FuelCard = true

                            },
                            new TransportModel
                            {
                                Pick_Up_Point = "Mosselbay International Airport",
                                Destination_point = "" ,
                                Transport_Type = 'C',
                                Transport_ratings = 0,
                                Transport_Status = " Available",
                                Transport_Price = 1499,
                                Transport_FuelCard = true

                            },
                            new TransportModel
                            {
                                Pick_Up_Point = "Mosselbay International Airport",
                                Destination_point = "Knysna,CapeTown " ,
                                Transport_Type = 'S',
                                Transport_ratings = 0,
                                Transport_Status = "Available",
                                Transport_Price = 299,
                                Transport_FuelCard = false

                            },
                            new TransportModel
                            {
                                Pick_Up_Point = "Mosselbay International Airport",
                                Destination_point = " " ,
                                Transport_Type = 'C',
                                Transport_ratings = 0,
                                Transport_Status = "Not Available",
                                Transport_Price = 1599,
                                Transport_FuelCard = true

                            },
                            new TransportModel
                            {
                                Pick_Up_Point = "George International Airport",
                                Destination_point = " " ,
                                Transport_Type = 'C',
                                Transport_ratings = 0,
                                Transport_Status = "Not Available",
                                Transport_Price = 1599,
                                Transport_FuelCard = true

                            },
                            new TransportModel
                            {
                                Pick_Up_Point = "George International Airport",
                                Destination_point = "StellenBosch,CapeTown " ,
                                Transport_Type = 'S',
                                Transport_ratings = 0,
                                Transport_Status = "Available",
                                Transport_Price = 599,
                                Transport_FuelCard = false

                            },
                             new TransportModel
                            {
                                Pick_Up_Point = "Stellenbosch International Airport",
                                Destination_point = " " ,
                                Transport_Type = 'C',
                                Transport_ratings = 0,
                                Transport_Status = "Available",
                                Transport_Price = 1599,
                                Transport_FuelCard = true

                            },
                              new TransportModel
                            {
                                Pick_Up_Point = "Stellenbosch International Airport",
                                Destination_point = "Langebaan, CapeTown" ,
                                Transport_Type = 'S',
                                Transport_ratings = 0,
                                Transport_Status = "Available",
                                Transport_Price = 1299,
                                  Transport_FuelCard = false

                            },
                            new TransportModel
                            {
                                Pick_Up_Point = "Port Alfred International Airport",
                                Destination_point = "Bathurst, East London" ,
                                Transport_Type = 'S',
                                Transport_ratings = 0,
                                Transport_Status = "Available",
                                Transport_Price = 1599,
                                Transport_FuelCard = false

                            },
                             new TransportModel
                            {
                                Pick_Up_Point = "Port Alfred International Airport",
                                Destination_point = "Gonubie, East London" ,
                                Transport_Type = 'S',
                                Transport_ratings = 0,
                                Transport_Status = "Available",
                                Transport_Price = 1599,
                                Transport_FuelCard = false

                            },
                        });
                    context.SaveChanges();

                }



            }

        }
    }
}