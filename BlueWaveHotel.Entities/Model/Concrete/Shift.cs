using BlueWaveHotel.Entities.Model.Abstract;

namespace BlueWaveHotel.Entities.Model.Concrete
{
    public class Shift : BaseEntity
    {
        public string Name { get; set; }
        public string Start { get; set; }
        public string Finish { get; set; }

        public ICollection<Profession> professions { get; set; }
        public ICollection<Personel> Personels { get; set; }
    }
}
