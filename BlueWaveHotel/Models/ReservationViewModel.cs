namespace BlueWaveHotel.Models
{
	public class ReservationViewModel
	{
		public int Days { get; set; }
		public string Month { get; set; }
		public int Year { get; set; }
		public DateTime TimeNow { get; set; }
		public DateTime ResultTime { get; set; }
	}
}
