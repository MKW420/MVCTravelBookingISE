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

                if (!context.Transport.Any())
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
                            Acco_Rules = "Free Cancellation for 48 hours (Full Refund included) After 3 Days a partial Refund will be included (50%) After 7 Days there is no Refunds. Free Parking included, WIFI available and no smoking allowed "


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
                             Acco_Rules = "Free Cancellation for 48 hours (Full Refund included) After 3 Days a partial Refund will be included (50%) After 7 Days there is no Refunds. Parking fee included, WIFI available and no smoking allowed "


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
                             Acco_Rules = "Free Cancellation for 48 hours (Full Refund included) After 3 Days a partial Refund will be included (50%) After 7 Days there is no Refunds. Parking fee included, WIFI available and no smoking allowed "
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
                             Acco_Rules = "Free Cancellation for 48 hours (Full Refund included) After 3 Days a partial Refund will be included (50%) After 7 Days there is no Refunds. Parking fee included, WIFI available and no smoking allowed "
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
                             Acco_Rules = "Free Cancellation for 48 hours (Full Refund included) After 3 Days a partial Refund will be included (50%) After 7 Days there is no Refunds. Parking fee included, WIFI available and no smoking allowed "
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
                             Acco_Rules = "Free Cancellation for 48 hours (Full Refund included) After 3 Days a partial Refund will be included (50%) After 7 Days there is no Refunds. Parking fee included, WIFI available and no smoking allowed "
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
                             Acco_Rules = "Free Cancellation for 48 hours (Full Refund included) After 3 Days a partial Refund will be included (50%) After 7 Days there is no Refunds. Parking fee included, WIFI available and no smoking allowed "
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
                             Acco_Rules = "Free Cancellation for 48 hours (Full Refund included) After 3 Days a partial Refund will be included (50%) After 7 Days there is no Refunds. Parking fee included, WIFI available and no smoking allowed "
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
                             Acco_Rules = "Free Cancellation for 48 hours (Full Refund included) After 3 Days a partial Refund will be included (50%) After 7 Days there is no Refunds. Parking fee included, WIFI available and no smoking allowed "
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
                             Acco_Rules = "Free Cancellation for 48 hours (Full Refund included) After 3 Days a partial Refund will be included (50%) After 7 Days there is no Refunds. Free Parking included, WIFI available and smoking allowed adn complimentary Shuttle provided on arrival "
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
                            Acco_Rules = "Free Cancellation for 48 hours (Full Refund included) After 3 Days a partial Refund will be included (50%) After 7 Days there is no Refunds. Free Parking included, WIFI available and no smoking allowed "
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
                            Acco_Rules = "Free Cancellation for 48 hours (Full Refund included) After 3 Days a partial Refund will be included (50%) After 7 Days there is no Refunds. Parking fee included, WIFI available and no smoking allowed "
                        },

                    });
                    context.SaveChanges();
                }


                //Transport

                if (!context.Transport.Any())
                {

                    context.Transport.AddRange(new List<TransportModel>()
                        {
                            new TransportModel
                            {
                                Pick_Up_Point = "O.R Tambo Airport",
                                Destination_point = "Sunninghill, Johannesburg" ,
                                Transport_Type = 'S',
                                Transport_ratings = 3
                            },
                            new TransportModel
                            {
                                Pick_Up_Point = "O.R Tambo Airport",
                                Destination_point = "Sunninghill, Johannesburg" ,
                                Transport_Type = 'C',
                                Transport_ratings = 0
                            },
                            new TransportModel
                            {
                                Pick_Up_Point = "Cape Town International Airport",
                                Destination_point = "Milnerton, Capetown" ,
                                Transport_Type = 'S',
                                Transport_ratings = 3
                            },
                            new TransportModel
                            {
                                Pick_Up_Point = "Cape Town International Airport",
                                Destination_point = "Sea Point , CapeTown" ,
                                Transport_Type = 'S',
                                Transport_ratings = 4
                            },
                               new TransportModel
                            {
                                Pick_Up_Point = "Cape Town International Airport",
                                Destination_point = "Bellville, CapeTown" ,
                                Transport_Type = 'S',
                                Transport_ratings = 0,
                              
                            },
                                new TransportModel
                            {
                                Pick_Up_Point = "Cape Town International Airport",
                                Destination_point = "Stellenbosch, CapeTown" ,
                                Transport_Type = 'S',
                                Transport_ratings = 0,

                            },



                        });
                    context.SaveChanges();

                }


                //FlightRules
                if (!context.FlightRule.Any())
                    {
                        context.FlightRule.AddRange(new List<FlightRulesModel>(){
                        new FlightRulesModel
                        {
                           Flight_Descrip = "Kulula Airways does not allow any forms of alcohol, no forms of drugs or liquids  when boarding on the flight. Electronics should are prohibited during takeoff and landing and devices need to be switched off before boarding",

                           Flight_Name = "Kulula Airways (KA)"

                        },
                        new FlightRulesModel()
                        {
                            Flight_Descrip = "Southern African Airways does not allow any forms of alcohol, no forms of drugs or liquids  when boarding on the flight. Electronics should are prohibited during takeoff and landing and devices need to be switched off before boarding",
                            Flight_Name = "Southern African Airways (SAA)"
                        },
                        new FlightRulesModel()
                        {
                            Flight_Descrip = "Mango Airlines does not allow any forms of alcohol, no forms of drugs or liquids  when boarding on the flight. Electronics should are prohibited during takeoff and landing and devices need to be switched off before boarding",
                            Flight_Name = "Mango Airways (JE)"
                        },
                        new FlightRulesModel()
                        {
                            Flight_Descrip = "SA Express Airways does not allow any forms of alcohol, no forms of drugs or liquids  when boarding on the flight. Electronics should are prohibited during takeoff and landing and devices need to be switched off before boarding",
                            Flight_Name = "SA Express Airways (SAE)"
                        },
                        new FlightRulesModel()
                        {
                            Flight_Descrip = "Fly Safair does not allow any forms of alcohol, no forms of drugs or liquids  when boarding on the flight. Electronics should are prohibited during takeoff and landing and devices need to be switched off before boarding",
                            Flight_Name = "Fly Safair Airways"
                        },
                        new FlightRulesModel(){

                            Flight_Descrip = "British Airways has a mandatory TSA screening procedure for assistive deivices that passengers may have on their person.  Electronics should are prohibited during takeoff and landing and devices need to be switched off before boarding",
                            Flight_Name = "British Airways (BA)"

                        }
                        ,
                        new FlightRulesModel(){

                            Flight_Descrip = "SA Airlink allows travellers to bring food items through security with them when traveling across state lines, but it must be declared at checkpoint. Travellers are allowed to wear masks or not wear masks but social distancing is mandatory",
                            Flight_Name = "SA Airlink"

                        },
                        new FlightRulesModel(){

                            Flight_Descrip = "If you are traveling with a connection, we recommend that you check all the travel requirements (Covid-19 test, vaccines....) for your transit country or countries on. We recommend that you transport all valuable, fragile and necessary items in your hand baggage. ",
                            Flight_Name = "Air France (AF)"
                        },
                         new FlightRulesModel(){

                            Flight_Descrip = "At Ethopian Airlines customers can choose to save by electing not to bring checked-in luggage. If you intend to bring checked-in luggage, please ensure that you have included checked-in luggage in your reservation. Please also ensure that you stick to the size and weight restrictions.",
                            Flight_Name = "Ethopian Airlines(ET)"
                        },
                         new FlightRulesModel(){

                            Flight_Descrip = "Maintain social distance and obey the covid protocols.No drinks or snack will be allowed on the flight. Refreshments will be served as needed. Any forms of drugs will not be allowed, if found the passenger will be escorted by security immediately.",
                            Flight_Name = "Kenya Airways(KQ)"
                        },
                         new FlightRulesModel(){

                            Flight_Descrip = "Check-in for your flight closes strictly 40min before departure. If the traveller arrives late, the next flight will have to be rebooked. The COVID protocols are still mandatory and passengers boarding need to abide by them at all means.  ",
                            Flight_Name = "Air Berlin (AB)"
                        },
                         new FlightRulesModel(){

                            Flight_Descrip = "Wearing masks during the flight is mandatory for entry into Hong Kong. It is also recommended to get Health Insurance that covers Covid-19 treatment.",
                            Flight_Name = "Hong Kong Express (UO)"
                        },
                         new FlightRulesModel(){

                            Flight_Descrip = "A passport that is valid for the period of intended stay and has 2 blank pages. Non-South African citizens will also require a visa.Confirmed accommodation booking is required. All covid protocols are applicable.",
                            Flight_Name = "Crotia Airlines (OU)"
                        },
                         new FlightRulesModel(){

                            Flight_Descrip = "Infants and children under 18 years of age require both a passport and an unabridged birth certificate for travel, additionally, a letter of consent (Affidavit) is required when an infant or child is travelling with one (1) single parent.",
                            Flight_Name = "Air Italy (IG)"
                        }
                        ,
                         new FlightRulesModel(){

                            Flight_Descrip = "A 3-day Qauratine is neccessary after boarding for any people under the age of 40. Checking in for the flight 30 min before departure is manadatory, any late travellers will not be tolerated. Infants and children under 18 years of age require both a passport and an unabridged birth certificate for travel, additionally, a letter of consent (Affidavit) is required when an infant or child is travelling with one (1) single parent.",
                            Flight_Name = "Air Aarbia Egypt"
                        },
                         new FlightRulesModel(){

                            Flight_Descrip = "SA Express Airways does not allow any forms of alcohol, no forms of drugs or liquids  when boarding on the flight. Electronics should are prohibited during takeoff and landing and devices need to be switched off before boarding",
                            Flight_Name = "Virgin Altantic"
                        }

                    });
                        context.SaveChanges();
                    }


                if (!context.Flight.Any())
                {
                    context.Flight.AddRange(new List<FlightModel>(){
                        new FlightModel
                        {

                           Flight_Destination = "Johannesburg",
                           Flight_Departure = "CapeTown",
                           Flight_Date =    DateTime.Now.AddDays(10),
                           Flight_Class = 'B',
                           Flight_Price = 4685,
                           FlightRules_Id = 1





                        },
                        new FlightModel
                        {

                           Flight_Destination = "CapeTown",
                           Flight_Departure = "Johannesburg",
                           Flight_Date =   DateTime.Now.AddDays(10),
                           Flight_Class = 'B',
                           Flight_Price = 4799,
                           FlightRules_Id = 3


                        },
                        new FlightModel
                        {

                           Flight_Destination = "Johannesburg",
                           Flight_Departure = "Durban",
                           Flight_Date =    DateTime.Now.AddDays(10),
                           Flight_Class = 'B',
                           Flight_Price = 4599,
                           FlightRules_Id = 2

                          },
                        new FlightModel
                        {

                           Flight_Destination = "Durban",
                           Flight_Departure = "Cape Town",
                           Flight_Date =    DateTime.Now.AddDays(10),
                           Flight_Class = 'B',
                           Flight_Price = 4599,
                           FlightRules_Id = 4

                         },
                         new FlightModel
                        {

                           Flight_Destination = "Durban",
                           Flight_Departure = "Pretoria",
                           Flight_Date =    DateTime.Now.AddDays(10),
                           Flight_Class = 'B',
                           Flight_Price = 4599,
                           FlightRules_Id= 5

                         },
                        new FlightModel
                        {

                           Flight_Destination = "Hartbeesport",
                           Flight_Departure = "Durban",
                           Flight_Date =    DateTime.Now.AddDays(15),
                           Flight_Class = 'F',
                           Flight_Price = 8599,
                           FlightRules_Id = 2

                        }
                        ,
                          new FlightModel
                        {

                           Flight_Destination = "Pretoria",
                           Flight_Departure = "CapeTown",
                           Flight_Date =    DateTime.Now.AddDays(15),
                           Flight_Class = 'B',
                           Flight_Price = 4599,
                           FlightRules_Id = 1

                          }
                        ,
                        new FlightModel
                        {

                           Flight_Destination = "Pretoria",
                           Flight_Departure = "Durban",
                           Flight_Date =    DateTime.Now.AddDays(15),
                           Flight_Class = 'B',
                           Flight_Price = 5599,
                           FlightRules_Id = 4

                         }
                        ,
                        new FlightModel
                        {

                           Flight_Destination = "Port Elizabeth",
                           Flight_Departure = "Johannesburg",
                           Flight_Date =    DateTime.Now.AddDays(20),
                           Flight_Class = 'B',
                           Flight_Price = 5589,
                           FlightRules_Id = 4

                        },
                         new FlightModel
                        {

                           Flight_Destination = "Port Elizabeth",
                           Flight_Departure = "Cape Town",
                           Flight_Date =    DateTime.Now.AddDays(20),
                           Flight_Class = 'B',
                           Flight_Price = 4599,
                           FlightRules_Id= 4


                        },
                         new FlightModel
                        {

                           Flight_Destination = "Port Elizabeth",
                           Flight_Departure = "Durban",
                           Flight_Date =    DateTime.Now.AddDays(20),
                           Flight_Class = 'B',
                           Flight_Price = 4599,
                           FlightRules_Id = 2


                        },
                        new FlightModel
                        {
                           Flight_Destination = "Cape Town",
                           Flight_Departure = "Queensland (Austraila)",
                           Flight_Date =    DateTime.Now.AddDays(20),
                           Flight_Class = 'F',
                           Flight_Price = 8569,
                           FlightRules_Id = 2

                         },
                         new FlightModel
                        {
                           Flight_Destination = "Cape Town",
                           Flight_Departure = "Queensland (Austraila)",
                           Flight_Date =    DateTime.Now.AddDays(20),
                           Flight_Class = 'B',
                           Flight_Price = 4599,
                           FlightRules_Id = 3

                         },
                        new FlightModel
                        {
                           Flight_Destination = "Johannesburg",
                           Flight_Departure = "Queensland (Austraila)",
                           Flight_Date =    DateTime.Now.AddDays(20),
                           Flight_Class = 'B',
                           Flight_Price = 4599,
                           FlightRules_Id = 2

                          },
                         new FlightModel
                        {
                           Flight_Destination = "Johannesburg",
                           Flight_Departure = "Queensland (Austraila)",
                           Flight_Date =    DateTime.Now.AddDays(20),
                           Flight_Class = 'E',
                           Flight_Price = 6899,
                           FlightRules_Id = 12


                          },
                          new FlightModel
                        {
                           Flight_Destination = "Johannesburg",
                           Flight_Departure = "Queensland (Austraila)",
                           Flight_Date =    DateTime.Now.AddDays(20),
                           Flight_Class = 'F',
                           Flight_Price = 8599,
                           FlightRules_Id = 8

                          },
                        new FlightModel
                        {
                           Flight_Destination = "Port Elizabeth",
                           Flight_Departure = "Queensland (Austraila)",
                           Flight_Date =    DateTime.Now.AddDays(20),
                           Flight_Class = 'B',
                           Flight_Price = 5599,
                           FlightRules_Id = 2


                           },
                          new FlightModel
                        {
                           Flight_Destination = "Johannesburg",
                           Flight_Departure = "Hong Kong",
                           Flight_Date =    DateTime.Now.AddDays(20),
                           Flight_Class = 'B',
                           Flight_Price = 5599,
                           FlightRules_Id = 1




                           }

                       });

                    context.SaveChanges();
                }



            }
            }
        }
    }

