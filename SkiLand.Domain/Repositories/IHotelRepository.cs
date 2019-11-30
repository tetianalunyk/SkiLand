using SkiLand.Domain.Entities;
using SkiLand.Domain.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SkiLand.Domain.Repositories
{
    public interface IHotelRepository : IRepository<Hotel>
    {
        Task<List<HotelListItem>> GetListAsync();
        Task<HotelDetailItem> GetDetails(long hotelId, long? roomId = null, Guid? userId = null);
    }
}
