using Microsoft.AspNetCore.Mvc;

namespace BlueWaveHotel.Controllers
{
    public class ReservationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
