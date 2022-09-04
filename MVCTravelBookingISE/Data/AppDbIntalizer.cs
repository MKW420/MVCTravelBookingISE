using MVCTravelBookingISE.Models;

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
                            Acco_Name = "",
                            Acco_Destination = "",
                            Acco_Rooms = "",
                            Acco_Bathrooms = "",
                            Acco_Distance = "",
                            Acco_Rate = '',
                            Acco_Price = ""

                            

                        new AccomodationModel
                        {
                             Acco_Name = "",
                            Acco_Destination = "",
                            Acco_Rooms = "",
                            Acco_Bathrooms = "",
                            Acco_Distance = "",
                            Acco_Rate = "",
                            Acco_Price = ""
                        },
                        new AccomodationModel
                        {
                            Acco_Name = "",
                            Acco_Destination = "",
                            Acco_Rooms = "",
                            Acco_Bathrooms = "",
                            Acco_Distance = "",
                            Acco_Rate = "",
                            Acco_Price = ""
                        },




                    });

                    //Transport

                    if (!context.Transport.Any())
                {

                    context.Transport.AddRange(new List<TransportModel>()
                    { 
                        new TransportModel
                        {
                            Pick_Up_Point = "",
                            Destination_point = "" ,
                            Transport_Type = "",
                            Transport_ratings = ""
                        },

                        new TransportModel
                        {
                            Pick_Up_Point = "",
                            Destination_point = "" ,
                            Transport_Type = "",
                            Transport_ratings = ""
                        },
                        new TransportModel
                        {
                            Pick_Up_Point = "",
                            Destination_point = "" ,
                            Transport_Type = "",
                            Transport_ratings = ""
                        },




                    });

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
                }
                context.SaveChanges();


              

            }
        }
    }
}
