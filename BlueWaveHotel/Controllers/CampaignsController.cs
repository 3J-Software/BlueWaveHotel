using Microsoft.AspNetCore.Mvc;

namespace BlueWaveHotel.Controllers
{
    public class CampaignsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Campaign(int id)
        {
            switch (id)
            {
                case 1:
                    return View("Campaign1");
                case 2:
                    return View("Campaign2");
                case 3:
                    return View("Campaign3");
                default:
                    return NotFound();
            }
        }
    }
}
