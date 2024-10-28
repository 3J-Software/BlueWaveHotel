using BlueWaveHotel.Entities.Model.Concrete;

namespace BlueWaveHotel.Models
{
    public class ReservationSearchVM
    {
        public DateTime FirstDay { get; set; }
        public DateTime LastDay { get; set; }
        public int Adult { get; set; }
        public int Child { get; set; }

        public List<Room> Rooms { get; set; } = new List<Room>();
    }
}
