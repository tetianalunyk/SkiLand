using Microsoft.EntityFrameworkCore;
using SkiLand.DAL.DdContext;
using SkiLand.Domain.Entities;
using SkiLand.Domain.Models;
using SkiLand.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SkiLand.DAL.Repositories
{
    public class HotelRepository: Repository<Hotel>, IHotelRepository
    {
        public HotelRepository(AppDbContext dbContext) : base(dbContext)
        {
        }

        public async Task<List<HotelListItem>> GetListAsync()
        {
            var currentDate = DateTime.Now.Date;

            var query = dbContext.Set<Hotel>()
                .Include(x => x.Photo)
                .Include("Rooms.Pricings")
                .Include("Rooms.Bookings")
                .Select(x =>
                    new HotelListItem()
                    {
                        Id = x.Id,
                        Name = x.Name,
                        Description = x.Description,
                        PhotoPath = x.Photo.Path,
                        Stars = x.Stars,
                        Raiting = x.Raiting,
                        Location = x.Location,
                        PriceFrom = x.Rooms
                            .Where(r =>
                                r.RoomsCount > r.Bookings
                                    .Count(b =>
                                        b.StartDate.Date >= currentDate &&
                                        currentDate <= b.EndDate.Date))
                            .SelectMany(s => s.Pricings)
                            .Min(p => p.Price)
                    }
                );

            return await query.ToListAsync();
        }

        public async Task<HotelDetailItem> GetDetails(long hotelId, long? roomTypeId = null, Guid? userId = null)
        {
            var currentDate = DateTime.Now.Date;

            var query = dbContext.Set<Hotel>()
                .Where(x => x.Id == hotelId)
                .Include(x => x.Photo)
                .Include("Rooms.Pricings")
                .Include("Rooms.Bookings")
                .Include("Rooms.Amenities.RoomAmenity")
                .Include("Rooms.Photos.Photo")
                .Include("Rooms.RoomType")
                .Select(x =>
                    new HotelDetailItem()
                    {
                        Id = x.Id,
                        Name = x.Name,
                        PhotoPath = x.Photo.Path,
                        Stars = x.Stars,
                        Raiting = x.Raiting,
                        Description = x.Description,
                        Location = x.Location,
                        RoomTypes = x.Rooms.Where(r=> r.Pricings.Any()).Select(r => r.RoomType).ToList(),
                        Room = x.Rooms
                            .Where(r => 
                                (roomTypeId.HasValue && r.RoomType.Id == roomTypeId.Value) || 
                                (!roomTypeId.HasValue && r.RoomType.Id == x.Rooms.Min(hr => hr.RoomType.Id)))
                            .Select(r => new RoomDetailItem()
                            {
                                Id = r.Id,
                                Adults = r.Adults,
                                Amenities = r.Amenities.Select(a => a.RoomAmenity.Title).ToList(),
                                Children = r.Children,
                                Description = r.Description,
                                RoomType = r.RoomType,
                                Price = r.Pricings
                                    .Where(w => r.RoomsCount > r.Bookings
                                        .Count(b => b.StartDate.Date >= currentDate && currentDate <= b.EndDate.Date))
                                    .Min(p => p.Price),
                                Photos = r.Photos.Select(p => p.Photo.Path).ToList(),
                                Reservations = r.Bookings
                                    .Where(b => userId.HasValue && b.UserId == userId.Value)
                                    .Select(b => new HotelReservationRequest()
                                    {
                                        BookingDate = b.BookDate,
                                        StartDate = b.StartDate,
                                        EndDate = b.EndDate,
                                        Adults = b.Adults,
                                        Children = b.Children
                                    })
                                    .ToList()
                            })
                            .First()
                    }
                );

            return await query.FirstAsync();
        }
    }
}
