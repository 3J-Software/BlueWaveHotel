using BlueWaveHotel.Entities.Model.Abstract;

namespace BlueWaveHotel.Entities.Model.Concrete
{
    public class Package : BaseEntity
    {
        public string PackageName { get; set; }
        public int capacity { get; set; }

        public ICollection<Reservation> reservations { get; set; }
    }
}
