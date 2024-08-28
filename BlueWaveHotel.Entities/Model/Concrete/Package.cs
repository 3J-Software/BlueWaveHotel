using BlueWaveHotel.Entities.Model.Abstract;

namespace BlueWaveHotel.Entities.Model.Concrete
{
    public class Package : BaseEntity
    {
        public string PackageName { get; set; }
        public ICollection<BedType> Beds { get; set; }
    }
}
