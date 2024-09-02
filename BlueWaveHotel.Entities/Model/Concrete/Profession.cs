using BlueWaveHotel.Entities.Model.Abstract;

namespace BlueWaveHotel.Entities.Model.Concrete
{
    public class Profession : BaseEntity
    {
        public string Title { get; set; }
        public ICollection<Shift> Shift { get; set; }
        public ICollection<Personel> personels { get; set; }
    }
}
