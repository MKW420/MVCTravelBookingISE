using Autofac.Core;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVCTravelBookingISE.Data.Base;
using MVCTravelBookingISE.Models;

namespace MVCTravelBookingISE.Data.Services
{
    public class AccomodationService : EntityBaseRepository<AccomodationModel>,IAccomodationService

    {

      private readonly AppDbContext _context;

        public AccomodationService(AppDbContext context) : base(context) {
            _context = context;
               
        }

        public async Task AddNewAccomodation(AccomodationModel accomodation)
        {
            var newAccomodation = new AccomodationModel()
            {
                Acco_Name = accomodation.Acco_Name,
                Acco_Distance = accomodation.Acco_Distance,
                Acco_Type = accomodation.Acco_Type,
               Acco_Rate = accomodation.Acco_Rate,
                Acco_Rooms = accomodation.Acco_Rooms,
                Acco_Bathrooms = accomodation.Acco_Bathrooms,
                Acco_Destination = accomodation.Acco_Destination,
                Acco_Rules = accomodation.Acco_Rules,
                Acco_picture = accomodation.Acco_picture,
                Acco_Price = accomodation.Acco_Price

            };
           await _context.Accomodation.AddAsync(newAccomodation);
            await _context.SaveChangesAsync();

            //ADD 

            //foreach(var accoId in accomodation.Acco_Id)
            //{
            //    var newAccomodation = new Accomodation()
            //    {

            //    }
            //}
        }

        public async Task<AccomodationModel> GetAccomodationByIdAsync(int id)
        {
            var accomodationDetails = await _context.Accomodation.FirstOrDefaultAsync(n => n.Acco_Id == id);

            return accomodationDetails;

        }
        
        public async Task UpdateAccomodationAsync(AccomodationModel data)
        {
            var dbAccomodation = await _context.Accomodation.FirstOrDefaultAsync(n => n.Acco_Id == data.Acco_Id);
            if(dbAccomodation != null)
            {

                dbAccomodation.Acco_Id = data.Acco_Id;
                dbAccomodation.Acco_Name = data.Acco_Name;
                dbAccomodation.Acco_Bathrooms = data.Acco_Bathrooms;
                dbAccomodation.Acco_Rooms = data.Acco_Rooms;
                dbAccomodation.Acco_Price = data.Acco_Price;
                dbAccomodation.Acco_Rate = data.Acco_Rate;
                dbAccomodation.Acco_Rules = data.Acco_Rules;
                dbAccomodation.Acco_Destination = data.Acco_Destination;
                dbAccomodation.Acco_picture = data.Acco_picture;
                dbAccomodation.Acco_Distance = data.Acco_Distance;
                dbAccomodation.Acco_Type = data.Acco_Type;
                await _context.SaveChangesAsync();


               
            }

            //Removing existing Accomodation

            var existingAccomodationDb = _context.bookingItems.Where(n => n.Acco_Id == data.Acco_Id).ToList();
            // _context.Booking.RemoveRange(existingAccomodationDb);
            await _context.SaveChangesAsync();

            //Add booking
            //foreach(var accoId in data.Acco_Id)
            //{
            //    var newAccomodation = new BookingModel()
            //    {
            //        Acco_Id = accoId
                    
            //    };
            //    await _context.Booking.AddAsync(newAccomodation);
            //}
            //await _context.SaveChangesAsync();
        }
        //public async Task UpdateAccomodationAsync(NewAccomodationVM data)
        //{
        //    var dbAccomodation = await _context.Accomodation.FirstOrDefaultAsync(n => n.Acco_Id == data.Id);


        //    if(dbAccomodation != null)
        //    {
        //        dbAccomodation.Acco_Id = data.Acco_Id;
        //        dbAccomodation.Acco_Name = data.Acco_Name;
        //        dbAccomodation.Acco_
        //    }



        //}

    }
}
