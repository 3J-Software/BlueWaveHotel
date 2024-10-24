namespace BlueWaveHotel.Models
{
	public class ReservationViewModel
	{
		public List<int> Days { get; set; } = new List<int>();
		public List<string> Month { get; set; } = new List<string>();
		public List<int> Year { get; set; } = new List<int>();
		public ReservationSearchVM Search { get; set; }
	}

}
