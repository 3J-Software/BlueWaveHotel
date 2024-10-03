using BlueWaveHotel.Models;
using Microsoft.AspNetCore.Mvc;

namespace BlueWaveHotel.Controllers
{
	public class ReservationController : Controller
	{
		[HttpGet]
		public IActionResult Index(DateTime TimeNow, int id)
		{
			int Days = nextMonth(TimeNow, id);
			var model = new ReservationViewModel()
			{
				Days = Days,
			};
			return View(model);
		}

		int nextMonth(DateTime TimeNow, int BackOrNext)
		{
			var Year = TimeNow.Year;
			var Month = TimeNow.Month;
			if (BackOrNext == 1)
			{
				// int monthDiff = ((DateTime.Now.AddMonths(3).Year - DateTime.Now.Year) * 12) + 
				// DateTime.Now.AddMonths(3).Month - DateTime.Now.Month;

				if (Month == 12)
				{
					Month = 1;
					Year = +1;
				}
				else
				{
					Month = +1;
				}
				return DateTime.DaysInMonth(Year, Month);
			}
			else if (BackOrNext == -1)
			{
				if (Month == 1)
				{
					Month = 12;
					Year = -1;
				}
				else
				{
					Month = +1;
				}
				return DateTime.DaysInMonth(Year, Month);
			}
			return DateTime.DaysInMonth(Year, Month);
		}
	}
}
