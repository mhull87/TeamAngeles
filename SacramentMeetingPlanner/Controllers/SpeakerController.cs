using Microsoft.AspNetCore.Mvc;

namespace SacramentMeetingPlanner.Controllers
{
    public class SpeakerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}