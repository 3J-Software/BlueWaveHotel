using BlueWaveHotel.Entities.Model.Abstract;

namespace BlueWaveHotel.Entities.Model.Concrete
{
    public class ProductCategory : BaseEntity
    {
        public string CategoryName { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
