using BlueWaveHotel.Entities.Model.Abstract;

namespace BlueWaveHotel.Entities.Model.Concrete
{
    public class TimeTracking : BaseEntity
    {
        public ICollection<Personel> personels { get; set; }
        public DateTime Start { get; set; }
        public DateTime? Finish { get; set; }
    }
}
