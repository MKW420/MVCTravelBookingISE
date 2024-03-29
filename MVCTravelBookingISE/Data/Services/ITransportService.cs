﻿using MVCTravelBookingISE.Data.Base;
using MVCTravelBookingISE.Models;

namespace MVCTravelBookingISE.Data.Services
{
    public interface ITransportService : IEntityBaseRepository<TransportModel>
    {
        Task<TransportModel> GetTransportByIdAsync(int id);
    }
}
