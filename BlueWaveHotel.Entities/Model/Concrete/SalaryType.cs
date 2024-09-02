using BlueWaveHotel.Entities.Model.Abstract;

namespace BlueWaveHotel.Entities.Model.Concrete
{
    public class SalaryType : BaseEntity
    {
        public string Name { get; set; }
        public ICollection<Personel> Personels { get; set; }
    }
}
