using BlueWaveHotel.Entities.Model.Abstract;

namespace BlueWaveHotel.Entities.Model.Concrete
{
    public class Product : BaseEntity
    {
        public string ProductName { get; set; }
        public ICollection<ProductCategory> ProductCategories { get; set; }
        public decimal price { get; set; }
        public ICollection<Extra> extras { get; set; }

    }
}