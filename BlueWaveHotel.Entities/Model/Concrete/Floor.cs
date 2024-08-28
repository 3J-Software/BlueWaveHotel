using BlueWaveHotel.Entities.Model.Abstract;

namespace BlueWaveHotel.Entities.Model.Concrete
{
    public class Floor : BaseEntity
    {
        public string FloorNumber { get; set; }
        public ICollection<Room> rooms { get; set; }
    }
}
