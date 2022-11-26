using MessagePack;
using MVCTravelBookingISE.Data.ViewModels;
using MVCTravelBookingISE.Models;
using System.Text;
using System.Text.Json;
using static MVCTravelBookingISE.Data.FlightAPI.TravelAPIs.BusiestPeriodResults;
using static MVCTravelBookingISE.Data.FlightAPI.TravelAPIs.FlightsAvailable;

namespace MVCTravelBookingISE.Data.FlightAPI
{
    public class TravelAPIs
    {

        private string apiKey;
        private string apiSecret;
        private string bearerToken;
        private HttpClient http;



        public TravelAPIs(IConfiguration config, IHttpClientFactory httpFactory)
        {
            apiKey = config.GetValue<string>("AmadeusAPI:APIKey");
            apiSecret = config.GetValue<string>("AmadeusAPI:APISecret");
            http = httpFactory.CreateClient("TravelAPIs");
        }
        public async Task ConnectOAuth()
        {
            var message = new HttpRequestMessage(HttpMethod.Post, "/v1/security/oauth2/token");
            message.Content = new StringContent(
                $"grant_type=client_credentials&client_id={apiKey}&client_secret={apiSecret}",
                Encoding.UTF8, "application/x-www-form-urlencoded"
            );

            var results = await http.SendAsync(message);
            await using var stream = await results.Content.ReadAsStreamAsync();
            var oauthResults = await JsonSerializer.DeserializeAsync<OAuthResults>(stream);

            bearerToken = oauthResults.access_token;
        }

        private class OAuthResults
        {
            public string access_token { get; set; }
        }



        public async Task<BusiestPeriodResults> GetBusiestTravelPeriodsOfYear(string cityCode, int year)
        {
            var message = new HttpRequestMessage(HttpMethod.Get,
                $"/v1/travel/analytics/air-traffic/busiest-period?cityCode={cityCode}&period={year}");

            ConfigBearerTokenHeader();
            var response = await http.SendAsync(message);
            using var stream = await response.Content.ReadAsStreamAsync();
            return await JsonSerializer.DeserializeAsync<BusiestPeriodResults>(stream);
        }

        private void ConfigBearerTokenHeader()
        {
            http.DefaultRequestHeaders.Add("Authorization", $"Bearer {bearerToken}");
        }
        public async Task<FlightsAvailable> SearchFlights(string OriginLocationCode, string DestinationLocationCode,  string DepartureDate, string ReturnDate,string Adults)
        {

            string ste = $"/v2/shopping/flight-offers?originLocationCode={OriginLocationCode} &destinationLocationCode={DestinationLocationCode}&departureDate={DepartureDate}&returnDate={ReturnDate}&adults={Adults}";

            var message = new HttpRequestMessage(HttpMethod.Get, ste);

            ConfigBearerTokenHeader();
            var response = await http.SendAsync(message);
            using var stream = await response.Content.ReadAsStreamAsync();
            return await JsonSerializer.DeserializeAsync<FlightsAvailable>(stream);

            

        }
       
      
        public class BusiestPeriodResults
        {
            public class Travelers
            {
                public int score { get; set; }
            }

            public class Analytics
            {
                public Travelers travelers { get; set; }
            }

            public class Item
            {
                public string type { get; set; }
                public string period { get; set; }
                public Analytics analytics { get; set; }
                public int score => analytics.travelers.score;
            }

            public List<Item> data { get; set; }
            public string graphArray => string.Join(',', data.OrderBy(x => x.period).Select(x => x.score));
        }

        public class FlightsAvailable {

            public class Flight
            {
                public int Id { get; set; }
                public FlightEndPoint destination { get; set; }

                public OriginalFlightPoint departure { get; set; }

                public string? carrierCode { get; set; }
                public int numberOfStops { get; set; }

            }
            public class DatedFlight
            {
                public string type { get; set; }
                public string scheduledDepartureDate { get; set; }

                public Flightdescriptor flightdescriptor { get; set; }

            }
            public class Flightdescriptor
            {
                
                public string carriercode { get; set; }

                public int flightNumber { get; set; }

                public string operationalSuffix { get; set; }
            }
            public class FlightEndPoint
            {
                public int Id { get; set; }
                public string iataCode { get; set; }

              //  public string terminal { get; set; }

                public string at { get; set; }

            }
            public class OriginalFlightPoint
            {
                public int Id { get; set; }
                public string iataCode { get; set; }

                public string at { get; set; }



            }
            public class Traveller
            {
                public string travellerType { get; set; }

                public string associatedAdultId { get; set; }
            }
            public class Price
            {
                public string total { get; set; }
            }

            public class FlightOffers
            {
               public int Id { get; set; }
                public int numberOfBookableSeats { get; set; }
                public List<itineraries> itineraries { get; set; }
                public Price? price { get; set; }
            }
            public class itineraries
            {
                public int Id { get; set; }
                public string Duration{ get; set; }
             

               // public List<Flights>? segments { get; set; }
            }
            public class Trips
            {
                public int Id { get; set; }
                public string? duration { get; set; }
                public List<Flights>? segments { get; set; }
            }
            public List<FlightOffers> data { get; set; }

            
        }
    }
}
