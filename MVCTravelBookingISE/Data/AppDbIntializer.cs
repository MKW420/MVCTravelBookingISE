namespace MVCTravelBookingISE.Data
{
    public class AppDbIntializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                context.Database.EnsureCreated();

                //Traveller
                if (!context.Travellers.Any())
                {

                }
                //Flights
                if (!context.Flights.Any())
                {

                }
                //Bookings
                if (!context.Bookings.Any())
                {

                }
                //Accomodations
                if (!context.Accomodations.Any())
                {

                }
                //Transport
                if (!context.Flights.Any())
                {

                }

            }
        }
    }
}
