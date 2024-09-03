using BlueWaveHotel.Entities.Model.Abstract;

namespace BlueWaveHotel.Entities.Model.Concrete
{
    public class Reservation : BaseEntity
    {

        public Customers customers { get; set; }

        public Package package { get; set; }

        public ICollection<Room> roomsId { get; set; }

        public decimal Purchase { get; set; } = 0;
        public DateTime BookingStart { get; set; }
        public DateTime BookingEnd { get; set; }
        public DateTime? CheckIn { get; set; }
        public DateTime? CheckOut { get; set; }
        public decimal Fee { get; set; }
    }
}
