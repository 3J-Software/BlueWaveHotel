using BlueWaveHotel.Entities.Model.Abstract;

namespace BlueWaveHotel.Entities.Model.Concrete
{
    public class Package : BaseEntity
    {
        public string packageName { get; set; }
        public int capacity { get; set; }
        public ICollection<Reservation> reservations { get; set; }
        public decimal fee { get; set; }
    }
}
