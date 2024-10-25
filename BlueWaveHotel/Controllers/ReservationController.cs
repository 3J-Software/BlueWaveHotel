using BlueWaveHotel.BL.Managers.Abstract;
using BlueWaveHotel.Entities.Model.Concrete;
using BlueWaveHotel.Models;
using Microsoft.AspNetCore.Mvc;

namespace BlueWaveHotel.Controllers
{
    public class ReservationController(IManager<Room> _roomManager) : Controller
    {


        public DateTime TimeNow = DateTime.Now;
        [HttpGet]
        public IActionResult Index()
        {
            var model = new ReservationViewModel();
            for (int i = 1; i <= 3; i++)
            {
                model.Days.Add(DaysInMonth(TimeNow));
                model.Month.Add(TimeNow.ToString("MMMM"));
                model.Year.Add(TimeNow.Year);
                TimeNow = TimeNow.AddMonths(i);
            }

            return View(model);
        }

        int DaysInMonth(DateTime TimeNow)
        {
            var Year = TimeNow.Year;
            var Month = TimeNow.Month;
            return DateTime.DaysInMonth(Year, Month);

        }

        public async Task<IActionResult> Search(ReservationSearchVM searchVM)
        {
            var capacity = searchVM.Child + searchVM.Adult;
            var rooms = await _roomManager.GetAll(x => x.Status == "avaible" && x.Capacity >= capacity);
            searchVM.Rooms = rooms;
            return RedirectToAction("Index", searchVM);
        }



    }
}
