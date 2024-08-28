using BlueWaveHotel.Entities.Model.Abstract;

namespace BlueWaveHotel.Entities.Model.Concrete
{
    public class BedType : BaseEntity
    {
        public string Bedtype { get; set; }

        public ICollection<Package> packages { get; set; }
        public ICollection<Room> rooms { get; set; }

    }
}