namespace BlueWaveHotel.Entities.Model.Abstract
{
    public class BaseEntity
    {
        public string Id { get; set; }
        public DateTime CreatedTime { get; set; } = DateTime.Now;
    }
}
