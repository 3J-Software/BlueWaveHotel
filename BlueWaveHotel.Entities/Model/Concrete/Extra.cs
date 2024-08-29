using BlueWaveHotel.Entities.Model.Abstract;

namespace BlueWaveHotel.Entities.Model.Concrete
{
    public class Extra : BaseEntity
    {
        public string CustomerId { get; set; }
        public Customers customer { get; set; }
        public ICollection<Product> product { get; set; }
        public int quantity { get; set; }
        public decimal fee { get; set; }
    }
}
