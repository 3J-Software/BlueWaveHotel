using BlueWaveHotel.Models;
using Microsoft.AspNetCore.Mvc;

namespace BlueWaveHotel.Controllers
{
	public class ReservationController : Controller
	{
		public DateTime TimeNow = DateTime.Now;
		[HttpGet]
		public IActionResult Index(int id)
		{
			int Days = DaysInnextMonth(TimeNow, id);
			DateTime month = nextMonth(TimeNow, 3);
			string currentMonth = month.ToString("MMMM");
			int currentYear = month.Year;
			var model = new ReservationViewModel()
			{
				Days = Days,
				ResultTime = month,
				Month = currentMonth,
				Year = currentYear
			};

			return View(model);
		}

		[HttpPost]
		public IActionResult Index(DateTime TimeNow, int id)
		{
			int Days = DaysInnextMonth(TimeNow, id);
			DateTime month = nextMonth(TimeNow, id);
			string currentMonth = month.ToString("MMMM");
			int currentYear = month.Year;
			var model = new ReservationViewModel()
			{
				Days = Days,
				ResultTime = month,
				Month = currentMonth,
				Year = currentYear
			};

			// Ajax için JSON olarak dönelim
			return Json(model);
		}
		int DaysInnextMonth(DateTime TimeNow, int BackOrNext)
		{
			var Year = TimeNow.Year;
			var Month = TimeNow.Month;
			if (BackOrNext == 1)
			{

				if (Month == 12)
				{
					Month = 1;
					Year += 1;
				}
				else
				{
					Month += 1;
				}
				return DateTime.DaysInMonth(Year, Month);
			}
			else if (BackOrNext == -1)
			{
				if (Month == 1)
				{
					Month = 12;
					Year -= 1;
				}
				else
				{
					Month -= 1;
				}
				return DateTime.DaysInMonth(Year, Month);
			}
			return DateTime.DaysInMonth(Year, Month);
		}

		DateTime nextMonth(DateTime TimeNow, int BackOrNext)
		{
			if (BackOrNext == 1)
			{
				return TimeNow.AddMonths(1);
			}
			else if (BackOrNext == -1)
			{
				return TimeNow.AddMonths(-1);
			}
			return TimeNow;
		}
	}
}
