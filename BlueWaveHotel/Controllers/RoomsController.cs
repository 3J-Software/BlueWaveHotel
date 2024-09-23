using Microsoft.AspNetCore.Mvc;

namespace BlueWaveHotel.Controllers
{
    public class RoomsController : Controller
    {
        public IActionResult Details(int id)
        {
            switch (id)
            {
                case 1:
                    return View("Details1");
                case 2:
                    return View("Details2");
                case 3:
                    return View("Details3");
                case 4:
                    return View("Details4");
                case 5:
                    return View("Details5");
                default:
                    return NotFound();
            }
        }
    }
}
