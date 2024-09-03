using BlueWaveHotel.Entities.Model.Abstract;

namespace BlueWaveHotel.Entities.Model.Concrete
{
    public class Personel : BaseEntity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime BirthDate { get; set; }

        public SalaryType salaryTypeId { get; set; }

        public decimal salary { get; set; }

        public Profession profession { get; set; }
        public ICollection<Shift> shifts { get; set; }
        public string Adress { get; set; }
        public string ID_number { get; set; }
        public bool Status { get; set; }
        public string NickName { get; set; }
        public string password { get; set; }
        public ICollection<TimeTracking> MyProperty { get; set; }
    }
}
