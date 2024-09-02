using BlueWaveHotel.Entities.Model.Abstract;

namespace BlueWaveHotel.Entities.Model.Concrete
{
    public class Customers : BaseEntity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Adress { get; set; }
        public string Phone { get; set; }
        public string Id_Number { get; set; }
        public string Mail { get; set; }
        public string NickName { get; set; }
        public string password { get; set; }
        ICollection<Reservation> reservations { get; set; }
    }
}
