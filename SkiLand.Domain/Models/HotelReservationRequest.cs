using System;

namespace SkiLand.Domain.Models
{
    public class HotelReservationRequest
    {
        public long Id { get; set; }
        public long HotelId { get; set; }
        public long RoomId { get; set; }
        public int RoomTypeId { get; set; } 
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime BookingDate { get; set; }
        public int Adults { get; set; }
        public int Children { get; set; }
        public Guid UserId { get; set; }
        public decimal Price { get; set; }
    }
}
