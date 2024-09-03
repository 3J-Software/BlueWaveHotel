using BlueWaveHotel.Entities.Model.Abstract;

namespace BlueWaveHotel.Entities.Model.Concrete
{
    public class Room : BaseEntity
    {

        public Floor floor { get; set; }

        public string Status { get; set; }
        public ICollection<BedType> bedTypes { get; set; }

        public int Capacity { get; set; }

        public Reservation Reservation { get; set; }


    }
}
